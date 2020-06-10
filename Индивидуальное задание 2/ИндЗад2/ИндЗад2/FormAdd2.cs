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

namespace ИндЗад2
{
    public partial class FormAdd2 : Form
    {
        public FormAdd2()
        {
            InitializeComponent();
            string connStr = "server=localhost;user=root;database=birjha_truda;";
            // создаём объект для подключения к БД
            MySqlConnection connection = new MySqlConnection(connStr);
            connection.Open();

            string sql = "SELECT Company FROM companies ";
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBoxCorp.Items.Add(reader[0]);
            }
            reader.Close();
            connection.Close();
        }

        private void Insertbtn_Click(object sender, EventArgs e)
        {

           
            string connStr = "server=localhost;user=root;database=birjha_truda;";
            // создаём объект для подключения к БД
            MySqlConnection connection = new MySqlConnection(connStr);
            connection.Open();
            string sql = "SELECT `id_Company` FROM `companies` WHERE Company = '" + comboBoxCorp.SelectedItem+"'";
            MySqlCommand command = new MySqlCommand(sql, connection);
            string S = command.ExecuteScalar().ToString();      

            sql = "INSERT INTO `vacansii`(`id_vakansii`, `Doljnost`, `Oklad`, `Trebovaniya`, `Company`, `Region`, `Opisanie_raboti`) VALUES " +
                "(NULL, '" + Dolj.Text + "','" + Oklad.Text + "','" + Treb.Text + "','"+ S
                + "','" + Region.Text + "','" + Info.Text + "');";
            command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
            Dolj.Clear();            
            Oklad.Clear();
            Treb.Clear();
            Region.Clear();
            Info.Clear();
        }
    }
}
