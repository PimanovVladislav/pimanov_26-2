namespace ИндЗад2
{
    partial class FormUser
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
            this.addbtn = new System.Windows.Forms.Button();
            this.Changebtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.ObnBtn = new System.Windows.Forms.Button();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Call_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prof_napr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Info,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(765, 342);
            this.dataGridView1.TabIndex = 1;
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(788, 58);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(100, 23);
            this.addbtn.TabIndex = 2;
            this.addbtn.Text = "Добавить";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // Changebtn
            // 
            this.Changebtn.Location = new System.Drawing.Point(788, 87);
            this.Changebtn.Name = "Changebtn";
            this.Changebtn.Size = new System.Drawing.Size(100, 23);
            this.Changebtn.TabIndex = 3;
            this.Changebtn.Text = "Изменить";
            this.Changebtn.UseVisualStyleBackColor = true;
            this.Changebtn.Click += new System.EventHandler(this.Changebtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(788, 116);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(100, 23);
            this.deletebtn.TabIndex = 4;
            this.deletebtn.Text = "Удалить";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // ObnBtn
            // 
            this.ObnBtn.Location = new System.Drawing.Point(788, 145);
            this.ObnBtn.Name = "ObnBtn";
            this.ObnBtn.Size = new System.Drawing.Size(100, 23);
            this.ObnBtn.TabIndex = 6;
            this.ObnBtn.Text = "Обновить";
            this.ObnBtn.UseVisualStyleBackColor = true;
            this.ObnBtn.Click += new System.EventHandler(this.ObnBtn_Click);
            // 
            // Company
            // 
            this.Company.HeaderText = "Фамилия";
            this.Company.Name = "Company";
            this.Company.Width = 120;
            // 
            // region
            // 
            this.region.HeaderText = "Имя";
            this.region.Name = "region";
            // 
            // Call_data
            // 
            this.Call_data.HeaderText = "Отчество";
            this.Call_data.Name = "Call_data";
            // 
            // Prof_napr
            // 
            this.Prof_napr.HeaderText = "Пол";
            this.Prof_napr.Name = "Prof_napr";
            this.Prof_napr.Width = 60;
            // 
            // Type
            // 
            this.Type.HeaderText = "Возраст";
            this.Type.Name = "Type";
            this.Type.Width = 60;
            // 
            // Info
            // 
            this.Info.HeaderText = "Паспортные данные";
            this.Info.Name = "Info";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "О себе";
            this.Column1.Name = "Column1";
            this.Column1.Width = 180;
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.ObnBtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.Changebtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormUser";
            this.Text = "FormUser";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button Changebtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button ObnBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn region;
        private System.Windows.Forms.DataGridViewTextBoxColumn Call_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prof_napr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Info;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}