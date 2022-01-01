using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitMQ.Conenction
{
    public class Listener : MqConnection
    {
        public void Listen()
        {
            var channel = connection.CreateModel();

            channel.QueueDeclare("costumer",false,false,false,null);
            var consumer = new EventingBasicConsumer(channel);

            consumer.Received += (model, eq) =>
             {
                 var body = eq.Body.ToArray();

                 var jsonString = Encoding.UTF8.GetString(body);
             };

            channel.BasicConsume("costumer", true, "Tag", false, false, null, consumer);

        }
    }
}