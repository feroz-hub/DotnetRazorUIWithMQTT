using Microsoft.EntityFrameworkCore;
using MqttMainScreen.Models;

namespace MqttMainScreen.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):DbContext(options)
{
    public DbSet<MqttClientRegistration> MqttClientRegistrations { get; set; }
}