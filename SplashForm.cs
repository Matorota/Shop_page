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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        int StartPoint = 0;
        private void SplashForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            StartPoint += 2;
            PoProgressBar.Value = StartPoint;
            if (PoProgressBar.Value == 100) 
            {
                PoProgressBar.Value = 0;
                timer1.Stop();
                LoginForm loginForm = new LoginForm();
                this.Hide();
                loginForm.Show();
            }
        }
    }
}
