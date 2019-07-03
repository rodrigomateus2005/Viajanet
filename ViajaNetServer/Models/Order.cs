using System;
using System.Linq;

namespace ViajaNet.Models
{
    public class Order
    {
        public Produto[] Produtos { get; set; }

        public decimal Total
        {
            get {
                return this.Produtos.Sum(x => {
                    if (x.PrecoPromocao > 0) {
                        return x.PrecoPromocao;
                    } else {
                        return x.Preco;
                    }
                });
            }   
        }

    }
}