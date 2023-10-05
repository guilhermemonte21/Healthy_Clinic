using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.HealthyClinic.Tarde.Domain
{
    [Table(nameof(Paciente))]
    public class Paciente
    {
        [Key]
        public Guid IdPaciente { get; set; } = Guid.NewGuid();
        
        [Required(ErrorMessage = "Informe o usuário do paciente!")]
        public Guid IdUsuario { get; set; }
        [ForeignKey(nameof(IdUsuario))]
        public Usuario? Usuario { get; set; }

        [Column(TypeName = "VARCHAR(6)")]
        [Required(ErrorMessage = "Data de nascimento do paciente é obrigatória!")]
        public string? DataNascimento { get; set; }

        
    }
}
