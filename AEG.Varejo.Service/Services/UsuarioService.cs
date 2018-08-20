using AEG.Varejo.Domain.Contratos.Servicos;
using AEG.Varejo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AEG.Varejo.Domain.Contratos.Repositorio;
using AEG.Varejo.Infra.EF.Repositories;

namespace AEG.Varejo.Service.Services
{
    public class UsuarioService : IUsuarioService
    {
        IUsuarioRepository rep;

        public UsuarioService()
        {
            rep = new UsuarioRepository();
        }

        public void AlterarSenha(string loginNome, string senhaAtual, string senhaAntiga)
        {
            var usuario = BuscarPorLoginSenha(loginNome, senhaAtual);
            if (usuario == null)
                throw new Exception("Login ou senha invalida!");

            usuario.Senha = senhaAntiga;
            rep.Salvar(usuario);
        }

        public Usuario BuscarPorId(int id)
        {
            return rep.BuscarPorId(id);
        }

        public Usuario BuscarPorLoginSenha(string loginName, string senha)
        {
            Usuario usuario = rep.BuscarPorNome(loginName);
            if (usuario == null)
                throw new Exception("Usuario não encontrado");

            if (usuario.Senha == senha)
            {
                return usuario;
            }
            else
                throw new Exception("Senha invalida");
        }

        public IEnumerable<Usuario> ListarTodos()
        {
            return rep.BuscarTodos();
        }

        public void NovoCadastro(Usuario usuario)
        {
            rep.Salvar(usuario);
        }
    }
}
