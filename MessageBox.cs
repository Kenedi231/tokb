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
    public partial class MessageBox : Form
    {

        public MessageBox(string text)
        {
            InitializeComponent();

            warningText.AutoSize = false;
            warningText.TextAlign = ContentAlignment.MiddleCenter;

            warningText.Text = text;
        }

        private void onClickOkButton(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void onFormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void MessageBox_Load(object sender, EventArgs e)
        {

        }
    }
}
