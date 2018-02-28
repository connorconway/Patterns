namespace Patterns.EventAggregator.Events
{
	public interface ISubscriber<in T>
	{
		void OnEvent(T e);
	}
}