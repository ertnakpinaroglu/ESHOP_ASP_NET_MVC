using EShop.CoreLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.EntitiesLayer.Entities
{
    public class Comment:BaseEntity,IEntity
    {
        public int CommentId { get; set; }
        public String Text { get; set; }

        public String IsActive { get; set; }


    }
}
