namespace BlazorApp.Models
{
   
    public class Activity
    {
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public string? Message { get; set; }
    }
}