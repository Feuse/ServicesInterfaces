using ServicesModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesInterfaces.DataAccess.Cache
{
    public interface IUserCacheAccess
    {
        public Task<IDictionary<string, string>> GetUserImages(Data data);
        public Task SetUserImages(Data data, IDictionary<string, string> images);
        public Task RemoveAndSetUserImages(Data data, IDictionary<string, string> images);
        public Task<UserCredentials> GetUserById(Data data);
        public Task SetUserById(Data data, UserCredentials user);
        public Task UpdateUserById(Data data);
    }
}
