using System;

namespace TheProject.API.Model.Entities
{
    public class FuncionarioCargo : BaseEntity
    {
        public int FuncionarioId { get; set; }
        public Funcionario Funcionario { get; set; }
        public int CargoId { get; set; }
        public Cargo Cargo { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; }

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