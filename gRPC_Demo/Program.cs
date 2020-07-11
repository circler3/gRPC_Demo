using GrpcDotNetNamedPipes;
using System;

namespace gRPC_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new NamedPipeServer("MY_PIPE_NAME");
            Greeter.BindService(server.ServiceBinder, new GreeterService());
            server.Start();
        }
    }
}
