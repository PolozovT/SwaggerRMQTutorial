using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;

namespace SwaggerRMQEx.Data
{
    public class RMQListener
    {
        private readonly string _queueName;
        private readonly string _hostName;

        public RMQListener(string queueName, string hostName)
        {
            _queueName = queueName;
            _hostName = hostName;
        }

        public void ListenQueue()
        {
            var factory = new ConnectionFactory() { HostName = _hostName };
            var rabbitConnection = factory.CreateConnection();
            var rabbitChannel = rabbitConnection.CreateModel();

            rabbitChannel.QueueDeclare(
                queue: _queueName,
                exclusive: false,
                autoDelete: false,
                arguments: null
             );

            var _messageCount = Convert.ToInt16(rabbitChannel.MessageCount(_queueName));
            Console.WriteLine($"Listening the queue {_queueName}. This channel has {_messageCount} messages.");

            var consumer = new EventingBasicConsumer(rabbitChannel);
            consumer.Received += (model, ea) =>
            {
                var body = ea.Body.ToArray();
                var mess = Encoding.UTF8.GetString(body);
                Console.WriteLine($"Connector RMQ received: {mess}");
                rabbitChannel.BasicAck(deliveryTag: ea.DeliveryTag, multiple: false);
                //Thread.Sleep(1000);
            };

            rabbitChannel.BasicConsume(
                queue: _queueName,
                autoAck: false,
                consumer: consumer
                );

            //Thread.Sleep(1000 * _messageCount);
            Console.WriteLine("Connection closed....no more messages.");
        }
    }
}
