namespace CrudBucketMVC.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public List<Review> Reviews { get; set; } = new List<Review>();
    }
}
