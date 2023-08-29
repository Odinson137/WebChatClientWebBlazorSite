namespace WebChatClientWebSite.Models
{
    public class Chat
    {
        public int ChatId { get; set; }
        public string Title { get; set; } = null!;
        public ICollection<User> Users { get; set; } = null!;
        public ICollection<Message>? Messages { get; set; }
    }
}
