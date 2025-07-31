using System.ComponentModel.DataAnnotations;

namespace LMS.ApplicationCore.Entities.Common
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdate { get; set; }
        public bool IsDeleted { get; set; }
        [StringLength(300)]
        public string? Description { get; set; }
    }
}
