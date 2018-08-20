using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AEG.Varejo.Domain.Entities;

namespace AEG.Varejo.Domain.Contratos.Servicos
{
    public interface IUsuarioService
    {
        Usuario BuscarPorLoginSenha(string loginName, string senha);
        Usuario BuscarPorId(int id);
        void AlterarSenha(string loginName, string senhaAtual, string senhaAntiga);
        void NovoCadastro(Usuario usuario);
        IEnumerable<Usuario> ListarTodos();
    }
}
