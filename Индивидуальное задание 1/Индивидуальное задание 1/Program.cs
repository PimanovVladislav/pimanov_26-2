using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Индивидуальное_задание_1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    class File
    {
        static public void ReadGraph(RichTextBox Box)
        {
            StreamReader file = new StreamReader("Matrix.txt");
            Box.Text = file.ReadToEnd();
            file.Close();
        }

        static public void WriteAnswer(RichTextBox Box)
        {
            StreamWriter file = new StreamWriter("Answer.txt");
            file.Write(Box.Text);
            file.Close();
        }
    }
}
