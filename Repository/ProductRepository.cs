using DemoShapeData.Entities;
using System.Collections.Generic;

namespace DemoShapeData.Repository
{
    public class ProductRepository
    {
        public ProductRepository()
        {

        }

        public List<Product> GetProductsList()
        {
            List<Product> listProducts = new List<Product>();

            listProducts.AddRange( new[] {
                  new Product()
                  {
                      Id = 1,
                      Name = "Lenovo X1 Carbon",
                      Description = "Lenovo Core I7 Octava Generación",
                      Category = "Computo",
                      SubCategory = "Laptop",
                      Price = 7500,
                      CountryOrigin = "China",
                      CompanyFabric = "Lenovo",
                      InStock = false
                  },
                  new Product()
                  {
                      Id = 2,
                      Name = "Mouse Inalambrico SA-54",
                      Description = "Mouse Inalambrico Logitech Gamer",
                      Category = "Computo",
                      SubCategory = "Accesorios",
                      Price = 180,
                      CountryOrigin = "USA",
                      CompanyFabric = "Logitech",
                      InStock = true
                  },
                  new Product()
                  {
                      Id = 3,
                      Name = "Monitor 27' ThinkView",
                      Description = "Lenovo ThinkView P27HQ",
                      Category = "Computo",
                      SubCategory = "Accesorios",
                      Price = 1780,
                      CountryOrigin = "China",
                      CompanyFabric = "Lenovo",
                      InStock = true
                  },
                  new Product()
                  {
                      Id = 4,
                      Name = "Laptop Dell XPS-15",
                      Description = "Dell XPS-15 Core I7 Octava Generación",
                      Category = "Computo",
                      SubCategory = "Laptop",
                      Price = 7800,
                      CountryOrigin = "USA",
                      CompanyFabric = "DELL",
                      InStock = true
                  },
                  new Product()
                  {
                      Id = 5,
                      Name = "Play Station 5",
                      Description = "Play Station 5 Digital Edition",
                      Category = "Gamer",
                      SubCategory = "Consolas",
                      Price = 1999,
                      CountryOrigin = "USA",
                      CompanyFabric = "SONY",
                      InStock = false
                  }
                  }
                );


            return listProducts;
        }

    }
}
