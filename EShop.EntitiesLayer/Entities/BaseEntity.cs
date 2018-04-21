using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.EntitiesLayer.Entities
{
    public class BaseEntity
    {
        public String CreatedDate { get; set; }
        public String ModifiedDate { get; set; }
        public String RemovedDate { get; set; }

    }
}
