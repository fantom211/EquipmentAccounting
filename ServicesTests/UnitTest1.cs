using BusinessLogic.Services;
using DAL;
using DAL.Context;
using EquipmentDatabase.Models;
using Microsoft.EntityFrameworkCore;

namespace ServicesTests
{
    public class UnitTest1
    {
        private EquipmentContext context = new EquipmentContext(new DbContextOptionsBuilder<EquipmentContext>()
            .UseSqlServer(AppConfig.connectionString)
            .Options);
        private Service service = new Service();
        [Fact]
        public void AddEntity()
        {
            int before = context.Departments.Count();
            var dept = new Department
            {
                Name = "Test"
            };
            service.Add(dept);
            int after = context.Departments.Count();

            Assert.Equal(before+1, after);
            service.Delete<Department>(dept.Id);
        }

        [Fact]
        public void DeleteEntity()
        {
            var dept = new Department { Name = "ToDelete" };
            context.Departments.Add(dept);
            context.SaveChanges();

            int before = context.Departments.Count();
            service.Delete<Department>(dept.Id);
            int after = context.Departments.Count();

            Assert.Equal(before - 1, after);
        }

        [Fact]
        public void UpdateEntity()
        {
            var dept = new Department { Name = "OldName" };
            context.Departments.Add(dept);
            context.SaveChanges();

            dept.Name = "NewName";
            service.Update(dept);

            var updated = context.Departments.First(d => d.Id == dept.Id);
            Assert.Equal("NewName", updated.Name);
        }

        [Fact]
        public void GetAllEntities()
        {
            context.Departments.AddRange(
                new Department { Name = "Dept1" },
                new Department { Name = "Dept2" }
            );
            context.SaveChanges();

            var result = service.GetAll<Department>();

            Assert.Equal(context.Departments.Count(), result.Count);
        }

        [Fact]
        public void GetByIdEntity()
        {
            var dept = new Department { Name = "Legal" };
            context.Departments.Add(dept);
            context.SaveChanges();

            var result = service.GetById<Department>(dept.Id);

            Assert.NotNull(result);
            Assert.Equal(dept.Name, result.Name);
        }

    }
}