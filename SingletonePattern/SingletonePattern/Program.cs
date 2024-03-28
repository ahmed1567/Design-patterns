// See https://aka.ms/new-console-template for more information
using SingletonePattern;

Singleton instance = Singleton.getInstance();


Console.WriteLine(instance.GetHashCode());

Singleton instance2 = Singleton.getInstance();

Console.WriteLine(instance2.GetHashCode());

Console.WriteLine(instance);




