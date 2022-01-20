// See https://aka.ms/new-console-template for more information
using System.Threading.Tasks;
using Grpc.Net.Client;

Console.WriteLine("Hello, World!");

// The port number must match the port of the gRPC server.
using var channel = GrpcChannel.ForAddress("http://localhost:10080");
var service = new Greeter.GreeterClient(channel);
var reply = await service.SayHelloAsync(new HelloRequest { Name = "GreeterClient" });

Console.WriteLine("From server: " + reply.Message);
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
