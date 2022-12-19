using System;
using System.Threading;

var environment = Environment.GetEnvironmentVariable("ENVIRONMENT");

while (true)
{
    System.Console.WriteLine($"Environment: {environment}. The time is: {DateTime.Now}");
    Thread.Sleep(5000);
}