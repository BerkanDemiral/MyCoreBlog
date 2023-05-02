using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoreBlog.Core.Models
{
    public abstract class BaseEntity : IBaseEntity
    {
        public virtual Guid Id { get; set; } = Guid.NewGuid();
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual DateTime? ChangedDate { get; set; }
        public virtual DateTime? DeletedDate { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual string? ChangedBy { get; set; }
        public virtual string? DeletedBy { get; set; }
        public virtual bool isDeleted { get; set; } = false;
    }
}
