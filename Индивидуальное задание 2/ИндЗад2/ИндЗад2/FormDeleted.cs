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
            comboBox1.Items.Add("Компания");
            comboBox1.Items.Add("Соискатель");
            comboBox1.Items.Add("Резюме");
            comboBox1.Items.Add("Вакансия");
            comboBox1.Items.Add("Работник");

        }

        private void EnterDel_Click(object sender, EventArgs e)
        {  string connStr = "server=localhost;user=root;database=birjha_truda;";
            MySqlConnection connection = new MySqlConnection(connStr);
            connection.Open();
           
            string sql="";
            string sql2 = "";
            string sql3 = "";
            switch (comboBox1.SelectedItem)
            {
                case "Компания": 
                     sql = "SELECT `id_Company` FROM `companies` WHERE Company = '" + richTextBox2.Text + "'";                    
                     break;
                case "Соискатель":
                    sql = "SELECT `id_users` FROM `soiskateli` WHERE Pasport = '" + richTextBox2.Text + "'";
                    break;
                case "Резюме":  sql = "DELETE FROM `rezume` WHERE Doljnost = '" + richTextBox2.Text + "'"; break;
                case "Вакансия":  sql = "DELETE FROM `vacansii` WHERE Doljnost = '" + richTextBox2.Text + "'"; break;
                case "Работник":
                    sql = "SELECT `id_users` FROM `soiskateli` WHERE Last_name = '" + richTextBox2.Text + "'";
                    break;
            } 
            MySqlCommand command = new MySqlCommand(sql, connection);
            string S = command.ExecuteScalar().ToString();
            switch (comboBox1.SelectedItem)
            {
                case "Компания":                    
                    sql2 = "DELETE FROM `vacansii` WHERE Company = '" + S + "'";                   
                    break;
                case "Соискатель":
                    sql2 = "DELETE FROM `rezume` WHERE user = '" + S + "'";
                    break;
                case "Работник":
                     sql2 = "DELETE FROM `rabotniki` WHERE  = '" + S + "'"; break;
            }
            MySqlCommand command2 = new MySqlCommand(sql2, connection);
            command2.ExecuteScalar();
            switch (comboBox1.SelectedItem)
            {
                case "Компания":
                    sql3 = "DELETE FROM `companies` WHERE Company = '" + richTextBox2.Text + "'";
                    break;
                case "Соискатель":
                    sql3 = "DELETE FROM `soiskateli` WHERE Pasport = '" + richTextBox2.Text + "'";
                    break;
            }
            MySqlCommand command3 = new MySqlCommand(sql3, connection);
            command3.ExecuteNonQuery();
            connection.Close();
            richTextBox2.Clear();
        }
    }
}
