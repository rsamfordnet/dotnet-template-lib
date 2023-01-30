using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Hosting;

// https://learn.microsoft.com/en-us/dotnet/core/extensions/generic-host
var builder = Host.CreateDefaultBuilder(args);
builder.ConfigureLogging(logging => {
	logging.SetMinimumLevel(LogLevel.Trace);
	logging.AddConsole();
});
builder.ConfigureServices(services => {
	//services.AddHostedService<Worker>();
});

var host = builder.Build();

await host.RunAsync();
