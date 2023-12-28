using HamburgueriaSana.Enum;
using System.ComponentModel.DataAnnotations;

namespace HamburgueriaSana.Models
{
    public class UsuarioModel
    {
        [Key]
        public int UsuarioId { get; set; }
        [Required(ErrorMessage ="Esse campo Usuario é obrigatório")]
        public string Usuario { get; set; }
        [Required(ErrorMessage = "Esse campo Usuario é obrigatório")]
        public string Senha { get; set; }
        public PerfilAcesso Perfil { get; set; }
        public DateTime DataCriacao { get; set; }
        public List<LogUsuarioModel> Logs { get; set; }
    }
}
