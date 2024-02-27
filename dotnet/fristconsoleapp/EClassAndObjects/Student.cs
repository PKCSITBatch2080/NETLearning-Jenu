using System;

class Student
{
{    
    // Default Constructor
    public Student()
    {

    }

    // Parameterized constructor
    public Student(string n, byte rn)
    {
        name = n;
        RollNumber = rn;
    }

    
    string name;
    byte rollNumber;
    public byte RollNumber
@@ -31,16 +30,14 @@ public byte RollNumber
            }
        }
    }
    public string Address { get; set; }      //Auto implemented property
    public DateTime Dob { get; }

    public string Address {get; set; }      //Auto implemented property
    DateTime dob;


    public void DisplayInfo() 
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Student Name: {name}");
        Console.WriteLine($"Student Roll Number: {rollNumber}");
        Console.WriteLine($"Student Dob: {dob}");
        Console.WriteLine($"Student Dob: {Dob}");
        Console.WriteLine($"Student Address: {Address}");
    }
}