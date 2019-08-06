namespace TheProject.API.Model.Entities
{
    public class TipoDocumento : NamedEntity
    {
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