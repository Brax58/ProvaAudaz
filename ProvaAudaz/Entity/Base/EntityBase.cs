using System;

namespace ProvaAudaz.Entity.Base
{
    public class EntityBase
    {
        public Guid Id { get; protected set; }

        public EntityBase()
        {
            Id = Guid.NewGuid();
        }
    }
}
