var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();
builder.Services.AddLogging(config =>{
    config.AddConsole();
    config.AddDebug();
});

var app = builder.Build();
//app.UseHttpsRedirection();
app.MapControllers();
app.Run();

