namespace WindowsFormsApp20
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
            this.stroka = new System.Windows.Forms.TextBox();
            this.rez = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.attention = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // stroka
            // 
            this.stroka.Location = new System.Drawing.Point(36, 42);
            this.stroka.Multiline = true;
            this.stroka.Name = "stroka";
            this.stroka.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.stroka.Size = new System.Drawing.Size(466, 55);
            this.stroka.TabIndex = 0;
            // 
            // rez
            // 
            this.rez.Location = new System.Drawing.Point(36, 120);
            this.rez.Multiline = true;
            this.rez.Name = "rez";
            this.rez.ReadOnly = true;
            this.rez.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.rez.Size = new System.Drawing.Size(466, 55);
            this.rez.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите строку с датой в формате дд.мм.гггг.: \r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ваша строка с датой следующего дня: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(509, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 55);
            this.button1.TabIndex = 4;
            this.button1.Text = "Заменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(508, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 55);
            this.button2.TabIndex = 5;
            this.button2.Text = "Очистить все";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // attention
            // 
            this.attention.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.attention.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.attention.Location = new System.Drawing.Point(36, 181);
            this.attention.Multiline = true;
            this.attention.Name = "attention";
            this.attention.ReadOnly = true;
            this.attention.Size = new System.Drawing.Size(586, 55);
            this.attention.TabIndex = 6;
            this.attention.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 257);
            this.Controls.Add(this.attention);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rez);
            this.Controls.Add(this.stroka);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox stroka;
        private System.Windows.Forms.TextBox rez;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox attention;
    }
}

