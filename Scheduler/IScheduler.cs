using ServicesModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesInterfaces.Scheduler
{
    public interface IScheduler
    {
        public Task Schedule(Message message);
    }
}
