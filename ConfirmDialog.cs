using System;
using System.Windows.Forms;

namespace MyAuthorization_form
{
    public partial class ConfirmDialog : Form
    {
        private object[] currentUser = Program.state.GetUser();
        private Boolean answer = false;
        public ConfirmDialog()
        {
            InitializeComponent();
        }

        public Boolean GetAnswer()
        {
            return answer;
        }

        public void SetAnswer(Boolean answer)
        {
            this.answer = answer;
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

        private void onCancel(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void onClosing(object sender, FormClosingEventArgs e)
        {
            if (!answer)
            {
                passInput.Text = "";
            }
            e.Cancel = true;
            this.Hide();
        }

        private void OnPasswordChanged(object sender, EventArgs e)
        {
            String pass = passInput.Text;
            SetAnswer(false);
            confirmButton.Enabled = pass.Length != 0;
        }

        private void onConfirmPass(object sender, EventArgs e)
        {
            String pass = passInput.Text;
            String userPassword = currentUser[2] as String;
            if (pass == userPassword)
            {
                passInput.Text = "";
                SetAnswer(true);
                this.Hide();
            }
            else
            {
                SetAnswer(false);
                ShowMessage("Incorrect password!");
            }
        }
    }
}
