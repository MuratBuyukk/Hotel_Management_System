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

namespace HMS.GUI.Forms
{
    public partial class MainForm : Form
    {
        UserBusiness userBusiness = new UserBusiness();

        public MainForm()
        {
            InitializeComponent();
            labelUserName.Text = "Welcome " + userBusiness.ActiveUserName();
            labelFormName.Visible = false;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            userBusiness.DeactivetUserStatus();
            Application.Exit();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            RoomForm roomForm = new RoomForm();
            roomForm.TopLevel = false;
            bntMainPanel.Controls.Clear();
            bntMainPanel.Controls.Add(roomForm);
            roomForm.BringToFront();
            roomForm.Show();
            labelFormName.Visible = true;
            labelFormName.Text = "Rooms";
        }

        private void btnCreateBooking_Click(object sender, EventArgs e)
        {
            CreateBookingForm createBookingForm = new CreateBookingForm();
            createBookingForm.TopLevel = false;
            bntMainPanel.Controls.Clear();
            bntMainPanel.Controls.Add(createBookingForm);
            createBookingForm.BringToFront();
            createBookingForm.Show();
            labelFormName.Visible = true;
            labelFormName.Text = "Create Booking";
        }

        private void btnRezervationList_Click(object sender, EventArgs e)
        {
            RezervationListForm rezervationList = new RezervationListForm();
            rezervationList.TopLevel = false;
            bntMainPanel.Controls.Clear();
            bntMainPanel.Controls.Add(rezervationList);
            rezervationList.BringToFront();
            rezervationList.Show();
            labelFormName.Visible = true;
            labelFormName.Text = "Rezervation List";
        }

        private void btnAccomadationList_Click(object sender, EventArgs e)
        {
            AccomadationListForm accomadationListForm = new AccomadationListForm();
            accomadationListForm.TopLevel = false;
            bntMainPanel.Controls.Clear();
            bntMainPanel.Controls.Add(accomadationListForm);
            accomadationListForm.BringToFront();
            accomadationListForm.Show();
            labelFormName.Visible = true;
            labelFormName.Text = "Accomadation List";
        }

        private void btnDepartedList_Click(object sender, EventArgs e)
        {
            DepartedListForm departedListForm = new DepartedListForm();
            departedListForm.TopLevel = false;
            bntMainPanel.Controls.Clear();
            bntMainPanel.Controls.Add(departedListForm);
            departedListForm.BringToFront();
            departedListForm.Show();
            labelFormName.Visible = true;
            labelFormName.Text = "Departed List";
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            var items = userBusiness.GetAll();
            foreach(var item in items)
            {
                if(item.UserStatus)
                {
                    if(item.IsAdmin == true)
                    {
                        UserForm userForm = new UserForm();
                        userForm.TopLevel = false;
                        bntMainPanel.Controls.Clear();
                        bntMainPanel.Controls.Add(userForm);
                        userForm.BringToFront();
                        userForm.Show();
                        labelFormName.Visible = true;
                        labelFormName.Text = "User Form";
                    }
                    else
                    {
                        MessageBox.Show("You cannot acces user field, you are not admin!","Error",MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            DashBoardForm dashBoardForm = new DashBoardForm();
            dashBoardForm.TopLevel = false;
            bntMainPanel.Controls.Clear();
            bntMainPanel.Controls.Add(dashBoardForm);
            dashBoardForm.BringToFront();
            dashBoardForm.Show();
            labelFormName.Visible = true;
            labelFormName.Text = "Dashboard";
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            userBusiness.DeactivetUserStatus();
            this.Hide();
            loginForm.Show();
        }
    }
}
