using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitMQ.Conenction
{
    public class Publisher:MqConnection
    {
   

    public void    CreateQuee()
        {
            using (var channel  = connection.CreateModel())
            {

                var model = new
                {
                    Name = "Musa"
                };

                var pay = Newtonsoft.Json.JsonConvert.SerializeObject(model);

                var body = Encoding.UTF8.GetBytes(pay);
                channel.QueueDeclare("costumer", false, false, false, null);

                channel.BasicPublish("", "costumer",false, null, body);
            }
        }
    }
}
