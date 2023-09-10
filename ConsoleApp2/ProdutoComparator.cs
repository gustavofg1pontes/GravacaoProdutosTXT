using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ProdutoComparator : IComparer<Produto>
    {
        public int Compare(Produto x, Produto y)
        {
            if(x.Preco > y.Preco) return 1;
            else if(x.Preco < y.Preco) return -1;
            else return 0;
        }
    }
}
