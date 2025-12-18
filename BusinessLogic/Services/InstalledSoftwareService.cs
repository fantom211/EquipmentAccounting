using BusinessLogic.Interfaces;
using EquipmentDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class InstalledSoftwareService
    {
        private readonly IRepository<InstalledSoftware> _repository;

        public InstalledSoftwareService(IRepository<InstalledSoftware> repository)
        {
            _repository = repository;
        }

        public void AddInstalledSoftware(InstalledSoftware software)
        {
            _repository.Add(software);
        }

        public void DeleteInstalledSoftware(int id)
        {
            _repository.Delete(id);
        }

        public void UpdateInstalledSoftware(InstalledSoftware software)
        {
            _repository.Update(software);
        }

        public InstalledSoftware GetInstalledSoftwareById(int id)
        {
            return _repository.GetById(id);
        }

        public List<InstalledSoftware> GetAllInstalledSoftware()
        {
            return _repository.GetAll();
        }
    }
}
