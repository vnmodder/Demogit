using System.Data;

namespace Demo3Layer.DAL
{
    public class UserDAL
    {
        public UserDAL() { }

        public DataTable GetUsers()
        {
            var query = "SELECT * FROM [USER]";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetUserByUserName(string userName)
        {
            var query = "EXEC USP_GetUserByUserName @UserName";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { userName });
        }

        public bool Login(string userName, string password)
        {
            var query = "EXEC USP_Login @UserName , @PassWord";
            var results = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, password });
            return results.Rows.Count > 0;
        }
    }
}
