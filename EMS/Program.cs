using HotChocolate.AspNetCore;
using HotChocolate.Execution.Processing;
using EMS.QueryResolver;
using EMS.Services;
using EMS.DTO;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Made by me
builder.Services.AddGraphQLServer()
    .AddQueryType(q => q.Name("Query"))
    .AddType<AttendeeQueryResolver>();

builder.Services.AddScoped<IAttendeeService,AttendeeService>();



var app = builder.Build();

// Configure the HTTP request pipeline.

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

//by me
app.UseEndpoints(endpoints =>
{
    _ = endpoints.MapControllers();
    _ = endpoints.MapGraphQL();
}
);


app.Run();
