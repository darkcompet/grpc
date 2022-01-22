# GRPC

Sample project for realtime-connection between client and server.


## Pre-requisites

	```bash
	# Install latest dotnet (at this time, we use 6.0)
	Install from official site: https://dotnet.microsoft.com/en-us/download
	```


## Setup and Run

	```bash
	# [Server] Run server at a terminal
	cd grpc-aspnetcore-server
	dotnet run

	# [Client] Run client at other terminal
	cd grpc-consoleapp-client
	dotnet run
	```

## How this was made


	```bash
	# Since Grpc.Core was deprecated, from now, we use gRPC.Net instead.
	# Impl: https://docs.microsoft.com/en-us/aspnet/core/tutorials/grpc/grpc-start?view=aspnetcore-6.0&tabs=visual-studio-code
	# gRPC: https://grpc.io/docs/languages/csharp/dotnet/
	# gRPC: https://github.com/grpc/grpc-dotnet

	# [Server] Create grpc-based asp.net project
	dotnet new grpc -o grpc-aspnetcore-server
	dotnet dev-certs https --trust

	# [Server] Remove namespace from all `.proto` and `.cs` files since we avoid use namespace for the app.

	# [Client] Create console app then add below nuget dependencies
	dotnet new console -o grpc-consoleapp-client
	
	# [Client] Add dependencies to `grpc-consoleapp-client/grpc-consoleapp-client.csproj`
	cd grpc-consoleapp-client
	dotnet add package Grpc.Net.Client
	dotnet add package Google.Protobuf
	dotnet add package Grpc.Tools
	
	# [Client] Copy `Protos/` folder from server to client project.

	# [Client] Then add below code to .csproj file.
	# [If use Visual studio] Right-click the project and select `Edit Project File`.
	<ItemGroup>
		<Protobuf Include="Protos\greet.proto" GrpcServices="Client" />
	</ItemGroup>

	# [Server] Run server at a terminal
	cd grpc-aspnetcore-server
	dotnet run

	# [Client] Run client at other terminal
	cd grpc-consoleapp-client
	dotnet run

	# Done, see the result.
	```


## Ref

- https://auth0.com/blog/implementing-microservices-grpc-dotnet-core-3/

