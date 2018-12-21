using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MeuEcommerce.Models
{
    public class Compra
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public CompraStatus Status { get; set; }

        public virtual List<CompraItem> Itens { get; set; }

        public string UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }


        [NotMapped]
        public decimal PrecoTotal
            => Itens.Sum(i => i.PrecoTotal);

        public Compra() { }

        public Compra(string usuarioId, List<CompraItem> itens)
        {
            Data = DateTime.Now;
            Status = CompraStatus.AgPagamento;
            Itens = itens;
            UsuarioId = usuarioId;
        }
    }

    public enum CompraStatus
    {
        AgPagamento = 1,
        SeparandoPedido = 2,
        EntregueTransportadora = 3,
        Finalizado = 4
    }
}