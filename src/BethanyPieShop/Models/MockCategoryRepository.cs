using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanyPieShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category { CategoryId =1, CategoryName = "Fruit pies", Description = "All-fruity pies" },
                    new Category { CategoryId =2, CategoryName = "Cheese cakes", Description = "Cheesy all the ways" },
                    new Category { CategoryId =3, CategoryName = "Season pies", Description = "Get in the mood for a season" }
                };
            }
        }
    }
}
