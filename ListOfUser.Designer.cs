namespace MyAuthorization_form
{
    partial class ListOfUser
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
            this.backButton = new System.Windows.Forms.Button();
            this.listUserView = new System.Windows.Forms.ListView();
            this.addUser = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(627, 374);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(170, 46);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.onClickBackButton);
            // 
            // listUserView
            // 
            this.listUserView.AutoArrange = false;
            this.listUserView.HideSelection = false;
            this.listUserView.Location = new System.Drawing.Point(0, 0);
            this.listUserView.MultiSelect = false;
            this.listUserView.Name = "listUserView";
            this.listUserView.Size = new System.Drawing.Size(612, 423);
            this.listUserView.TabIndex = 2;
            this.listUserView.UseCompatibleStateImageBehavior = false;
            this.listUserView.View = System.Windows.Forms.View.Details;
            this.listUserView.SelectedIndexChanged += new System.EventHandler(this.listUserView_SelectedIndexChanged);
            // 
            // addUser
            // 
            this.addUser.Location = new System.Drawing.Point(627, 4);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(170, 39);
            this.addUser.TabIndex = 3;
            this.addUser.Text = "Add";
            this.addUser.UseVisualStyleBackColor = true;
            this.addUser.Click += new System.EventHandler(this.onAddUser);
            // 
            // editButton
            // 
            this.editButton.Enabled = false;
            this.editButton.Location = new System.Drawing.Point(627, 49);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(170, 39);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.OnEditClick);
            // 
            // deleteUser
            // 
            this.deleteUser.Enabled = false;
            this.deleteUser.Location = new System.Drawing.Point(627, 94);
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(170, 39);
            this.deleteUser.TabIndex = 3;
            this.deleteUser.Text = "Delete";
            this.deleteUser.UseVisualStyleBackColor = true;
            this.deleteUser.Click += new System.EventHandler(this.onDeleteUser);
            // 
            // ListOfUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deleteUser);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addUser);
            this.Controls.Add(this.listUserView);
            this.Controls.Add(this.backButton);
            this.Name = "ListOfUser";
            this.Size = new System.Drawing.Size(800, 423);
            this.Enter += new System.EventHandler(this.ListOfUser_Enter);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ListView listUserView;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteUser;
    }
}
