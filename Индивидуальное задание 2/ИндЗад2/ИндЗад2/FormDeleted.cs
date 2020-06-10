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
    public partial class FormDeleted : Form
    {
        public FormDeleted()
        {
            InitializeComponent();
        }

        private void EnterDel_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;database=birjha_truda;";
            MySqlConnection connection = new MySqlConnection(connStr);
            connection.Open();
            string sql = "DELETE FROM `companies` WHERE Company = '" + richTextBox2.Text + "'";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
            richTextBox2.Clear();
        }
    }
}
