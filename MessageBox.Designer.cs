namespace MyAuthorization_form
{
    partial class MessageBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.warningText = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // warningText
            // 
            this.warningText.AutoEllipsis = true;
            this.warningText.AutoSize = true;
            this.warningText.Dock = System.Windows.Forms.DockStyle.Top;
            this.warningText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.warningText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.warningText.Location = new System.Drawing.Point(0, 0);
            this.warningText.Name = "warningText";
            this.warningText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.warningText.Size = new System.Drawing.Size(325, 24);
            this.warningText.TabIndex = 0;
            this.warningText.Text = "Something message das  dasl  ldska  dlask ";
            this.warningText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.warningText.UseCompatibleTextRendering = true;
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okButton.Location = new System.Drawing.Point(142, 139);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(104, 36);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.onClickOkButton);
            // 
            // MessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(385, 187);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.warningText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MessageBox";
            this.Text = "Warning!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.onFormClosing);
            this.Load += new System.EventHandler(this.MessageBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label warningText;
        private System.Windows.Forms.Button okButton;
    }
}