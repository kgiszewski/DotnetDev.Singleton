// See https://aka.ms/new-console-template for more information

using DotnetDev.Singleton;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Hello, World!");

MySingletonClass.Instance().DoSomething();

var services = new ServiceCollection();

services.AddSingleton<MyNewSingleton>();

var container = services.BuildServiceProvider();

var myProperSingleton = container.GetRequiredService<MyNewSingleton>();

myProperSingleton.DoSomething();

var anotherOne = container.GetRequiredService<MyNewSingleton>();

Console.WriteLine(myProperSingleton == anotherOne);