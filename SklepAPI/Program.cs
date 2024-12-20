using Microsoft.EntityFrameworkCore;
using SklepAPI.Data; // Upewnij si�, �e masz odpowiedni� przestrze� nazw

var builder = WebApplication.CreateBuilder(args);

// Dodaj us�ugi do kontenera
builder.Services.AddDbContext<SklepContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();

var app = builder.Build();

// Skonfiguruj potok ��da� HTTP
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();