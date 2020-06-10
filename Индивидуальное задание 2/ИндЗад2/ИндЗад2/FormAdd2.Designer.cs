namespace ИндЗад2
{
    partial class FormAdd2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Insertbtn = new System.Windows.Forms.Button();
            this.Dolj = new System.Windows.Forms.RichTextBox();
            this.Oklad = new System.Windows.Forms.RichTextBox();
            this.Treb = new System.Windows.Forms.RichTextBox();
            this.Region = new System.Windows.Forms.RichTextBox();
            this.Info = new System.Windows.Forms.RichTextBox();
            this.comboBoxCorp = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Описание ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Регион";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Название компании";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Требования";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Оклад";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Должность";
            // 
            // Insertbtn
            // 
            this.Insertbtn.Location = new System.Drawing.Point(143, 222);
            this.Insertbtn.Name = "Insertbtn";
            this.Insertbtn.Size = new System.Drawing.Size(100, 23);
            this.Insertbtn.TabIndex = 13;
            this.Insertbtn.Text = "Добавить";
            this.Insertbtn.UseVisualStyleBackColor = true;
            this.Insertbtn.Click += new System.EventHandler(this.Insertbtn_Click);
            // 
            // Dolj
            // 
            this.Dolj.Location = new System.Drawing.Point(174, 33);
            this.Dolj.Name = "Dolj";
            this.Dolj.Size = new System.Drawing.Size(219, 21);
            this.Dolj.TabIndex = 14;
            this.Dolj.Text = "";
            // 
            // Oklad
            // 
            this.Oklad.Location = new System.Drawing.Point(174, 64);
            this.Oklad.Name = "Oklad";
            this.Oklad.Size = new System.Drawing.Size(219, 21);
            this.Oklad.TabIndex = 15;
            this.Oklad.Text = "";
            // 
            // Treb
            // 
            this.Treb.Location = new System.Drawing.Point(174, 92);
            this.Treb.Name = "Treb";
            this.Treb.Size = new System.Drawing.Size(219, 21);
            this.Treb.TabIndex = 16;
            this.Treb.Text = "";
            // 
            // Region
            // 
            this.Region.Location = new System.Drawing.Point(174, 154);
            this.Region.Name = "Region";
            this.Region.Size = new System.Drawing.Size(219, 21);
            this.Region.TabIndex = 17;
            this.Region.Text = "";
            // 
            // Info
            // 
            this.Info.Location = new System.Drawing.Point(174, 186);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(219, 21);
            this.Info.TabIndex = 18;
            this.Info.Text = "";
            // 
            // comboBoxCorp
            // 
            this.comboBoxCorp.FormattingEnabled = true;
            this.comboBoxCorp.Location = new System.Drawing.Point(174, 127);
            this.comboBoxCorp.Name = "comboBoxCorp";
            this.comboBoxCorp.Size = new System.Drawing.Size(219, 21);
            this.comboBoxCorp.TabIndex = 20;
            // 
            // FormAdd2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 277);
            this.Controls.Add(this.comboBoxCorp);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.Region);
            this.Controls.Add(this.Treb);
            this.Controls.Add(this.Oklad);
            this.Controls.Add(this.Dolj);
            this.Controls.Add(this.Insertbtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAdd2";
            this.Text = "FormAdd2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Insertbtn;
        private System.Windows.Forms.RichTextBox Dolj;
        private System.Windows.Forms.RichTextBox Oklad;
        private System.Windows.Forms.RichTextBox Treb;
        private System.Windows.Forms.RichTextBox Region;
        private System.Windows.Forms.RichTextBox Info;
        private System.Windows.Forms.ComboBox comboBoxCorp;
    }
}