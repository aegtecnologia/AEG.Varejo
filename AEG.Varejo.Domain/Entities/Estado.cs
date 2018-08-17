using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEG.Varejo.Domain.Entities
{
    public class Estado
    {
        public int EstadoId { get; set; }
        public string Nome { get; set; }
        public virtual IEnumerable<Cidade> Cidades { get; set; }
    }
}
