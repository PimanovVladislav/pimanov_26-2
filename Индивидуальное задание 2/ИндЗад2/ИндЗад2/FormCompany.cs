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
using System.Data.SqlClient;

namespace ИндЗад2
{
    public partial class FormCompany : Form
    {
        public FormCompany()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            string connStr = "server=localhost;user=root;database=birjha_truda;";
            // создаём объект для подключения к БД
            MySqlConnection connection = new MySqlConnection(connStr);
            connection.Open();
            string sql = "SELECT id_Company,Company,Region,Kont_data, Prof_Napr, Type, Info FROM companies ";
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5]);
            }
            reader.Close();
        }
        
        private void addbtn_Click(object sender, EventArgs e)
        {
            FormAdd comp = new FormAdd();
            comp.Owner = this;
            comp.Show();
        }
    }

}