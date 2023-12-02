using Proxy.Iterfaces;

namespace Proxy.Classes;

class ProxyClass : IService
{
    private IService _service;

    public ProxyClass(IService service)
    {
        _service = service;
        
    }
    public void Service(string servise)
    {
        if(servise.Length >3)
        {
            Console.WriteLine(servise);
        }
        else
        {
            _service.Service(servise);
        
        }
    }
}
