

namespace ECommerce.Domain.BaseEntities
{
    public class BaseEntity
    {
        
      
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public virtual DateTime UpdateDate { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
