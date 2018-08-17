namespace AEG.Varejo.Infra.EF.Contexto
{
    using AEG.Varejo.Domain.Entities;
    using AEG.Varejo.Infra.EF.Mapeamentos;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class DBContexto : DbContext
    {
        public DBContexto() : base("name=DBContexto")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Despesa> Despesa { get; set; }
        public DbSet<CentroCusto> CentroCusto { get; set; }
        public DbSet<DespesaCentroCusto> DespesaCentroCusto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                   .Where(p => p.Name == p.ReflectedType.Name + "Id")
                   .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                   .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                  .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new UsuarioMap());
            modelBuilder.Configurations.Add(new DespesaMap());
            modelBuilder.Configurations.Add(new CentroCustoMap());           
            modelBuilder.Configurations.Add(new DespesaCCustoMap());
        }

    }
}