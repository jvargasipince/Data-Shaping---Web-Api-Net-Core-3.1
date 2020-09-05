using DemoShapeData.Entities;
using DemoShapeData.Repository;
using System.Collections;
using System.Collections.Generic;

namespace DemoShapeData.Logic
{
    public class ProductLogic
    {
        private readonly ProductRepository _productRepository;
        public ProductLogic()
        {
            _productRepository = new ProductRepository();
        }

        public IList<Product> GetProductsList()
        {
            return _productRepository.GetProductsList();
        }




    }
}
