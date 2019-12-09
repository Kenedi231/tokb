using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

enum UserType
{
    user,
    admin,
};

namespace MyAuthorization_form
{
    public partial class MainForm : Form
    {
        // users array
        public List<object> users = new List<object>();

        AboutProgram aboutProgram = new AboutProgram();
        AuthorizationControl authorization = new AuthorizationControl();
        ProfileControl profile = new ProfileControl();
        ListOfUser listOfUser = new ListOfUser();

        private void navigation(Control pointNav)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(pointNav);
        }

        public MainForm()
        {
            getListUsers();
            InitializeComponent();

            getPrevState();


            // set event handler
            authorization.onClickSingIn += new EventHandler(onClickSingIn);
            listOfUser.onClickBackButtonEvent += new EventHandler(onClickBackFromListOfUsers);
            profile.onClickLogoutEvent += new EventHandler(onClickLogout);
            profile.onListOfUserClick += new EventHandler(onClickListOfUser);
        }

        private void getPrevState()
        {
            if (!File.Exists("state.txt"))
            {
                navigation(authorization);
                return;
            }
            StreamReader sr = new StreamReader("state.txt");
            String line = sr.ReadLine();
            Boolean isNotMatch = true;
            Int16 ID = Int16.Parse(line);
            foreach (object[] user in users)
            {
                if (user[0] as Int16? == ID)
                {
                    Program.state.SetUser(user);
                    profile.SetCurrentUser();
                    navigation(profile);
                    isNotMatch = false;
                    break;
                }
            }
            if (isNotMatch)
            {
                navigation(authorization);
            }

            sr.Close();
        }

        // ID LOGIN password     ROLE LIMIT BLOCK
        public void getListUsers()
        {
            StreamReader sr = new StreamReader("users.txt");
            String line;
            users = new List<object>();

            while ((line = sr.ReadLine()) != null)
            {
                String[] splitedText = line.Split(' ');
                UserType type = splitedText[3] == "user" ? UserType.user : UserType.admin;
                object[] user = { Int16.Parse(splitedText[0]), splitedText[1], splitedText[2], type, splitedText[4], splitedText[5] };
                users.Add(user);
            }

            Program.state.SetUserList(users);
            users = Program.state.GetUserList();
            profile.updateComponent();
            authorization.updateComponent();
            sr.Close();
        }

        private void onClickSingIn(object sender, EventArgs e)
        {
            profile.SetCurrentUser();
            navigation(profile);
        }

        private void onClickLogout(object sender, EventArgs e)
        {
            File.Delete("state.txt");
            getListUsers();
            navigation(authorization);
        }

        private void onClickListOfUser(object sender, EventArgs e)
        {
            navigation(listOfUser);
        }

        private void onClickBackFromListOfUsers(object sender, EventArgs e)
        {
            navigation(profile);
        }

        private void onClickAboutProgram(object sender, EventArgs e)
        {
            aboutProgram.ShowDialog();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
