using EShop.CoreLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.EntitiesLayer.Entities
{
    public class ImageFiles:BaseEntity,IEntity
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ImagesFileId { get; set; }

        public String ProfileImage { get; set; }

        // Bir fotograf en az bir ürüne sahip olmalıdır.
        public virtual Products Product { get; set; }

        public int ProductId { get; set; }


    }
}
