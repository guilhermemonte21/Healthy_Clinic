using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.HealthyClinic.Tarde.Domain
{
    [Table(nameof(Clinica))]
    public class Clinica
    {
        [Key]
        public Guid IdClinica { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(14)")]
        [Required(ErrorMessage = "CNPJ da clínica é obrigatório!")]
        [StringLength(14, ErrorMessage = "CNPJ esta incorreto")]
        public string? CNPJ { get; set; }
        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Nome fantasia da clínica é obrigatório!")]
        public string? NomeFantasia { get; set; }

        [Column(TypeName = "VARCHAR(25)")]
        [Required(ErrorMessage = "Horário de funcionamento é obrigatório!")]
        public string? HorarioFuncionamento { get; set; }
        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Endereço da clínica é obrigatório!")]
        public string? Endereco { get; set; }
    }
}
