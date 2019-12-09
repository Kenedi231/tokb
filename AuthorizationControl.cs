using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.IO;

namespace MyAuthorization_form
{
    public partial class AuthorizationControl : UserControl
    {
        public EventHandler onClickSingIn;
        private List<object> userList = Program.state.GetUserList();
        private int countIncorrectPassword = 0;

        private Boolean loginIsNotEmpty = false;
        private Boolean passwordIsValid = false;

        Regex reg = new Regex(@"[^A-Za-z\*\-\+\/\%]");

        public AuthorizationControl()
        {
            InitializeComponent();
        }

        private void setEnabledButton()
        {
            loginButton.Enabled = loginIsNotEmpty && passwordIsValid;
        }

        private void ShowMessage(String text)
        {
            MessageBox message = new MessageBox(text);
            message.ShowDialog();
        }

        public void updateComponent()
        {
            userList = Program.state.GetUserList();
        }

        private void onSignIn(object sender, EventArgs e)
        {
            String login = loginInput.Text;
            String password = passwordInput.Text;

            Boolean matchLogin = false;
            object[] currentUser = { 0, "0", "1", UserType.user };

            foreach (object[] value in userList)
            {
                if (value[1] as String == login)
                {
                    matchLogin = true;
                    currentUser = value;
                    break;
                }
            }

            if (!matchLogin)
            {
                ShowMessage("No such user!");
                return;
            }
            if (password != currentUser[2] as String)
            {
                ShowMessage("Incorrect password!");
                countIncorrectPassword++;
                if (countIncorrectPassword == 3)
                {
                    Application.Exit();
                }
                return;
            }
            if (currentUser[5] as String == "1")
            {
                ShowMessage("You`re blocked!");
                return;
            }
            Program.state.SetUser(currentUser);
            WriteIDToStateFile(currentUser[0] as Int16?);
            loginInput.Text = "";
            passwordInput.Text = "";
            onClickSingIn?.Invoke(sender, e);
        }

        public void WriteIDToStateFile(Int16? ID)
        {
            if (File.Exists("state.txt"))
            {
                File.WriteAllText("state.txt", ID.ToString());
            }
            else
            {
                File.Create("state.txt").Close();
                File.WriteAllText("state.txt", ID.ToString());
            }
        }

        private void onLoginChange(object sender, EventArgs e)
        {
            String text = loginInput.Text;
            loginIsNotEmpty = text.Length != 0;
            setEnabledButton();
        }

        private void onChangePassword(object sender, EventArgs e)
        {
            String passText = passwordInput.Text;
            MatchCollection matches = reg.Matches(passText);
            passwordIsValid = matches.Count == 0;
            errorPass.Visible = !passwordIsValid;
            setEnabledButton();

        }
    }
}
