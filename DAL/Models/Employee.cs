using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EquipmentDatabase.Models;

public partial class Employee
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [StringLength(200)]
    public string FullName { get; set; } = null!;

    [StringLength(100)]
    public string Position { get; set; } = null!;

    [Column("DepartmentID")]
    public int DepartmentId { get; set; }

    [ForeignKey("DepartmentId")]
    [InverseProperty("Employees")]
    public virtual Department Department { get; set; } = null!;

    [InverseProperty("Manager")]
    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();

    [InverseProperty("Employee")]
    public virtual ICollection<Equipment> Equipment { get; set; } = new List<Equipment>();

    [InverseProperty("NewEmployee")]
    public virtual ICollection<EquipmentHistory> EquipmentHistoryNewEmployees { get; set; } = new List<EquipmentHistory>();

    [InverseProperty("OldEmployee")]
    public virtual ICollection<EquipmentHistory> EquipmentHistoryOldEmployees { get; set; } = new List<EquipmentHistory>();
}
