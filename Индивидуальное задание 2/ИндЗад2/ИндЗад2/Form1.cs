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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Company_Click(object sender, EventArgs e)
        {
            FormCompanies comp = new FormCompanies();
            comp.Owner = this;
            comp.Show();
        }

        private void btn_Vacanse_Click(object sender, EventArgs e)
        {

        }

        private void btn_Rezume_Click(object sender, EventArgs e)
        {

        }

        private void btn_Clients_Click(object sender, EventArgs e)
        {

        }

        private void btn_workers_Click(object sender, EventArgs e)
        {

        }
    }
}
