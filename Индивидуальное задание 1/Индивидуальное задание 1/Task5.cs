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
    public partial class Task5 : Form
    {
        public Task5()
        {
            InitializeComponent();
            label1.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            button2.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            button1.Font = new Font("Times New Roman", 10, FontStyle.Bold);
        }

        private string CreateString(int[,] Tree)
        {
            string s = "";
            for (int i = 0; i < Math.Sqrt(Tree.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(Tree.Length); j++)
                    s += Tree[i, j].ToString() + " ";
                s += "\n";
            }
            return s;
        }
        private string CreateStr(List<string> cicles)
        {
            string s = "";
            for (int i = 0; i < cicles.LongCount(); i++)
                s += cicles[i];
            return s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlgorithmsOnGraphs g = new AlgorithmsOnGraphs(Matrix);
            if (g.CheckingForCorrectness())
            {
                if (g.CountComponents() != 1) answer.Text = "Это не подходящий граф";
                else
                {
                    answer.Text = "Остовное дерево:\n";
                    answer.Text += CreateString(g.OstTree());
                    answer.Text += "\nФундаментальное множество циклов:\n";
                    answer.Text += CreateStr(g.FMC());                   
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
