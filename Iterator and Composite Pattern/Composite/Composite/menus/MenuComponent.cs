﻿
namespace Composite
{
    public abstract class MenuComponent 
    {
        public abstract void add(MenuComponent menuComponent);
        public abstract void remove(MenuComponent menuComponent); 
        public abstract MenuComponent getChild(int i);
        public abstract string getName();
        public abstract string getDescription();
        public abstract double getPrice();
        public abstract bool isVegetarian();
        public abstract void print();
    }
}