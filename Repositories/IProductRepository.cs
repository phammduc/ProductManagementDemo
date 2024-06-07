using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace Repositories
{
    public interface IProductRepository
    {
        public void SaveProduct(Product p);
        public void DeleteProduct(Product p);
        public void UpdateProduct(Product p);
        public List<Product> GetProducts();
        Product GetProductById(int id);

    }
}
