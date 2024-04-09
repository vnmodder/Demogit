using Demo3Layer.DAL;
using Demo3Layer.DTO;
using System.Data;

namespace Demo3Layer.BUS
{
    public class UserBUS
    {
        private readonly UserDAL _userDAL;

        public UserBUS()
        {
            _userDAL = new UserDAL();
        }

        /// <summary>
        /// Logins the specified username.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public bool Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return false;
            }

            return _userDAL.Login(username, password);
        }

        /// <summary>
        /// Gets the name of the user by user.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <returns></returns>
        public User? GetUserByUserName(string userName)
        {
            if (string.IsNullOrEmpty(userName) )
            {

                return null;
            }

            var data = _userDAL.GetUserByUserName(userName);
            if (data.Rows.Count > 0)
            {
                return new User((DataRow)data.Rows[0]);
            }

            return null;
        }
    }
}
