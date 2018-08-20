using AEG.Varejo.Domain.Entities;
using AEG.Varejo.Domain.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEG.Varejo.Domain.Contratos.Servicos
{
    public interface IDespesaService
    {
        void Salvar(Despesa despesa);
        void Excluir(Despesa despesa);
        void Pagar(int despesaId, DateTime dataPagto);
        IEnumerable<Despesa> BuscarPor(DateTime dataIncio, DateTime dataFim, eSituacaoDespesa situacao);
        Despesa BuscarPorId(int id);
    }
}
