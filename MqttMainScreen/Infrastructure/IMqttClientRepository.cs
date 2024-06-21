using MqttMainScreen.Models;

namespace MqttMainScreen.Infrastructure;

public interface IMqttClientRepository
{
    Task<List<string>> GetActiveClientIdsAsync();
    Task<List<MqttClientRegistration>> GetAllClientsAsync();
    Task<List<string>> GetAllClient();
    Task RegisterClientAsync(MqttClientRegistration mqttClientRegistration);
    Task UpdateClientAsync(MqttClientRegistration clientRegistration);
}