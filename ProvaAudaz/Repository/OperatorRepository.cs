using ProvaAudaz.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProvaAudaz.Repository
{
    public class OperatorRepository
    {
        public OperatorRepository()
        {
            _fakeDatabase = new List<Operator>();
        }

        private List<Operator> _fakeDatabase;

        public void Insert(Operator request)
        {
            _fakeDatabase.Add(request);
        }

        public Guid GetByCode(string code)
        {
            var result = _fakeDatabase.FirstOrDefault(savedModel => savedModel.Code == code);

            if (result == null)
                return Guid.Empty;

            return result.Id;
        }
    }
}
