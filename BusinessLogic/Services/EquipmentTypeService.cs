using BusinessLogic.Interfaces;
using EquipmentDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class EquipmentTypeService
    {
        private readonly IRepository<EquipmentType> _repository;

        public EquipmentTypeService(IRepository<EquipmentType> repository)
        {
            _repository = repository;
        }

        public void AddType(EquipmentType type)
        {
            _repository.Add(type);
        }

        public void DeleteType(int id)
        {
            _repository.Delete(id);
        }

        public void UpdateType(EquipmentType type)
        {
            _repository.Update(type);
        }

        public EquipmentType GetTypeById(int id)
        {
            return _repository.GetById(id);
        }

        public List<EquipmentType> GetAllTypes()
        {
            return _repository.GetAll();
        }
    }
}
