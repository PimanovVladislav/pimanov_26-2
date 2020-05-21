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
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
            label1.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            button2.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            button1.Font = new Font("Times New Roman", 10, FontStyle.Bold);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlgorithmsOnGraphs g = new AlgorithmsOnGraphs(Matrix);
            if (g.CheckingForCorrectness())
            {
                if (g.CountComponents() != 1) answer.Text = "Это некорректный граф";
                else
                {
                    if (g.CheckTwoDoles()) answer.Text = "Граф двудольный";
                    else answer.Text = "Граф НЕ двудольный";
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
