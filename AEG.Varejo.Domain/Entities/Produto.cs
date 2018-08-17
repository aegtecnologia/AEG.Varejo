using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEG.Varejo.Domain.Entities
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string DescricaoCompleta { get; set; }
        public string DescricaoReduzida { get; set; }
        public string NCM { get; set; }
        public string GrupoId { get; set; }
        public string Grupo { get; set; }
        public string QuantidadeAtual { get; set; }
        public string QuantidadeMinima { get; set; }
        public string Valor { get; set; }
        public string ValorPromocional { get; set; }
        public string ValorMedio { get; set; }
        public string Custo { get; set; }
        public string CustoMedio { get; set; }
        public string DataValidade { get; set; }


    }
}
