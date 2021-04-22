using System.IO;
using System;

class Program
{
    static void Main()
    {
         int[,] arr = new int[3,3];
         Console.WriteLine("Enter the elements");
         for(int row=0; row < arr.Getlength(1); row++)
         {
             for(int col=0; col < arr.Getlength(1); col++)
              {
               arr[row,col] =Convert.ToInt32(Console.ReadLine());
              }
         }
        for(int row=0; row < arr.GetLength(1); row++)
         {
             for(int col=0; col < arr.GetLength(1); col++)
              {
               Console.Write(arr[row, col] + "\t");
              } 
        Console.Write("\n");
         }
	
        for(int row=0; row < arr.GetLength(1); row++)
         {
             for(int col=0; col < arr.GetLength(1); col++)
              {
               Console.Write(arr[col, row] + "\t");
              } 
	 Console.Write("\n");
     }
         Console.ReadLine();
}