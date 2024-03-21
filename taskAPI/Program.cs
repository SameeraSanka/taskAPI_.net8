using taskAPI.Servises;
using TaskAPI.Servises;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ITodoRepository, TodoServise>();

// Addsingelton mulu application ekatama eka instenst ekai hadenne

// AddScoprd -eka request ekakata hadanne eka object ekai

// AddTransient - hamathissema interface ekata inject karana object eke instent ekak hadanawaa.
// hama welema aluthin hadanawa hama request ekakatama

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
