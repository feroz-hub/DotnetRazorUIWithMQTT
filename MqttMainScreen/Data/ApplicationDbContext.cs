using Microsoft.EntityFrameworkCore;
using MqttMainScreen.Models;

namespace MqttMainScreen.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):DbContext(options)
{
    public DbSet<Client> MqttClients { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Client>().HasData(
            new Client
            {
                ClientId = Guid.NewGuid(),
                DeviceName = "Device Alpha",
                Created = new DateTime(2023, 5, 12, 14, 30, 0),
                SubscribedTopics = ["topic1", "topic2"],
                LastAccessed = new DateTime(2024, 6, 24, 9, 45, 0),
                Status = true,
                KeepAlive = 60,
                IpAddress = "192.168.1.1"
            },
            new Client
            {
                ClientId = Guid.NewGuid(),
                DeviceName = "Device Beta",
                Created = new DateTime(2023, 6, 11, 11, 20, 0),
                SubscribedTopics = ["topic3", "topic4"],
                LastAccessed = new DateTime(2024, 6, 23, 10, 15, 0),
                Status = false,
                KeepAlive = 60,
                IpAddress = "192.168.1.2"
            },
            new Client
            {
                ClientId = Guid.NewGuid(),
                DeviceName = "Device Gamma",
                Created = new DateTime(2023, 7, 21, 9, 45, 0),
                SubscribedTopics = ["topic5", "topic6"],
                LastAccessed = new DateTime(2024, 6, 22, 16, 30, 0),
                Status = true,
                KeepAlive = 60,
                IpAddress = "192.168.1.3"
            }
            // Add more dummy clients as needed
        );
    }
}