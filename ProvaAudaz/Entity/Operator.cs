using System;

namespace ProvaAudaz.Entity
{
    public class Operator
    {
        public Guid Id { get; private set; }
        public string Code { get; private set; }

        public Operator()
        {

        }

        public Operator(string code)
        {
            Id = Guid.NewGuid();
            Code = code;
        }
    }
}
