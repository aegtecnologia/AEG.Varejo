using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEG.Varejo.Domain.Entities
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public decimal Valor { get; set; }
        public decimal Desconto { get; set; }
        public List<PedidoItem> Itens { get; set; }
        public Pedido()
        {
            Itens = new List<PedidoItem>();
        }
    }
}
