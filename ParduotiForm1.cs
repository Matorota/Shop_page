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
    public partial class ParduotiForm1 : Form
    {
        DBConnectcs dBCon = new DBConnectcs();
        public ParduotiForm1()
        {
            InitializeComponent();
        }
        private void getTable()
        {
            string selectQuerry = "SELECT Vardas, Kaina FROM Product";
            MySqlCommand command = new MySqlCommand(selectQuerry, dBCon.GetCon());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView_produktas.DataSource = table;
        }
        private void getParduotaTable()
        {
            string selectQuerry = "SELECT * FROM Bill";
            MySqlCommand command = new MySqlCommand(selectQuerry, dBCon.GetCon());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView_Parduotu_sarasas.DataSource = table;
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
        }
        private void ParduotiForm1_Load(object sender, EventArgs e)
        {
            label_date.Text = DateTime.Today.ToShortDateString();

            getCategory();
            getTable();
            getParduotaTable();
        }

        private void DataGridView_produktas_Click(object sender, EventArgs e)
        {

            TextBox_vardas.Text = DataGridView_produktas.SelectedRows[0].Cells[0].Value.ToString();
            TextBox_kaina.Text = DataGridView_produktas.SelectedRows[0].Cells[1].Value.ToString();

        }

        private void TextBox_vardas_TextChanged(object sender, EventArgs e)
        {

        }
        int Isviso = 0, n = 0;

        private void Button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Bill VALUES(" + TextBox_id.Text + ",'" + label_pardavejas.Text + "','" + label_date.Text + "'," + Isviso.ToString() + ")"; 
                MySqlCommand command = new MySqlCommand(insertQuery, dBCon.GetCon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("uzsakymas pridetas", "uzsakymo informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                getParduotaTable();
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Print_Click(object sender, EventArgs e)
        {

        }

        private void Button_AddOrder_Click(object sender, EventArgs e)
        {   if (TextBox_vardas.Text == "" || TextBox_kiekis.Text == "")
            {
                MessageBox.Show("Truksta info", "Info error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int total = Convert.ToInt32(TextBox_kaina.Text) * Convert.ToInt32(TextBox_kiekis.Text);
                DataGridViewRow addRow = new DataGridViewRow();
                addRow.CreateCells(dataGridView_uzsakyti);
                addRow.Cells[0].Value = ++n;
                addRow.Cells[1].Value = TextBox_vardas.Text;
                addRow.Cells[2].Value = TextBox_kaina.Text;
                addRow.Cells[3].Value = TextBox_kiekis.Text;
                addRow.Cells[4].Value = total;
                dataGridView_uzsakyti.Rows.Add(addRow);
                Isviso += total;
                label_kiekisSt.Text = Isviso + "Eurai";
            }
            }
    }
}
