namespace TheProject.API.Model.Entities
{
    public class Cidade : NamedEntity
    {
        public int UFId { get; set; }
        public UF UF { get; set; }
        public override void Merge(object other)
        {
            Nome = ((Cidade)other).Nome;
        }
        public override bool Validate()
        {
            return true;
        }
    }
}