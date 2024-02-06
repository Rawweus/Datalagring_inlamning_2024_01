using Datalagring_inlamning_2024_01.Contexts;
using Datalagring_inlamning_2024_01.Repositories;
using Datalagring_inlamning_2024_01.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

var host = Host.CreateDefaultBuilder()
    .ConfigureServices((context, services) =>
    {
        services.AddDbContext<DataContext>(options =>
            options.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\c-sharp-project\App_Database_Datalagring\Datalagring_inlamning_2024_01\Datalagring_inlamning_2024_01\Data\local_db.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True"));

        // Denan reggar mina repositories och services
        services.AddSingleton<CategoryRepository>();
        services.AddSingleton<CategoryService>();
    })

     .ConfigureLogging(logging =>
     {
         logging.ClearProviders();
         logging.AddConsole();
         logging.SetMinimumLevel(LogLevel.Warning);
         logging.AddFilter("Microsoft.EntityFrameworkCore.Database.Command", LogLevel.Warning);
     })

    .Build();


var categoryService = host.Services.GetRequiredService<CategoryService>();
categoryService.RunMenu();

host.Run();