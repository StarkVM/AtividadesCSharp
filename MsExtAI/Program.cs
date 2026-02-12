// dotnet add package Microsoft.Extensions.AI
//dotnet add package Microsoft.Extensions.AI.Abstractions --prerelease 
//dotnet add package Microsoft.Extensions.AI.OpenAI --prerelease
//dotnet add package OllamaSharp

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/weatherforecast", () => { })
.WithName("GetWeatherForecast");

app.Run();

public record Question(string Prompt);



