using RabbitMQ.Client;
using System;
using System.Text;

namespace SwaggerRMQTutorial.Data
{
    public class RMQService
    {
        private readonly string _exchangeName = "test";
        private readonly string _queueName = "test";
        private readonly string _routingKey = "test";

        public RMQConnector rmqConnector = new RMQConnector();

        public RMQService(string exchangeName, string queueName, string routingKey)
        {
            _exchangeName = exchangeName;
            _queueName = queueName;
            _routingKey = routingKey;
        }

        private IModel GetRabbitChannel(string exchangeName, string queueName, string routingKey)
        {
            IModel model = rmqConnector.GetRabbitConnection().CreateModel();
            model.ExchangeDeclare(exchangeName, ExchangeType.Direct);
            model.QueueDeclare(queueName, false, false, false, null);
            model.QueueBind(queueName, exchangeName, routingKey, null);
            return model;
        }

        public void SendMessage(string mess)
        {
            if (string.IsNullOrEmpty(mess))
                throw new ArgumentException("Message should NOT be empty", nameof(mess));

            IModel model = GetRabbitChannel(_exchangeName, _queueName, _routingKey);
            byte[] messageBodyBytes = Encoding.UTF8.GetBytes(mess);
            model.BasicPublish(_exchangeName, _routingKey, null, messageBodyBytes);
        }

        private string ReceiveSingleMessage()
        {
            string originalMessage = "";
            IModel model = GetRabbitChannel(_exchangeName, _queueName, _routingKey);
            BasicGetResult result = model.BasicGet(_queueName, false);

            if (result == null)
            {
                Console.WriteLine("There is no message...");
            }
            else
            {
                byte[] body = result.Body.ToArray();
                originalMessage = Encoding.UTF8.GetString(body);
            }

            return originalMessage;
        }
    }
}
