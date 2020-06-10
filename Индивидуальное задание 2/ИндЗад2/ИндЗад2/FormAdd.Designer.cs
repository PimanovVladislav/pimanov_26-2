namespace ИндЗад2
{
    partial class FormAdd
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
            this.Company = new System.Windows.Forms.RichTextBox();
            this.Region = new System.Windows.Forms.RichTextBox();
            this.Kont_data = new System.Windows.Forms.RichTextBox();
            this.Napr = new System.Windows.Forms.RichTextBox();
            this.Type = new System.Windows.Forms.RichTextBox();
            this.Info = new System.Windows.Forms.RichTextBox();
            this.Insertbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название компании";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Регион";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Контактные данные";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Сфера деятельности";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Тип компании";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "О компании";
            // 
            // Company
            // 
            this.Company.Location = new System.Drawing.Point(171, 12);
            this.Company.Name = "Company";
            this.Company.Size = new System.Drawing.Size(219, 21);
            this.Company.TabIndex = 6;
            this.Company.Text = "";
            // 
            // Region
            // 
            this.Region.Location = new System.Drawing.Point(171, 50);
            this.Region.Name = "Region";
            this.Region.Size = new System.Drawing.Size(219, 21);
            this.Region.TabIndex = 7;
            this.Region.Text = "";
            // 
            // Kont_data
            // 
            this.Kont_data.Location = new System.Drawing.Point(171, 89);
            this.Kont_data.Name = "Kont_data";
            this.Kont_data.Size = new System.Drawing.Size(219, 21);
            this.Kont_data.TabIndex = 8;
            this.Kont_data.Text = "";
            // 
            // Napr
            // 
            this.Napr.Location = new System.Drawing.Point(171, 128);
            this.Napr.Name = "Napr";
            this.Napr.Size = new System.Drawing.Size(219, 21);
            this.Napr.TabIndex = 9;
            this.Napr.Text = "";
            // 
            // Type
            // 
            this.Type.Location = new System.Drawing.Point(171, 172);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(219, 21);
            this.Type.TabIndex = 10;
            this.Type.Text = "";
            // 
            // Info
            // 
            this.Info.Location = new System.Drawing.Point(171, 210);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(219, 21);
            this.Info.TabIndex = 11;
            this.Info.Text = "";
            // 
            // Insertbtn
            // 
            this.Insertbtn.Location = new System.Drawing.Point(134, 273);
            this.Insertbtn.Name = "Insertbtn";
            this.Insertbtn.Size = new System.Drawing.Size(100, 23);
            this.Insertbtn.TabIndex = 12;
            this.Insertbtn.Text = "Добавить";
            this.Insertbtn.UseVisualStyleBackColor = true;
            this.Insertbtn.Click += new System.EventHandler(this.Insertbtn_Click);
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 354);
            this.Controls.Add(this.Insertbtn);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Napr);
            this.Controls.Add(this.Kont_data);
            this.Controls.Add(this.Region);
            this.Controls.Add(this.Company);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAdd";
            this.Text = "FormAdd";
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
        private System.Windows.Forms.RichTextBox Company;
        private System.Windows.Forms.RichTextBox Region;
        private System.Windows.Forms.RichTextBox Kont_data;
        private System.Windows.Forms.RichTextBox Napr;
        private System.Windows.Forms.RichTextBox Type;
        private System.Windows.Forms.RichTextBox Info;
        private System.Windows.Forms.Button Insertbtn;
    }
}