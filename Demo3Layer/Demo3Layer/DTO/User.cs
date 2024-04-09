using System.Data;

namespace Demo3Layer.DTO
{
    public class User
    {
        public int? Id { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }

        public User(int? id, string username, string password)
        {
            Id = id;
            UserName = username;  
            Password = password;
        }

        public User(DataRow row)
        {
            Id = (int) row["Id"];
            UserName = row["UserName"].ToString();
            Password = row["Password"].ToString();
        }
    }
}
