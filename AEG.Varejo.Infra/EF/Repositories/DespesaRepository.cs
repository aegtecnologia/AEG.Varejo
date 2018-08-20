using AEG.Varejo.Domain.Contratos.Repositorio;
using AEG.Varejo.Domain.Entities;
using AEG.Varejo.Infra.EF.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEG.Varejo.Infra.EF.Repositories
{
    public class DespesaRepository : IDespesaRepository
    {
        DBContexto db;

        public DespesaRepository()
        {
            db = new DBContexto();
        }
        public Despesa BuscarPorId(int id)
        {
            return db.Despesa.AsNoTracking().Where(c => c.DespesaId == id).SingleOrDefault();
        }

        public IEnumerable<Despesa> BuscarTodos()
        {
            return db.Despesa.AsNoTracking();
        }

        public void Deletar(Despesa despesa)
        {
            db.Despesa.Remove(despesa);
        }

        public void Salvar(Despesa despesa)
        {
            Despesa despesaAtual;

            if (despesa.DespesaId == 0)
                db.Despesa.Add(despesa);
            else
            {
                despesaAtual = db.Despesa.Where(c => c.DespesaId == despesa.DespesaId).SingleOrDefault();
                despesaAtual.CentroCustoLista = despesa.CentroCustoLista;
                despesaAtual.DataAtualizacao = despesa.DataAtualizacao;
                despesaAtual.DataCriacao = despesa.DataCriacao;
                despesaAtual.DataPagamento = despesa.DataPagamento;
                despesaAtual.DataVencimento = despesa.DataVencimento;
                despesaAtual.Descricao = despesa.Descricao;
                despesaAtual.UsuarioId = despesa.UsuarioId;
                despesaAtual.ValorAcrescimo = despesa.ValorAcrescimo;
                despesaAtual.ValorBruto = despesa.ValorBruto;
                despesaAtual.ValorDesconto = despesa.ValorDesconto;
                //despesaAtual.ValorLiquido = despesa.ValorLiquido;
            }

            db.SaveChanges();
        }
    }
}
