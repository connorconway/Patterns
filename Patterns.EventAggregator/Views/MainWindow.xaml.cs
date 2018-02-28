﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using Patterns.EventAggregator.Events;
using Patterns.EventAggregator.Model;

namespace Patterns.EventAggregator.Views
{
	public partial class MainWindow
	{
		private readonly IEventAggregator _eventAggregator;
		private ObservableCollection<Order> _orders;

		public MainWindow()
		{
			InitializeComponent();
			_eventAggregator = new SimpleEventAggregator();
			OrderListView.EventAggregator = _eventAggregator;
			AddOrderViews();
			LoadOrders();

			New.Click += New_Click;
			Save.Click += Save_Click;
		}

		private void AddOrderViews()
		{
			var tabs = OrderViews.Items;
			tabs.Add(new TabItem { Header = "Header", Content = new OrderView(_eventAggregator) });
			tabs.Add(new TabItem { Header = "Detail", Content = new OrderDetail(_eventAggregator) });
			tabs.Add(new TabItem { Header = "Order History", Content = new OrderHistory(_eventAggregator) });
		}

		private void LoadOrders()
		{
			_orders = new ObservableCollection<Order>
			{
				new Order {OrderNumber = "1000", Description = "An Order"},
				new Order {OrderNumber = "2000", Description = "Another Order"},
				new Order {OrderNumber = "3000", Description = "Yet Another Order"}
			};
			OrderListView.SetOrders(_orders);
		}

		private void New_Click(object sender, RoutedEventArgs e)
		{
			var order = new Order { Description = "New Order", OrderNumber = "New ID: 1" };
			_orders.Add(order);
			_eventAggregator.Publish(new OrderSelected {Order = order});
		}

		private void Save_Click(object sender, RoutedEventArgs e)
		{
			var order = (Order)OrderListView.OrdersList.SelectedItem;
			_eventAggregator.Publish(new OrderSaved{Order = order});
		}
	}

	public class SimpleEventAggregator : IEventAggregator
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
