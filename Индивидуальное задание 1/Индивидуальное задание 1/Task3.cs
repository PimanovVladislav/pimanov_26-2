using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlgorithmsOnGraphsClass;

namespace Индивидуальное_задание_1
{
    public partial class Task3 : Form
    {
        public Task3()
        {
            InitializeComponent();
            label1.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            button2.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            button1.Font = new Font("Times New Roman", 10, FontStyle.Bold);
        }

        private string CreateString(List<int> list)
        {
            string s = "";
            for (int i = 0; i < list.Count; i++)
                s += list[i].ToString() + " ";

            return s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlgorithmsOnGraphs g = new AlgorithmsOnGraphs(Matrix);
            if (g.CheckingForCorrectness())
            {
                if (!g.CheckUndirected()) answer.Text = "Это не неориентированный граф";
                else
                {
                    answer.Text = g.MinPokr().ToString();                   
                }
                File.WriteAnswer(answer);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.ReadGraph(Matrix);
        }
    }
}
