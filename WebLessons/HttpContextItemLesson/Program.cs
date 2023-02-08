var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// app.Use(async (context, next) =>
// {
//     context.Items["text"] = "Hello from HttpContext.Items";
//     await next.Invoke();
// });
//
// app.Run(async context =>
// {
//     await context.Response.WriteAsync(context.Items["text"].ToString());
// });

app.Use(async (context, next) =>
{
    context.Items.Add("messag","MyItem");
    await next.Invoke();
});

app.Run(async context =>
{
    if (context.Items.ContainsKey("message"))
    {
        await context.Response.WriteAsync($"{context.Items["message"]}");
    }
    else
    {
        await context.Response.WriteAsync("y");
    }

});

app.Run();