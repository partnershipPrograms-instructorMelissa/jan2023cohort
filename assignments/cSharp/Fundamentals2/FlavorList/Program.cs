// See https://aka.ms/new-console-template for more information

// create string list of at least 5 unique ice cream flavors 
List<string> flavors = new List<string>();

flavors.Add("Mint Chocolate Chip");
flavors.Add("Cookie Dough");
flavors.Add("Coffee");
flavors.Add("Cookies and Cream");
flavors.Add("Vanilla");

// output length of the list
Console.WriteLine($"Initial Length of flavors List: {flavors.Count} kw");

// output third flavor from list
Console.WriteLine($"Third flavor in list: {flavors[2]} kw");

// remove third flavor using index location
flavors.RemoveAt(2);

// output length of list again
Console.WriteLine($"Changed Length of flavors List: {flavors.Count} kw");