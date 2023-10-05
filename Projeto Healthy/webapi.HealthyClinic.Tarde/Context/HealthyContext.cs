using Microsoft.EntityFrameworkCore;
using webapi.HealthyClinic.Tarde.Domain;

namespace webapi.HealthyClinic.Tarde.Context
{
    public class HealthyContext: DbContext
    {
        public DbSet<TipoUsuario> TipoUsuario { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Clinica> Clinica { get; set; }
        public DbSet<Especialidade> Especialidade{ get; set; }
        public DbSet<Comentario> Comentario { get; set; }
        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<Medico> Medico { get; set; }
        public DbSet<Consulta> Consulta { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuider)
        {
            optionsBuider.UseSqlServer("Server=NOTE05-S15; Database=HealthyClinic.tarde; User Id = sa; Pwd = Senai@134; TrustServerCertificate = true;");
            base.OnConfiguring(optionsBuider);
        }

    }
}
