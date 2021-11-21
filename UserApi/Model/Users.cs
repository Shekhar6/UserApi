using System.ComponentModel.DataAnnotations;

namespace UserApi.Model
{
    public class Users
    {
        [Key]
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
    }
}
