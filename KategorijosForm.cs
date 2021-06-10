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
    public partial class KategorijosForm : Form
    {
        DBConnectcs dBCon = new DBConnectcs();
        public KategorijosForm()
        {
            InitializeComponent();
        }
        private void getTable() 
        {
            string selectQuerry = "SELECT * FROM Categorys";
            MySqlCommand command = new MySqlCommand(selectQuerry, dBCon.GetCon());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_kategorija.DataSource = table;
        }
        private void Button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Categorys VALUES(" + TextBox_id.Text + ",'" + TextBox_vardas.Text + "','" + TextBox_aprasymas.Text + "')";
                MySqlCommand command = new MySqlCommand(insertQuery, dBCon.GetCon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Kategorija pakrauta","kategorijos informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void comboBox_kategorijos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_refresh_Click(object sender, EventArgs e)
        {

        }

        private void KategorijosForm_Load(object sender, EventArgs e)
        {
            getTable();
        }

        private void Button_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_id.Text == "" || TextBox_vardas.Text == "" || TextBox_aprasymas.Text == "")
                {
                    MessageBox.Show("Truksta informacijos", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else { 
                string updateQuery = " UPDATE Categorys SET Vardas='" + TextBox_vardas.Text + "', Aprasymas='" + TextBox_aprasymas.Text + "' WHERE Id=" + TextBox_id.Text + " ";
                MySqlCommand command = new MySqlCommand(updateQuery, dBCon.GetCon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Kategorija updatinta gerai", "updatintos informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                getTable();
                    clear();
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView_product_Click(object sender, EventArgs e)
        {
            TextBox_id.Text = dataGridView_kategorija.SelectedRows[0].Cells[0].Value.ToString();
            TextBox_vardas.Text = dataGridView_kategorija.SelectedRows[0].Cells[1].Value.ToString();
            TextBox_aprasymas.Text = dataGridView_kategorija.SelectedRows[0].Cells[2].Value.ToString();
            
        }
        private void clear()
        {
            TextBox_id.Clear();
            TextBox_vardas.Clear();
            TextBox_aprasymas.Clear();
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string deleteQuery = "DELETE FROM Categorys WHERE Id=" + TextBox_id.Text + "";
                MySqlCommand command = new MySqlCommand(deleteQuery, dBCon.GetCon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Kategorija istrinta", "istrinimo informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                getTable();
                clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }        
        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Blue;
        }

        private void label_Logout_MouseEnter(object sender, EventArgs e)
        {
            label_Logout.ForeColor = Color.Red;
        }

        private void label_Logout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void label_Logout_MouseLeave(object sender, EventArgs e)
        {
            label_Logout.ForeColor = Color.Blue;
        }

        private void button_produktas_Click(object sender, EventArgs e)
        {
            ProduktaiForm product = new ProduktaiForm();
            product.Show();
            this.Hide();
        }

        private void button_Pardavejas_Click(object sender, EventArgs e)
        {
            PardavejasForm PARDAV = new PardavejasForm();
            PARDAV.Show();
            this.Hide();
        }

        private void button_Parduoti_Click(object sender, EventArgs e)
        {
            ParduotiForm1 PARDAV = new ParduotiForm1();
            PARDAV.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
