using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using AlgorithmsOnGraphsClass;

namespace Индивидуальное_задание_1
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
            label1.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            button2.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            button1.Font = new Font("Times New Roman", 10, FontStyle.Bold);
        }
        private string CreateString(string list)
        {
            string s = "";
            s += list[0].ToString();
            for (int i = 1; i < list.Length; i++)
                s += " -> " + list[i].ToString();
            return s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlgorithmsOnGraphs g = new AlgorithmsOnGraphs(Matrix);
            if (g.CountComponents() > 1) answer.Text = "Это некорректный граф";
            else
            {
                if(First.Text !=""&& Last.Text!="")
                answer.Text = CreateString(g.Deickstra(int.Parse(First.Text), int.Parse(Last.Text)));
                else
                    answer.Text = CreateString(g.Deickstra());
            }
            File.WriteAnswer(answer);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.ReadGraph(Matrix);
        }

        public void Task1_Load(object sender, EventArgs e)
        {
            //Form1 form1 = new Form1();
            //form1.Visible = true;
            //this.Close();
        }
    }
}
