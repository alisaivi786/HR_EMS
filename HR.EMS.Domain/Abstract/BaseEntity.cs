﻿using System.ComponentModel.DataAnnotations;

namespace HR.EMS.Domain.Abstract;

public abstract class BaseEntity
{
    [ExcludeParameter]
    [Key]
    public long Id { get; set; }
    public Guid? RowId { get; set; } = Guid.NewGuid();
    public DateTime? DateCreated { get; set; } = DateTime.Now;
    public long? CreatedBy { get; set; } = null;
    public DateTime? DateModified { get; set; } = null;
    public long? ModifiedBy { get; set; } = null;
    public DateTime? DateDeleted { get; set; } = null;
    public long? DeletedBy { get; set; } = null;
    public bool? IsActive { get; set; } = true;
    public bool? IsDeleted { get; set; } = false;

}
