using Factory;

NYPizzaStore NyStore = new NYPizzaStore();

NyStore.OrderPizza("cheese");
NyStore.OrderPizza("greek");
NyStore.OrderPizza("pepperoni");



Console.WriteLine("---------------------------------------------------------------------------------------------");

CHPizzaStore ChStore = new CHPizzaStore();

ChStore.OrderPizza("cheese");
ChStore.OrderPizza("greek");
ChStore.OrderPizza("pepperoni");





NyStore.OrderPizza("DFD");// test exception