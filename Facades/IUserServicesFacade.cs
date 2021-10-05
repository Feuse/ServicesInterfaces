using ServicesModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesInterfaces.Facades
{
    public interface IUserServicesFacade
    {
        Task<List<UserServiceCredentials>> AuthenticateUserServices(string id);
        Task<Data> LoginToService(Data data);
    }
}
