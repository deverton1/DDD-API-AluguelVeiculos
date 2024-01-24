namespace Domain.Commands
{
    public class ClienteCommand
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Habilitacao { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Estado { get; set; }
    }
}
