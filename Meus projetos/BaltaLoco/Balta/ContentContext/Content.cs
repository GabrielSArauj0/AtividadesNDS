namespace BaltaLoco.ContentContext
{
    public abstract class Content
    {
        public Content()
        {
            Id = Guid.NewGuid(); //SPOF 
        }
        
        public Guid Id { get; set; }

        public string? Title { get; set; }

        public string Url { get; set; } = null!;
    }
} 
