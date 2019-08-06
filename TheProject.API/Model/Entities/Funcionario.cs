namespace TheProject.API.Model.Entities
{
    public class Funcionario : NamedEntity
    {
        public string DocumentoPrincipal { get; set; }
        public int TipoDocumentoId { get; set; }
        public TipoDocumento TipoDocumento { get; set; }

        public override void Merge(object other)
        {
            Nome = ((Funcionario)other).Nome;
            DocumentoPrincipal = ((Funcionario)other).DocumentoPrincipal;
            TipoDocumentoId = ((Funcionario)other).TipoDocumentoId;
        }
        public override bool Validate()
        {
            return true;
        }
    }
}