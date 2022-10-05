using InstantMessengerApi.Hubs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//SignalR
builder.Services.AddSignalR();

string[] urls = new[] { "http://localhost:3000" };
builder.Services.AddCors(options =>
    options.AddDefaultPolicy(builder => builder.WithOrigins(urls)        
    .AllowAnyMethod().AllowAnyHeader().AllowCredentials()));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//CORS 需要在 UseHttpsRedirection 前
app.UseCors();
app.UseHttpsRedirection();

app.UseAuthorization();
//SignalR 需要在 MapControllers 前
app.MapHub<ChatHub>("/Hubs/ChatHub");

app.MapControllers();

app.Run();
