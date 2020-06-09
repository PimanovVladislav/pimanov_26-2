namespace ИндЗад2
{
    partial class FormCompany
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
            this.Savebtn = new System.Windows.Forms.Button();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Name,
            this.region,
            this.Call_data,
            this.Prof_napr,
            this.Type,
            this.Info});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 351);
            this.dataGridView1.TabIndex = 0;
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(753, 42);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(100, 23);
            this.addbtn.TabIndex = 1;
            this.addbtn.Text = "Добавить";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // Changebtn
            // 
            this.Changebtn.Location = new System.Drawing.Point(753, 71);
            this.Changebtn.Name = "Changebtn";
            this.Changebtn.Size = new System.Drawing.Size(100, 23);
            this.Changebtn.TabIndex = 2;
            this.Changebtn.Text = "Изменить";
            this.Changebtn.UseVisualStyleBackColor = true;
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(753, 100);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(100, 23);
            this.deletebtn.TabIndex = 3;
            this.deletebtn.Text = "Удалить";
            this.deletebtn.UseVisualStyleBackColor = true;
            // 
            // Savebtn
            // 
            this.Savebtn.Location = new System.Drawing.Point(753, 129);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(100, 23);
            this.Savebtn.TabIndex = 4;
            this.Savebtn.Text = "Сохранить";
            this.Savebtn.UseVisualStyleBackColor = true;
            // 
            // Name
            // 
            this.Name.HeaderText = "Название компании";
            this.Name.Name = "Name";
            // 
            // region
            // 
            this.region.HeaderText = "Регион";
            this.region.Name = "region";
            // 
            // Call_data
            // 
            this.Call_data.HeaderText = "Контактные данные";
            this.Call_data.Name = "Call_data";
            // 
            // Prof_napr
            // 
            this.Prof_napr.HeaderText = "Сфера деятельности";
            this.Prof_napr.Name = "Prof_napr";
            // 
            // Type
            // 
            this.Type.HeaderText = "Тип компании";
            this.Type.Name = "Type";
            // 
            // Info
            // 
            this.Info.HeaderText = "О компании";
            this.Info.Name = "Info";
            // 
            // FormCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 366);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.Changebtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormCompany";
            this.Text = "FormCompany";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button Changebtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn region;
        private System.Windows.Forms.DataGridViewTextBoxColumn Call_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prof_napr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Info;
    }
}