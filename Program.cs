using MiniChallenges5To7.Services.MiniChallenge5;
using MiniChallenges5To7.Services.MiniChallenge6;
using MiniChallenges5To7.Services.MiniChallenge7;
using MiniChallenges5To7.Services.MiniChallenge7_Num;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IMiniChallenge5Service, MiniChallenge5Service>();
builder.Services.AddScoped<IMiniChallenge6Service, MiniChallenge6Service>();
builder.Services.AddScoped<IMiniChallenge7Service, MiniChallenge7Service>();
builder.Services.AddScoped<IMiniChallenge7_NumService, MiniChallenge7_NumService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
