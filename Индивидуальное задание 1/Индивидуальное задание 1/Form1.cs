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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Menu.Font = new Font("Times New Roman", 20, FontStyle.Bold);
            task1.Font = new Font("Times New Roman", 12, FontStyle.Italic);
            task2.Font = new Font("Times New Roman", 12, FontStyle.Italic);
            task3.Font = new Font("Times New Roman", 12, FontStyle.Italic);
            task4.Font = new Font("Times New Roman", 12, FontStyle.Italic);
            task5.Font = new Font("Times New Roman", 12, FontStyle.Italic);
        }

        private void task1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Task1 task = new Task1();
            task.Show();
        }

        private void task2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Task2 task = new Task2();
            task.Show();
        }

        private void task3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Task3 task = new Task3();
            task.Show();
        }

        private void task4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Task4 task = new Task4();
            task.Show();
        }

        private void task5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Task5 task = new Task5();
            task.Show();
        }
    }
}
