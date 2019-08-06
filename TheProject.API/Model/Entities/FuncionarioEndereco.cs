namespace TheProject.API.Model.Entities
{
    public class FuncionarioEndereco : BaseEntity
    {
        public int FuncionarioId { get; set; }
        public Funcionario Funcionario { get; set; }
        public int TipoLogradouroId { get; set; }
        public TipoLogradouro TipoLogradouro { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public int CEP { get; set; }
        public int CidadeId { get; set; }
        public Cidade Cidade { get; set; }
        public int UFId { get; set; }
        public UF UF { get; set; }

        public override void Merge(object other)
        {
            return;
        }
        public override bool Validate()
        {
            return true;
        }
    }
}