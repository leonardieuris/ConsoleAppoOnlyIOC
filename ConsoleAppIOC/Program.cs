using ConsoleAppIOC;
using Microsoft.Extensions.DependencyInjection;


Console.WriteLine("Start");
var provider = IOC.GetProvider();
var instance = provider.GetService<IPrinterResult>();
instance?.Print(5,4);
Console.WriteLine("END");
