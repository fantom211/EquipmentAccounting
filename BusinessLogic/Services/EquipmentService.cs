using BusinessLogic.Interfaces;
using EquipmentDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class EquipmentService
    {
        private readonly IRepository<Equipment> _repository;
        public EquipmentService(IRepository<Equipment> repository)
        {
            _repository = repository;
        }
        public void AddEquipment(Equipment equipment)
        {
            _repository.Add(equipment);
        }

        public void DeleteEquipment(int id)
        {
            _repository.Delete(id);
        }

        public void UpdateEquipment(Equipment equipment)
        {
            _repository.Update(equipment);
        }

        public Equipment GetEquipmentById(int id)
        {
            return _repository.GetById(id);
        }

        public List<Equipment> GetAllEquipment()
        {
            return _repository.GetAll();
        }
    }
}
