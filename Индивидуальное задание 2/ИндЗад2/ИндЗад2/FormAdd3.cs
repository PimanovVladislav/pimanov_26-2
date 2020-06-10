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
    public partial class FormAdd3 : Form
    {
        public FormAdd3()
        {
            InitializeComponent(); string connStr = "server=localhost;user=root;database=birjha_truda;";
            // создаём объект для подключения к БД
            MySqlConnection connection = new MySqlConnection(connStr);
            connection.Open();

            string sql = "SELECT Pasport FROM soiskateli ";
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
            string sql = "SELECT `id_users` FROM `soiskateli` WHERE Pasport = '" + comboBoxCorp.SelectedItem + "'";
            MySqlCommand command = new MySqlCommand(sql, connection);
            string S = command.ExecuteScalar().ToString();

            sql = "INSERT INTO `rezume`(`User`, `Doljnost`, `Oklad`, `Staj`, `Region`, `Graphic`, `Info`) VALUES " +
                "('" + S+"','" + doljnost.Text + "','" + oklad.Text + "','" + staj.Text + "','" + region.Text
                + "','" + graphic.Text + "','" + moreInf.Text + "');";
            command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
            doljnost.Clear();
            staj.Clear();
            oklad.Clear();
            graphic.Clear();
            region.Clear();
            moreInf.Clear();
        }
    }
}
