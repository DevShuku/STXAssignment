using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using STXAssignment.Data;
using STXAssignment.Services;
using System.Text;

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

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "Authorization header using the Bearer tokens",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement{
    {
        new OpenApiSecurityScheme
        {
            Reference = new OpenApiReference
            {
                Type = ReferenceType.SecurityScheme,
                Id = "Bearer"
            }
        },
        Array.Empty<string>()
    }});
});


// Configure JWT Authentication
var key = Encoding.ASCII.GetBytes("eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJTaHJ1dGhpTWF5eWEiLCJpYXQiOjE3MTkxNjI3OTIsImV4cCI6MTc1MDY5ODc5MiwiYXVkIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NzA1My9zd2FnZ2VyL2luZGV4Lmh0bWwiLCJzdWIiOiJzaHJ1dGhpbWF5eWFAZ21haWwuY29tIiwiTmFtZSI6InNocnV0aGltYXl5YSJ9.n5wJdXSXb_eAeEf_7y06Hfo0KPJBghszaOUZkp8fK34");

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = "ShruthiMayya",
        ValidAudience = "https://localhost:7053/swagger/index.html",
        IssuerSigningKey = new SymmetricSecurityKey(key)
    };
});


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
