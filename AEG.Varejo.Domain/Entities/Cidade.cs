using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEG.Varejo.Domain.Entities
{
    public class Cidade
    {
        public int CidadeId { get; set; }
        public string Nome { get; set; }
        public string CodigoIBGE { get; set; }
        public int EstadoId { get; set; }
        public virtual Estado Estado { get; set; }
    }
}
