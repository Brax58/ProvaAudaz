using ProvaAudaz.Entity;
using ProvaAudaz.Repository;
using System;

namespace ProvaAudaz.Service
{
    public class OperatorService
    {
        private readonly OperatorRepository _operatorRepository;

        public OperatorService()
        {
            _operatorRepository = new OperatorRepository();
        }

        public Guid Create(string request)
        {
            if (string.IsNullOrEmpty(request))
                throw new Exception("Código deve ser preenchido!");

            var operatorInsert = new Operator(request);

            _operatorRepository.Insert(operatorInsert);
            return operatorInsert.Id;
        }

        public Guid GetByCode(string request)
        {
            if (string.IsNullOrEmpty(request))
                throw new Exception("Código deve ser preenchido!");

            var result = _operatorRepository.GetByCode(request);

            if (result == Guid.Empty)
                return Guid.Empty;

            return result;
        }
    }
}
