﻿using System;

namespace Sandbox
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            //Opret en skole
            School school1 = new School("Zeuland", "Maglegaardsvej", "00110022");
            school1.Name = "Zealand";
            
            // hold
            Hold holdA = new Hold("Hold A", "12122019");
            
            

            school1.Hold = holdA;
            //Students
            
            Student student1 = new Student("Egon olsen", "0101012431", "vridsløse 02", "88888888");
            Student student2 = new Student("Benny", "0202032679", "vridsløse 03", "51525354");
            Student student3 = new Student("Kjeld", "1111111111", "vridsløse 04", "112");
            Console.WriteLine($"Studentno for student1 { student1.StudNo}");
            Console.WriteLine($"Studentno for student2 { student2.StudNo}");
            Console.WriteLine($"Studentno for student3 { student3.StudNo}");
            holdA.S1 = student1;
            holdA.S2 = student2;
            holdA.S3 = student3;

            
            

            //Teacher
            Teacher poul = new Teacher("Poul", "123456", "Some address", 8008);
            

            holdA.Teacher = poul;
            //Lokale
            Lokale lokaleA = new Lokale();
            

            holdA.Lokale = lokaleA;

            //print
            poul.PrintInfo();
            Console.WriteLine("_____________________________");
            student1.PrintInfo();
            Console.WriteLine("_____________________________");
            student2.PrintInfo();
            Console.WriteLine("_____________________________");
            student3.PrintInfo();
            Console.WriteLine("_____________________________");
            lokaleA.PrintInfo();
            Console.WriteLine("_____________________________");
            holdA.PrintInfo();
            holdA.PrintStudents();
            Console.WriteLine("_____________________________");
            school1.PrintInfo();


            // The LAST line of code should be ABOVE this line
        }
    }
}