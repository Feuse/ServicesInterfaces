using MongoDB.Driver;
using ServicesModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesInterfaces.DataAccess
{
    public interface IServiceDataAccess : IDataAccess
    {
        Task<UpdateResult> UpdateService(Data data);
    }
}
