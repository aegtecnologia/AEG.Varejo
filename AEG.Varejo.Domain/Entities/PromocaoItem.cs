using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEG.Varejo.Domain.Entities
{
    public class PromocaoItem
    {
        public int PromocaoId { get; set; }
        public Promocao.eCriterio Criterio { get; set; }
        public decimal Valor { get; set; }     
    }
}
