//  from previous parts
string[] strArr = {"Tim", "Martin", "Nikki", "Sara"};

List<string> flavors = new List<string>();

flavors.Add("Mint Chocolate Chip");
flavors.Add("Cookie Dough");
flavors.Add("Coffee");
flavors.Add("Cookies and Cream");
flavors.Add("Vanilla");

//  create dictionary that will store string keys and string values
Dictionary<string, string> orders = new Dictionary<string, string>();

// add key/value pair to the dictionary where:
//      Each key is a name from your name array
//      Each value is a randomly selected flavor from you flavors list
Random rand = new Random();
foreach(string name in strArr){
    orders.Add(name, flavors[rand.Next(0,5)]);
    // Console.WriteLine($"added pair: {orders[name]} (kw)");
}

// Loop through dictionary and print out each user's name and ice cream flavor
foreach(var order in orders){
    Console.WriteLine($"{order.Key} ordered {order.Value}.");
}