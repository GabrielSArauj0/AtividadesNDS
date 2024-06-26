using BaltaLoco.ContentContext.Enums;

namespace BaltaLoco.ContentContext
{
    public class Course : Content
    {
        
        public Course()
        {
            Modules = new List<Module>();
        }

        public string Tag { get; set; }

        public IList<Module> Modules { get; set; }

        public int DurationInMinute { get; set; }
        
        public EContentLevel Level { get; set; }


        public class Module
        {
            public Module()
            {
                Lectures = new List<Lecture>();
            }

            public int Order { get; set; }

            public string Title { get; set; } = null!;

            public IList<Lecture> Lectures { get; set; }
        }
        

        public class Lecture
        {
            public int Ordem { get; set; }
            public string? Title { get; set; }
        }
    }
}