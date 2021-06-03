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
        private void Button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Categorys VALUES(" + TextBox_id.Text + ",'" + TextBox_vardas.Text + "','" + TextBox_aprasymas.Text + "')";
                MySqlCommand command = new MySqlCommand(insertQuery, dBCon.GetCon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Kategorija pakrauta");
                dBCon.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void label_exit_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_kategorijos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_refresh_Click(object sender, EventArgs e)
        {

        }


    }
}
