using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string arqOrigem = "C:\\TEMP\\Produtos.txt";
            string arqDestino = "C:\\TEMP\\ProdutosOrdenados.txt";
            List<Produto> produtos = new List<Produto>();

            try {
                using (FileStream fs = new FileStream(arqOrigem, FileMode.Open, FileAccess.Read)) {
                    using (StreamReader sr = new StreamReader(fs)) {
                        while(!sr.EndOfStream)
                        {
                            Produto p = new Produto(sr.ReadLine());
                            produtos.Add(p);
                            Console.WriteLine("Produto criado: " + p);
                        }
                    }
                }

                produtos.Sort(new ProdutoComparator());
                Console.WriteLine("\nLista Ordenada: ");
                foreach (Produto p in produtos) Console.WriteLine(p);

                using(FileStream fs = new FileStream(arqDestino, FileMode.CreateNew, FileAccess.ReadWrite)) {
                    using (StreamWriter sr = new StreamWriter(fs)) { 
                        foreach(Produto produto in produtos) sr.WriteLine(produto);
                    }
                }
                Console.WriteLine("\nArquivo criado!");
            }catch(Exception ex)
            {

            }
            Console.ReadKey();
        }
    }
}
