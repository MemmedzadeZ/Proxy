using Proxy.Iterfaces;

namespace Proxy.Classes;

class ConcreteService : IService
{
    public void Service(string servise)
    {
        Console.WriteLine($"ConcreteService {servise}");
    }
}
