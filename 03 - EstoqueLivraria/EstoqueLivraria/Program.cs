using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Common;

struct Livro 
{
    public int id {get; set;}
    public string nome {get; set;}
    public string autor {get; set;}
    public string editora {get; set;}

    public Livro(int id, string nome, string autor, string editora)
    {
        this.id = id;
        this.nome = nome;
        this.autor = autor;
        this.editora = editora;
    
    }

    public void exibirLivro()
    {
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Autor: {autor}");
        Console.WriteLine($"Editora: {editora}");
    }
}
class Program
{
    enum Opcoes {Cadastrar = 1, Consultar, Remover, Sair}
    static int id = 0;
    public static Dictionary<int, Livro> livros = new Dictionary<int, Livro>();
    static void Main(string[] args)
    {
        IniciarMenu();
        
    }

    public static void ErrorMsg()
    {
        Console.WriteLine("Erro: Opcao Invalida, Tente Novamente.");
    }

    public static void IniciarMenu()
    {
        bool escolheuSair = false;
        while (!escolheuSair)
        {
            Console.WriteLine("===== MENU PRINCIPAL =====");
            Console.WriteLine("1 - Cadastrar");
            Console.WriteLine("2 - Consultar");
            Console.WriteLine("3 - Remover");
            Console.WriteLine("4 - Sair");
            try
            {
                Opcoes opcao = (Opcoes)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Opcoes.Cadastrar:
                        Console.Clear();
                        CadastrarLivro();
                        break;
                    case Opcoes.Consultar:
                        Console.Clear();
                        ConsultarLivro();
                        break;
                    case Opcoes.Remover:
                        Console.Clear();
                        RemoverLivro();
                        break;
                    case Opcoes.Sair:
                        Console.WriteLine("Encerrando o programa...");
                        escolheuSair = true;
                        break;
                    default:
                        ErrorMsg();
                        break;

            }
        }
        catch
        {
            ErrorMsg();
        }
        }
        
    }

    public static void CadastrarLivro()
    {
        id+=1;
        Console.WriteLine("===== MENU CADASTRO =====");
        Console.WriteLine($"ID: {id}");
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Autor: ");
        string autor = Console.ReadLine();
        Console.Write("Editora: ");
        string editora = Console.ReadLine();

        Livro novoLivro = new Livro(id, nome, autor, editora);
        livros.Add(id, novoLivro);
        Console.Clear();
        Console.WriteLine("Livro Cadastrado com Sucesso.");
        
    }

    public static void ConsultarLivro()
    {
        bool escolheuSair = false;
        while (!escolheuSair)
        {
            Console.WriteLine("===== MENU CONSULTAR =====");
            if (livros.Count() == 0)
            {
                Console.WriteLine("Nenhum Livro Cadastrado.");
                break;
            }
            else
            {
                Console.WriteLine("1 - Consultar Todos");
                Console.WriteLine("2 - Consultar por ID");
                Console.WriteLine("3 - Consultar por nome");
                Console.WriteLine("4 - Menu Principal");
                Console.Write("Infome a opcao desejada: ");
                try
                {
                    int opcaoConsultar = int.Parse(Console.ReadLine());
                    switch (opcaoConsultar)
                    {
                        case 1:
                            Console.Clear();
                            foreach(var livro in livros.Values)
                            {
                                livro.exibirLivro();
                                Console.WriteLine();
                            }
                            break;
                            
                        case 2:
                            Console.Clear();
                            Console.Write("Informe o ID: ");
                            int idConsulta = int.Parse(Console.ReadLine());
                            if (livros.ContainsKey(idConsulta))
                            {
                                Livro livro = livros[idConsulta];
                                livro.exibirLivro();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Livro nao encontrado.");
                            }
                            break;
                        case 3:
                            Console.Clear();
                            Console.Write("Informe o nome do livro: ");
                            string nomeConsulta = Console.ReadLine();
                            var livroAchado = livros.Values.Where(i => i.nome.Contains(nomeConsulta, StringComparison.OrdinalIgnoreCase));
                            if (livroAchado.Any())
                            {
                                foreach (var livro in livroAchado)
                                {
                                    livro.exibirLivro();
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Nenhum livro achado com esse nome.");
                            }
                            break;
                        case 4:
                            escolheuSair = true;
                            Console.Clear();
                            Console.WriteLine("Retornando ao Menu Principal");
                            break;
                        default:
                            ErrorMsg();
                            break;
                    }
                }
                catch
                {
                    ErrorMsg();
                }
            
            }
        }
        
    }

    public static void RemoverLivro()
    {
        Console.WriteLine("===== MENU REMOVER =====");
        if (livros.Count() == 0)
        {
            Console.WriteLine("Nao ha livros cadastrados.");
        }
        else
        {
            try
            {
                Console.Write("Informe o ID a ser removido: ");
                int idRemover = int.Parse(Console.ReadLine());
                if (livros.ContainsKey(idRemover))
                {   
                    livros.Remove(idRemover);
                    Console.Clear();
                    Console.WriteLine("Livro Removido com Sucesso.");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Livro nao encontrado.");
                }

            }
            catch 
            {
                ErrorMsg();
            }
        }
        
    }
    
}


