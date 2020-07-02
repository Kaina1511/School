namespace School
{
    partial class Menu
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
            this.buttonStud = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonTeatch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStud
            // 
            this.buttonStud.Location = new System.Drawing.Point(57, 82);
            this.buttonStud.Name = "buttonStud";
            this.buttonStud.Size = new System.Drawing.Size(132, 35);
            this.buttonStud.TabIndex = 0;
            this.buttonStud.Text = "Ученики";
            this.buttonStud.UseVisualStyleBackColor = true;
            this.buttonStud.Click += new System.EventHandler(this.buttonStud_Click);
            // 
            // buttonSub
            // 
            this.buttonSub.Location = new System.Drawing.Point(57, 140);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(132, 35);
            this.buttonSub.TabIndex = 1;
            this.buttonSub.Text = "Предметы";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.buttonSub_Click);
            // 
            // buttonTeatch
            // 
            this.buttonTeatch.Location = new System.Drawing.Point(57, 201);
            this.buttonTeatch.Name = "buttonTeatch";
            this.buttonTeatch.Size = new System.Drawing.Size(132, 35);
            this.buttonTeatch.TabIndex = 2;
            this.buttonTeatch.Text = "Учителя";
            this.buttonTeatch.UseVisualStyleBackColor = true;
            this.buttonTeatch.Click += new System.EventHandler(this.buttonTeatch_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 315);
            this.Controls.Add(this.buttonTeatch);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.buttonStud);
            this.Name = "Menu";
            this.Text = "Меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStud;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonTeatch;
    }
}

