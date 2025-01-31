using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
class Program
{
   static void Main(string[] args)
   { 
    List<double> numeros = new List<double>();
    int quantidade = 0;
    double valorTotal = 0;
    do
    {
        Console.Write("Informe a quantidade de números para calcular a média (entre 3 e 10): ");
        quantidade = int.Parse(Console.ReadLine());

        if (quantidade < 3 || quantidade > 10)
        {
            Console.WriteLine("Quantidade inválida, tente novamente.");
        }

    } while (quantidade < 3 || quantidade > 10);    

    for (int contador = 0; contador < quantidade; contador++)
    {
        Console.Write("Informe um numero: ");
        double numero = double.Parse(Console.ReadLine());
        numeros.Add(numero);

    }

    valorTotal = numeros.Sum();
    double media = valorTotal/quantidade;
    Console.WriteLine($"A Media dos numeros selecionados e igual a: {media}");
   }

}


