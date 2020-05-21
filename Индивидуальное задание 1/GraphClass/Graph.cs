using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphClass
{
    public class Graph
    {
        private
                int[][] Matrix;
        public bool checkCorrectlyMatrix; 
        public Graph(RichTextBox box)
        {
            checkCorrectlyMatrix = true;
            string[] text = box.Text.Split('\n');
            Matrix = new int[text.Length][];
            CreateMatrix(text);
        }
        /// <summary>
        /// Возвращает количество вершин графа
        /// </summary>
        /// <returns></returns>
        public int CountOfVertex()
        {
            return Matrix.Length;
        }
        /// <summary>
        /// Возвращает количество ребер
        /// </summary>
        /// <returns></returns>
        public int CountOfEdge()
        {
            int count = new int();
            for (int i = 0; i < CountOfVertex(); i++)
                for (int j = 0; j < CountOfVertex(); j++)
                    if (Matrix[i][j] == 1)
                    {
                        if (!(Matrix[j][i] == 1) || j == i) count++;
                        else if (i < j) count++;
                    }
            return count;
        }
        /// <summary>
        /// Проверяет, существует ли ребро между двумя вершинами
        /// </summary>
        /// <param name="v"></param>
        /// <param name="u"></param>
        /// <returns></returns>
        public bool ExistEdge(int v, int u)
        {
            if (Matrix[v][u] != 0) return true;
            else return false;
        }
        /// <summary>
        /// Проверяет, существует ли ребро между двумя вершинами
        /// </summary>
        /// <param name="v"></param>
        /// <param name="u"></param>
        /// <returns></returns>
        public int WeightEdge(int v, int u)
        {
            return Matrix[v][u];
        }
        private void CreateMatrix(string[] text)
        {
            for (int i = 0; i < Matrix.Length; i++)
            {
                Matrix[i] = new int[Matrix.Length];
                string[] elements = text[i].Split(' ');

                if (elements.Length != text.Length || !checkCorrectlyMatrix)
                {
                    checkCorrectlyMatrix = false;
                    MessageBox.Show("Матрица введена неверно", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    for (int j = 0; j < Matrix.Length && checkCorrectlyMatrix; j++)
                    {
                        if ( elements[j] !="" && int.Parse(elements[j]) >= 0)
                            Matrix[i][j] = int.Parse(elements[j]);
                        else
                        {
                            checkCorrectlyMatrix = false;
                            MessageBox.Show("Матрица введена неверно", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Создает список смежности вершин
        /// </summary>
        /// <returns></returns>
        public List<List<int>> CreateListAdj()
        {
            List<List<int>> ListAdj = new List<List<int>>();
            for (int i = 0; i < Matrix.Length; i++)
            {
                var Adj = new List<int>();
                for (int j = 0; j < Matrix.Length; j++)
                {
                    if (Matrix[i][j] == 1) Adj.Add(j);
                }
                ListAdj.Add(Adj);
            }
            return ListAdj;
        }
        /// <summary>
        /// Получает степень вершины
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public int DegreeOfVertex(int v)
        {
            return Matrix[v].Sum();
        }
        /// <summary>
        /// Удаляет ребро
        /// </summary>
        /// <param name="v"></param>
        /// <param name="u"></param>
        public void DellEdge(int v, int u)
        {
            Matrix[v][u] = 0;
        }
    }
}
