using System.IO;
using System;

class Program
{
    static void Main(string[] args)
    {
      
     int age;
      Console.WriteLine("Enter a number");//age
      age = Convert.ToInt32(Console.ReadLine());
       if(age >18)
       {
       Console.WriteLine(age + " is eligible.");
       }
       else
       {
         Console.WriteLine(age + " is not eligible.");  
       }
       Console.ReadLine();
    }
}