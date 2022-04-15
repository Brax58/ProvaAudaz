using ProvaAudaz.Entity.Base;

namespace ProvaAudaz.Entity
{
    public class Operator : EntityBase
    {
        public string Code { get; private set; }

        public Operator(string code)
        {
            Code = code;
        }
    }
}
