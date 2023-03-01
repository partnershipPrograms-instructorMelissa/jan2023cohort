public class Trainer{
    public int Id {get; set;}
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public string Email {get; set;}
    public int Experience {get; set;}

    public Trainer(int id, string first, string last, string email, int exp){
        Id = id;
        FirstName = first;
        LastName = last;
        Email = email;
        Experience = exp;
    }

    public string printTrainer(){
        return $@"
            FullName: {FirstName} {LastName}
            Email: {Email}
            Experience Level: {Experience}
        ";
    }
}