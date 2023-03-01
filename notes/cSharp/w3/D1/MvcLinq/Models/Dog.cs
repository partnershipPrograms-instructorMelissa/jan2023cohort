#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace MvsLinq.Models;

public class Dog{
    public int Id {get; set;}
    public string Name {get; set;}
    public string Family {get; set;}
    public string Breed {get; set;}
    public int Age {get; set;}

    public Dog(){}
    public Dog(int id, string name, string family, string breed, int age){
        Id = id;
        Name = name;
        Family = family;
        Breed = breed;
        Age = age;
    }

    public string printDog(){
        return $@"
            Dog Name: {Name}
            Belongs to: {Family}
            Breed: {Breed}
            Age: {Age}
        ";
    }
}