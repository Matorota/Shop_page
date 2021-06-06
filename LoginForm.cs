using MySql.Data.MySqlClient;
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
        DBConnectcs dBCon = new DBConnectcs();
        public static string SelVardas;
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

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



        private void Button_login_Click(object sender, EventArgs e)
        {
            if (TextBox_username.Text == "" || TextBox_password.Text == "")
            {
                MessageBox.Show("Pamirsote username ir slaptazodi parasyti", "truksta  informacijos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (comboBox_Rolės.SelectedIndex > -1)
                {
                    if (comboBox_Rolės.SelectedItem.ToString() == "Admin")
                    {
                        if (TextBox_username.Text == "Admin" && TextBox_password.Text == "123")
                        {
                            PardavejasForm product = new PardavejasForm();
                            product.Show();
                            this.Hide();
                        }
                        else MessageBox.Show("jei easate adminas, prasau iveskite teisinga id ir slaptazodi", "Truksta info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string selectQuery = "SELECT * FROM Seller where Vardas='" + TextBox_username.Text + "'AND Slaptazodis='" + TextBox_password.Text + "'";
                        DataTable table = new DataTable();
                        MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, dBCon.GetCon());

                        adapter.Fill(table);
                        if (table.Rows.Count > 0)
                        {
                            SelVardas = TextBox_username.Text;
                            ParduotiForm1 Parduoti = new ParduotiForm1();
                            Parduoti.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Blogas Username ARBA slaptazodis", "bloga informacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Pasirinkite role ", "bloga informacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
