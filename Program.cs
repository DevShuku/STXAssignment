using Microsoft.Extensions.DependencyInjection;
using STXAssignment.Data;
using STXAssignment.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

var connectionString = builder.Configuration.GetConnectionString("STXSssignmentCon");

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

builder.Services.AddTransient<ICustomerServices, CustomerService>();
builder.Services.AddTransient<ISupplierServices, SupplierService>();
builder.Services.AddTransient<IMeetingServices, MeetingService>();
builder.Services.AddTransient<ITradeDetailsServices, TradeDetailsService>();

builder.Services.AddLogging();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
