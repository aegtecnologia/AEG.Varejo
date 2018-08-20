using AEG.Varejo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEG.Varejo.Domain.Contratos.Servicos
{
    public interface ICentroCustoService
    {
        void Salvar(CentroCusto ccusto);
        CentroCusto BuscarPorId(int id);
        IEnumerable<CentroCusto> BuscarTodos();

    }
}
