namespace MyAuthorization_form
{
    partial class OnEditUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.blockCheckBox = new System.Windows.Forms.CheckBox();
            this.limitPassCheckbox = new System.Windows.Forms.CheckBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // usernameInput
            // 
            this.usernameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameInput.Location = new System.Drawing.Point(16, 40);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(203, 26);
            this.usernameInput.TabIndex = 1;
            this.usernameInput.TextChanged += new System.EventHandler(this.OnLoginTextChanged);
            // 
            // blockCheckBox
            // 
            this.blockCheckBox.AutoSize = true;
            this.blockCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.blockCheckBox.Location = new System.Drawing.Point(16, 83);
            this.blockCheckBox.Name = "blockCheckBox";
            this.blockCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.blockCheckBox.Size = new System.Drawing.Size(67, 24);
            this.blockCheckBox.TabIndex = 2;
            this.blockCheckBox.Text = "Block";
            this.blockCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.blockCheckBox.UseVisualStyleBackColor = true;
            this.blockCheckBox.CheckedChanged += new System.EventHandler(this.OnBlockCheckChanged);
            // 
            // limitPassCheckbox
            // 
            this.limitPassCheckbox.AutoSize = true;
            this.limitPassCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.limitPassCheckbox.Location = new System.Drawing.Point(16, 113);
            this.limitPassCheckbox.Name = "limitPassCheckbox";
            this.limitPassCheckbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.limitPassCheckbox.Size = new System.Drawing.Size(128, 24);
            this.limitPassCheckbox.TabIndex = 2;
            this.limitPassCheckbox.Text = "Password limit";
            this.limitPassCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.limitPassCheckbox.UseVisualStyleBackColor = true;
            this.limitPassCheckbox.CheckedChanged += new System.EventHandler(this.OnLimitCheckedChanged);
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(16, 160);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(128, 38);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.OnSaveClick);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(230, 160);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(128, 38);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.OnCancelClick);
            // 
            // OnEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 219);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.limitPassCheckbox);
            this.Controls.Add(this.blockCheckBox);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.label1);
            this.Name = "OnEditUser";
            this.Text = "OnEditUser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.CheckBox blockCheckBox;
        private System.Windows.Forms.CheckBox limitPassCheckbox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}