using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mysql_ir_CSharp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void LoginForm_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Black;
        }

        private void label_Clear_MouseEnter(object sender, EventArgs e)
        {
            label_Clear.ForeColor = Color.Red;
        }

        private void label_Clear_MouseLeave(object sender, EventArgs e)
        {
            label_Clear.ForeColor = Color.Goldenrod;
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_Clear_Click(object sender, EventArgs e)
        {
            TextBox_username.Clear();
            TextBox_password.Clear();
        }
    }
}
