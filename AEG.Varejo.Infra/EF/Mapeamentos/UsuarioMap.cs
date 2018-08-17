using AEG.Varejo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEG.Varejo.Infra.EF.Mapeamentos
{
    public class UsuarioMap:EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            HasKey(u=> u.UsuarioId);

            Property(u => u.Email)
                .HasMaxLength(150);

            Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(50);

            Property(u => u.Senha)
                .IsRequired()
                .HasMaxLength(10);
        }
    }
}
