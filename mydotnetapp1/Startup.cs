using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
namespace mydotnetapp1 {
public class Startup
{
public Startup(IHostingEnvironment env)
{
}
public void Configure(IApplicationBuilder app,
IHostingEnvironment env, ILoggerFactory loggerFactory)
{
app.Run(async (context) =>
{
await context.Response.WriteAsync("Hello, world!");
});
}
}
}