﻿using System;

namespace DependencyInjection
{
    public class ConsoleMessageWriter : IMessageWriter
    {
        public void Write(string message)
        {
            Console.WriteLine(
                $"ConsoleMessageWriter.Write(message: \"{message}\")"
            );
        }
    }
}
