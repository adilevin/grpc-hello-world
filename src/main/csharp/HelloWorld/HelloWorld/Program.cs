using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new GreetingClient("127.0.0.1:5001");
            List<string> names = new List<string> { "Adi", "Noam", "Yael" };
            names.ForEach((name) => { Console.WriteLine(client.Greet(name)); });
        }
    }
}
