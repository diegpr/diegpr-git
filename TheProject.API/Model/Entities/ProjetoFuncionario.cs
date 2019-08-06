namespace TheProject.API.Model.Entities
{
    public class ProjetoFuncionario : BaseEntity
    {
        public int ProjetoId { get; set; }
        public Projeto Projeto { get; set; }
        public int FuncionarioId { get; set; }
        public Funcionario Funcionario { get; set; }

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