using MinimalJwt.Models;
using MinimalJwt.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSingleton<IMovieService, MovieService>();
builder.Services.AddSingleton<IUserService, UserService>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

//app.MapPost("/create",
    //(Movie movie, IMovieService service) => Create(movie, service));

app.Run();

