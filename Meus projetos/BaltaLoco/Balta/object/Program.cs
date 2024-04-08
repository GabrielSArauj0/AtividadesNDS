using BaltaLoco.ContentContext;

namespace BaltaLoco.@object
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hellou mader foukers.");

            var course = new Course();
            course.Level = ContentContext.Enums.EContentLevel.Beginner;
            
            foreach (var item in course.Modules)
            {
                var articles = new List<Article>();
                articles.Add(new Article());
            }

            var career = new Career();
            career.Items.Add(new Career.CareerItem());
            Console.WriteLine(career.TotalCourses);
        }
    }
}