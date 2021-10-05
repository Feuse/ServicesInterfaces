using MongoDB.Driver;
using ServicesModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesInterfaces.DataAccess
{
    public interface IUserDataAccess : IDataAccess
    {
        public Task<UserCredentials> GetUserById(Data data);
        public Task<UserCredentials> AuthenticateUser(Data data);
        public Task<UserCredentials> RegisterUser(Data data);
        public Task<UserCredentials> CheckIfUsernameExists(Data data);
        public Task<UpdateResult> UpdateUser(Data data);
    }
}
