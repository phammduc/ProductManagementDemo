using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using Repositories;

namespace Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository iProducRepository;

        public ProductService()
        {
            iProducRepository = new ProductRepository();
        }
        public void SaveProduct(Product p)
        {
            iProducRepository.SaveProduct(p);
        }

        public void DeleteProduct(Product p)
        {
            iProducRepository.DeleteProduct(p);
        }

        public void UpdateProduct(Product p)
        {
            iProducRepository.UpdateProduct(p);
        }

        public List<Product> GetProducts()
        {
            return iProducRepository.GetProducts();
        }

        public Product GetProductById(int id)
        {
            return iProducRepository.GetProductById(id);
        }

        
    }
}
