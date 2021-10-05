using ServicesModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesInterfaces.DataAccess.Cache
{
    public interface IServiceCacheAccess
    {
        public Task<ServiceSessions> GetServiceSession(Data data);
        public Task SetServiceSession(Data data, ServiceSessions session);
        public Task<List<UserServiceCredentials>> GetUserServices(Data data);
        public Task<UserServiceCredentials> GetUserServiceByServiceNameAndId(Data data);
        public Task SetUserServices(Data data, List<UserServiceCredentials> services);
        public Task RemoveService(Data data);
    }
}
