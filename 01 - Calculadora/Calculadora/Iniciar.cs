using System;

namespace Projeto1
{
    class StartProgram
    {
        enum Opcoes {Adicao = 1, Subtracao, Divisao, Multiplicacao, Encerrar = 0}
        static void Main(string[] args)
        {
            Operadores op = new Operadores();
            bool escolheuSair = false;
            double resultado;
            while (!escolheuSair)
            {
                Console.WriteLine("1 - Adicao\n2 - Subtracao\n3 - Divisao\n4 - Multiplicao\n0 - Encerrar");
                Console.Write("Informe a opcao desejada: ");

    
                Opcoes opcao = (Opcoes)int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case Opcoes.Adicao:
                        Console.WriteLine($"{Opcoes.Adicao} Selecionado");
                        resultado = op.Adicao();
                        Console.WriteLine($"O resultado da Soma e igual a: {resultado}");
                        break;
                    
                    case Opcoes.Subtracao:
                        Console.WriteLine($"{Opcoes.Subtracao} Selecionado");
                        resultado = op.Subtracao();
                        Console.WriteLine($"O resultado da Subtracao e igual a: {resultado}");
                        break;

                    case Opcoes.Divisao:
                        Console.WriteLine($"{Opcoes.Divisao} Selecionado");
                        resultado = op.Divisao();
                        Console.WriteLine($"O resultado da Divisao e igual a: {resultado}");
                        break;

                    case Opcoes.Multiplicacao:
                        Console.WriteLine($"{Opcoes.Multiplicacao} Selecionado");
                        resultado = op.Multiplicacao();
                        Console.WriteLine($"O resultado da Multiplicacao e igual a: {resultado}");
                        break;

                    case Opcoes.Encerrar:
                        escolheuSair = true;
                        Console.WriteLine("Encerrando o programa...");
                        break;

                    default:
                        Console.WriteLine("Opcao Invalida, tente novamente.");
                        break;

                }
            }
        }
    }
}