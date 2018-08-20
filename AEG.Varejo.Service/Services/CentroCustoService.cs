using AEG.Varejo.Domain.Contratos.Repositorio;
using AEG.Varejo.Domain.Contratos.Servicos;
using AEG.Varejo.Domain.Entities;
using AEG.Varejo.Infra.EF.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEG.Varejo.Service.Services
{

    public class CentroCustoService : ICentroCustoService
    {
        ICentroCustoRepository rep;
        
        public CentroCustoService()
        {
            rep = new CentroCustoRepository();
        }
        public CentroCusto BuscarPorId(int id)
        {
            return rep.BuscarPorId(id);
        }

        public IEnumerable<CentroCusto> BuscarTodos()
        {
            return rep.BuscarTodos();
        }

        public void Salvar(CentroCusto ccusto)
        {
            rep.Salvar(ccusto);
        }
    }
}
