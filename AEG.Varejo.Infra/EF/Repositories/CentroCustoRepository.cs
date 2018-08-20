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
    public class CentroCustoRepository : ICentroCustoRepository
    {
        DBContexto db;

        public CentroCustoRepository()
        {
            db = new DBContexto();
        }
        public CentroCusto BuscarPorId(int id)
        {
            return db.CentroCusto.Where(c => c.CentroCustoId == id).SingleOrDefault();
        }

        public IEnumerable<CentroCusto> BuscarTodos()
        {
            return db.CentroCusto.AsNoTracking();
        }

        public void Deletar(CentroCusto ccusto)
        {
            db.CentroCusto.Remove(ccusto);
        }

        public void Salvar(CentroCusto ccusto)
        {
            if (ccusto.CentroCustoId == 0)
                db.CentroCusto.Add(ccusto);
            else
            {
                var cc = db.CentroCusto.Where(c => c.CentroCustoId == ccusto.CentroCustoId).SingleOrDefault();
                cc.Descricao = ccusto.Descricao;                
            }

            db.SaveChanges();
        }
    }
}
