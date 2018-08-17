using AEG.Varejo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEG.Varejo.Infra.EF.Mapeamentos
{
    public class CentroCustoMap:EntityTypeConfiguration<CentroCusto>
    {
        public CentroCustoMap()
        {
            HasKey(e => e.CentroCustoId);

            Property(e => e.Descricao)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
