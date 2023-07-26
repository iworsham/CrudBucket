namespace CrudBucketMVC.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public string Content { get; set; }
        public Game Game { get; set; }
    }
}
