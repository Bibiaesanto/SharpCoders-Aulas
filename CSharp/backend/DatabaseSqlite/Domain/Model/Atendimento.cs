using System.ComponentModel.DataAnnotations;

namespace DatabaseSqlite.Domain.Model;

    public class Atendimento
    {
        [key]
        [Required]

        public int Id { get; set; }
        
    [Required]

        public string Nome { get; set; } = null!;

        public string? Relato { get; set; } = string.Empty;

        public bool EstaResolvido { get; set; }

        public bool DesejaRetorno { get; set; }

        public bool EstaAtivo { get; set; } = true;

        public DateTime? CriadoEm { get; set; } = DateTime.Now;

        public DateTime? AtualizadoEm { get; set; } = DateTime.Now;

        public DateTime? DeletadoEm { get; set; } = null;
    }
