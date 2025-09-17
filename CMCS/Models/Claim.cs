namespace CMCS.Models
{
    public class Claim
    {
        public int Id { get; set; }
        public string? ClaimNumber { get; set; }
        public string? lecturer { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateSubmitted { get; set; }
        public string? Status { get; set; }
    }
}
