using ServicesModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesInterfaces
{
    public interface IJsonFactory
    {
        public dynamic GetJson(JsonTypes types);
    }
}
