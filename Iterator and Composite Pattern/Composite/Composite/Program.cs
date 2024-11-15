using Composite;
using System;
using System.Collections;

/*
We need some kind of a tree shaped structure that will accommodate menus, submenus and menu items
*/

/*The Composite Pattern allows you to compose objects into tree structures to represent part-whole hierarchies.
 Composite lets clients treat individual objects and compositions of objects uniformly.

The Composite Pattern allows us to build structures of objects in the form of trees that contain both 
compositions of objects and individual objects as nodes
*/


Menu dinerMenu = new DinerMenu("DINER MENU", "Lunch");
Menu pancakeHouseMenu = new PancakeHouseMenu("PANCAKE HOUSE MENU", "Breakfast");
Menu allMenus = new Menu("all menus", "ALL");

pancakeHouseMenu.add(dinerMenu);

allMenus.add(dinerMenu);
allMenus.add(pancakeHouseMenu);

waitress waitress = new waitress(allMenus);

waitress.printMenu();
