using Grpc.Core;
using GrpcGreeter;

namespace BlazorGrpc.Server.gRPC_services
{
    public class GreeterService : Greeter.GreeterBase
    {
        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            var reply = new HelloReply { Message = $"Hello from gRPC, {request.Name}!" };
            return Task.FromResult(reply);
        }
    }
}
