using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Orleans.Configuration;

try
{
    using IHost host = await StartSiloAsync();
    Console.WriteLine("\n\n Press Enter to terminate...\n\n");
    Console.ReadLine();

    await host.StopAsync();

    return 0;
}
catch (Exception ex)
{
    Console.WriteLine(ex);
    return 1;
}

static async Task<IHost> StartSiloAsync()
{
    var persistanceConnectionString = "192.168.30.55,1435;ServerDatabase=orleans;User Id=sa;Password=Monemnejijannet1;";


    var builder = Host
        .CreateDefaultBuilder()
        .UseOrleans((context, silo) =>
        {
            silo.Configure<ClusterOptions>(options =>
            {
                options.ClusterId = "dev";
                options.ServiceId = "GloboTicket";
            })
                .UseAdoNetClustering(options =>
                {
                    options.ConnectionString = persistanceConnectionString ?? " ";
                    options.Invariant = "System.Data.SqlClient";
                }).AddAdoNetGrainStorage("profiles", options =>
                {
                    options.ConnectionString = persistanceConnectionString ?? " ";
                    options.Invariant = "System.Data.SqlClient";
                }).AddAdoNetGrainStorage("profile", options =>
                {
                    options.ConnectionString = persistanceConnectionString ?? " ";
                    options.Invariant = "System.Data.SqlClient";
                })
                .ConfigureLogging(logging => logging.AddConsole()).UseDashboard(options =>
            {
                options.Username = "username";
                options.Password = "password";
                options.Host = "localhost";
                options.Port = 9000;
                options.HostSelf = true;
                options.CounterUpdateIntervalMs = 1000;
            }); ;

        });

    var host = builder.Build();
    await host.StartAsync();

    return host;
}

