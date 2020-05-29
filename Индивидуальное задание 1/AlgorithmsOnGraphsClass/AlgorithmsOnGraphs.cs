using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraphClass;

namespace AlgorithmsOnGraphsClass
{
    public class AlgorithmsOnGraphs
    {
        private
               Graph graph;
        int MaxPokr;
        public AlgorithmsOnGraphs(RichTextBox box)
        {
            graph = new Graph(box);
            MaxPokr = graph.CountOfVertex();
        }

        public bool CheckingForCorrectness()
        {
            return graph.checkCorrectlyMatrix;
        }

        /// <summary>
        /// Проверяет, содержатся ли в графе петли
        /// </summary>
        /// <returns></returns>
        private bool CheckLoop()
        {
            bool check = new bool();
            for (int i = 0; i < graph.CountOfVertex(); i++)
                if (graph.ExistEdge(i, i)) check = true;
            return check;
        }
        /// <summary>
        /// Проверяет граф на неориентированность
        /// </summary>
        /// <returns></returns>
        public bool CheckUndirected()
        {
            for (int i = 0; i < graph.CountOfVertex(); i++)
                for (int j = 0; j < graph.CountOfVertex(); j++)
                    if (graph.ExistEdge(i, j))
                        if (!graph.ExistEdge(j, i)) return false;
            return true;
        }

        /// <summary>
        /// Осуществляет поиск в глубину графа
        /// </summary>
        /// <param name="v"></param>
        /// <param name="visited"></param>
        private void DFS(int v, bool[] visited)
        {
            int countVertex = graph.CountOfVertex();
            Stack<int> vertex = new Stack<int>();
            vertex.Push(v);
            visited[v] = true;

            while (vertex.Count != 0)
            {
                int currentVertex = vertex.Pop();
                for (int i = 0; i < countVertex; i++)
                {
                    if (graph.ExistEdge(currentVertex, i) && !visited[i])
                    {
                        vertex.Push(currentVertex);
                        currentVertex = i;
                        visited[i] = true;
                        i = -1;
                    }
                }
            }
        }
        /// <summary>
        /// Проверяет является ли граф двудольным
        /// </summary>
        /// <returns></returns>
        public bool CheckTwoDoles()
        {
            int[] mas = new int[graph.CountOfVertex()];
            for (int i = 0; i < graph.CountOfVertex(); i++)
                mas[i] = 0;
            for (int i = 0; i < graph.CountOfVertex(); i++)
            {
                for (int j = i + 1; j < graph.CountOfVertex(); j++)
                {
                    if (graph.ExistEdge(i, j))
                    {
                        if (mas[i] == 0 && mas[j] == 0)
                        {
                            mas[i] = 1;
                            mas[j] = 2;
                        }
                        else
                        {
                            if (mas[i] == 1 && mas[j] == 0)
                            {
                                mas[j] = 2;
                            }
                            else
                            {
                                if (mas[i] == 2 && mas[j] == 0)
                                {

                                    mas[j] = 1;
                                }
                                else
                                {
                                    if ((mas[i] == 1 && mas[j] == 1) || (mas[i] == 2 && mas[j] == 2))
                                        return false;
                                }
                            }
                        }
                    }
                }
            }
            return true;
        }

        private void DellEdge(int V1, bool[] visited)
        {
            for (int i = 0; i < graph.CountOfVertex(); i++)
            {
                if (graph.ExistEdge(V1, i))
                {
                    visited[i] = true;
                    graph.DellEdge(V1, i);
                    graph.DellEdge(i, V1);
                    for (int j = 0; j < graph.CountOfVertex(); j++)
                    {
                        graph.DellEdge(i, j);
                        graph.DellEdge(j, i);
                    }
                }
            }
        }

        /// <summary>
        /// Считает количество компонент связности
        /// </summary>
        /// <returns></returns>
        public int CountComponents()
        {
            if (CheckUndirected())
            {
                bool[] visited = new bool[graph.CountOfVertex()];
                int K = new int();
                for (int i = 0; i < graph.CountOfVertex(); i++)
                {
                    if (!visited[i])
                    {
                        K++;
                        DFS(i, visited);
                    }
                }
                return K;
            }
            else return -1;
        }

