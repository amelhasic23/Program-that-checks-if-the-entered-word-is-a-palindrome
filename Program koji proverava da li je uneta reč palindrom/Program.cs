using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Unesite reč: ");
        string rec = Console.ReadLine();

        string obrnuto = new string(rec.ToCharArray().Reverse().ToArray());

        if (rec.Equals(obrnuto, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine($"Reč '{rec}' je palindrom.");
        }
        else
        {
            Console.WriteLine($"Reč '{rec}' nije palindrom.");
        }
    }
}
