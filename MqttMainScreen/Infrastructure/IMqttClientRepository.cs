using MqttMainScreen.Models;

namespace MqttMainScreen.Infrastructure;

public interface IMqttClientRepository
{
    Task<List<string>> GetActiveClientIdsAsync();
    Task<List<Client>> GetAllClientsAsync();
    Task<List<string>> GetAllClient();
    Task RegisterClientAsync(Client mqttClientRegistration);
    Task UpdateClientAsync(Client clientRegistration);
}