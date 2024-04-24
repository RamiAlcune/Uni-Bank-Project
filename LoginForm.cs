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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }
        private string Password = "12345678";
        private string UserName = "Rami";
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(tbUserName.Text != UserName)
            {
                MessageBox.Show("UserName Not Available!");

            }
            else
            {
                if (tbPassword.Text == Password)
                {
                    this.Hide();
                    Form f2 = new BankProjectPannel();
                    f2.ShowDialog();
                    f2 = null;
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Fail!");
                }
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://github.com/RamiAlcune";
            System.Diagnostics.Process.Start(url);
        }

        private void LoginButton_MouseEnter(object sender, EventArgs e)
        {
            LoginButton.BackColor = Color.White;
        }

        private void LoginButton_MouseLeave(object sender, EventArgs e)
        {
            LoginButton.BackColor = Color.DarkOrchid;
        }

        private void LoginButton_MouseHover(object sender, EventArgs e)
        {
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
