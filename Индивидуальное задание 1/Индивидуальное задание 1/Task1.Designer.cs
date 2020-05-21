namespace Индивидуальное_задание_1
{
    partial class Task1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Matrix = new System.Windows.Forms.RichTextBox();
            this.answer = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.First = new System.Windows.Forms.RichTextBox();
            this.Last = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Location = new System.Drawing.Point(38, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Задание: 1.Дан взвешенный ориентированный граф слабосвязный граф. \r\nДаны две верш" +
    "ины. Найти кратчайший путь из А в В с помощью алгоритма Дейкстры.";
            // 
            // Matrix
            // 
            this.Matrix.Enabled = false;
            this.Matrix.Location = new System.Drawing.Point(41, 143);
            this.Matrix.Name = "Matrix";
            this.Matrix.Size = new System.Drawing.Size(216, 177);
            this.Matrix.TabIndex = 1;
            this.Matrix.Text = "";
            // 
            // answer
            // 
            this.answer.Enabled = false;
            this.answer.Location = new System.Drawing.Point(493, 222);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(234, 40);
            this.answer.TabIndex = 3;
            this.answer.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Получить кратчайший путь";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(41, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 53);
            this.button2.TabIndex = 5;
            this.button2.Text = "Матрица смежности вершин";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Начальная точка\r\n(По умолчанию: первая вершина графа)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(500, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Конечная точка\r\n(По умолчанию: последняя вершина графа)";
            // 
            // First
            // 
            this.First.Location = new System.Drawing.Point(266, 159);
            this.First.Name = "First";
            this.First.Size = new System.Drawing.Size(172, 29);
            this.First.TabIndex = 8;
            this.First.Text = "";
            // 
            // Last
            // 
            this.Last.Location = new System.Drawing.Point(503, 159);
            this.Last.Name = "Last";
            this.Last.Size = new System.Drawing.Size(172, 29);
            this.Last.TabIndex = 9;
            this.Last.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(447, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ответ:";
            // 
            // Task1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Last);
            this.Controls.Add(this.First);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.Matrix);
            this.Controls.Add(this.label1);
            this.Name = "Task1";
            this.Text = "Задание 1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Task1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox Matrix;
        private System.Windows.Forms.RichTextBox answer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox First;
        private System.Windows.Forms.RichTextBox Last;
        private System.Windows.Forms.Label label4;
    }
}