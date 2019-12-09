using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MyAuthorization_form
{
    public partial class ProfileControl : UserControl
    {
        private object[] currentUser = Program.state.GetUser();
        private List<object> userList = Program.state.GetUserList();
        ChangePassword changePassword = new ChangePassword();
        ListOfUser listOfUser = new ListOfUser();

        public EventHandler onListOfUserClick;
        public EventHandler onClickLogoutEvent;
        public ProfileControl()
        {
            InitializeComponent();

            // set event handler
            changePassword.onSaveClickHandler += new EventHandler(onChangePassword);
        }

        public void updateComponent() 
        {
            userList = Program.state.GetUserList();
            listOfUser.updateComponent();
        }

        private void onChangePassword(object sender, EventArgs e)
        {
            currentUser = Program.state.GetUser();
            Int16 pos = 0;
            foreach (object[] user in userList)
            {
                if (user[0] == currentUser[0])
                {
                    break;
                }
                pos++;
            }
            userList.RemoveAt(pos);
            userList.Insert(pos, currentUser);
            Program.state.SetUserList(userList);
            updateComponent();
            RewriteUsersFile();
        }

        private void RewriteUsersFile()
        {
            String replacedText = "";
            foreach (object[] user in userList)
            {
                replacedText += $"{user[0]} {user[1]} {user[2]} {user[3]} {user[4]} {user[5]}\n";
            }
            File.WriteAllText("users.txt", replacedText);
        }

        private void setProfileSettings(UserType? type, String username)
        {
            String userTypeValue = type == UserType.user ? "user" : "admin";
            welcomeMessage.Text = $"You are logged in as a {username}! (Role: {userTypeValue})";
            listOfUserButton.Visible = type == UserType.admin;
        }

        public void SetCurrentUser()
        {
            currentUser = Program.state.GetUser();
            setProfileSettings(currentUser[3] as UserType?, currentUser[1] as String);
            changePassword.UpdateComponent();
        }

        private void onClickLogout(object sender, EventArgs e)
        {
            onClickLogoutEvent?.Invoke(sender, e);
        }

        private void onClickListOfUser(object sender, EventArgs e)
        {
            listOfUser.updateComponent();
            onListOfUserClick?.Invoke(sender, e);
        }

        private void OnChangePasswordClick(object sender, EventArgs e)
        {
            changePassword.ShowDialog();
        }
    }
}
