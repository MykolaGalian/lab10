namespace lab10
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
            this.sin = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.tg = new System.Windows.Forms.Button();
            this.ctg = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sin
            // 
            this.sin.Location = new System.Drawing.Point(423, 4);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(75, 23);
            this.sin.TabIndex = 0;
            this.sin.Text = "sin(x)";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Click += new System.EventHandler(this.sin_Click);
            // 
            // cos
            // 
            this.cos.Location = new System.Drawing.Point(423, 33);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(75, 23);
            this.cos.TabIndex = 1;
            this.cos.Text = "cos(x)";
            this.cos.UseVisualStyleBackColor = true;
            this.cos.Click += new System.EventHandler(this.cos_Click);
            // 
            // tg
            // 
            this.tg.Location = new System.Drawing.Point(423, 62);
            this.tg.Name = "tg";
            this.tg.Size = new System.Drawing.Size(75, 23);
            this.tg.TabIndex = 2;
            this.tg.Text = "tg(x)";
            this.tg.UseVisualStyleBackColor = true;
            this.tg.Click += new System.EventHandler(this.tg_Click);
            // 
            // ctg
            // 
            this.ctg.Location = new System.Drawing.Point(423, 91);
            this.ctg.Name = "ctg";
            this.ctg.Size = new System.Drawing.Size(75, 23);
            this.ctg.TabIndex = 3;
            this.ctg.Text = "ctg(x)";
            this.ctg.UseVisualStyleBackColor = true;
            this.ctg.Click += new System.EventHandler(this.ctg_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(423, 176);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 4;
            this.Clear.Text = "Очистить";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(419, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "О программе";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(510, 281);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.ctg);
            this.Controls.Add(this.tg);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.sin);
            this.Name = "Form1";
            this.Text = "Графики тригонометрических  функций";
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button tg;
        private System.Windows.Forms.Button ctg;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button button1;
    }
}

