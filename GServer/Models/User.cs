namespace GServer.Models
{
    public class User
    {
        protected int id { get; set; }
        protected int? chatId { get; set; }
        protected string name { get; set; }
        private string session { get; set; }
    }
}
