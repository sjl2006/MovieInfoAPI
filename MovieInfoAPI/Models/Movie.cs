namespace MovieInfoAPI.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string Provider { get; set; }
        public string? AvailableTime { get; set; }
        public int? Price { get; set; }
        public int? Rating { get; set; }
        public string? ImageUrl { get; set; }
        public string? Duration { get; set; }
        public string? Genre { get; set; }
        public string? Classfication { get; set; }
        public string? Director { get; set; }
      }
        
    
}
