using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
   static void Main(string[] args)
   {
    Console.WriteLine("Informe um numero: ");
    int numero = int.Parse(Console.ReadLine());

    if(numero % 2 == 0)
    {
        Console.WriteLine("Numero Par");
    }
    else
    {
        Console.WriteLine("Numero Impar");
    }
   }
}