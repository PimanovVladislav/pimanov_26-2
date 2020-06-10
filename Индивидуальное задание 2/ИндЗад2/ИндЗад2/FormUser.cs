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
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent(); dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            string connStr = "server=localhost;user=root;database=birjha_truda;";
            // создаём объект для подключения к БД
            MySqlConnection connection = new MySqlConnection(connStr);
            connection.Open();
            string sql = "SELECT `id_users`, `Last_name`, `Name`, `Father_name`, `Pol`, `Age`, `Pasport`, `Info` FROM `soiskateli` ";
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader[1], reader[2], reader[3], reader[4], reader[5], reader[6], reader[7]);
            }
            reader.Close();
            connection.Close();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            FormAdd comp = new FormAdd();
            comp.Owner = this;
            comp.Show();
        }

        private void ObnBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string connStr = "server=localhost;user=root;database=birjha_truda;";
            MySqlConnection connection = new MySqlConnection(connStr);
            connection.Open();
            string sql = "SELECT Company,Region,Kont_data, Prof_Napr, Type, Info FROM companies ";
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5]);
            }
            reader.Close();
            connection.Close();
        }

        private void Changebtn_Click(object sender, EventArgs e)
        {
            FormChanged comp = new FormChanged();
            comp.Owner = this;
            comp.Show();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            FormDeleted comp = new FormDeleted();
            comp.Owner = this;
            comp.Show();
        }
    }
}
