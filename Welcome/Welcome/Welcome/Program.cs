using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Vad heter du? ");
        string name = Console.ReadLine();

        Welcome(name);
    }

    static void Welcome(string name)
    {
        Console.WriteLine("Välkommen " + name + "!");
        Console.ReadKey();
    }
}