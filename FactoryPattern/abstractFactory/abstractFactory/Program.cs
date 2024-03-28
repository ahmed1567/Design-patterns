// See https://aka.ms/new-console-template for more information
using abstractFactory;

ChIngredientsFactory ChicagoIngredients =  new ChIngredientsFactory();
CHPizzaStore ChicagoStore = new CHPizzaStore(ChicagoIngredients);

ChicagoStore.OrderPizza("Marinara", "Mozzarila");
ChicagoStore.OrderPizza("Tomato", "Blue");
ChicagoStore.OrderPizza("Marinara", "Blue");


Console.WriteLine("---------------------------------------------------------------------------");


NyIngredientsFactory NewYorkIngredients = new NyIngredientsFactory();
NYPizzaStore NewYorkStore = new NYPizzaStore(NewYorkIngredients);

NewYorkStore.OrderPizza("Marinara", "Mozzarila");
NewYorkStore.OrderPizza("Tomato", "Blue");
NewYorkStore.OrderPizza("Marinara", "Blue");


NewYorkStore.OrderPizza("dfddfd", "Dfdfdfsa");
