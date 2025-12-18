using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EquipmentDatabase.Models;

[Index("SerialNumber", Name = "IDX_Equipments_SerialNumber")]
public partial class Equipment
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [StringLength(150)]
    public string Name { get; set; } = null!;

    [Column("TypeID")]
    public int TypeId { get; set; }

    [StringLength(100)]
    public string SerialNumber { get; set; } = null!;

    [Column("EmployeeID")]
    public int? EmployeeId { get; set; }

    public DateOnly DateAdded { get; set; }

    [StringLength(50)]
    public string Status { get; set; } = null!;

    [ForeignKey("EmployeeId")]
    [InverseProperty("Equipment")]
    public virtual Employee? Employee { get; set; }

    [InverseProperty("Equipment")]
    public virtual ICollection<EquipmentHistory> EquipmentHistories { get; set; } = new List<EquipmentHistory>();

    [InverseProperty("Equipment")]
    public virtual ICollection<InstalledSoftware> InstalledSoftwares { get; set; } = new List<InstalledSoftware>();

    [ForeignKey("TypeId")]
    [InverseProperty("Equipment")]
    public virtual EquipmentType Type { get; set; } = null!;
}
