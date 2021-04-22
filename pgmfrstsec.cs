using System.IO;
using System;

class Program
{
    static void Main()
    {
      
      int firstNumber, secondNumber, result;
      Console.Write("Enter firstNumber:");
      firstNumber = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine();
      Console.Write("Enter secondNumber:");
      secondNumber = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine();
      result = firstNumber+secondNumber;
      Console.WriteLine("Sum of Two Numbers is:{0} ",result);
  
    }
}