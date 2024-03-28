// See https://aka.ms/new-console-template for more information
using SimpleFactory;

simpleFactory Factory = new simpleFactory();

PizzaStore Store = new PizzaStore(Factory);

Store.OrderPizza("cheese");
Store.OrderPizza("greek");
Store.OrderPizza("pepperoni");


// what if u have different region which need different Factories u will need differnt types of pizzas also !!!!!