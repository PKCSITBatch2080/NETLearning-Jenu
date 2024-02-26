using System;

class Student
{
    string name;
    byte rollNumber;
    public byte RollNumber
     {
        get 
        {
            return rollNumber;

        }
        set 
        {
            if(value<=100)
            {
                rollNumber=value;
            }
        }
     }
    string address;
    //Auto Implemented property
    public string Address{get; set;} //this is property without logic 
    DateTime dob;
    public Student() // default constructor=> this is a method without return value
    {

    }
    public Student(string n, byte rn) //parameterized constructor
    {
        name= n; //initialized value of name
        RollNumber=rn; //initialized garda nai property use garna sakinxa

    }
    //property
    // get set value is a keyword

     public void StudentInfo() // this is method
     {
        Console.WriteLine($"Student name = {name}");
        Console.WriteLine($"Student  rollnumber = {rollNumber}");

     }

}
  5 changes: 5 additions & 0 deletions5  
consoleapp/Program.cs
@@ -15,3 +15,8 @@
g.Display<string>("Jenu Oli");
g.Display<int>(303);

Student Jenu= new Student();
Student smriti= new Student("smriti kc",123);
sapana.RollNumber=5;



