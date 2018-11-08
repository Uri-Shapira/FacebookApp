using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace A19_Ex01_Aline_000802480_Uri_201465234
{
    public partial class MainForm : Form
    {
        User m_LoggedInUser;

        public MainForm()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 200;
            FacebookWrapper.FacebookService.s_FbApiVersion = 2.8f;
            loginAndInit();
        }

        private void loginAndInit()
        {
            // Use the FacebookService.Login method to display the login form to any user who wish to use this application.
            //  You can then save the result.AccessToken for future auto-connect to this user:
            LoginResult result = FacebookService.Login("2169376336723441", "user_birthday");

            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                m_LoggedInUser = result.LoggedInUser;
                fetchUserInfo();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
    }
