using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KindOfAnInventorySystem.Model
{
    public class ProductRepository : IRepository

    {
        Product product = new Product();
        private List<Product> products;

        void IRepository.Create()
        {
            products.Add(product);
        }

           

        void IRepository.Delete()
        {
            products.Remove(product);
        }

        void IRepository.Read()
        {
            
        }

        void IRepository.Search()
        {
            throw new NotImplementedException();
        }

        void IRepository.Update()
        {
            throw new NotImplementedException();
        }
    }

}
