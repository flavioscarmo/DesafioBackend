namespace DesafioBackend.DTO
{
    public class ClienteDTO
    {
        public int Id { get; set; }
        public bool Ativo { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Cnpj { get; set; } = string.Empty;
        public string Planta { get; set; } = string.Empty;
        public string PessoaResponsavel { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int Ddd { get; set; }
        public int Telefone { get; set; }
        public int TipoDeCliente { get; set; }
    }
}
