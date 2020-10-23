using Confluent.Kafka;
using System.Threading.Tasks;

namespace KafkaProducer
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var config = new ProducerConfig { BootstrapServers = "localhost:9092", ClientId = "testjan" };
            using (var producer = new ProducerBuilder<Null, string>(config).Build())
            {
                await producer.ProduceAsync("testjantopic", new Message<Null, string> { Value = "test jan" });
            }
        }
    }
}
