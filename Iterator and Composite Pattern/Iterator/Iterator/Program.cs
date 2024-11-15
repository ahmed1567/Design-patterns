using Iterator;
// itrator pattern provides a way to access the elements of an aggregate object sequentially without exposing its underlying representation
// now we have two different collection we want to print data on 
// simple solution we need two methode print each different collection , does that the right thing to do?
// there is another solution using Iterator pattern 

DinerMenu dinerMenu = new DinerMenu();
PancakeHouseMenu pancakeHouseMenu  = new PancakeHouseMenu();

waitress waitress = new waitress(pancakeHouseMenu , dinerMenu);

waitress.printMenu();


// instead of create our iterators , C# collection implement IEnumerator whic provid iterator for each collection on C#