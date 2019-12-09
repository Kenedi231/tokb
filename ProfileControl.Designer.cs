namespace MyAuthorization_form
{
    partial class ProfileControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.welcomeMessage = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.listOfUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeMessage
            // 
            this.welcomeMessage.AutoSize = true;
            this.welcomeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.welcomeMessage.Location = new System.Drawing.Point(256, 10);
            this.welcomeMessage.Name = "welcomeMessage";
            this.welcomeMessage.Size = new System.Drawing.Size(241, 24);
            this.welcomeMessage.TabIndex = 1;
            this.welcomeMessage.Text = "You are logged in as a user";
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoutButton.Location = new System.Drawing.Point(659, 359);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(122, 44);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.Text = "Log out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.onClickLogout);
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changePasswordButton.Location = new System.Drawing.Point(34, 55);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(168, 45);
            this.changePasswordButton.TabIndex = 3;
            this.changePasswordButton.Text = "Change password";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            this.changePasswordButton.Click += new System.EventHandler(this.OnChangePasswordClick);
            // 
            // listOfUserButton
            // 
            this.listOfUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listOfUserButton.Location = new System.Drawing.Point(34, 106);
            this.listOfUserButton.Name = "listOfUserButton";
            this.listOfUserButton.Size = new System.Drawing.Size(168, 45);
            this.listOfUserButton.TabIndex = 3;
            this.listOfUserButton.Text = "List of user";
            this.listOfUserButton.UseVisualStyleBackColor = true;
            this.listOfUserButton.Click += new System.EventHandler(this.onClickListOfUser);
            // 
            // ProfileControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listOfUserButton);
            this.Controls.Add(this.changePasswordButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.welcomeMessage);
            this.Name = "ProfileControl";
            this.Size = new System.Drawing.Size(800, 423);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label welcomeMessage;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.Button listOfUserButton;
    }
}
