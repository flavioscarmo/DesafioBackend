namespace DesafioBackend.Model
{
    public class ClienteModel
    {
        public int Id { get; set; }
        public bool ativo { get; set; }
        public string nome { get; set; }
        public string cnpj { get; set; }
        public string planta { get; set; }
        public string pessoaResponsavel { get; set; }
        public string email { get; set; }
        public int ddd { get; set; }
        public int telefone { get; set; }
        public int tipoDeCliente { get; set;}
    }
}
