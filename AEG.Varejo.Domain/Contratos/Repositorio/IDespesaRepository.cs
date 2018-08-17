using AEG.Varejo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEG.Varejo.Domain.Contratos.Repositorio
{
    public interface IDespesaRepository
    {
        IEnumerable<Despesa> BuscarTodos();
        Despesa BuscarPorId(int id);
        void Salvar(Despesa despesa);
        void Deletar(Despesa despesa);
    }
}
