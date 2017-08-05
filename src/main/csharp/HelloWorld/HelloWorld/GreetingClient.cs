using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Grpc.Core;

namespace HelloWorld
{
    class GreetingClient
    {
        private GreetingService.GreetingServiceClient client;

        public GreetingClient(string url)
        {
            var channel = new Channel(url, ChannelCredentials.Insecure);
            client = new GreetingService.GreetingServiceClient(channel);
        }

        public string Greet(string name)
        {
            var req = new GreetingRequest { Name = name };
            var reply = client.Greet(req);
            return reply.ResponseText;
        }
    }
}
