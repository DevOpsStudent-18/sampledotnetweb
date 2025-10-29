using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using System.Net;

namespace MyFunctionModule
{
	    public class HelloFunction
		        {
				        [Function("HelloFunction")]
						        public HttpResponseData Run(
									            [HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequestData req,
										                FunctionContext context)
								        {
										            var logger = context.GetLogger("HelloFunction");
											                logger.LogInformation("Processing request...");

													            var response = req.CreateResponse(HttpStatusCode.OK);
														                response.WriteString("Hello from Azure Function!");

																            return response;
																	            }
					    }
}
