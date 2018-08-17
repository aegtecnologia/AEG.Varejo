using AEG.Varejo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEG.Varejo.Domain.Contratos.Repositorio
{
    public interface ICentroCustoRepository
    {
        IEnumerable<CentroCusto> BuscarTodos();
        CentroCusto BuscarPorId(int id);
        void Salvar(CentroCusto ccusto);
        void Deletar(CentroCusto ccusto);
    }
}
