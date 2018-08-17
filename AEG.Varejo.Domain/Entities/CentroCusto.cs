using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEG.Varejo.Domain.Entities
{
    public class CentroCusto
    {
        public int CentroCustoId { get; set; }
        public string Descricao { get; set; }
        public virtual IEnumerable<DespesaCentroCusto> Despesas { get; set; }
    }
}
