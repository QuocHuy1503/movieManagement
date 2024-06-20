namespace BlazorApp5.Data
{
    public class Movie
    {
        public int Id { get; set; }
        public  string Title { get; set; }
        public  string Director { get; set; }
        public  string Description { get; set; }
        public  string Image { get; set; }
       /* public  TimeSpan Duration { get; set; }
        public  DateTime ReleaseDate { get; set; }*/
        public  string Language { get; set; }
/*        public required float Price { get; set; }
*/       /* public required string IsFeatured { get; set; }*/
        public  int Status { get; set; }
        
        public Movie()
        {

        }

        public Movie(int id, string title, 
            string director, string description, 
            string image, string language, 
            int status)
        {
            Id = id;
            Title = title;
            Director = director;
            Description = description;
            Image = image;
          
            Language = language;
            Status = status;
        }
    }
}
