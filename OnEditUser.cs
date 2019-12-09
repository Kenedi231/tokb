using System;
using System.Windows.Forms;

namespace MyAuthorization_form
{
    public partial class OnEditUser : Form
    {
        object[] user;
        private String loginText = "";
        private Boolean blockCheckbox = false;
        private Boolean limitCheckbox = false;

        public OnEditUser(object[] user)
        {
            this.user = user;
            InitializeComponent();

            limitCheckbox = user[4] as String == "1" ? true : false;
            blockCheckbox = user[5] as String == "1" ? true : false;
            limitPassCheckbox.Checked = limitCheckbox;
            blockCheckBox.Checked = blockCheckbox;
            usernameInput.Text = user[1] as String;
        }

        public void SetBlockCheckBox(Boolean value)
        {
            blockCheckbox = value;
        }

        public Boolean GetBlockCheckBox()
        {
            return blockCheckbox;
        }

        public void SetLimitCheckBox(Boolean value)
        {
            limitCheckbox = value;
        }

        public Boolean GetLimitCheckBox()
        {
            return limitCheckbox;
        }

        public void SetLoginText(String text)
        {
            loginText = text;
        }

        public String GetLoginText()
        {
            return loginText;
        }

        private void SetStatusSaveButton()
        {
            Boolean beginStateBlock = user?[5] as String == "1" ? true : false;
            Boolean beginStateLimit = user?[4] as String == "1" ? true : false;
            String beginStateLogin = user?[1] as String;
            saveButton.Enabled = (blockCheckbox != beginStateBlock) || (limitCheckbox != beginStateLimit) || (loginText != beginStateLogin);
        }

        private void OnCancelClick(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void OnLoginTextChanged(object sender, EventArgs e)
        {
            SetLoginText(usernameInput.Text);
            SetStatusSaveButton();
        }

        private void OnBlockCheckChanged(object sender, EventArgs e)
        {
            SetBlockCheckBox(blockCheckBox.Checked);
            SetStatusSaveButton();
        }

        private void OnLimitCheckedChanged(object sender, EventArgs e)
        {
            SetLimitCheckBox(limitPassCheckbox.Checked);
            SetStatusSaveButton();
        }

        private void OnSaveClick(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
