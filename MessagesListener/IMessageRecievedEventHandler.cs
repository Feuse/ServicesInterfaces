﻿using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesInterfaces
{
    public interface IMessageRecievedEventHandler
    {
        public void RegisterToQueueEvent();
    }
}
