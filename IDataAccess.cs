using RabbitMQScheduler.Models;
using ServicesModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesInterfaces
{
    public interface IDataAccess
    {
        public Task<UserServiceCredentials> GetById(Message message);
    }
}
