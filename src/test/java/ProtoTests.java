import org.junit.Assert;
import org.junit.Test;
import com.github.adilevin.hello_world.GreetingRequest;
import com.github.adilevin.hello_world.GreetingResponse;

/**
 * Created by alevin on 7/29/2017.
 */
public class ProtoTests {

  @Test
  public void testHelloWorldProto() {
    GreetingRequest greetingRequest = GreetingRequest.newBuilder().
            setName("Adi").build();
    GreetingResponse greetingRespone = GreetingResponse.newBuilder().
            setResponseText("Hello Adi").build();
    Assert.assertEquals("Hello Adi",greetingRespone.getResponseText());
  }
}
