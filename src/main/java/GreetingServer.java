import com.github.adilevin.hello_world.GreetingRequest;
import com.github.adilevin.hello_world.GreetingResponse;
import com.github.adilevin.hello_world.GreetingServiceGrpc;
import io.grpc.Server;
import io.grpc.ServerBuilder;
import io.grpc.stub.StreamObserver;

import java.io.IOException;
import java.util.logging.Logger;

/**
 * Created by alevin on 7/29/2017.
 */
public class GreetingServer {

  private static final Logger logger = Logger.getLogger(GreetingServer.class.getName());
  private Server server;

  private void start() throws IOException {
    int port = 5001;
    logger.info("Starting server - listening on port " + port);
    server = ServerBuilder.forPort(port)
            .addService(new GreetingServerImpl())
            .build()
            .start();
  }

  private void stop() {
    if (server != null) {
      logger.info("Shutting down server");
      server.shutdown();
    }
  }

  private void blockUntilShutdown() throws InterruptedException {
    if (server != null) {
      server.awaitTermination();
    }
  }

  public static void main(String[] args) throws IOException, InterruptedException {
    final GreetingServer server = new GreetingServer();
    server.start();
    server.blockUntilShutdown();
  }

  static class GreetingServerImpl extends GreetingServiceGrpc.GreetingServiceImplBase {

    @Override
    public void greet(GreetingRequest req, StreamObserver<GreetingResponse> responseObserver) {
      GreetingResponse reply = GreetingResponse.newBuilder().setResponseText("Hello " + req.getName()).build();
      responseObserver.onNext(reply);
      responseObserver.onCompleted();
      logger.info("Get request " + req.getName() + ". Responded with " + reply.getResponseText());
    }
  }
}
