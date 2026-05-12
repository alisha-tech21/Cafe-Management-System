using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cafe_Management_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            AddProducts P = new AddProducts();
            P.Location = new Point(this.Location.X + 292, this.Location.Y + 0);
            P.Show();
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            Order O = new Order();
            O.Location = new Point(this.Location.X + 292, this.Location.Y + 0);
            O.Show();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Login F = new Login();
            F.Show();
            this.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;
        }

        private void BtnCustomer_Click(object sender, EventArgs e)
        {
            Customer C = new Customer();
            C.Location = new Point(this.Location.X + 292, this.Location.Y + 0);
            C.Show();
        }

        private void BtnViewOrder_Click(object sender, EventArgs e)
        {
            ViewOrder VO = new ViewOrder();
            VO.Location = new Point(this.Location.X + 292, this.Location.Y + 0);
            VO.Show();
        }

       
    }
}
