using Application.Broker.Producers.Interafaces;
using Confluent.Kafka;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Application.Broker.Producers;

public class ListTraineeRequestProducer : IListTraineeRequestProducer
{
    private readonly IServiceProvider _serviceProvider;
    private readonly IProducer<Null, string> _producer;
    private readonly ILogger<ListTraineeRequestProducer> _logger;
    
    private readonly string _inscriptionServiceRequestTopic;
    private readonly string _getTraineesServiceTopic;
    
    public ListTraineeRequestProducer(IConfiguration configuration, IServiceProvider serviceProvider,ILogger<ListTraineeRequestProducer> logger)
    {
        _serviceProvider = serviceProvider;
        _logger = logger;
        var producerconfig = new ProducerConfig
        {
            BootstrapServers = configuration["Kafka:BootstrapServers"]
        };
        _producer = new ProducerBuilder<Null, string>(producerconfig).Build();
        _inscriptionServiceRequestTopic = configuration["Kafka:InscriptionServiceRequestTopic"];
        _getTraineesServiceTopic = configuration["Kafka:GetTraineesServiceTopic"];
    }

    public async Task ProduceAsync()
    {
        try
        {
            var kafkaMessage = new Message<Null, string> { Value =  _getTraineesServiceTopic};
            _logger.LogInformation($"Producing message to Kafka topic {_inscriptionServiceRequestTopic}");

            await _producer.ProduceAsync(_inscriptionServiceRequestTopic, kafkaMessage);
            _logger.LogInformation($"Message produced successfully to topic {_inscriptionServiceRequestTopic}");
        }
        catch (Exception e)
        {
            _logger.LogError(e, $"An error occurred while producing message to Kafka topic {_inscriptionServiceRequestTopic}");
        }
    }
}