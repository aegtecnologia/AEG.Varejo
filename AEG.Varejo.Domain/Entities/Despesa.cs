using AEG.Varejo.Domain.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEG.Varejo.Domain.Entities
{
    public class Despesa
    {
        public virtual eSituacaoDespesa Situacao { get; set; }   
        public int DespesaId { get; set; }
        public int UsuarioId { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime? DataPagamento { get; set; }
        public decimal ValorBruto { get; set; }
        public decimal ValorDesconto { get; set; }
        public decimal ValorAcrescimo { get; set; }
        public decimal ValorLiquido { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual IEnumerable<DespesaCentroCusto> CentroCustoLista{get;set;}
    }
}
