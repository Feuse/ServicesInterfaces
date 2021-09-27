﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesInterfaces.DataAccess
{
    public interface  IAutoLoverDatabaseSettings
    {
        public string ServiceSessionsCollectionName { get; set; }
        public string UserCredentialsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
