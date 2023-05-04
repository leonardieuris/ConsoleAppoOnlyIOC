using Microsoft.Extensions.DependencyInjection;

namespace ConsoleAppIOC
{
    public static class IOC
    {
        private static void GetCollection(this IServiceCollection service)
        {
        
            service.AddSingleton<IPrinterResult,PrinterResult>();
            service.AddSingleton<ICalculator, Multi>();
            service.AddSingleton<Calculator>();
        }


        public static ServiceProvider GetProvider()
        {
            var services = new ServiceCollection();
            services.GetCollection();
            return  services.BuildServiceProvider();
        }
    }
}
