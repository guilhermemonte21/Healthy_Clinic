using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace webapi.HealthyClinic.Tarde.Domain
{
    [Table(nameof(Medico))]
    public class Medico
    {
        [Key]
        public Guid IdMedico { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(6)")]
        [Required(ErrorMessage = "CRM  é obrigatório")]
        [StringLength(6, ErrorMessage = "CRM informado esta incorreto")]
        public int CRM { get; set; }
        [ForeignKey(nameof(IdClinica))]
        public Clinica? Clinica { get; set; }
        [Required(ErrorMessage = "Clinica  obrigatoria")]
        public Guid IdClinica { get; set; }


        [ForeignKey(nameof(Especialidade))]
        [Required(ErrorMessage = "especialidade obrigatoria")]
        public Guid IdEspecialidade { get; set; }
       
        public Guid IdUsuario { get; set; }
        [ForeignKey(nameof(IdUsuario))]
        public Usuario? Usuario { get; set; }
    }
}
