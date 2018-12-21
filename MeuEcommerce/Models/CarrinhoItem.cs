using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeuEcommerce.Models
{
    public class CarrinhoItem
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public decimal PrecoUnitario { get; set; }
        public int Quantidade { get; set; }

        public CarrinhoItem(
            int idProduto,
            string nome,
            decimal precoUnitario)
        {
            this.IdProduto = idProduto;
            this.Nome = nome;
            this.Quantidade = 1;
            this.PrecoUnitario = precoUnitario;
        }

        public decimal PrecoTotal
            => PrecoUnitario * Quantidade;
    }
}