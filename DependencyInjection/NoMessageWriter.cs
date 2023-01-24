using System;
using System.Diagnostics;

namespace DependencyInjection
{
    public class DebugMessageWriter : IMessageWriter
    {
        public void Write(string message)
        {
            Debug.WriteLine(
                $"DebugMessageWriter.Write(message: \"{message}\")"
            );
        }
    }
}
