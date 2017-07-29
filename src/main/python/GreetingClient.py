# Requires to pre-install
# pip install grpcio

class GreetingClient(object):

    def __init__(self, url):
        import grpc
        import HelloWorld_pb2_grpc
        channel = grpc.insecure_channel(url)
        self.stub = HelloWorld_pb2_grpc.GreetingServiceStub(channel)

    def greet(self, name):
        import HelloWorld_pb2
        req = HelloWorld_pb2.GreetingRequest()
        req.name = name
        resp = self.stub.Greet(req)
        return resp.response_text

if __name__=="__main__":
    client = GreetingClient('localhost:5001')
    for name in ["Adi", "Noam", "Yael"]:
        print client.greet(name)

