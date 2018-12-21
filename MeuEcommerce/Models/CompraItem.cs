using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MeuEcommerce.Models
{
    public class CompraItem
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }

        public int ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }

        [NotMapped]
        public decimal PrecoTotal 
            => PrecoUnitario * Quantidade;

        public CompraItem() { }

        public CompraItem(int quantidade, decimal precoUnitario, int produtoId)
        {
            this.Quantidade = quantidade;
            this.PrecoUnitario = precoUnitario;
            this.ProdutoId = produtoId;
        }
    }
}