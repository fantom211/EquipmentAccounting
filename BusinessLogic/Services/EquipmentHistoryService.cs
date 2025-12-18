using BusinessLogic.Interfaces;
using EquipmentDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class EquipmentHistoryService
    {
        private readonly IRepository<EquipmentHistory> _repository;

        public EquipmentHistoryService(IRepository<EquipmentHistory> repository)
        {
            _repository = repository;
        }

        public void AddHistory(EquipmentHistory history)
        {
            _repository.Add(history);
        }

        public void DeleteHistory(int id)
        {
            _repository.Delete(id);
        }

        public void UpdateHistory(EquipmentHistory history)
        {
            _repository.Update(history);
        }

        public EquipmentHistory GetHistoryById(int id)
        {
            return _repository.GetById(id);
        }

        public List<EquipmentHistory> GetAllHistories()
        {
            return _repository.GetAll();
        }
    }
}

