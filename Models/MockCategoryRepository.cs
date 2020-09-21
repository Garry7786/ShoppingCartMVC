using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCartMVCProject.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories => new List<Category> { 
            new Category
            {
                CategoryId=201,
                Name="Web Technology",
                Description="All Server side and client side courses."
            },
            new Category
            {
                CategoryId=202,
                Name="Data Science",
                Description="All Data Science related courses."
            },
            new Category
            {
                CategoryId=203,
                Name="C#",
                Description="Various Courses related to C#."
            },

        };
    }
}
