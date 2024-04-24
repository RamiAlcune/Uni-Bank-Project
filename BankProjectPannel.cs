using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankProjectC_
{
    public partial class BankProjectPannel : Form
    {

        public BankProjectPannel()
        {
            
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            DateLabel.Text = DateOfWeek + "," + DateOfMonth + " " + DateofYear;
            TimeDate.Text = time;

        }

        private void ManageClients_MouseEnter(object sender, EventArgs e)
        {
            ManageClients.BackColor = Color.White;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            ManageClients.BackColor = Color.WhiteSmoke;
        }
        private string DateOfWeek = DateTime.Now.ToString("dddd");
        private string DateOfMonth = DateTime.Now.ToString("MMMM");
        private string DateofYear = DateTime.Now.Year.ToString();
        private string time = DateTime.Now.ToString("HH:mm tt");

        private void DateLabel_Click(object sender, EventArgs e)
        {

        }

        private void ManageClients_Click(object sender, EventArgs e)
        {
            Form frm3 = new BankProject_ManageClients();
            frm3.ShowDialog();
            this.Hide();
            frm3 = null;
            this.Show();
        }

        private void btnClientTransactions_Click(object sender, EventArgs e)
        {
            Form frm4 = new ClientTransactions();
            frm4.ShowDialog();
            this.Hide();
            frm4 = null;
            this.Show();
        }

        private void BankProjectPannel_Load(object sender, EventArgs e)
        {

        }
    }
}
