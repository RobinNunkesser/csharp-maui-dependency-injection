using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace DependencyInjection;

public partial class App : Application
{
    public App(IMessageWriter messageWriter)
    {
        InitializeComponent();
        messageWriter.Write("App initialized.");
        MainPage = new AppShell();
    }
}
