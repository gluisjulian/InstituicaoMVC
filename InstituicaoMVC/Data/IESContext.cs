using InstituicaoMVC.Models;
using Microsoft.EntityFrameworkCore;
using Modelo.Cadastros;

namespace InstituicaoMVC.Data
{
    public class IESContext : DbContext
    {

        public IESContext(DbContextOptions<IESContext> options) : base(options)
        {
        }

        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Instituicao> Instituicoes { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Departamento>().ToTable("Departamento");
        }


        //Caso queira usar dessa forma pode configurar o acesso ao banco na classe de contexto
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=IESCasaDoCodigo;Trusted_Connection=True;MultipleActiveResultSets=true");
        //}
    }
}
