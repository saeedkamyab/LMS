namespace LMS.Application.Dtos.Common
{
   public class BaseDto
    {
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdate { get; set; }
        public bool IsDeleted { get; set; }
        public string? Description { get; set; }
    }
}
