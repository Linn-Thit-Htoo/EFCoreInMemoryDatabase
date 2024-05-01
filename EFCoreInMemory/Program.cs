using EFCoreInMemory.Data;
using EFCoreInMemory.Extenstions;
using EFCoreInMemory.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers().AddJsonOptions(opt =>
{
    opt.JsonSerializerOptions.PropertyNamingPolicy = null;
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseInMemoryDatabase("DbName");
}, ServiceLifetime.Transient);

builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();

var app = builder.Build();

await app.AddCustomer();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();