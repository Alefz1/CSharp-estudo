using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
   static void Main(string[] args)
   {
    List<string> clientes = new List<string>();

    clientes.Add("Alef");
    clientes.Add("Emilly");

    clientes.RemoveAt(0);


    foreach (string cliente in clientes)
    {
        Console.WriteLine(cliente);
    }

    Console.WriteLine(clientes.IndexOf("Emilly"));
   }
}