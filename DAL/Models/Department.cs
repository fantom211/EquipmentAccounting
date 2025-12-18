using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EquipmentDatabase.Models;

public partial class Department
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [StringLength(100)]
    public string Name { get; set; } = null!;

    [Column("ManagerID")]
    public int? ManagerId { get; set; }

    [InverseProperty("Department")]
    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    [ForeignKey("ManagerId")]
    [InverseProperty("Departments")]
    public virtual Employee? Manager { get; set; }
}
