namespace website.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }
        public boolean? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
