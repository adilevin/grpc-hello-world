// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: HelloWorld.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace HelloWorld {
  public static partial class GreetingService
  {
    static readonly string __ServiceName = "hello_world.GreetingService";

    static readonly grpc::Marshaller<global::HelloWorld.GreetingRequest> __Marshaller_GreetingRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HelloWorld.GreetingRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HelloWorld.GreetingResponse> __Marshaller_GreetingResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HelloWorld.GreetingResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::HelloWorld.GreetingRequest, global::HelloWorld.GreetingResponse> __Method_Greet = new grpc::Method<global::HelloWorld.GreetingRequest, global::HelloWorld.GreetingResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Greet",
        __Marshaller_GreetingRequest,
        __Marshaller_GreetingResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::HelloWorld.HelloWorldReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of GreetingService</summary>
    public abstract partial class GreetingServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::HelloWorld.GreetingResponse> Greet(global::HelloWorld.GreetingRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for GreetingService</summary>
    public partial class GreetingServiceClient : grpc::ClientBase<GreetingServiceClient>
    {
      /// <summary>Creates a new client for GreetingService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public GreetingServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for GreetingService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public GreetingServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected GreetingServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected GreetingServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::HelloWorld.GreetingResponse Greet(global::HelloWorld.GreetingRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Greet(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HelloWorld.GreetingResponse Greet(global::HelloWorld.GreetingRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Greet, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HelloWorld.GreetingResponse> GreetAsync(global::HelloWorld.GreetingRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GreetAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HelloWorld.GreetingResponse> GreetAsync(global::HelloWorld.GreetingRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Greet, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override GreetingServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new GreetingServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(GreetingServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Greet, serviceImpl.Greet).Build();
    }

  }
}
#endregion
