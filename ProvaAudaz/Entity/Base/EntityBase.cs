using System;

namespace ProvaAudaz.Entity.Base
{
    public class EntityBase
    {
        public Guid Id { get; private set; }

        public EntityBase()
        {
            Id = Guid.NewGuid();
        }
    }
}
