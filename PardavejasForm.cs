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
    }
}
