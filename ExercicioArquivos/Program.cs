using System;
using System.Collections.Generic;
using ExercicioArquivos.Produtos;

namespace ExercicioArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int i = 0;
            Produto produto = new Produto();
            List<Produto> ListProduto = new List<Produto>();

            do
            {
                string msg = "Digite 0 para sair \n Digite 1 para salvar \ndigite 2 para realizar o backup da lista \nou qual quer outro  numero para adicionar mais produtos";
                switch (i)
                {
                    case 1:

                        produto.CreateArquivo(ListProduto);
                        Console.WriteLine(msg);
                        break;
                    case 2:

                        produto.GerarCopy();
                        Console.WriteLine(msg);
                        break;
                    default:
                        Console.WriteLine("Adicione os items a sua lista de produtos:");

                        Console.WriteLine("Informe o nome do produto: ");
                        string nome = Console.ReadLine();

                        Console.WriteLine("Informe o preço do produto:");
                        double preco = double.Parse(Console.ReadLine());

                        Console.WriteLine("Informe a quantidade do produto:");
                        int qtd = int.Parse(Console.ReadLine());

                        ListProduto.Add(new Produto(nome, preco, qtd));



                        Console.WriteLine(msg);

                        break;
                }
                
                i = int.Parse(Console.ReadLine());
            } while (i != 0);

            
            
        }
    }
}
