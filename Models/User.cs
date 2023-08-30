namespace WebChatClientWebSite.Models
{
    public class User
    {
        public string Id { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string Token { get; set; } = null!;
    }

    public class CreateUser
    {
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
    }

    public class UserDTO
    {
        public string Id { get; set; } = null!;
        public string Token { get; set; } = null!;
    }
}
