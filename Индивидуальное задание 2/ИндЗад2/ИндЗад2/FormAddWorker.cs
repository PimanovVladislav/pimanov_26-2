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
    public partial class FormAddWorker : Form
    {
        public FormAddWorker()
        {
         
            InitializeComponent();
            string connStr = "server=localhost;user=root;database=birjha_truda;";
            // создаём объект для подключения к БД
            MySqlConnection connection = new MySqlConnection(connStr);
            connection.Open();

            string sql = "SELECT Pasport FROM soiskateli ";
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0]);
            }
            reader.Close();
            connection.Close();
            connection.Open();
            sql = "SELECT Doljnost FROM vakansii";
            MySqlDataReader reader1 = command.ExecuteReader();
            while (reader1.Read())
            {
                comboBox1.Items.Add(reader[0]);
            }
            reader1.Close();
            connection.Close();
        }

        private void Insertbtn_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;database=birjha_truda;";
            // создаём объект для подключения к БД
            MySqlConnection connection = new MySqlConnection(connStr);
            connection.Open();
            string S1, S2, S3,S4;
            string sql = "SELECT id_users FROM soiskateli WHERE Pasport =" + comboBox1.SelectedItem;
            MySqlCommand command = new MySqlCommand(sql, connection);
            S1 = command.ExecuteScalar().ToString();
            sql = "SELECT id_vakansii FROM vacansii WHERE Doljnost =" + comboBoxCorp.SelectedItem;
            S2 = command.ExecuteScalar().ToString();
            sql = "SELECT Company FROM vacansii WHERE Doljnost =" + comboBoxCorp.SelectedItem;
            S3 = command.ExecuteScalar().ToString();
            sql = "SELECT id_Company FROM companies WHERE Company =" + S2;
            S4 = command.ExecuteScalar().ToString();

            sql = "INSERT INTO `rabotniki`(`Company`, `Vakansiya`, `User`) VALUES " +
                "('" + S1 + "','" + S2 + "','" + S4 +"');";
            
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
