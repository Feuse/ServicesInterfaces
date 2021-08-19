using ServicesModels;

namespace ServicesInterfaces
{
    public interface IServicesFactory
    {
        public IService GetService(Service service);
    }
}
