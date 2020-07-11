using GrpcDotNetNamedPipes;
using System;
using System.Threading.Tasks;

namespace gRPC_Demo_Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var channel = new NamedPipeChannel(".", "MY_PIPE_NAME");
            var client = new Greeter.GreeterClient(channel);

            var response = await client.SayHelloAsync(
                new HelloRequest { Name = "World" });

            Console.WriteLine(response.Message);
            Console.ReadKey();
        }
    }
}
