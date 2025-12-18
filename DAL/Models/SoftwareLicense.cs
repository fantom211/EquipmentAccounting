using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EquipmentDatabase.Models;

public partial class SoftwareLicense
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(150)]
    public string Name { get; set; } = null!;

    [StringLength(100)]
    public string Vendor { get; set; } = null!;

    [StringLength(100)]
    public string LicenseKey { get; set; } = null!;

    public DateOnly ExpirationDate { get; set; }

    [InverseProperty("License")]
    public virtual ICollection<InstalledSoftware> InstalledSoftwares { get; set; } = new List<InstalledSoftware>();
}
