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
    public partial class PardavejasForm : Form
    {
        public PardavejasForm()
        {
            InitializeComponent();
        }
        DBConnectcs dBCon = new DBConnectcs();
        private void getTable()
        {
            string selectQuerry = "SELECT * FROM Seller";
            MySqlCommand command = new MySqlCommand(selectQuerry, dBCon.GetCon());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_pardavejas.DataSource = table;
        }
        private void Button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Seller VALUES(" + TextBox_id.Text + ",'" + TextBox_vardas.Text + "','" + TextBox_metai.Text + "','" + TextBox_numeris.Text + "','" + TextBox_password.Text + "')"; 
                MySqlCommand command = new MySqlCommand(insertQuery, dBCon.GetCon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Produktas pridetas", "Produkto informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                getTable();
                clear();
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void clear()
        {
            TextBox_id.Clear();
            TextBox_vardas.Clear();
            TextBox_metai.Clear();
            TextBox_numeris.Clear();
            TextBox_password.Clear();
        }
        private void PardavejasForm_Load(object sender, EventArgs e)
        {
            getTable();
            clear();
        }

        private void Button_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_id.Text == "" || TextBox_vardas.Text == "" || TextBox_metai.Text == "" || TextBox_numeris.Text == "" || TextBox_password.Text == "")
                {
                    MessageBox.Show("Truksta informacijos", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string updateQuery = "UPDATE Seller SET Vardas='" + TextBox_vardas.Text + "',Metai=" + TextBox_metai.Text + ",Numeris=" + TextBox_numeris.Text + ",Slaptazodis='" + TextBox_password.Text + "' WHERE Id =" + TextBox_id.Text + "";
                    MySqlCommand command = new MySqlCommand(updateQuery, dBCon.GetCon());
                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Pardavejo UPDATINTAS", "Pardavejo UPDATINIMOSI informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dataGridView_pardavejas_Click(object sender, EventArgs e)
        {
            TextBox_id.Text = dataGridView_pardavejas.SelectedRows[0].Cells[0].Value.ToString();
            TextBox_vardas.Text = dataGridView_pardavejas.SelectedRows[0].Cells[1].Value.ToString();
            TextBox_metai.Text = dataGridView_pardavejas.SelectedRows[0].Cells[2].Value.ToString();
            TextBox_numeris.Text = dataGridView_pardavejas.SelectedRows[0].Cells[3].Value.ToString();
            TextBox_password.Text = dataGridView_pardavejas.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_id.Text == "")
                {
                    MessageBox.Show("Truksta informacijos", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("AR TIKRAI NORI ISTRINTI?", "ISTRINTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
                    { 
                    string deleteQuery = "DELETE FROM Seller WHERE Id=" + TextBox_id.Text + "";
                    MySqlCommand command = new MySqlCommand(deleteQuery, dBCon.GetCon());
                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Pardavejo panaikintas", "Pardavejo panaikinta informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dBCon.CloseCon();
                    getTable();
                    clear();
                }
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_logout_MouseEnter(object sender, EventArgs e)
        {
            button_logout.ForeColor = Color.Red;
        }

        private void button_logout_MouseLeave(object sender, EventArgs e)
        {
            button_logout.ForeColor = Color.Blue;
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            button_logout.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            button_logout.ForeColor = Color.Blue;
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void button_produktai_Click(object sender, EventArgs e)
        {
            ProduktaiForm kategorijos = new ProduktaiForm();
            kategorijos.Show();
            this.Hide();
        }

        private void button_Kategorijos_Click(object sender, EventArgs e)
        {
            KategorijosForm kategorijos = new KategorijosForm();
            kategorijos.Show();
            this.Hide();
        }

        private void button_Parduoti_Click(object sender, EventArgs e)
        {
            ParduotiForm1 kategorijos = new ParduotiForm1();
            kategorijos.Show();
            this.Hide();
        }
    }
}
