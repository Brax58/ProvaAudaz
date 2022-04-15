using System;

namespace ProvaAudaz.Entity
{
    public class Fare
    {
        public Guid Id { get; private set; }
        public Guid OperatorId { get; private set; }
        public int Status { get; private set; }
        public decimal Value { get; private set; }


        public Fare(Guid operatorId,decimal value)
        {
            Id = Guid.NewGuid();
            Status = 1;
            OperatorId = operatorId;
            Value = value;
        }
    }
}
