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
    public partial class DepartedListForm : Form
    {
        public DepartedListForm()
        {
            InitializeComponent();
        }
        BookingBusiness bookingBusiness = new BookingBusiness();

        private void bindDepartedList()
        {
            var items = bookingBusiness.GetDepartedList();
            dgvBooking.DataSource = items;
            dgvBooking.Cursor = Cursors.Default;
        }

        private void DepartedListForm_Load(object sender, EventArgs e)
        {
            bindDepartedList();
        }
    }
}
