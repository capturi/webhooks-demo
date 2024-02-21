using Newtonsoft.Json.Converters;

// Create new web application
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers().AddNewtonsoftJson(o =>
{
    o.SerializerSettings.Converters.Add(new StringEnumConverter());
});

// Build and run app
var app = builder.Build();
app.MapControllers();
app.Run("http://localhost:8080");