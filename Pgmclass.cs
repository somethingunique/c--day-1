using System.IO;
using System;

class Student
{
    pulic int RollNumber{ get; set; }
    pulic int Name{ get; set; }
    pulic int Gender{ get; set; }
    static void Main()
    {
         Student student = new Student();
         student.Rollnumber = 13;
         student.Name = "Abi";
         student.Gender = "Female";
         Console.WriteLine(student.Rollnumber+"\t"+ student.Name+"\t" + student.Gender);
         Console.ReadLine();
         
    }
}