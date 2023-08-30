
namespace WebChatClientWebSite.Models
{
    public class Message
    {
        public int MessageId { get; set; }
        public int ChatId { get; set; }
        public string Id { get; set; } = null!;
        public DateTime SendTime { get; set; }
        public string text { get; set; } = null!;
    }
}
