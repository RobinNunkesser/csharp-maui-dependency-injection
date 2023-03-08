using System;

namespace DependencyInjection
{
    public class NoMessageWriter : IMessageWriter
    {
        public void Write(string message)
        {
            Console.WriteLine($"NoMessageWriter.Write");
        }
    }
}
