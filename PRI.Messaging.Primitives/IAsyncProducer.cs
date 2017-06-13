#if SUPPPORT_ASYNC_CONSUMER
namespace PRI.Messaging.Primitives
{
	public interface IAsyncProducer<out T> where T : IMessage
	{
		void AttachConsumer(IAsyncConsumer<T> consumer);
	}
}
#endif
