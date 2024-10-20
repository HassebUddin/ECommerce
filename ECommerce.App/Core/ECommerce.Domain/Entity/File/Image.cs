using ECommerce.Domain.BaseEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Domain.Entity.File
{
    public class Image : BaseEntity
    {
        public string FileName { get; set; } = null!;
        public string Path { get; set; } = null!;
        public string Storage { get; set; } = null!;



        [NotMapped]
        public override DateTime UpdateDate { get => base.UpdateDate; set => base.UpdateDate = value; }

    }
}
