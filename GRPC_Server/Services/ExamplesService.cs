using Grpc.Core;
using GRPC_Server.Protos;

namespace GRPC_Server.Services
{
    public class ExamplesService : Examples.ExamplesBase
    {
        public override Task<ResponseExample> GetText(RequestExample request, ServerCallContext context)
        {
            return Task.FromResult(new ResponseExample() { Text = $"You said: {request.Text}, i say: Hellowwww"});
        }
    }
}
