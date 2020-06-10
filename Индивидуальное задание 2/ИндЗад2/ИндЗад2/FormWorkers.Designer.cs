namespace ИндЗад2
{
    partial class FormWorkers
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Addbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Call_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prof_napr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Company,
            this.region,
            this.Call_data,
            this.Prof_napr,
            this.Type,
            this.Info});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(767, 342);
            this.dataGridView1.TabIndex = 1;
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(790, 53);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(102, 23);
            this.Addbtn.TabIndex = 2;
            this.Addbtn.Text = "Найти работу";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(790, 82);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(102, 23);
            this.deletebtn.TabIndex = 3;
            this.deletebtn.Text = "Уволиться";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(790, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Обновить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Company
            // 
            this.Company.HeaderText = "Название компании";
            this.Company.Name = "Company";
            this.Company.Width = 120;
            // 
            // region
            // 
            this.region.HeaderText = "Должность";
            this.region.Name = "region";
            // 
            // Call_data
            // 
            this.Call_data.HeaderText = "Оклад";
            this.Call_data.Name = "Call_data";
            // 
            // Prof_napr
            // 
            this.Prof_napr.HeaderText = "Фамилия";
            this.Prof_napr.Name = "Prof_napr";
            // 
            // Type
            // 
            this.Type.HeaderText = "Регион";
            this.Type.Name = "Type";
            // 
            // Info
            // 
            this.Info.HeaderText = "Описание работы";
            this.Info.Name = "Info";
            this.Info.Width = 200;
            // 
            // FormWorkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormWorkers";
            this.Text = "FormWorkers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn region;
        private System.Windows.Forms.DataGridViewTextBoxColumn Call_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prof_napr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Info;
    }
}