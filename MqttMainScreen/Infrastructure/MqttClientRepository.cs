using Microsoft.EntityFrameworkCore;
using MqttMainScreen.Data;
using MqttMainScreen.Models;

namespace MqttMainScreen.Infrastructure;

public class MqttClientRepository(ApplicationDbContext dbContext):IMqttClientRepository
{
    public async Task<List<string>> GetActiveClientIdsAsync()
    {
        return await dbContext.MqttClientRegistrations
            .Where(client => client.IsConnected)
            .Select(client => client.Id.ToString())
            .ToListAsync();
    }

    public async Task<List<MqttClientRegistration>> GetAllClientsAsync()
    {
        return await dbContext.MqttClientRegistrations.ToListAsync();
    }

    public async Task<List<string>> GetAllClient()
    {
        return await dbContext.MqttClientRegistrations
            .Select(client => client.Name)
            .ToListAsync();
    }

    public async Task RegisterClientAsync(MqttClientRegistration mqttClientRegistration)
    {
        dbContext.MqttClientRegistrations.Add(mqttClientRegistration);
        await dbContext.SaveChangesAsync();
    }

    public async Task UpdateClientAsync(MqttClientRegistration clientRegistration)
    {
        dbContext.MqttClientRegistrations.Update(clientRegistration);
        await dbContext.SaveChangesAsync();
    }
}