//  creating a human
Human Juli = new Human("Juli", "Vanden Heuvel");
Juli.Introduction();

//  creating a student
Student Kaitlynn = new Student("Kaitlynn", "Whitney", "C#");
Kaitlynn.Introduction();

Kaitlynn.PrintStudent();
// Juli.PrintStudent(); // will not work since human not a student
// Juli = new Student(Juli.FirstName, Juli.LastName, "JavaScript"); // not allowed
