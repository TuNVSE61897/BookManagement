using Interface_Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApp
{
    public partial class LoginForm : Form
    {
        IBussinessLogic proxy;
        public LoginForm()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            ChannelFactory<IBussinessLogic> chanel = new ChannelFactory<IBussinessLogic>("ClientEndPoint");
            proxy = chanel.CreateChannel();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(5);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            int result=proxy.checkLogin(username, password);
            if (result == 1)
            {
                Form1 form= new Form1();
                this.Hide();
                form.WindowState = FormWindowState.Maximized;
                form.Show();
                
            }
            else if (result == 0)
            {
                EmployeeForm form2 = new EmployeeForm();
                form2.WindowState = FormWindowState.Maximized;

                this.Hide();
                form2.Show();
            }
            else {
                MessageBox.Show("Logoin Fail! Please Try Again!");
             
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
