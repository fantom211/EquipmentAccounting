using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EquipmentDatabase.Models;

public partial class EquipmentHistory
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("EquipmentID")]
    public int EquipmentId { get; set; }

    public DateOnly DateMoved { get; set; }

    [Column("OldEmployeeID")]
    public int? OldEmployeeId { get; set; }

    [Column("NewEmployeeID")]
    public int? NewEmployeeId { get; set; }

    [ForeignKey("EquipmentId")]
    [InverseProperty("EquipmentHistories")]
    public virtual Equipment Equipment { get; set; } = null!;

    [ForeignKey("NewEmployeeId")]
    [InverseProperty("EquipmentHistoryNewEmployees")]
    public virtual Employee? NewEmployee { get; set; }

    [ForeignKey("OldEmployeeId")]
    [InverseProperty("EquipmentHistoryOldEmployees")]
    public virtual Employee? OldEmployee { get; set; }
}
