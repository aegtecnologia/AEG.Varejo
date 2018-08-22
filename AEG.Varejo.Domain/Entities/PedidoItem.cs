using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEG.Varejo.Domain.Entities
{
    public class PedidoItem
    {
        public int PedidoId { get; set; }
        public string Descricao { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public int GrupoId { get; set; }
        public virtual Pedido Pedido { get; set; }
    }
}
