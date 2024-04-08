namespace BaltaLoco.ContentContext
{

    public class Career : Content
    {           
        public Career()
        {
            Items = new List<CareerItem>();
        }

        public IList<CareerItem> Items { get; set; }

        public int TotalCourses =>Items.Count;
      
        public class CareerItem { 
            public int Ordem { get; set; }

            public string? Title { get; set; }
        
            public string? Description { get; set; }

            public Course Course { get; set; }
        }
    }
}