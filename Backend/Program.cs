using Backend.Services;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

// AQUI PARA AÑADIR EN LAS FUNCIONALIDAD
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<HabitacionServices>(); // SERVICIO DE HABITACION
builder.Services.AddScoped<ServicioServices>(); // SERVICIO DE SERVICIO
builder.Services.AddScoped<HuespedServices>(); // SERVICIO DE HUESPED
builder.Services.AddScoped<HabitacionReservaServices>(); // SERVICIO DE HABITACION_RESERVA
builder.Services.AddScoped<ReservaServices>(); // SERVICIO RESERVA

builder.Services.AddScoped<ConexionServices>(); // SERVICIO DE CONEXION DE BASE DE DATOS MYSQL


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