        private bool vizit(bool[] visited, int N)
        {
            bool f = false;
            for (int i = 0; i < N; i++)
            {
                if (!visited[i]) f = true;
            }
            return f;
        }
        /// <summary>
        /// Строит остовное дерево графа
        /// </summary>
        /// <returns></returns>
        public int[,] OstTree()
        {
            bool[] visited = new bool[graph.CountOfVertex()];
            int[,] Tree = new int[graph.CountOfVertex(), graph.CountOfVertex()];
            for (int ind = 0; ind < graph.CountOfVertex(); ind++)
            {
                visited[ind] = false;
                for (int j = 0; j < graph.CountOfVertex(); j++)
                {
                    Tree[ind, j] = 0;
                }
            }
            int i = 0;
            visited[i] = true;
            while (vizit(visited, graph.CountOfVertex()))
            {
                for (int j = 0; j < graph.CountOfVertex(); j++)
                {
                    if (graph.ExistEdge(i, j))
                    {
                        if (visited[j] == false)
                        {
                            Tree[i, j] = 1;
                            Tree[j, i] = 1;
                            visited[j] = true;
                        }
                    }
                }
                i++;
                while (visited[i] == false)
                {
                    i++;
                }
            }
            return Tree;
        }
        private string Cicl(int[,] G2, int Begin, int End)
        {
            int[] Pytb = new int[graph.CountOfVertex()];
            string[] VerP = new string[graph.CountOfVertex()];
            bool[] visited = new bool[graph.CountOfVertex()];
            for (int ind = 0; ind < graph.CountOfVertex(); ind++)
            {
                visited[ind] = false;
                Pytb[ind] = 10000;
                VerP[ind] = (Begin+1).ToString();
            }
            visited[Begin] = true;
            Pytb[Begin] = 0;
            while (vizit(visited, graph.CountOfVertex()))
            {
                visited[Begin] = true;
                for (int j = 0; j < graph.CountOfVertex(); j++)
                {
                    if (G2[Begin,j]==1 && visited[j] == false)
                    {
                        if (Pytb[Begin] + graph.WeightEdge(Begin, j) < Pytb[j])
                        {
                            Pytb[j] = Pytb[Begin] + graph.WeightEdge(Begin, j);
                            VerP[j] = VerP[Begin] + (j+1).ToString();
                        }
                    }
                }
                for (int c = 0; c < graph.CountOfVertex(); c++)
                    for (int i = 0; i < graph.CountOfVertex(); i++)
                    {
                        if (visited[i] == false && visited[c] == true && G2[c,i] == 1)
                        {
                            Begin = i;

                            break;
                        }
                    }
            }
            return VerP[End];
        }


        /// <summary>
        /// Строит фундаментальное множество циклов графа
        /// </summary>
        /// <returns></returns>
        public List<string> FMC()
        {
            List<string> fmc = new List<string>();
            int[,] Tree = new int[graph.CountOfVertex(), graph.CountOfVertex()];
            Tree = OstTree();
            for (int i = 0; i < graph.CountOfVertex(); i++)
            {
                for (int j = i + 1; j < graph.CountOfVertex(); j++)
                {
                    if (graph.ExistEdge(i, j) == true && Tree[i, j] == 0)
                    {
                        string cicl = "";
                        cicl += Cicl(Tree, i,  j);
                        Tree[i, j] = 1;
                        Tree[j, i] = 1;
                        cicl += (i + 1).ToString() + "\n";
                        fmc.Add(cicl);
                    }
                }
            }
            return fmc;
        }

