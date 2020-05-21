namespace Индивидуальное_задание_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.task1 = new System.Windows.Forms.LinkLabel();
            this.task2 = new System.Windows.Forms.LinkLabel();
            this.task4 = new System.Windows.Forms.LinkLabel();
            this.task5 = new System.Windows.Forms.LinkLabel();
            this.Menu = new System.Windows.Forms.Label();
            this.task3 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // task1
            // 
            this.task1.AutoSize = true;
            this.task1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.task1.LinkColor = System.Drawing.Color.Black;
            this.task1.Location = new System.Drawing.Point(99, 95);
            this.task1.Name = "task1";
            this.task1.Size = new System.Drawing.Size(481, 30);
            this.task1.TabIndex = 0;
            this.task1.TabStop = true;
            this.task1.Text = "1.Дан взвешенный ориентированный граф слабосвязный граф. Даны две вершины.\r\n    Н" +
    "айти кратчайший путь из А в В с помощью алгоритма Дейкстры.";
            this.task1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.task1_LinkClicked);
            // 
            // task2
            // 
            this.task2.AutoSize = true;
            this.task2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.task2.LinkColor = System.Drawing.Color.Black;
            this.task2.Location = new System.Drawing.Point(99, 146);
            this.task2.Name = "task2";
            this.task2.Size = new System.Drawing.Size(456, 15);
            this.task2.TabIndex = 1;
            this.task2.TabStop = true;
            this.task2.Text = "2.\tДан неориентированный связный граф. Проверить, будет ли он двудольным.\r\n";
            this.task2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.task2_LinkClicked);
            // 
            // task4
            // 
            this.task4.AutoSize = true;
            this.task4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.task4.LinkColor = System.Drawing.Color.Black;
            this.task4.Location = new System.Drawing.Point(99, 222);
            this.task4.Name = "task4";
            this.task4.Size = new System.Drawing.Size(502, 15);
            this.task4.TabIndex = 3;
            this.task4.TabStop = true;
            this.task4.Text = "4.Дан произвольный неориентированный граф. Построить наибольшее паросочетание.";
            this.task4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.task4_LinkClicked);
            // 
            // task5
            // 
            this.task5.AutoSize = true;
            this.task5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.task5.LinkColor = System.Drawing.Color.Black;
            this.task5.Location = new System.Drawing.Point(99, 260);
            this.task5.Name = "task5";
            this.task5.Size = new System.Drawing.Size(332, 30);
            this.task5.TabIndex = 4;
            this.task5.TabStop = true;
            this.task5.Text = "5.\tДан неориентированный связный граф, построить \r\nфундаментальное множество цикл" +
    "ов и остовное дерево.\r\n";
            this.task5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.task5_LinkClicked);
            // 
            // Menu
            // 
            this.Menu.AutoSize = true;
            this.Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Menu.Location = new System.Drawing.Point(332, 49);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(66, 24);
            this.Menu.TabIndex = 5;
            this.Menu.Text = "Меню";
            // 
            // task3
            // 
            this.task3.AutoSize = true;
            this.task3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.task3.LinkColor = System.Drawing.Color.Black;
            this.task3.Location = new System.Drawing.Point(99, 185);
            this.task3.Name = "task3";
            this.task3.Size = new System.Drawing.Size(479, 15);
            this.task3.TabIndex = 6;
            this.task3.TabStop = true;
            this.task3.Text = "3.\tДан неориентированный граф. Построить произвольное минимальное покрытие.\r\n";
            this.task3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.task3_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.task3);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.task5);
            this.Controls.Add(this.task4);
            this.Controls.Add(this.task2);
            this.Controls.Add(this.task1);
            this.Name = "Form1";
            this.Text = "Индивидуальное задание 1. Графы.";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel task1;
        private System.Windows.Forms.LinkLabel task2;
        private System.Windows.Forms.LinkLabel task4;
        private System.Windows.Forms.LinkLabel task5;
        private System.Windows.Forms.Label Menu;
        private System.Windows.Forms.LinkLabel task3;
    }
}

