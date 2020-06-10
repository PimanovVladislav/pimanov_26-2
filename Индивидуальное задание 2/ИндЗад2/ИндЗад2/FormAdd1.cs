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
    public partial class FormAdd1 : Form
    {
        public FormAdd1()
        {
            InitializeComponent();
        }

        private void Insertbtn_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;database=birjha_truda;";
            // создаём объект для подключения к БД
            MySqlConnection connection = new MySqlConnection(connStr);
            connection.Open();
            string sql = "IINSERT INTO `soiskateli`(`id_users`, `Last_name`, `Name`, `Father_name`, `Pol`, `Age`, `Pasport`, `Info`) VALUES " +
                "(NULL, '" + Fam.Text + "','" + Ima.Text + "','" + Otch.Text + "','" +Pol.Text
                + "','" +Age.Text + "','" + Pasport.Text + "','" + Inf.Text + "');";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
            Ima.Clear();
            Fam.Clear();
            Otch.Clear();
            Pol.Clear();
            Pasport.Clear();
            Age.Clear();
            Inf.Clear();
        }
    }
}
