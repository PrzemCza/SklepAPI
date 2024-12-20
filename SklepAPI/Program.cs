using Microsoft.EntityFrameworkCore;
using SklepAPI.Data; // Upewnij siê, ¿e masz odpowiedni¹ przestrzeñ nazw

var builder = WebApplication.CreateBuilder(args);

// Dodaj us³ugi do kontenera
builder.Services.AddDbContext<SklepContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();

var app = builder.Build();

// Skonfiguruj potok ¿¹dañ HTTP
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();