var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.Use(async (context,next) =>
{
    await context.Response.WriteAsync("Hello World from ASP.NET Core Middleware!\n");
    await next(context);
});

app.Run(async (context) =>
{
    await context.Response.WriteAsync("Hello Earth from ASP.NET Core Middleware!");
});

app.Run();
