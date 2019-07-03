using System;

namespace ViajaNet.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public decimal PrecoPromocao { get; set; }

    }
}