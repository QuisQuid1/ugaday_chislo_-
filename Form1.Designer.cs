namespace ugaday_chislo__
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
            this.button_povtor = new System.Windows.Forms.Button();
            this.button_check = new System.Windows.Forms.Button();
            this.label_rez = new System.Windows.Forms.Label();
            this.textBox_chisl = new System.Windows.Forms.TextBox();
            this.label_pop = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_povtor
            // 
            this.button_povtor.Location = new System.Drawing.Point(478, 336);
            this.button_povtor.Name = "button_povtor";
            this.button_povtor.Size = new System.Drawing.Size(75, 42);
            this.button_povtor.TabIndex = 9;
            this.button_povtor.Text = "button1";
            this.button_povtor.UseVisualStyleBackColor = true;
            this.button_povtor.Click += new System.EventHandler(this.button_povtor_Click);
            // 
            // button_check
            // 
            this.button_check.Location = new System.Drawing.Point(107, 336);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(75, 42);
            this.button_check.TabIndex = 8;
            this.button_check.Text = "button1";
            this.button_check.UseVisualStyleBackColor = true;
            this.button_check.Click += new System.EventHandler(this.button_check_Click);
            // 
            // label_rez
            // 
            this.label_rez.AutoSize = true;
            this.label_rez.Location = new System.Drawing.Point(192, 233);
            this.label_rez.Name = "label_rez";
            this.label_rez.Size = new System.Drawing.Size(51, 20);
            this.label_rez.TabIndex = 7;
            this.label_rez.Text = "label1";
            // 
            // textBox_chisl
            // 
            this.textBox_chisl.Location = new System.Drawing.Point(68, 117);
            this.textBox_chisl.Name = "textBox_chisl";
            this.textBox_chisl.Size = new System.Drawing.Size(100, 26);
            this.textBox_chisl.TabIndex = 6;
            // 
            // label_pop
            // 
            this.label_pop.AutoSize = true;
            this.label_pop.Location = new System.Drawing.Point(64, 40);
            this.label_pop.Name = "label_pop";
            this.label_pop.Size = new System.Drawing.Size(51, 20);
            this.label_pop.TabIndex = 5;
            this.label_pop.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_povtor);
            this.Controls.Add(this.button_check);
            this.Controls.Add(this.label_rez);
            this.Controls.Add(this.textBox_chisl);
            this.Controls.Add(this.label_pop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_povtor;
        private System.Windows.Forms.Button button_check;
        private System.Windows.Forms.Label label_rez;
        private System.Windows.Forms.TextBox textBox_chisl;
        private System.Windows.Forms.Label label_pop;
    }
}

