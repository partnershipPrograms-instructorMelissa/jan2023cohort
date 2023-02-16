// OOP - classes
//  we are not starting to work with other files =D

// format - variables, constructor, methods
class Developer {
    string Name;
    int Age;
    int TimeOnJob;
    string Role;
    string FavLanguage;

    // constructor
    Developer(string name, int age){
        Name = name;
        Age = age;
        TimeOnJob = 0;
        Role = "JR Dev";
        FavLanguage = "";
    }
}

// Developer Katie = new Developer("Katie", 29); // error CS8803: Top-level statements must precede namespace and type declarations