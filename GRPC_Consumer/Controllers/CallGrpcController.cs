using Grpc.Net.Client;
using GRPC_Consumer.Protos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GRPC_Consumer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CallGrpcController : ControllerBase
    {
        [HttpGet("message")]
        public IActionResult GetMessageFromGrpc(string message)
        {
            //No good practices here, just for educational purposes :D
            using var channel = GrpcChannel.ForAddress("http://localhost:5267");
            var client = new Examples.ExamplesClient(channel);
            var reply = client.GetText(
                              new RequestExample { Text = message });
            return Ok(reply);
        }
    }
}
