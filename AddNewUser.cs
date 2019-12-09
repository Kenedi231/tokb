using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAuthorization_form
{
    public partial class AddNewUser : Form
    {
        private List<object> userList = Program.state.GetUserList();
        private Boolean okButton = false;
        private Boolean createUser = false;
        private String loginText = "";
        private String passText = "";
        public AddNewUser()
        {
            InitializeComponent();
        }

        public void UpdateComponent()
        {
            userList = Program.state.GetUserList();
        }

        private void ShowMessage(String text)
        {
            MessageBox message = new MessageBox(text);
            message.ShowDialog();
        }

        public void ClearData()
        {
            loginInput.Text = "";
            passwordInput.Text = "";
        }

        private void OnCancelClick(object sender, EventArgs e)
        {
            ClearData();
            this.Hide();
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (!okButton)
            {
                ClearData();
            }
            e.Cancel = true;
            okButton = false;
            this.Hide();
        }

        public void SetLoginText(String text)
        {
            loginText = text;
        }

        public String GetLoginText()
        {
            return loginText;
        }

        public void SetPassText(String text)
        {
            passText = text;
        }

        public String GetPassText()
        {
            return passText;
        }

        public void SetCreateUser(Boolean create)
        {
            createUser = create;
        }

        public Boolean GetCreateUser()
        {
            return createUser;
        }

        private void OnLoginChanged(object sender, EventArgs e)
        {
            createButton.Enabled = loginInput.Text.Length != 0 && passwordInput.Text.Length != 0;
            SetLoginText(loginInput.Text);
        }

        private void OnPassChanged(object sender, EventArgs e)
        {
            createButton.Enabled = loginInput.Text.Length != 0 && passwordInput.Text.Length != 0;
            SetPassText(passwordInput.Text);
        }

        private void OnCreateUser(object sender, EventArgs e)
        {
            okButton = true;
            foreach (object[] user in userList)
            {
                if (user[1] as String == loginText)
                {
                    ShowMessage("Such a user already exists!");
                    okButton = false;
                    SetCreateUser(false);
                    return;
                }
            }

            SetCreateUser(true);
            this.Hide();
        }
    }
}
