using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindSpareParts.Model
{
    public class ProductRepository
    {
        private List<Product> products; //liste til at gemme produkterne

        public ProductRepository()
        {
            products = new List<Product>(); //initialisering af produktlisten
        }

        public void CreateProduct(Product product)
        {
            products.Add(product); //det nye produkt tilføjes til listen products
        }

        public void DeleteProduct(Product product)
        {
            products.Remove(product); //sletter et produkt fra listen products
        }

        public void SearchProduct(Product product)
        {
            products.BinarySearch(product); //søger efter et produkt i listen products 
        }



    }
}
