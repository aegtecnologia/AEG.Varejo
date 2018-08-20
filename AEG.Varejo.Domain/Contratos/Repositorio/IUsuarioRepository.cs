using AEG.Varejo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEG.Varejo.Domain.Contratos.Repositorio
{
    public interface IUsuarioRepository
    {
        IEnumerable<Usuario> BuscarTodos();
        Usuario BuscarPorId(int id);
        Usuario BuscarPorNome(string nome);
        void Salvar(Usuario usuario);
        void Deletar(Usuario usuario);
    }
}
