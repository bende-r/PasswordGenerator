namespace PasswordGenerator
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
            this.charsinput = new System.Windows.Forms.TextBox();
            this.numberofchars = new System.Windows.Forms.TrackBar();
            this.generatebutton = new System.Windows.Forms.Button();
            this.Lable1 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numberofchars)).BeginInit();
            this.SuspendLayout();
            // 
            // charsinput
            // 
            this.charsinput.Location = new System.Drawing.Point(18, 27);
            this.charsinput.Name = "charsinput";
            this.charsinput.Size = new System.Drawing.Size(222, 22);
            this.charsinput.TabIndex = 0;
            // 
            // numberofchars
            // 
            this.numberofchars.Location = new System.Drawing.Point(246, 27);
            this.numberofchars.Minimum = 1;
            this.numberofchars.Name = "numberofchars";
            this.numberofchars.Size = new System.Drawing.Size(136, 56);
            this.numberofchars.TabIndex = 1;
            this.numberofchars.Value = 1;
            // 
            // generatebutton
            // 
            this.generatebutton.Location = new System.Drawing.Point(18, 55);
            this.generatebutton.Name = "generatebutton";
            this.generatebutton.Size = new System.Drawing.Size(130, 36);
            this.generatebutton.TabIndex = 2;
            this.generatebutton.Text = "Сгенерировать";
            this.generatebutton.UseVisualStyleBackColor = true;
            this.generatebutton.Click += new System.EventHandler(this.generatebutton_Click);
            // 
            // Lable1
            // 
            this.Lable1.AutoSize = true;
            this.Lable1.Location = new System.Drawing.Point(12, 121);
            this.Lable1.Name = "Lable1";
            this.Lable1.Size = new System.Drawing.Size(83, 16);
            this.Lable1.TabIndex = 3;
            this.Lable1.Text = "Ваш пароль";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(18, 140);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(222, 22);
            this.result.TabIndex = 4;
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 184);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(18, 228);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(222, 22);
            this.textBox2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Число комбинаций";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Время взлома(сек)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.Lable1);
            this.Controls.Add(this.generatebutton);
            this.Controls.Add(this.numberofchars);
            this.Controls.Add(this.charsinput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numberofchars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox charsinput;
        private System.Windows.Forms.TrackBar numberofchars;
        private System.Windows.Forms.Button generatebutton;
        private System.Windows.Forms.Label Lable1;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

