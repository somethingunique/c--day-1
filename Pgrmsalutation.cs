using System.IO;
using System;

namespace SampleApplication
{
    
public enum Salutation
{
    Mr=0,
    Ms=1,
    Mrs=2,
    Dr=3
}
Class Class12
{
    static void Main(string[] args)
    {
        Salutation salutation;
        string name;
        Console.WriteName("Enter the Salutation:");
        Salutation = (Salutation)Enum.Parse(typeof(Salutation), Console.ReadLine());
        //Console.WriteLine(typeof(string));
Console.WriteLine("Enter your name:");
name = Console.ReadLine();
Console.Write("\nYour NAme is: {0}", salutatuion.TosString());
Console.Write("."+ name);
Console.ReadLine();
    }
}