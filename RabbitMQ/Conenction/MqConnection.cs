using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitMQ.Conenction
{
    public class MqConnection
    {
        public readonly ConnectionFactory factory;
        public readonly IConnection connection;
        public MqConnection()
        {
            factory = new ConnectionFactory
            {
                HostName = "localhost",
                UserName = "musa",
                Password = "1234"
            };

            connection = factory.CreateConnection();
        }
    }
}
