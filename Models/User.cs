namespace WebChatClientWebSite.Models
{
    public class User
    {
        public string Id { get; set; } = null!;
        public string UserName { get; set; } = null!;
    }

    public class CreateUser
    {
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
