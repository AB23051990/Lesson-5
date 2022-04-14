namespace HW2.Controllers.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public bool IsTaken { get; set; }        
        public bool IsDone { get; set; }
        
    }
}
