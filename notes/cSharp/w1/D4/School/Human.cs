class Human {
    public string FirstName;
    public string LastName;

    public Human(string first, string last){
        FirstName = first;
        LastName = last;
    }

    public string Introduction(){
        Console.WriteLine($"{FirstName} {LastName}");
        return FirstName + " " + LastName;
    }
}