using AEG.Varejo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEG.Varejo.Infra.EF.Mapeamentos
{
    public class DespesaCCustoMap:EntityTypeConfiguration<DespesaCentroCusto>
    {
        public DespesaCCustoMap()
        {
            HasKey(c => c.DespesaCentroCustoId);

            HasRequired(c => c.Despesa)
                .WithMany()
                .HasForeignKey(c => c.DespesaId);

            HasRequired(c => c.CentroCusto)
                .WithMany()
                .HasForeignKey(c => c.CentroCustoId);
        }
    }
}
