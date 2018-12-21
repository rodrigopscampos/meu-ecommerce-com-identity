using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MeuEcommerce.Models
{
    [Table("Produtos")]
    public class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string Imagem { get; set; }
        public string Descricao { get; set; }
        public int Id { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }

        public Produto() { }

        Random _random = new Random();

        public Produto(string nome, int categoriaId )
        {
            Nome = nome;
            CategoriaId = categoriaId;
            Preco = _random.Next(10, 100) + (decimal)_random.NextDouble();
            Descricao = "Descrição - " + Nome;
            Imagem = "img/" + nome + ".jpg";
        }
    }
}