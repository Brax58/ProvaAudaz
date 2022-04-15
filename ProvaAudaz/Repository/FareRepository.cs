using ProvaAudaz.Entity;
using ProvaAudaz.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProvaAudaz.Repository
{
    public class FareRepository
    {
        private List<Fare> _fakeDatabase;

        public FareRepository()
        {
            _fakeDatabase = new List<Fare>();
        }

        public void Insert(Fare request)
        {
            _fakeDatabase.Add(request);
        }

        public void Update(Fare request)
        {
            _fakeDatabase.Add(request);
        }

        public Fare GetById(Guid OperatorId,Guid? idFare = null)
        {
            return _fakeDatabase.FirstOrDefault(savedModel => savedModel.OperatorId == OperatorId && savedModel.Id != idFare && savedModel.Status == 1);
        }

        public List<Fare> GetAll()
        {
            var allModels = _fakeDatabase.Where(savedModel => savedModel.GetType().IsAssignableFrom(typeof(FareModel)));
            return allModels.Select(genericModel => genericModel).ToList();
        }

        public void Delete(Guid idRequest)
        {
            var fare = _fakeDatabase.FirstOrDefault(savedModel => savedModel.Id == idRequest);
            _fakeDatabase.Remove(fare);
        }
    }
}
