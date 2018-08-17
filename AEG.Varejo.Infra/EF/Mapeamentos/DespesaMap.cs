using AEG.Varejo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEG.Varejo.Infra.EF.Mapeamentos
{
    public class DespesaMap:EntityTypeConfiguration<Despesa>
    {
        public DespesaMap()
        {
            HasKey(d => d.DespesaId);

            Property(d => d.DataAtualizacao)
                .IsOptional();

            Property(d => d.DataCriacao)
                .IsRequired();

            Property(d => d.DataPagamento)
                .IsOptional();

            Property(d => d.DataVencimento)
                .IsRequired();

            Property(d => d.Descricao)
                .IsRequired()
                .HasMaxLength(150);

            HasRequired(d => d.Usuario)
                .WithMany()
                .HasForeignKey(d => d.UsuarioId);
        }
    }
}
