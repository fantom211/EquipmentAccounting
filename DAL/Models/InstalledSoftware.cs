using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EquipmentDatabase.Models;

[PrimaryKey("EquipmentId", "LicenseId")]
public partial class InstalledSoftware
{
    public int Id { get; set; }
    [Key]
    [Column("EquipmentID")]
    public int EquipmentId { get; set; }

    [Key]
    [Column("LicenseID")]
    public int LicenseId { get; set; }

    public DateOnly InstallDate { get; set; }

    [ForeignKey("EquipmentId")]
    [InverseProperty("InstalledSoftwares")]
    public virtual Equipment Equipment { get; set; } = null!;

    [ForeignKey("LicenseId")]
    [InverseProperty("InstalledSoftwares")]
    public virtual SoftwareLicense License { get; set; } = null!;
}
