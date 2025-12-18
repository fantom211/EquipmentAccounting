using BusinessLogic.Interfaces;
using EquipmentDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class SoftwareLicenseService
    {
        private readonly IRepository<SoftwareLicense> _repository;

        public SoftwareLicenseService(IRepository<SoftwareLicense> repository)
        {
            _repository = repository;
        }

        public void AddLicense(SoftwareLicense license)
        {
            _repository.Add(license);
        }

        public void DeleteLicense(int id)
        {
            _repository.Delete(id);
        }

        public void UpdateLicense(SoftwareLicense license)
        {
            _repository.Update(license);
        }

        public SoftwareLicense GetLicenseById(int id)
        {
            return _repository.GetById(id);
        }

        public List<SoftwareLicense> GetAllLicenses()
        {
            return _repository.GetAll();
        }
    }
}
