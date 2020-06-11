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
    public partial class FormWorkers : Form
    {
        public FormWorkers()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            string connStr = "server=localhost;user=root;database=birjha_truda;";
            // создаём объект для подключения к БД
            MySqlConnection connection = new MySqlConnection(connStr);
            connection.Open();
            string sql = "SELECT companies.Company, vacansii.Doljnost, vacansii.Oklad, soiskateli.Last_name, vacansii.Region, vacansii.Opisanie_raboti FROM `rabotniki` " +
               "JOIN `companies` ON companies.id_Company = rabotniki.Company" +
               " JOIN `soiskateli`  ON soiskateli.id_users=rabotniki.User" +
               " JOIN `vacansii`  ON vacansii.id_vakansii=rabotniki.Vakansiya";
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5]);
            }
            reader.Close();
            connection.Close();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            FormAddWorker comp = new FormAddWorker();
            comp.Owner = this;
            comp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string connStr = "server=localhost;user=root;database=birjha_truda;";
            MySqlConnection connection = new MySqlConnection(connStr);
            connection.Open();
            string sql = "SELECT companies.Company, vacansii.Doljnost, vacansii.Oklad, soiskateli.Last_name, vacansii.Region, vacansii.Opisanie_raboti FROM `rabotniki` " +
                "JOIN `companies` ON companies.id_Company = rabotniki.Company" +
                " JOIN `soiskateli`  ON soiskateli.id_users=rabotniki.User" +
                " JOIN `vacansii`  ON vacansii.id_vakansii=rabotniki.Vakansiya";
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5]);
            }
            reader.Close();
            connection.Close();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            FormDeleted comp = new FormDeleted();
            comp.Owner = this;
            comp.Show();
        }
    }
}
