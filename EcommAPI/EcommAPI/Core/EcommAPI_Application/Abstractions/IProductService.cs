using EcommAPI_Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommAPI_Application.Abstractions
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
