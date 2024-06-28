namespace DotnetRabbitMQ.Relatorios
{
    public static class Lista
    {
        public static List<SolicitacaoRelatorio> Relatorios = new();
    }
    public class SolicitacaoRelatorio()
    {
        public Guid IdSolicitacao { get; set; }
        public string Nome { get; set; }
        public string Status { get; set; }
        public DateTime? DataProcessamento { get; set; }
    }
}