using System.Collections.Generic;
using System.Linq;

namespace LvdtLesson06.Models
{
    public static class ProductData
    {
        public static List<Product> Products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Nồi cơm điện cao tần Nagakawa NAG0102",
                Price = 2450000m,
                Image = "/images/nagakawa.png",
                Category = "Gia dụng"
            },
            new Product
            {
                Id = 2,
                Name = "Nồi cơm điện cao tần Nagakawa NAG0102",
                Price = 2450000m,
                Image = "/images/nagakawa.png",
                Category = "Gia dụng"
            },
            new Product
            {
                Id = 3,
                Name = "Nồi cơm điện cao tần Nagakawa NAG0102",
                Price = 2450000m,
                Image = "/images/nagakawa.png",
                Category = "Gia dụng"
            },
            new Product
            {
                Id = 4,
                Name = "Nồi cơm điện cao tần Nagakawa NAG0102",
                Price = 2450000m,
                Image = "/images/nagakawa.png",
                Category = "Gia dụng"
            },
            new Product
            {
                Id = 5,
                Name = "Nồi cơm điện cao tần Nagakawa NAG0102",
                Price = 2450000m,
                Image = "/images/nagakawa.png",
                Category = "Gia dụng"
            },
            new Product
            {
                Id = 6,
                Name = "Nồi cơm điện cao tần Nagakawa NAG0102",
                Price = 2450000m,
                Image = "/images/nagakawa.png",
                Category = "Gia dụng"
            }
        };

        public static List<Product> GetNewProducts(int count = 3)
        {
            return Products.Take(count).ToList();
        }

        public static List<Product> GetHotProducts(int count = 3)
        {
            return Products.Skip(3).Take(count).ToList();
        }
    }
}
