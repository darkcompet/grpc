# GRPC



## How this was made


	```bash
	# Since Grpc.Core was deprecated, from now, we use gRPC.Net instead.
	# gRPC: https://grpc.io/docs/languages/csharp/dotnet/
	# gRPC: https://github.com/grpc/grpc-dotnet
	# Impl: https://docs.microsoft.com/en-us/aspnet/core/tutorials/grpc/grpc-start?view=aspnetcore-6.0&tabs=visual-studio-mac

	# [Server] Create grpc-based asp.net project

	# [Client] Create console app then add below nuget dependencies
	- Grpc.Net.Client: contains the .NET Core client.
	- Google.Protobuf: contains protobuf message APIs for C#.
	- Grpc.Tools: contain C# tooling support for protobuf files. The tooling package is NOT required at runtime, so the dependency is marked with PrivateAssets="All".

	# [Client] Copy `Protos/` folder from server to client project.

	# [Client] Right-click the project and select `Edit Project File`.
	# Then add below code to .csproj file.
	<ItemGroup>
		<Protobuf Include="Protos\greet.proto" GrpcServices="Client" />
	</ItemGroup>
	```

## Ref

- https://auth0.com/blog/implementing-microservices-grpc-dotnet-core-3/

