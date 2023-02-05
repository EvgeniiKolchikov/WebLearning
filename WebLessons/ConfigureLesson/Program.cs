string[] commandLineArgs = { "name=Sam", "age=33" };

//var builder = WebApplication.CreateBuilder(commandLineArgs);
var builder = WebApplication.CreateBuilder();
builder.Configuration.AddCommandLine(commandLineArgs);

// builder.Configuration.AddInMemoryCollection(new Dictionary<string, string>
// {
//     { "name", "Max" },
//     { "age", "17" }
// });

var app = builder.Build();

app.Map("/", (IConfiguration appConfig) => $"{appConfig["name"]} + {appConfig["age"]}");

// app.Run(async (context) =>
// {
//     var name = app.Configuration["name"];
//     var age = app.Configuration["age"];
//     await context.Response.WriteAsync($"{name} - {age}");
// });


app.Run();