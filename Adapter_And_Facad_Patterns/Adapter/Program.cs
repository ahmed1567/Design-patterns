// See https://aka.ms/new-console-template for more information
using AdapterPattern;


Turkey turkey = new Turkey();

Duck duck = new Duck();


// convert turkey interface to duck interface
TurkeyAdapter turkeyAdapter = new TurkeyAdapter(turkey);

turkeyAdapter.quack();
turkeyAdapter.fly();


// convert duck interface to turkey interface
DuckAdapter duckAdapter = new DuckAdapter(duck);

duckAdapter.gobble();


for (int i = 0; i < 10; i++)
{
    duckAdapter.fly();
}//the duck has a 20% chance of flying since 1 out of 5 possible values results in true so i used loop to see that chance .
