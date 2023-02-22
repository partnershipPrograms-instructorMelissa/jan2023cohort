#pragma warning disable CS8618
public class User{
    public string FirstName { get; set; }
    public string? LastName { get; set; }

    public User(string firstName){
        FirstName = firstName;
    }
    public User(string firstName, string? lastName){
        FirstName = firstName;
        LastName = lastName;
    }
}