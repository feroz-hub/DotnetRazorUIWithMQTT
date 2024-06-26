using Microsoft.EntityFrameworkCore;
using MqttMainScreen.Data;
using MqttMainScreen.Models;

namespace MqttMainScreen.Infrastructure;

public class MqttClientRepository(ApplicationDbContext dbContext):IMqttClientRepository
{
    public async Task<List<string>> GetActiveClientIdsAsync()
    {
        return await dbContext.MqttClients
            .Where(client => client.Status)
            .Select(client => client.ClientId.ToString())
            .ToListAsync();
    }

    public async Task<List<Client>> GetAllClientsAsync()
    {
        return await dbContext.MqttClients.ToListAsync();
    }

    public async Task<List<string>> GetAllClient()
    {
        return await dbContext.MqttClients
            .Select(client => client.DeviceName)
            .ToListAsync();
    }

    public async Task RegisterClientAsync(Client mqttClientRegistration)
    {
        dbContext.MqttClients.Add(mqttClientRegistration);
        await dbContext.SaveChangesAsync();
    }

    public async Task UpdateClientAsync(Client clientRegistration)
    {
        dbContext.MqttClients.Update(clientRegistration);
        await dbContext.SaveChangesAsync();
    }
}