using Microsoft.AspNetCore.Mvc;
using RabbitMQ.Client;
using System.Text;

namespace SwaggerRMQTutorial.Controllers
{
    [Route("api/PostLocation")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        [HttpPost]
        public void Post([FromBody] Location location)
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (var chanel = connection.CreateModel())
            {
                chanel.QueueDeclare(
                    queue: "locationQueue",
                    durable: false,
                    exclusive: false,
                    autoDelete: false,
                    arguments: null
                );

                string message = "Latitude" + location.Latitude + ", Lognitude: " + location.Longitude + ", Time: " + location.Date;
                var body = Encoding.UTF8.GetBytes(message);

                chanel.BasicPublish(
                    exchange: "",
                    routingKey: "locationQueue",
                    basicProperties: null,
                    body: body
                );
            }
        }
    }
}
