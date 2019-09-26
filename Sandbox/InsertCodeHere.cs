using System;

namespace Sandbox
{    
    public class InsertCodeHere
    {
        
        
        
       
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            //Opret en skole
            School school1 = new School("Zealand", "Maglegaardsvej 2", "00110022");
            school1.Name = "Zealand - we are the best ever";
            
            // hold
            Hold holdA = new Hold("Hold A", "12122019");
            Hold holdB = new Hold("Hold B", "34343434");


            school1.Hold = holdA;
            //Students
            
            Student student1 = new Student("Egon Olsen", "0101012431", "vridsløse 02", "88888888");
            Student student2 = new Student("Benny", "0202032679", "vridsløse 03", "51525354");
            Student student3 = new Student("Kjeld", "1111111111", "vridsløse 04", "112");
            Student student4 = new Student() { Navn = "Batman", Cpr = "2222222" };
            Console.WriteLine($"Studentno for student1 { student1.StudNo}");
            Console.WriteLine($"Studentno for student2 { student2.StudNo}");
            Console.WriteLine($"Studentno for student3 { student3.StudNo}");
            holdA.S1 = student1;
            holdA.S2 = student2;
            holdA.S3 = student3;

            string isFull = holdA.CheckIfFull();
            Console.WriteLine($"Holdet er fyldt {isFull}");

            holdA.S1 = null;

            //isFull = holdA.CheckIfFull();
            //Console.WriteLine($"Holdet er fyldt {isFull}");
            string isFullString = (holdA.CheckIfFull()== "Sandt") ? "Holdet er fyldt" : "Holdet er ikke fyldt";
            Console.WriteLine($"Holdstatus {isFullString}");

            //Teacher
            Teacher poul = new Teacher("Poul", "123456", "Some address", 8008);
            int karakter= poul.EvaluateTest(20);

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