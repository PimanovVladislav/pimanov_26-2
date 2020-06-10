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
    public partial class FormChanged : Form
    {
        public FormChanged()
        {
            InitializeComponent();
        }

        private void EnterChange_Click(object sender, EventArgs e)
        {
            string S = listBox1.SelectedItem.ToString();
            switch(S)
            {
                case "Название Компании": S = "Company"; break;
                case "Регион": S = "Region"; break;
                case "Контактные данные": S = "Kont_data"; break;
                case "Сфера деятельности": S = "Prof_Napr"; break;
                case "Тип компании": S = "Type"; break;
                case "О компании": S = "Info"; break;
            }
            string connStr = "server=localhost;user=root;database=birjha_truda;";
            MySqlConnection connection = new MySqlConnection(connStr);
            connection.Open();
            string sql = "UPDATE `companies` SET `"+S+"` = '" + richTextBox1.Text+"'"+ " WHERE Company = '"+richTextBox2.Text+"'";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
            richTextBox1.Clear();
            richTextBox2.Clear();
        }
    }
}
