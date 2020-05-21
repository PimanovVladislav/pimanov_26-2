namespace Индивидуальное_задание_1
{
    partial class Task3
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Задание: Дан неориентированный граф. \r\nПостроить произвольное минимальное покрыти" +
    "е.\r\n";
            // 
            // Matrix
            // 
            this.Matrix.Enabled = false;
            this.Matrix.Location = new System.Drawing.Point(53, 170);
            this.Matrix.Name = "Matrix";
            this.Matrix.Size = new System.Drawing.Size(242, 198);
            this.Matrix.TabIndex = 2;
            this.Matrix.Text = "";
            // 
            // answer
            // 
            this.answer.Enabled = false;
            this.answer.Location = new System.Drawing.Point(489, 233);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(225, 27);
            this.answer.TabIndex = 3;
            this.answer.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 55);
            this.button1.TabIndex = 4;
            this.button1.Text = "Mинимальное покрытие\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(53, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(242, 50);
            this.button2.TabIndex = 5;
            this.button2.Text = "Матрица смежности вершин графа";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Task3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.Matrix);
            this.Controls.Add(this.label1);
            this.Name = "Task3";
            this.Text = "Задание 3";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox Matrix;
        private System.Windows.Forms.RichTextBox answer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}