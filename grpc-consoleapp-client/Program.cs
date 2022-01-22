// See https://aka.ms/new-console-template for more information
using System.Threading.Tasks;
using Grpc.Net.Client;

Console.WriteLine("Hello, World!");

// The port number must match the port of the gRPC server.
using var channel = GrpcChannel.ForAddress("http://localhost:10080");
var client = new Greeter.GreeterClient(channel);
var reply = await client.SayHelloAsync(new HelloRequest { Name = "GreeterClient" });
Console.WriteLine("Greeting: " + reply.Message);
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
