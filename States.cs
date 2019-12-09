using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAuthorization_form
{
    class States
    {
        private object[] currentUser = { -1, "-1", "-1", "-1", "1", "1"}; // ID LOGIN PASS ROLE LIMIT BLOCK
        private List<object> userList = new List<object>();

        public void SetUserList(List<object> UserList)
        {
            userList = UserList;
        }

        public List<object> GetUserList()
        {
            return userList;
        }

        public void SetUser(object[] user)
        {
            currentUser = user;
        }

        public object[] GetUser()
        {
            return currentUser;
        }
    }
}
