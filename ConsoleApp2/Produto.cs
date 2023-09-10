using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Produto
    {

        public Produto(String produto)
        {
            string[] campos = produto.Split(';');
            Nome = campos[0];
            Preco = double.Parse(campos[1], CultureInfo.InvariantCulture);
        }

        public string Nome { get; set; }
        public double Preco { get; set; }


        public override string ToString()
        {
            return "Produto{ nome: " + Nome + "; preco: R$" + Preco.ToString("0.00") + " }";
        }
    }
}
