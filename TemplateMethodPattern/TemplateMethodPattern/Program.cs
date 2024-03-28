using TemplateMethodPattern;


//The Template Method Pattern defi nes the skeleton of an algorithm in a method, deferring some steps to subclasses. Template Method lets subclasses redefine 
//certain steps of an algorithm without changing the algorithm’s structure.


Coffee coffee = new Coffee();
coffee.PrepareRecipe();

Console.WriteLine("------------------------------------------------------------------------------");
Tea tea = new Tea();
tea.PrepareRecipe();