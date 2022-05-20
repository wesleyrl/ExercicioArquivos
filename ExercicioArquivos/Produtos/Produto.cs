using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ExercicioArquivos.Produtos
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public int Quantidade { get; set; }

        public Produto()
        {

        }
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public void CreateArquivo(List<Produto> prod)
        {
            

            try
            {
                var arquivo = @"c:\temp\Produtos\produtos.txt";

                StreamWriter sw = new StreamWriter(arquivo);

                sw.WriteLine("############ PRODUTOS #################");
                foreach (var prods in prod)
                {
                    sw.WriteLine("Nome: "+ prods.Nome);
                    sw.WriteLine("Preço: " + prods.Preco);
                    sw.WriteLine("Quantidade: " + prods.Quantidade);
                    sw.WriteLine("----------------------------");
                }
               
               
                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        public void GerarCopy()
        {
            string arquivoOrigem = @"c:\temp\Produtos\produtos.txt"; 
            string arquivoDestino = @"c:\temp\Produtos\ProdutosBackup\produtos.txt";

            try
            {
                string[] linhas = File.ReadAllLines(arquivoOrigem);
                using (StreamWriter sw = File.AppendText(arquivoDestino))
                {
                    foreach (string line in linhas)
                    {
                        sw.WriteLine(line);
                    }
                }

                Console.WriteLine("Copia gerada com sucesso!");
            }
            catch (Exception e)
            {

                Console.WriteLine("Um erro ocorreu! " + e.Message);
            }

        }

        public override string ToString()
        {
            return $"Nome {Nome} \n" +
                   $"Preço: {Preco} \n" +
                   $"Quantidade: {Quantidade}";
        }




    }
}
