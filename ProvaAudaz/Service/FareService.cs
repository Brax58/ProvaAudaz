using ProvaAudaz.Entity;
using ProvaAudaz.Repository;
using System;
using System.Collections.Generic;
using TestePleno.Models;

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

            var ExistFire = _fareRepository.GetById(operatorId, request.Id);

            if (ExistFire != null)
                throw new Exception("Já existe um tarifa criada com essa operadora!");

            var fare = new Fare(operatorId, request.Value);

            _fareRepository.Insert(fare);
        }

        public void Update(FareModel request)
        {
            Guid operatorId = Guid.Empty;

            var operatorIdExist = _operatorService.GetByCode(request.OperatorCode);

            if (operatorIdExist == Guid.Empty)
                operatorId = _operatorService.Create(request.OperatorCode);

            var ExistFire = _fareRepository.GetById(operatorId ,request.Id);

            if (ExistFire != null)
                _fareRepository.Delete(ExistFire.Id);

            var fare = new Fare(operatorId, request.Value);

            _fareRepository.Update(fare);
        }

        public Fare GetFareById(Guid operatorId, Guid fareId)
        {
            return _fareRepository.GetById(operatorId,fareId);
        }

        public List<Fare> GetFares()
        {
            return _fareRepository.GetAll();
        }
    }
}
