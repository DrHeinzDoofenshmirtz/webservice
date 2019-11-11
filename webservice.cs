
#r "Newtonsoft.Json"
using Newtonsoft.Json;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Microsoft.AspNetCore.Mvc;

public static async Task<IActionResult> Run(HttpRequest request, ILogger log)
{
    log.LogInformation("Start");    
    return new OkObjectResult(
        new 
        {
            nice = "cool"
        }
    );
}
