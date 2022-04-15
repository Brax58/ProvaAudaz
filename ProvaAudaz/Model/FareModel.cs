using System;

namespace ProvaAudaz.Model
{
    public class FareModel
    {
        public Guid Id { get; private set; }
        public decimal Value { get; private set; }
        public string OperatorCode { get; private set; }


        public FareModel(Guid id,string operatorCode, decimal value)
        {
            Id = id;
            OperatorCode = operatorCode;
            Value = value;
        }

        public FareModel(string operatorCode, decimal value)
        {
            Id = Guid.NewGuid();
            OperatorCode = operatorCode;
            Value = value;
        }
    }
}
