using DemoCustomHealtCheck;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHealthChecks()
    .AddCheck<MyHealthCheck>("MyHealthCheck");
    
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.UseHealthChecks("/healt");
app.UseHttpsRedirection();
app.MapControllers();

app.Run();
