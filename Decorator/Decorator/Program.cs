using Decorator;

Coffees esperesso = new Esperesso();
Console.WriteLine(esperesso.getDescription());

esperesso = new Mocha(esperesso);
Console.WriteLine(esperesso.getDescription());
Console.WriteLine(esperesso.cost());
esperesso = new Mocha(esperesso);
Console.WriteLine(  esperesso.getDescription() );
Console.WriteLine(esperesso.cost());