using System;
Console.WriteLine("hello");
Datatypes dt1= new();
dt1.Learn();
Methods M=new();
M.Greet("Namaste");
var highest= M.GetMax(3.4,5.6,8.4,23.4);
var highest2= M.GetMax(3.4,8.4,23.4);
var highest3= M.GetMax(3.4,5.6);
var highest4= M.GetMax(23.4);
Generic g= new(); 
g.Display<string>("sapana shrestha");
g.Display<int>(303);

Student Jenu= new Student();
Student smriti= new Student("smriti kc",123);
Jenu.RollNumber=5;