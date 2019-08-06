namespace TheProject.API.Model.Entities
{
    public class Projeto : NamedEntity
    {
        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }

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