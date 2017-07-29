import com.github.adilevin.hello_world.GreetingRequest;
import com.github.adilevin.hello_world.GreetingResponse;
import com.github.adilevin.hello_world.GreetingServiceGrpc;
import io.grpc.ManagedChannel;
import io.grpc.ManagedChannelBuilder;
import io.grpc.StatusRuntimeException;

import java.io.IOException;
import java.util.concurrent.TimeUnit;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 * Created by alevin on 7/29/2017.
 */
public class GreetingClient {

  private static final Logger logger = Logger.getLogger(GreetingServer.class.getName());
  private final ManagedChannel channel;
  private final GreetingServiceGrpc.GreetingServiceBlockingStub blockingStub;

  public GreetingClient(String host, int port) {
    this(ManagedChannelBuilder.forAddress(host,port)
            .usePlaintext(true)
            .build());
  }

  public GreetingClient(ManagedChannel channel) {
    this.channel = channel;
    this.blockingStub = GreetingServiceGrpc.newBlockingStub(channel);
  }

  public void shutdown() throws InterruptedException {
    channel.shutdown().awaitTermination(5, TimeUnit.SECONDS);
  }

  public void greet(String name) {
    logger.info("Will try to greet " + name + " ...");
    GreetingRequest request = GreetingRequest.newBuilder().setName(name).build();
    GreetingResponse response;
    try {
      response = blockingStub.greet(request);
    } catch (StatusRuntimeException e) {
      logger.log(Level.WARNING, "RPC failed: {0}", e.getStatus());
      return;
    }
    logger.info("Greeting: " + response.getResponseText());
  }

  public static void main(String[] args) throws IOException, InterruptedException {
    final GreetingClient client = new GreetingClient("localhost",5000);
    for(int i=0;i<100;++i) {
      client.greet("Adi" + i);
    }
    client.shutdown();
  }
}
