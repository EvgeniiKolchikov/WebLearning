using LogLesson.FileLogger;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.AddFile(Path.Combine(Directory.GetCurrentDirectory(), "logger.txt"));

var app = builder.Build();

// ILoggerFactory loggerFatory = LoggerFactory.Create(builder => builder.AddConsole());
// ILogger logger = loggerFatory.CreateLogger<Program>();

// app.Run(async context =>
// {
//     logger.LogInformation($"{context.Request.Path}");
//     await context.Response.WriteAsync("fff");
// });

// app.Run(async (context) =>
// {
//     var path = context.Request.Path;
//     
//     app.Logger.LogCritical($"LogCritical {path}");
//     app.Logger.LogDebug($"LogDebug {path}");
//     app.Logger.LogError($"LogError {path}");
//     app.Logger.LogTrace($"LogTrace {path}");
//     app.Logger.LogWarning($"LogWarning {path}");
//     app.Logger.Log(LogLevel.Information, $"Log {path}");
//
//     await context.Response.WriteAsync("Hello");
// });

// app.Map("/hello", (ILogger<Program> logger) =>
// {
//     logger.LogInformation($"Path: /hello Time: {DateTime.Now}");
//     return "Hello, World";
// });

// app.Map("log", (ILoggerFactory loggerFatory) =>
// {
//     ILogger logger = loggerFatory.CreateLogger("MapLogger");
//     logger.Log(LogLevel.Critical, $"{DateTime.Now}");
//     return $"jjj";
// });


// ILoggerFactory loggerFactory = LoggerFactory.Create(builder => builder.AddDebug());
// var logger = loggerFactory.CreateLogger("EVGEN");
//
// app.Run(async context =>
// {
//     logger.LogInformation("My LOgInformation");
//     await context.Response.WriteAsync("iii");
// });

app.Run(async context => 
{
    app.Logger.LogInformation($"{context.Request.Path} {DateTime.Now}");
    await context.Response.WriteAsync("Logging");
});

app.Run();