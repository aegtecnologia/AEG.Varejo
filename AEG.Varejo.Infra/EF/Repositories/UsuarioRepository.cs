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
    public class UsuarioRepository : IUsuarioRepository
    {
        DBContexto db;

        public UsuarioRepository()
        {
            db = new DBContexto();
        }

        public Usuario BuscarPorId(int id)
        {
            return db.Usuario.Where(c => c.UsuarioId == id).SingleOrDefault();
        }

        public Usuario BuscarPorNome(string nome)
        {
            return db.Usuario.Where(c => c.Nome == nome).SingleOrDefault();
        }

        public IEnumerable<Usuario> BuscarTodos()
        {
            return db.Usuario.AsNoTracking();
        }

        public void Deletar(Usuario usuario)
        {
            db.Usuario.Remove(usuario);
            db.SaveChanges();
        }

        public void Salvar(Usuario usuario)
        {
            if (usuario.UsuarioId == 0)
                db.Usuario.Add(usuario);
            else
            {
                var atual = db.Usuario.Where(c => c.UsuarioId == usuario.UsuarioId).SingleOrDefault();
                atual.Email = usuario.Email;
                atual.Nome = usuario.Nome;
                atual.Senha = usuario.Senha;                
            }

            db.SaveChanges();

        }
    }
}
