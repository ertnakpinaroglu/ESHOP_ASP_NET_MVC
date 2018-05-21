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
    public class Comment:BaseEntity,IEntity
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CommentId { get; set; }
        public String Text { get; set; }

        public String IsActive { get; set; }

        public virtual Products Product { get; set; }
        public virtual Customer Customer { get; set; }

        public int ProductId { get; set; }
        public int CustomerId { get; set; }



    }
}
