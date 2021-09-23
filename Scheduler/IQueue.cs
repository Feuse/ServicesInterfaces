using ServicesModels;

namespace ServicesInterfaces.Scheduler
{
    public interface IQueue
    {
        public void QueueMessage(Message message);
    }
}
