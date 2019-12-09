using System;
using System.Windows.Forms;

namespace MyAuthorization_form
{
    public partial class ChangePassword : Form
    {
        public EventHandler onSaveClickHandler;
        private object[] currentUser = Program.state.GetUser();
        Boolean isNotEmptyCurrentPassword = false;
        Boolean isNotEmptyNewPassword = false;

        public ChangePassword()
        {
            InitializeComponent();
        }

        private void ShowMessage(String text)
        {
            MessageBox message = new MessageBox(text);
            message.ShowDialog();
        }

        public void UpdateComponent()
        {
            currentUser = Program.state.GetUser();
        }

        public void SetCurrentUser()
        {
            currentUser = Program.state.GetUser();
        }

        private void OnSaveClick(object sender, EventArgs e)
        {
            String currentUserPassword = currentUser[2] as String;
            String currentInputPassword = currentPassword.Text;
            String newPass = newPassword.Text;
            if (currentInputPassword != currentUserPassword)
            {
                ShowMessage("Wrong current password!");
                return;
            }

            if (currentInputPassword == newPass)
            {
                ShowMessage("You entered the same password!");
                return;
            }

            object[] updateUser = { currentUser[0], currentUser[1], newPass, currentUser[3], currentUser[4], currentUser[5] };
            Program.state.SetUser(updateUser);
            ShowMessage("Password changed successfully!");
            onSaveClickHandler?.Invoke(sender, e);
            currentUser = Program.state.GetUser();
            this.Hide();
        }

        private void OnCancelClick(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            currentPassword.Text = "";
            newPassword.Text = "";
            this.Hide();
        }

        private void onCurrentPassChanged(object sender, EventArgs e)
        {
            isNotEmptyCurrentPassword = currentPassword.Text.Length != 0;
            saveButton.Enabled = isNotEmptyCurrentPassword && isNotEmptyNewPassword;
        }

        private void onNewPassChanged(object sender, EventArgs e)
        {
            isNotEmptyNewPassword = newPassword.Text.Length != 0;
            saveButton.Enabled = isNotEmptyCurrentPassword && isNotEmptyNewPassword;
        }
    }
}
