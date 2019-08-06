using System;

namespace TheProject.API.Model.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataUltimaAlteracao { get; set; }
        public bool Ativo { get; set; }

        public abstract void Merge(object other);
        public abstract bool Validate();
    }
}