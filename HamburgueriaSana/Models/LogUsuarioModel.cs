namespace HamburgueriaSana.Models
{
    public class LogUsuarioModel
    {
        public int  LogId { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataRegistro { get; set; } = DateTime.Now;
        public string Mensagem { get; set; }

    }
}
