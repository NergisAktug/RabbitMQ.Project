using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;

namespace Consumer.ConsoleApp
{
    public class Program
    {
        //Burada Producer'da connection kismina yazdigin url'i yazmalısınız
        private static string connectionString = "amqp://nergis:nergis@192.168.1.109:5672";
        private static string queueName;
        private static IConnection connection;
        private static IModel _channel;
        private static IModel channel => _channel ??= (_channel = CreateOrGetChannel());

        static void Main(string[] args)
        {
            //burada producer kısmında oluşturduğunuz queue'yi yazmalısınız
            queueName=args.Length>0 ? args[0]: "test_queue";
           
            connection=GetConnection();

            channel.QueueDeclare(queueName, exclusive: false);

            var consumerEvent=new EventingBasicConsumer(channel);

            consumerEvent.Received += (ch, e) => 
            {
                var byteArr= e.Body.ToArray();
                var bodyStr=Encoding.UTF8.GetString(byteArr);

                Console.WriteLine($"Received Data:{bodyStr}");
            };

            channel.BasicConsume(queueName, true, consumerEvent);
            Console.WriteLine($"{queueName} listening....\n\n\n");

            Console.ReadLine();
        }

        private static IModel CreateOrGetChannel()
        {
            return connection.CreateModel();
        }

        private static IConnection GetConnection()
        {
            ConnectionFactory factory = new ConnectionFactory()
            {
                // hangi port'tan rabbitmq'ya bağlanılacağı bilgisi girilir
                Uri = new Uri(connectionString)
                /*HostName = "192.168.1.100",
                 Port= 5672,
                 UserName = "nergis",
                 Password="nergis"*/
            };

            return factory.CreateConnection();
        }


    }
}
