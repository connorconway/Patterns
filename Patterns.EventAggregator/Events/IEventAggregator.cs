namespace Patterns.EventAggregator.Events
{
	public interface IEventAggregator
	{
		void Subscribe(object subscriber);
		void Publish<TEvent>(TEvent eventToPublish);
	}
}