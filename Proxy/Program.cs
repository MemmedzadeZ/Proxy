using Proxy.Classes;
using Proxy.Iterfaces;

IService ConcreteService1 = new ConcreteService();
IService proxy = new ProxyClass(ConcreteService1);

ConcreteService1.Service("jmeiwm");
proxy.Service("aaa");


