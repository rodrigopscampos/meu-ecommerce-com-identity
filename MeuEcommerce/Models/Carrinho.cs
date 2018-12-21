using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeuEcommerce.Models
{
    public class Carrinho
    {
        public Dictionary<int, CarrinhoItem> Itens;

        public Carrinho()
        {
            Itens = new Dictionary<int, CarrinhoItem>();
        }

        public void Add(Produto produto)
        {
            if (Itens.ContainsKey(produto.Id))
            {
                Itens[produto.Id].Quantidade++;
            }
            else
            {
                var carrinhoItem = new CarrinhoItem(
                    produto.Id,
                    produto.Nome,
                    produto.Preco);

                Itens.Add(produto.Id, carrinhoItem);
            }
        }

        public void Decrementa(int id)
        {
            Itens[id].Quantidade--;

            if (Itens[id].Quantidade <= 0)
            {
                Delete(id);
            }
        }

        public void Incrementa(int id)
        {
            Itens[id].Quantidade++;
        }

        public void Delete(int id)
        {
            Itens.Remove(id);
        }

        public int QuantidadeDeItens => Itens.Values.Sum(item => item.Quantidade);

        public void Limpar()
        {
            Itens.Clear();
        }

        public decimal GetPrecoTotal()
        {
            decimal resultado = 0;
            foreach (var item in Itens.Values)
            {
                resultado += item.PrecoTotal;
            }

            return resultado;
        }
    }
}