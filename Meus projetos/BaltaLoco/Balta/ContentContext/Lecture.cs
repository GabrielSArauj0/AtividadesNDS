using BaltaLoco.ContentContext.Enums;

namespace BaltaLoco.ContentContext;

public class Lecture
{
    public Lecture(IList<Lecture> lectures)
    {
        Lectures = lectures;
    }

    public int Ordem { get; set; }
    
    public string? Title { get; set; }
    
    public int DurationInMinutes { get; set; }
    
    public IList<Lecture> Lectures { get; set; }
    public  EContentLevel Level { get; set; }
}
    



