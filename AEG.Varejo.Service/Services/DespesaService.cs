using AEG.Varejo.Domain.Contratos.Repositorio;
using AEG.Varejo.Domain.Contratos.Servicos;
using AEG.Varejo.Domain.Entities;
using AEG.Varejo.Domain.Enumeradores;
using AEG.Varejo.Infra.EF.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEG.Varejo.Service.Services
{
    public class DespesaService : IDespesaService
    {
        IDespesaRepository rep;

        public DespesaService()
        {
            rep = new DespesaRepository();
        }

        public IEnumerable<Despesa> BuscarPor(DateTime dataIncio, DateTime dataFim, eSituacaoDespesa situacao)
        {
           return rep.BuscarTodos().Where(c => c.DataVencimento >= dataIncio && c.DataVencimento <= dataFim && c.Situacao == situacao);
        }

        public Despesa BuscarPorId(int id)
        {
            return rep.BuscarPorId(id);
        }

        public void Excluir(Despesa despesa)
        {
            rep.Deletar(despesa);
        }

        public void Pagar(int despesaId, DateTime dataPagto)
        {
            var despesa = rep.BuscarPorId(despesaId);

            despesa.DataPagamento = dataPagto;
            despesa.DataAtualizacao = DateTime.Now;
            despesa.Situacao = eSituacaoDespesa.PAGO;

            rep.Salvar(despesa);
        }

        public void Salvar(Despesa despesa)
        {
            rep.Salvar(despesa);
        }
    }
}
