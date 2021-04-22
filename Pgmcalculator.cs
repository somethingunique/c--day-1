using System.IO;
using System;

class Program
{
    static void Main(string[] args)
    {
      Console.WriteLine("Enter what you want to do. \n 1.Addition \n 2.Sub \n 3.Multiply ")
      int Choice =Convert.ToInt32(Console.ReadLine());
     switch (Choice)
     {
         case 1:
          Console.WriteLine("Add");
          break;
          case 2:
          Console.WriteLine("Sub");
          break;
          case 3:
          Console.WriteLine("Multiply");
          break;
          default:
          Console.WriteLine("Nothing");
          break;
     }
       Console.ReadLine();
    }
}