        private void NaimPokr(List<string> list)
        {
            Stack<string> vertex = new Stack<string>();

            string S = "";
            vertex.Push(S);
            bool[] Localvisited = new bool[graph.CountOfVertex()];
            for (int ind = 0; ind < graph.CountOfVertex(); ind++)
            {
                Localvisited[ind] = false;
            }
            while (vertex.Count() != 0)
            {
                S = vertex.Pop();
                for (int i = 0; i < graph.CountOfVertex(); i++)
                {
                    string s = S;
                    bool crit = false;
                    for (int k = 0; k < s.Length; k++)
                        if (s[k].ToString() == i.ToString()) crit = true;
                    if (crit == false)
                    {
                        s += i.ToString();

                        for (int k = 0; k < s.Length; k++)
                        {
                            int b = int.Parse(s[k] + "");
                            for (int j = 0; j < graph.CountOfVertex(); j++)
                            {
                                if (graph.ExistEdge(b, j))
                                {
                                    Localvisited[b] = true;
                                    Localvisited[j] = true;

                                }
                            }
                        }
                        if (vizit(Localvisited, graph.CountOfVertex()))
                        {
                            vertex.Push(s);
                        }
                        else
                        {
                            list.Add(s);
                        }

                    }
                    for (int ind = 0; ind < graph.CountOfVertex(); ind++)
                    {
                        Localvisited[ind] = false;
                    }
                }
            }
        }

        public string MinPokr()
        {
            List<string> Pokr = new List<string>();
            string s = "";
            string S = "{";
            NaimPokr(Pokr);
            int leng = graph.CountOfVertex();
            for (int i = 0; i < Pokr.LongCount(); i++)
            {
                if (Pokr[i].Length < leng)
                {
                    s = Pokr[i];
                    leng = Pokr[i].Length;
                }
            }
            for (int k = 0; k < s.Length - 1; k++)
            {
                int vert = int.Parse(s[k].ToString());
                vert++;
                S += vert.ToString() + ", ";
            }
            S += (int.Parse(s[s.Length - 1].ToString()) + 1).ToString() + "}";
            return S;
        }
        public List<string> Paros()
        {
            List<string> ParoSochet = new List<string>();
            bool[] visited = new bool[graph.CountOfVertex()];
            for (int ind = 0; ind < graph.CountOfVertex(); ind++)
            {
                visited[ind] = false;
            }
            while (vizit(visited, graph.CountOfVertex()))
            {
                int i = MinDeg(visited);

                for (int j = 0; j < graph.CountOfVertex(); j++)
                {
                    if (graph.ExistEdge(i, j) == true)
                    {
                        if (visited[i] == false && visited[j] == false)
                        {
                            visited[i] = true;
                            visited[j] = true;
                            string s = "( " + (i + 1).ToString() + " ," + (j + 1).ToString() + ") ";
                            ParoSochet.Add(s);
                        }
                    }
                }
                visited[i] = true;
            }
            return ParoSochet;
        }
        private int MinDeg(bool[] visited)
        {
            int Degree = graph.CountOfVertex();
            int Index = graph.CountOfVertex();
            for (int i = 0; i < graph.CountOfVertex(); i++)
            {
                if (visited[i] == false)
                    if (graph.DegreeOfVertex(i) < Degree)

                    {
                        Index = i;
                        Degree = graph.DegreeOfVertex(i);
                    }
            }
            return Index;
        }

        public string Deickstra(int Begin = 0, int End = -1)
        {
            if (End == -1) End = graph.CountOfVertex() - 1;
            int[] Pytb = new int[graph.CountOfVertex()];
            string[] VerP = new string[graph.CountOfVertex()];
            bool[] visited = new bool[graph.CountOfVertex()];
            for (int ind = 0; ind < graph.CountOfVertex(); ind++)
            {
                visited[ind] = false;
                Pytb[ind] = 10000;
                VerP[ind] = Begin.ToString();
            }
            visited[Begin] = true;
            Pytb[Begin] = 0;
            while (vizit(visited, graph.CountOfVertex()))
            {
                visited[Begin] = true;
                for (int j = 0; j < graph.CountOfVertex(); j++)
                {
                    if (graph.ExistEdge(Begin, j) == true && visited[j] == false)
                    {
                        if (Pytb[Begin] + graph.WeightEdge(Begin, j) < Pytb[j])
                        {
                            Pytb[j] = Pytb[Begin] + graph.WeightEdge(Begin, j);
                            VerP[j] = VerP[Begin] + j.ToString();
                        }
                    }
                }
                for (int c = 0; c < graph.CountOfVertex(); c++)
                    for (int i = 0; i < graph.CountOfVertex(); i++)
                    {
                        if (visited[i] == false && visited[c] == true && graph.ExistEdge(c, i) == true)
                        {
                            Begin = i;

                            break;
                        }
                    }
            }
            return VerP[End];
        }
    }
}