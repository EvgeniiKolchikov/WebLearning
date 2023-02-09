var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.Run(async context =>
{
    if (context.Request.Cookies.ContainsKey("name"))
    {
        var name = context.Request.Cookies["name"];
        await context.Response.WriteAsync($"Hello {name}");
    }
    else
    {
        context.Response.Cookies.Append("name", "Evgen");
        await context.Response.WriteAsync("No Name");
    }
});

app.Run();