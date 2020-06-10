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
    public partial class FormChanged1 : Form
    {
        public FormChanged1()
        {
            InitializeComponent();
        }
        private void EnterChange_Click(object sender, EventArgs e)
        {
            string S = listBox1.SelectedItem.ToString();
            switch (S)
            {
                case "Фамилия": S = "Last_name"; break;
                case "Имя": S = "Name"; break;
                case "Отчество": S = "ather_name"; break;
                case "Пол": S = "Pol"; break;
                case "Возраст": S = "Age"; break;
                case "Паспорт": S = "Pasport"; break;
                case "О себе": S = "Info"; break;
            }
            string connStr = "server=localhost;user=root;database=birjha_truda;";
            MySqlConnection connection = new MySqlConnection(connStr);
            connection.Open();
            string sql = "UPDATE `companies` SET `" + S + "` = '" + richTextBox1.Text + "'" + " WHERE Pasport = '" + richTextBox2.Text + "'";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
            richTextBox1.Clear();
            richTextBox2.Clear();
        }
    }
}
