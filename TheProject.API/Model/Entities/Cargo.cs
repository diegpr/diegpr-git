namespace TheProject.API.Model.Entities
{
    public class Cargo : NamedEntity
    {
        public override void Merge(object other)
        {
            Nome = ((Cargo)other).Nome;
        }

        public override bool Validate()
        {
            return !string.IsNullOrEmpty(Nome);
        }
    }
}