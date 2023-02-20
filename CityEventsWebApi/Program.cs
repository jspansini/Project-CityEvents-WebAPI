using AutoMapper;
using CityEvents.Service.DTO;
using CityEventsInfraData.Repository;
using CityEventsService.Dto;
using CityEventsService.Entitys;
using CityEventsService.Interfaces;
using CityEventsService.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

MapperConfiguration mapperConfig = new(mc =>
{
    mc.CreateMap<CityEventsEntitys, CityEventDTO>().ReverseMap();

    mc.CreateMap<EventReservationEntitys, EventReservDTO>().ReverseMap();
});

IMapper mapper = mapperConfig.CreateMapper();

builder.Services.AddSingleton(mapper);

builder.Services.AddScoped<ICityEventService, CityEventService>();
builder.Services.AddScoped<ICityEventsRepository, CityEventRepository>();
builder.Services.AddScoped<IEventReservationRepository, EventReservationRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();


//builder.Services.AddScoped<IEventReservationService, EventReservationService>();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
