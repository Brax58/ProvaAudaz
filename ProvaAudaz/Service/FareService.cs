using ProvaAudaz.Entity;
using ProvaAudaz.Model;
using ProvaAudaz.Repository;
using System;
using System.Collections.Generic;

namespace ProvaAudaz.Service
{
    public class FareService
    {
        private readonly FareRepository _fareRepository;
        private readonly OperatorService _operatorService;

        public FareService()
        {
            _fareRepository = new FareRepository();
            _operatorService = new OperatorService();
        }

        public void Create(FareModel request)
        {
            Guid operatorId = Guid.Empty;

            operatorId = _operatorService.GetByCode(request.OperatorCode);

            if (operatorId == Guid.Empty)
                operatorId = _operatorService.Create(request.OperatorCode);

            var fare = new Fare(operatorId, request.Value);

            var ExistFire = _fareRepository.GetById(operatorId, fare.Id);

            if (ExistFire != null)
                throw new Exception("Já existe um tarifa criada com essa operadora!");

            _fareRepository.Insert(fare);
        }

        public void Update(FareModel request)
        {
            Guid operatorId = Guid.Empty;

            operatorId = _operatorService.GetByCode(request.OperatorCode);

            if (operatorId == Guid.Empty)
                operatorId = _operatorService.Create(request.OperatorCode);

            var fare = new Fare(request.Id,operatorId, request.Value);

            var ExistFire = _fareRepository.GetById(operatorId, fare.Id);

            if (ExistFire != null)
                throw new Exception("Já existe um tarifa criada com essa operadora!");

            _fareRepository.Update(fare);
        }

        public Fare GetFareById(Guid operatorId, Guid fareId)
        {
            return _fareRepository.GetById(operatorId, fareId);
        }

        public List<Fare> GetFares()
        {
            return _fareRepository.GetAll();
        }
    }
}
