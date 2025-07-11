using CueMarket.API.Data;
using CueMarket.API.Mappings;
using CueMarket.API.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<CueMarketDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("CueMarketConnectionString")));

builder.Services.AddScoped<ICueRepository, SQLCueRepository>();
builder.Services.AddScoped<IWeightBoltRepository, SQLWeightBoltRepository>();
builder.Services.AddScoped<IBumperRepository, SQLBumperRepository>();
builder.Services.AddScoped<IButtSleeveRepository, SQLButtSleeveRepository>();
builder.Services.AddScoped<IWrapRepository, SQLWrapRepository>();
builder.Services.AddScoped<IForearmRepository, SQLForearmRepository>();
builder.Services.AddScoped<IRingRepository, SQLRingRepository>();
builder.Services.AddScoped<IButtRepository, SQLButtRepository>();
builder.Services.AddScoped<IUserRepository, SQLUserRepository>();
builder.Services.AddScoped<IFerruleRepository, SQLFerruleRepository>();
builder.Services.AddScoped<ITipRepository, SQLTipRepository>();
builder.Services.AddScoped<IShaftRepository, SQLShaftRepository>();
builder.Services.AddAutoMapper(typeof(AutoMapperProfiles));

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
