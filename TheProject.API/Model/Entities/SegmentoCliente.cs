namespace TheProject.API.Model.Entities
{
    public class SegmentoCliente : NamedEntity
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