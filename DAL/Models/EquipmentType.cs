using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EquipmentDatabase.Models;

public partial class EquipmentType
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [StringLength(100)]
    public string Name { get; set; } = null!;

    [InverseProperty("Type")]
    public virtual ICollection<Equipment> Equipment { get; set; } = new List<Equipment>();
}
