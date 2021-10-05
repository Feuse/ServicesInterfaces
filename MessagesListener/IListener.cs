using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesInterfaces
{
    public interface IListener 
    {
        public void StartListening();
        event Action<string> Message;
    }
}
