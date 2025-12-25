using BusinessLogic.DTOs;
using BusinessLogic.Interfaces;
using DAL.Context;
using EquipmentDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public static class ValidatoR
    {
        public static bool IsValid<T>(T dto, EquipmentContext context, out string errorMessage)
        {
            errorMessage = "";

            switch (dto)
            {
                case Employee employee:
                    if (string.IsNullOrWhiteSpace(employee.FullName))
                        errorMessage = "ФИО сотрудника пустое.";
                    else if (string.IsNullOrWhiteSpace(employee.Position))
                        errorMessage = "Должность сотрудника пустая.";
                    else if (!DepartmentExists(employee.DepartmentId, context))
                        errorMessage = "Отдел с таким ID не найден.";
                    break;

                case Department department:
                    if (string.IsNullOrWhiteSpace(department.Name))
                        errorMessage = "Название отдела пустое.";
                    else if (!ManagerExists(department.ManagerId, context))
                        errorMessage = "Менеджер с таким ID не найден.";
                    break;

                case Equipment equipment:
                    if (string.IsNullOrWhiteSpace(equipment.Name))
                        errorMessage = "Название оборудования пустое.";
                    else if (!EquipmentTypeExists(equipment.TypeId, context))
                        errorMessage = "Тип оборудования с таким ID не найден.";
                    else if (!EmployeeExists(equipment.EmployeeId, context))
                        errorMessage = "Сотрудник с таким ID не найден.";
                    else if (string.IsNullOrWhiteSpace(equipment.SerialNumber))
                        errorMessage = "Серийный номер пустой.";
                    else if (string.IsNullOrWhiteSpace(equipment.Status))
                        errorMessage = "Статус оборудования не выбран.";
                    break;

                case SoftwareLicense license:
                    if (string.IsNullOrWhiteSpace(license.Name))
                        errorMessage = "Название лицензии пустое.";
                    else if (string.IsNullOrWhiteSpace(license.Vendor))
                        errorMessage = "Поставщик лицензии пустой.";
                    else if (string.IsNullOrWhiteSpace(license.LicenseKey))
                        errorMessage = "Ключ лицензии пустой.";
                    else if (license.ExpirationDate < DateOnly.FromDateTime(DateTime.Today))
                        errorMessage = "Дата окончания лицензии не может быть в прошлом.";
                    break;

                case InstalledSoftware installed:
                    if (!EquipmentExists(installed.EquipmentId, context))
                        errorMessage = "Оборудование с таким ID не найдено.";
                    else if (!SoftwareLicenseExists(installed.LicenseId, context))
                        errorMessage = "Лицензия с таким ID не найдена.";
                    break;

                case EquipmentType type:
                    if (string.IsNullOrWhiteSpace(type.Name))
                        errorMessage = "Название типа оборудования пустое.";
                    break;

                case EquipmentHistory history:
                    if (!EquipmentExists(history.EquipmentId, context))
                        errorMessage = "Оборудование с таким ID не найдено.";
                    else if (history.OldEmployeeId.HasValue && !EmployeeExists(history.OldEmployeeId, context))
                        errorMessage = "Сотрудник (старый) с таким ID не найден.";
                    else if (history.NewEmployeeId.HasValue && !EmployeeExists(history.NewEmployeeId, context))
                        errorMessage = "Сотрудник (новый) с таким ID не найден.";
                    else if (history.DateMoved > DateOnly.FromDateTime(DateTime.Today))
                        errorMessage = "Дата перемещения не может быть в будущем.";
                    break;

                default:
                    errorMessage = "Неизвестный тип DTO.";
                    break;
            }

            return string.IsNullOrEmpty(errorMessage);
        }

        private static bool DepartmentExists(int id, EquipmentContext db)
        {
            return db.Departments.Any(d => d.Id == id);
        }

        private static bool ManagerExists(int? id, EquipmentContext db)
        {
            if (!id.HasValue) return false;
            return db.Employees.Any(e => e.Id == id);
        }

        private static bool EmployeeExists(int? id, EquipmentContext db)
        {
            if (!id.HasValue) return false;
            return db.Employees.Any(e => e.Id == id);
        }

        private static bool EquipmentTypeExists(int id, EquipmentContext db)
        {
            return db.EquipmentTypes.Any(t => t.Id == id);
        }

        private static bool EquipmentExists(int id, EquipmentContext db)
        {
            return db.Equipments.Any(e => e.Id == id);
        }

        private static bool SoftwareLicenseExists(int id, EquipmentContext db)
        {
            return db.SoftwareLicenses.Any(s => s.Id == id);
        }

    }
}
