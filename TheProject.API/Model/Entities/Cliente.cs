namespace TheProject.API.Model.Entities
{
    public class Cliente : BaseEntity
    {
        public long CNPJ { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string NomeAmigavel { get; set; }
        public int SegmentoClienteId { get; set; }
        public SegmentoCliente SegmentoCliente { get; set; }
        public override void Merge(object other)
        {
            RazaoSocial = ((Cliente)other).RazaoSocial;
            NomeFantasia = ((Cliente)other).NomeFantasia;
            NomeAmigavel = ((Cliente)other).NomeAmigavel;
        }
        public override bool Validate()
        {
            return true;
        }
    }
}