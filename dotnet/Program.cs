﻿using System;
Console.WriteLine(3687426);
DataTypes dt = new();
dt.Learn();
Methods m = new();
m.Greet("Hi");
m.CalculateBMI(233.3f, 343.34f);
var highest = m.GetMax(3.4, 5.6, 78.4, 23.4);
var highest2 = m.GetMax(3.4, 5.6);
var highest3 = m.GetMax(3.4, 5.6, 78.4, 23.4, 67.8);
var highest4 = m.GetMax(3.4);
Generics g = new();
g.Display<string>("jsdlkfjsf ");
g.Display<int>(786);

Student iliya = new Student();
Student smriti = new Student("Smiriti KC", 123);
var iliya = new Student();
var smriti = new Student("Smiriti KC", 123);

iliya.RollNumber = 22;      // Assined
smriti.RollNumber = 223;    // Not Assigned

//smriti.Dob = DateTime.Now;
var rekha = new CSStudent("Rekha Aryal", 24, "Hospital Managemenet System");
rekha.DisplayInfo();


var sapana = new CyberSecurityStudent("Sapana Shrestha", 11, "HMS", "RedHat");
sapana.DisplayInfo();