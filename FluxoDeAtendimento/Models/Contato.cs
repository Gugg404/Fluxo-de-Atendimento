using System.ComponentModel.DataAnnotations;

namespace FluxoDeAtendimento.Models
{
    public class Contato
    {
        [Required(ErrorMessage = "Nome obrigatório")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "Usuário obrigatório")]
        public string Usuario { get; set; } = string.Empty;

        public string Administrador { get; set; } = string.Empty;

        [Required(ErrorMessage = "Situação obrigatória")]
        public string Situacao { get; set; } = string.Empty;

        public string Conclusao { get; set; } = string.Empty;

        // opcional: id para evolução futura
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}