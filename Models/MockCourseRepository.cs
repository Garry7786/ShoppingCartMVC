using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCartMVCProject.Models
{
    public class MockCourseRepository : ICourseRepository
    {
        private readonly ICategoryRepository categoryRepository;
        public MockCourseRepository(ICategoryRepository repo)
        {
            categoryRepository = repo;
        }
        public IEnumerable<Course> AllCourses => new List<Course> {
            new Course{
                CourseId = 1, Title = "ASP.Net Core", Description = "",
                Fee =1250,isWeekendClassAvailable = true, ImageUrl="",
                Category = categoryRepository.AllCategories.ToList()[0]
            },
            new Course{
                CourseId = 1, Title = "C++", Description = "",
                Fee =1250,isWeekendClassAvailable = true, ImageUrl="",
                Category = categoryRepository.AllCategories.ToList()[0]
            },
            new Course{
                CourseId = 1, Title = "C#", Description = "",
                Fee =1250,isWeekendClassAvailable = true, ImageUrl="",
                Category = categoryRepository.AllCategories.ToList()[0]
            },
            new Course{
                CourseId = 1, Title = "Data Structure", Description = "",
                Fee =1250,isWeekendClassAvailable = true, ImageUrl="",
                Category = categoryRepository.AllCategories.ToList()[1]
            },
            new Course{
                CourseId = 1, Title = "Data Structure &Algorithn", Description = "",
                Fee =1250,isWeekendClassAvailable = true, ImageUrl="",
                Category = categoryRepository.AllCategories.ToList()[1]
            },
            new Course{
                CourseId = 1, Title = "Database", Description = "",
                Fee =1250,isWeekendClassAvailable = true, ImageUrl="",
                Category = categoryRepository.AllCategories.ToList()[2]
            },
            new Course{
                CourseId = 1, Title = "Sql Server", Description = "",
                Fee =1250,isWeekendClassAvailable = true, ImageUrl="",
                Category = categoryRepository.AllCategories.ToList()[2]
            },
        };

        public IEnumerable<Course> FreeCoursesOfTheWeek { get; }

        public Course GetCourseById(int courseId)
        {
            return AllCourses.FirstOrDefault(c => c.CourseId == courseId);
        }
    }
}
