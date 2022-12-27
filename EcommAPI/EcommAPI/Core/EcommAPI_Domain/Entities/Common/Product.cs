using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommAPI_Domain.Entities.Common
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int StockNumber { get; set; }

        public long Price { get; set; }
    }
}
