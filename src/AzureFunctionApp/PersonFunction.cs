using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Host;

namespace AzureFunctionApp
{
    public static class PersonFunction
    {
        [FunctionName("PersonFunction")]
        public static IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)]HttpRequest req, TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            int.TryParse(req.Query["personId"], out int personId);
            if (personId == 0)
            {
                return new BadRequestObjectResult("A personId must be passed in the query string.");
            }

            //string requestBody = new StreamReader(req.Body).ReadToEnd();
            //dynamic data = JsonConvert.DeserializeObject(requestBody);
            //name = name ?? data?.name;

            var person = new Person
            {
                PersonId = personId,
                FullName = $"John Doe{personId}"
            };

            return new OkObjectResult(person);
        }
    }
}