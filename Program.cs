using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Content(
    "<html><head><style>body { font-family: Arial, sans-serif; margin: 0; padding: 0; background: linear-gradient(to right, #4facfe, #00f2fe); color: white; text-align: center; } h1 { margin-top: 20px; } .content { padding: 20px; } ul { list-style: none; padding: 0; } li { margin: 10px 0; }</style></head><body><div class='content'><h1>Welcome to Azure App!</h1><p>Benefits of Azure:</p><ul><li>Scalability</li><li>High Availability</li><li>Security</li><li>Cost Efficiency</li><li>Global Reach</li></ul></div></body></html>",
    "text/html"));

app.Run();
