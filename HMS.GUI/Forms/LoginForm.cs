
using HMS.Business.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HMS.GUI.Forms
{
    public partial class LoginForm : Form
    {
        UserBusiness userBusiness = new UserBusiness();
        public LoginForm()
        {
            InitializeComponent();
            
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            
            String username = tbUserName.Text;
            String password = tbPassword.Text;
            bool loginCheck = false;
            var items = userBusiness.GetAll();

            foreach (var item in items)
            {
                if (item.UserName == username && item.Password == password)
                {
                    loginCheck = true;
                    userBusiness.Update(new Entities.User
                    {
                        UserId = item.UserId,
                        UserName = item.UserName,
                        Password = item.Password,
                        Email = item.Email,
                        UserStatus = true,
                        IsAdmin = item.IsAdmin,
                    });
                    break;
                }
            }
            if (loginCheck)
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login attempt. Please check your username and Password. " +
                    "İf you don't have an available account, please make contact your system admin",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}


