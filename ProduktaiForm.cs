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
    public partial class ProduktaiForm : Form
    {
        DBConnectcs dBCon = new DBConnectcs();
        public ProduktaiForm()
        {
            InitializeComponent();
        }       
        private void ProduktaiForm_Load(object sender, EventArgs e)
        {
            getCategory();
            getTable();
            clear();
        }
        private void clear()
        {
            TextBox_id.Clear();
            TextBox_vardas.Clear();
            TextBox_kiekis.Clear();
            TextBox_kaina.Clear();
            comboBox_kategorija.SelectedIndex = 0;
        }
        private void getTable()
        {
            string selectQuerry = "SELECT * FROM Product";
            MySqlCommand command = new MySqlCommand(selectQuerry, dBCon.GetCon());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_product.DataSource = table;
        }
        private void Button_Add_Click(object sender, EventArgs e)
        {
            try
            {
            string insertQuery = "INSERT INTO Product VALUES(" + TextBox_id.Text + ",'" + TextBox_vardas.Text + "','" + TextBox_kiekis.Text + "','" + TextBox_kaina.Text + "','" + comboBox_kategorija.Text +"')"; // pataisyti
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

        private void button_Kategorijos_Click(object sender, EventArgs e)
        {
            KategorijosForm kategorijos = new KategorijosForm();
            kategorijos.Show();
            this.Hide();
        }


        private void getCategory()
        {
            string selectQuerry = "SELECT * FROM Categorys";
            MySqlCommand command = new MySqlCommand(selectQuerry, dBCon.GetCon());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBox_kategorija.DataSource = table;
            comboBox_kategorija.ValueMember = "Vardas";
            comboBox_search.DataSource = table;
            comboBox_search.ValueMember = "Vardas";
        }

        private void Button_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_id.Text == "" || TextBox_vardas.Text == "" || comboBox_kategorija.Text == "" || TextBox_kiekis.Text == "" || TextBox_kaina.Text == "")
                {
                    MessageBox.Show("Truksta informacijos", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string updateQuery = "UPDATE Product SET Vardas='" + TextBox_vardas.Text + "',Kaina=" + TextBox_kaina.Text + ",Kiekis=" + TextBox_kiekis.Text + ",Kategorija='" + comboBox_kategorija.Text + "' WHERE Id =" + TextBox_id.Text + "";
                    MySqlCommand command = new MySqlCommand(updateQuery, dBCon.GetCon());
                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Produktas UPDATINTAS", "Produkto UPDATINIMOSI informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        private void dataGridView_product_Click_1(object sender, EventArgs e)
        {
            TextBox_id.Text = dataGridView_product.SelectedRows[0].Cells[0].Value.ToString();
            TextBox_vardas.Text = dataGridView_product.SelectedRows[0].Cells[1].Value.ToString();
            TextBox_kaina.Text = dataGridView_product.SelectedRows[0].Cells[2].Value.ToString();
            TextBox_kiekis.Text = dataGridView_product.SelectedRows[0].Cells[3].Value.ToString();
            comboBox_kategorija.SelectedValue = dataGridView_product.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_id.Text == "" )
                {
                    MessageBox.Show("Truksta informacijos", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string deleteQuery = "DELETE FROM Product WHERE Id=" + TextBox_id.Text + "";
                    MySqlCommand command = new MySqlCommand(deleteQuery, dBCon.GetCon());
                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Produktas panaikintas", "Produkto panaikinta informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button_refresh_Click(object sender, EventArgs e)
        {
            getTable();
        }

        private void comboBox_search_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectQuerry = "SELECT * FROM Product WHERE Kategorija='" + comboBox_search.SelectedValue.ToString()+"'";
            MySqlCommand command = new MySqlCommand(selectQuerry, dBCon.GetCon());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_product.DataSource = table;
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Blue;
        }

        private void button_logout_MouseEnter(object sender, EventArgs e)
        {
            button_logout.ForeColor = Color.Red;
        }

        private void button_logout_MouseLeave(object sender, EventArgs e)
        {
            button_logout.ForeColor = Color.Blue;
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Pardavejas_Click(object sender, EventArgs e)
        {
            PardavejasForm login = new PardavejasForm();
            login.Show();
            this.Hide();
        }

        private void comboBox_kategorija_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_Parduoti_Click(object sender, EventArgs e)
        {
            ParduotiForm1 login = new ParduotiForm1();
            login.Show();
            this.Hide();
        }
    }
}
