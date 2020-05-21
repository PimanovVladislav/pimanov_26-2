namespace Индивидуальное_задание_1
{
    partial class Task5
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
            this.Matrix = new System.Windows.Forms.RichTextBox();
            this.answer = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Matrix
            // 
            this.Matrix.Enabled = false;
            this.Matrix.Location = new System.Drawing.Point(51, 176);
            this.Matrix.Name = "Matrix";
            this.Matrix.Size = new System.Drawing.Size(251, 189);
            this.Matrix.TabIndex = 0;
            this.Matrix.Text = "";
            // 
            // answer
            // 
            this.answer.Enabled = false;
            this.answer.Location = new System.Drawing.Point(320, 176);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(233, 189);
            this.answer.TabIndex = 1;
            this.answer.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Задание: Дан неориентированный связный граф, построить \r\nфундаментальное множеств" +
    "о циклов и остовное дерево.\r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 56);
            this.button1.TabIndex = 4;
            this.button1.Text = "Фундаментальное множество циклов и остовное дерево.\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(51, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(251, 53);
            this.button2.TabIndex = 5;
            this.button2.Text = "Матрица смежности вершин графа";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Task5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.Matrix);
            this.Name = "Task5";
            this.Text = "Задание 5";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Matrix;
        private System.Windows.Forms.RichTextBox answer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}