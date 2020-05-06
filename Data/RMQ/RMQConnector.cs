using RabbitMQ.Client;

namespace SwaggerRMQEx.Data
{
    public class RMQConnector
    {
        public RMQConnector()
        {
        }

        public IConnection GetRabbitConnection()
        {
            ConnectionFactory factory = new ConnectionFactory
            {
                UserName = "guest",
                Password = "guest",
                VirtualHost = "/",
                HostName = "localhost"
            };

            IConnection connect = factory.CreateConnection();
            return connect;
        }

    }
}
