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
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();

        }

        private void Insertbtn_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;database=birjha_truda;";
            // создаём объект для подключения к БД
            MySqlConnection connection = new MySqlConnection(connStr);
            connection.Open();
            string sql = "INSERT INTO `birjha_truda`.`companies`" +
                "(`id_Company`, `Company`, `Region`, `Kont_data`," +
                " `Prof_Napr`, `Type`, `Info`) VALUES " +
                "(NULL, '" + Company.Text + "','" + Region.Text + "','" + Kont_data.Text + "','" + Napr.Text
                + "','" + Type.Text + "','" + Info.Text + "');";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
            Company.Clear();
            Region.Clear();
            Kont_data.Clear();
            Napr.Clear();
            Type.Clear();
            Info.Clear();
        }
    }
}
