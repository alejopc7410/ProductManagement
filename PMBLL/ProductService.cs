using PMDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMBLL
{
    public class ProductService
    {
        public List<Product> GetProducts()
        {
            ProductRepository productRepository = new ProductRepository();
            return productRepository.GetProducts();
        }

        public bool AddProduct(Product product)
        {
            ProductRepository productRepository = new ProductRepository();
            return productRepository.AddProduct(product);
        }
        
        public Product GetProduct(int productId)
        {
            ProductRepository productRepository = new ProductRepository();
            return productRepository.GetProduct(productId);
        }
        
        public bool EditProduct(Product product)
        {
            ProductRepository productRepository = new ProductRepository();
            return productRepository.EditProduct(product);
        }
        
        public bool DeleteProduct(int productId)
        {
            ProductRepository productRepository = new ProductRepository();
            return productRepository.DeleteProduct(productId);
        }
    }
}
