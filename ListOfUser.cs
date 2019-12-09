using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyAuthorization_form
{
    public partial class ListOfUser : UserControl
    {
        public EventHandler onClickBackButtonEvent;
        private Int32 selectedRow = -1;
        private List<object> userList = Program.state.GetUserList();

        ConfirmDialog confirmDialog = new ConfirmDialog();
        AddNewUser addNewUser = new AddNewUser();
        public ListOfUser()
        {
            userList = Program.state.GetUserList();
            InitializeComponent();

            ColumnHeader ID = new ColumnHeader("ID");
            ColumnHeader Login = new ColumnHeader("Login");
            ColumnHeader Password = new ColumnHeader("Password");
            ColumnHeader Role = new ColumnHeader("Role");
            ColumnHeader Limit = new ColumnHeader("Limit");
            ColumnHeader Blocking = new ColumnHeader("Blocking");
            ID.Text = "ID";
            Login.Text = "Login";
            Password.Text = "Password";
            Role.Text = "Role";
            Limit.Text = "Limit";
            Blocking.Text = "Blocking";
            listUserView.Columns.AddRange(new ColumnHeader[] { ID, Login, Password, Role, Limit, Blocking });
            listUserView.FullRowSelect = true;
            listUserView.GridLines = true;
            listUserView.View = View.Details;
        }

        private void ShowMessage(String text)
        {
            MessageBox message = new MessageBox(text);
            message.ShowDialog();
        }

        public void setUsersInTable()
        {
            List<ListViewItem> listItems = new List<ListViewItem>();
            foreach (object[] user in userList)
            {
                ListViewItem userItem = new ListViewItem($"{user[0]}", 0);
                userItem.SubItems.Add($"{user[1]}");
                userItem.SubItems.Add("**********");
                String role = user[3] as UserType? == UserType.user ? "user" : "admin";
                userItem.SubItems.Add(role);
                String limit = user[4] as String == "1" ? "Yes" : "No";
                String blocking = user[5] as String == "1" ? "Yes" : "No";
                userItem.SubItems.Add(limit);
                userItem.SubItems.Add(blocking);

                listItems.Add(userItem);
            }

            listUserView.Items.AddRange(listItems.ToArray());
        }
        private void RewriteUsersFile()
        {
            String replacedText = "";
            foreach (object[] user in userList)
            {
                replacedText += $"{user[0]} {user[1]} {user[2]} {user[3]} {user[4]} {user[5]}\n";
            }
            File.WriteAllText("users.txt", replacedText);
        }

        public void updateComponent()
        {
            userList = Program.state.GetUserList();
            setUsersInTable();
        }

        private void onClickBackButton(object sender, EventArgs e)
        {
            onClickBackButtonEvent?.Invoke(sender, e);
        }

        private void update()
        {
            listUserView.Items.Clear();
            userList = Program.state.GetUserList();
            setUsersInTable();
            listUserView.Refresh();
            this.Update();
            Application.DoEvents();
        }

        private void ListOfUser_Enter(object sender, EventArgs e)
        {
            update();
        }

        private void listUserView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listUserView.SelectedItems.Count > 0)
            {
                selectedRow = listUserView.Items.IndexOf(listUserView.SelectedItems[0]);
            } else
            {
                selectedRow = -1;
            }
            editButton.Enabled = selectedRow != -1;
            deleteUser.Enabled = selectedRow != -1;
        }

        private void onDeleteUser(object sender, EventArgs e)
        {
            confirmDialog.UpdateComponent();
            confirmDialog.ShowDialog();
            Boolean answer = confirmDialog.GetAnswer();
            confirmDialog.SetAnswer(false);
            if (answer)
            {
                userList.RemoveAt(selectedRow);
                selectedRow = -1;
                Program.state.SetUserList(userList);
                RewriteUsersFile();
                ShowMessage("User was deleted!");
                update();
            }
        }

        private Int16 GetFreeID()
        {
            Int16 id = 0;
            Boolean work = true;
            while (work)
            {
                work = false;
                id++;
                foreach (object[] user in userList)
                {
                    if (user[0] as Int16? == id)
                    {
                        work = true;
                        break;
                    }
                };
            }

            return id;
        }

        private void onAddUser(object sender, EventArgs e)
        {
            confirmDialog.UpdateComponent();
            addNewUser.UpdateComponent();
            confirmDialog.ShowDialog();
            Boolean answer = confirmDialog.GetAnswer();
            confirmDialog.SetAnswer(false);
            if (!answer)
            {
                return;
            }
            addNewUser.ShowDialog();
            Boolean isCreateUser = addNewUser.GetCreateUser();
            if (!isCreateUser)
            {
                return;
            }
            String login = addNewUser.GetLoginText();
            String pass = addNewUser.GetPassText();
            addNewUser.ClearData();
            object[] newUser = { GetFreeID(), login, pass, "user", "0", "0" };
            userList.Add(newUser);
            Program.state.SetUserList(userList);
            RewriteUsersFile();
            update();
            ShowMessage("User was created!");
        }

        private void OnEditClick(object sender, EventArgs e)
        {
            confirmDialog.UpdateComponent();
            confirmDialog.ShowDialog();
            Boolean answer = confirmDialog.GetAnswer();
            confirmDialog.SetAnswer(false);
            if (!answer)
            {
                return;
            }
            OnEditUser onEditUser = new OnEditUser(userList[selectedRow] as object[]);
            onEditUser.ShowDialog();
            object[] user = userList[selectedRow] as object[];
            String loginText = onEditUser.GetLoginText();
            String block = onEditUser.GetBlockCheckBox() ? "1" : "0";
            String limit = onEditUser.GetLimitCheckBox() ? "1" : "0";
            object[] updateUser = { user[0], loginText, user[2], user[3], limit, block };
            userList.RemoveAt(selectedRow);
            userList.Insert(selectedRow, updateUser);
            Program.state.SetUserList(userList);
            RewriteUsersFile();
            update();
            ShowMessage("User was updated!");
        }
    }
}
