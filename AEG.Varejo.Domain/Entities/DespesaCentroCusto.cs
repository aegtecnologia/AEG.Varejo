using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEG.Varejo.Domain.Entities
{
    public class DespesaCentroCusto
    {
        public int DespesaCentroCustoId { get; set; }
        public int DespesaId { get; set; }
        public int CentroCustoId { get; set; }
        public decimal Valor { get; set; }
        public virtual Despesa Despesa { get; set; }
        public virtual CentroCusto CentroCusto { get; set; }
    }
}
