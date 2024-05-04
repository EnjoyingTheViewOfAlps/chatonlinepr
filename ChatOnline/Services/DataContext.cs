using ChatOnline.Data;

namespace ChatOnline.Services
{
    public class DataContext
    {
        public List<Chat> Chats = new List<Chat>();

        public List<User> Users = new List<User>()
        {
            new User("Login1", "talgat"),
            new User("Login2", "Password2"),
            new User("Login3", "Password3")
        };
    }
}
