using ProvaAudaz.Entity.Base;
using System;

namespace ProvaAudaz.Entity
{
    public class Fare : EntityBase
    {
        public Guid OperatorId { get; private set; }
        public int Status { get; private set; }
        public decimal Value { get; private set; }


        public Fare(Guid operatorId,decimal value)
        {
            Status = 1;
            OperatorId = operatorId;
            Value = value;
        }
    }
}
