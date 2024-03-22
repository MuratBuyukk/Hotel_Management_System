using HMS.Business.Repository.Concrete;
using HMS.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.GUI.Forms
{
    public partial class UserForm : Form
    {
        int userIdValue;
        public UserForm()
        {
            InitializeComponent();
        }

        UserBusiness userBusiness = new UserBusiness();
        private void bindUser()
        {
            var items = userBusiness.GetUsers();
            dgvUser.DataSource = items;
            dgvUser.Cursor = Cursors.Default;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            bindUser();
        }

        private void dgvUser_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = dgvUser.Rows[e.RowIndex];
            userIdValue = (int)selectedRow.Cells["UserId"].Value;
            tbUserName.Text = selectedRow.Cells["UserName"].Value.ToString();
            tbPassword.Text = selectedRow.Cells["Password"].Value.ToString();
            tbEmail.Text = selectedRow.Cells["Email"].Value.ToString();
            tbStatus.Text = selectedRow.Cells["UserStatus"].Value.ToString();
            tbAdmin.Text = selectedRow.Cells["IsAdmin"].Value.ToString();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if(tbUserName.Text == "" || tbEmail.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Please Fill All Required Fields",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to add new user?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    userBusiness.Add(new User
                    {
                        UserName = tbUserName.Text,
                        Password = tbPassword.Text,
                        Email = tbEmail.Text,
                        UserStatus = false,
                        IsAdmin = false,
                    });
                    dgvUser.DataSource = userBusiness.GetUsers();
                }
            }
        }

        private void btnClearRoom_Click(object sender, EventArgs e)
        {
            tbUserName.Clear();
            tbPassword.Clear();
            tbEmail.Clear();
            tbStatus.Clear();
            tbAdmin.Clear();
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to remove this user?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                userBusiness.Delete(userIdValue);
                dgvUser.DataSource = userBusiness.GetUsers();
            }
        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            if (tbUserName.Text == "" || tbEmail.Text == "" || tbPassword.Text == "" ||
                tbStatus.Text == "" || tbAdmin.Text == "" || userIdValue.Equals(""))
            {
                MessageBox.Show("Please Fill All Required Fields",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to add new user?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    userBusiness.Update(new User
                    {
                        UserId = userIdValue,
                        UserName = tbUserName.Text,
                        Password = tbPassword.Text,
                        Email = tbEmail.Text,
                        UserStatus = false,
                        IsAdmin = false,
                    });
                    dgvUser.DataSource = userBusiness.GetUsers();
                }
            }
        }

        private void btnMakeAdmin_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to make admin this user?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if(tbAdmin.Text == "False")
                {
                    userBusiness.Update(new User
                    {
                        UserId = userIdValue,
                        UserName = tbUserName.Text,
                        Password = tbPassword.Text,
                        Email = tbEmail.Text,
                        UserStatus = false,
                        IsAdmin = true,
                    });
                    dgvUser.DataSource = userBusiness.GetUsers();
                }
                else
                {
                    userBusiness.Update(new User
                    {
                        UserId = userIdValue,
                        UserName = tbUserName.Text,
                        Password = tbPassword.Text,
                        Email = tbEmail.Text,
                        UserStatus = false,
                        IsAdmin = false,
                    });
                    dgvUser.DataSource = userBusiness.GetUsers();
                }
               
            }
        }
    }
}
