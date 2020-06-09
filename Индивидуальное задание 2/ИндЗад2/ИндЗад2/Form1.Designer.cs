namespace ИндЗад2
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
            this.btn_Company = new System.Windows.Forms.Button();
            this.btn_Vacanse = new System.Windows.Forms.Button();
            this.btn_Rezume = new System.Windows.Forms.Button();
            this.btn_Clients = new System.Windows.Forms.Button();
            this.btn_workers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Company
            // 
            this.btn_Company.Location = new System.Drawing.Point(246, 92);
            this.btn_Company.Name = "btn_Company";
            this.btn_Company.Size = new System.Drawing.Size(369, 23);
            this.btn_Company.TabIndex = 0;
            this.btn_Company.Text = "Открыть список компаний";
            this.btn_Company.UseVisualStyleBackColor = true;
            this.btn_Company.Click += new System.EventHandler(this.btn_Company_Click);
            // 
            // btn_Vacanse
            // 
            this.btn_Vacanse.Location = new System.Drawing.Point(246, 121);
            this.btn_Vacanse.Name = "btn_Vacanse";
            this.btn_Vacanse.Size = new System.Drawing.Size(369, 23);
            this.btn_Vacanse.TabIndex = 1;
            this.btn_Vacanse.Text = "Открыть список вакансий";
            this.btn_Vacanse.UseVisualStyleBackColor = true;
            this.btn_Vacanse.Click += new System.EventHandler(this.btn_Vacanse_Click);
            // 
            // btn_Rezume
            // 
            this.btn_Rezume.Location = new System.Drawing.Point(246, 150);
            this.btn_Rezume.Name = "btn_Rezume";
            this.btn_Rezume.Size = new System.Drawing.Size(369, 23);
            this.btn_Rezume.TabIndex = 2;
            this.btn_Rezume.Text = "Открыть список резюме";
            this.btn_Rezume.UseVisualStyleBackColor = true;
            this.btn_Rezume.Click += new System.EventHandler(this.btn_Rezume_Click);
            // 
            // btn_Clients
            // 
            this.btn_Clients.Location = new System.Drawing.Point(246, 179);
            this.btn_Clients.Name = "btn_Clients";
            this.btn_Clients.Size = new System.Drawing.Size(369, 23);
            this.btn_Clients.TabIndex = 3;
            this.btn_Clients.Text = "Открыть список соискателей";
            this.btn_Clients.UseVisualStyleBackColor = true;
            this.btn_Clients.Click += new System.EventHandler(this.btn_Clients_Click);
            // 
            // btn_workers
            // 
            this.btn_workers.Location = new System.Drawing.Point(246, 208);
            this.btn_workers.Name = "btn_workers";
            this.btn_workers.Size = new System.Drawing.Size(369, 23);
            this.btn_workers.TabIndex = 4;
            this.btn_workers.Text = "Открыть список работников";
            this.btn_workers.UseVisualStyleBackColor = true;
            this.btn_workers.Click += new System.EventHandler(this.btn_workers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_workers);
            this.Controls.Add(this.btn_Clients);
            this.Controls.Add(this.btn_Rezume);
            this.Controls.Add(this.btn_Vacanse);
            this.Controls.Add(this.btn_Company);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Company;
        private System.Windows.Forms.Button btn_Vacanse;
        private System.Windows.Forms.Button btn_Rezume;
        private System.Windows.Forms.Button btn_Clients;
        private System.Windows.Forms.Button btn_workers;
    }
}

