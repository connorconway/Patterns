﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Patterns.EventAggregator.Events
{
	public class GenericEventAggregator : IEventAggregator
	{
		private readonly Dictionary<Type, List<WeakReference>> _eventSubscribersLists = new Dictionary<Type, List<WeakReference>>();
		private readonly object _lock = new object();

		public void Subscribe(object subscriber)
		{
			lock (_lock)
			{
				var subscriberTypes = subscriber.GetType()
					.GetInterfaces()
					.Where(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(ISubscriber<>));

				var weakReference = new WeakReference(subscriber);
				foreach (var subscriberType in subscriberTypes)
				{
					var subscribers = GetSubscribers(subscriberType);
					subscribers.Add(weakReference);
				}
			}
		}

		private List<WeakReference> GetSubscribers(Type subscriberType)
		{
			List<WeakReference> subscribers;

			lock (_lock)
			{
				var found = _eventSubscribersLists.TryGetValue(subscriberType, out subscribers);
				if (!found)
				{
					subscribers = new List<WeakReference>();
					_eventSubscribersLists.Add(subscriberType, subscribers);
				}
			}

			return subscribers;
		}

		public void Publish<TEvent>(TEvent eventToPublish)
		{
			var subscriberType = typeof(ISubscriber<>).MakeGenericType(typeof(TEvent));
			var subscribers = GetSubscribers(subscriberType);
			var subscribersToRemove = new List<WeakReference>();
			foreach (var weakSubscriber in subscribers)
			{
				if (weakSubscriber.IsAlive)
				{
					var sub = (ISubscriber<TEvent>) weakSubscriber.Target;
					var syncContext = SynchronizationContext.Current ?? new SynchronizationContext();

					syncContext.Post(s => sub.OnEvent(eventToPublish), null);
				}
				else
				{
					subscribersToRemove.Add(weakSubscriber);
				}
			}

			if (subscribersToRemove.Any())
			{
				lock (_lock)
				{
					foreach (var weakReference in subscribersToRemove)
					{
						subscribers.Remove(weakReference);
					}
				}
			}
		}
	}
}