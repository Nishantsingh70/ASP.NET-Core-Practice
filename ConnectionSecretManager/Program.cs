using ConnectionSecretManager.Configuration;
using ConnectionSecretManager.Models;
using Microsoft.EntityFrameworkCore;
using Amazon;

var builder = WebApplication.CreateBuilder(args);


var env = builder.Environment.EnvironmentName;
var appName = builder.Environment.ApplicationName;

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// secret is stored in user secrets.json file

//Scaffold-DbContext "Server=DESKTOP-64SOF1U;Database=DevDB;User Id=admin_Dev;Password=MyDevStrongPassword;Trusted_Connection=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer   -OutputDir Models
//Scaffold-DbContext "Server=DESKTOP-64SOF1U;Database=ProdDB;User Id=admin_Prod;Password=MyProdStrongPassword;Trusted_Connection=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer   -OutputDir Models

//Production_ConnectionSecretManager_DefaultConnection__ConnectionString Secret manager name:
//Server=DESKTOP-64SOF1U;Database=ProdDB;User Id=admin_Prod;Password=MyProdStrongPassword;Trusted_Connection=True;TrustServerCertificate=True;

//Development_ConnectionSecretManager_DefaultConnection__ConnectionString Secret manager name:
//Server=DESKTOP-64SOF1U;Database=DevDB;User Id=admin_Dev;Password=MyDevStrongPassword;Trusted_Connection=True;TrustServerCertificate=True;

builder.Configuration.AddSecretsManager(region: RegionEndpoint.APSouth1,
    configurator: options =>
    {
        options.SecretFilter = entry => entry.Name.StartsWith($"{env}_{appName}_");
        options.KeyGenerator = (_, s) => s
                                         .Replace($"{env}_{appName}_", string.Empty)
                                         .Replace("__", ":");

        // if your key is rorating then this will help to fetch correct inform.
        options.PollingInterval = TimeSpan.FromMinutes(5);
    }
    );

builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection(DatabaseSettings.SectionName));


// connection string for AWS Secret Manager
if (builder.Environment.IsProduction())
{
    builder.Services.AddDbContext<ProdDbContext>(options =>
        options.UseSqlServer(builder.Configuration
            .GetConnectionString("DefaultConnection")));
}
else
{
    builder.Services.AddDbContext<DevDbContext>(options =>
        options.UseSqlServer(builder.Configuration
            .GetConnectionString("DefaultConnection")));
}


var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{

// we want Swagger for all environments.
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseAuthorization();

app.MapControllers();

app.Run();
