
namespace Cesar
{
    partial class CesarForm
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
            this.cesar_txt = new System.Windows.Forms.TextBox();
            this.shifr_btn = new System.Windows.Forms.Button();
            this.rashifr_btn = new System.Windows.Forms.Button();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.cesar_res_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.step_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cesar_txt
            // 
            this.cesar_txt.Location = new System.Drawing.Point(12, 35);
            this.cesar_txt.Multiline = true;
            this.cesar_txt.Name = "cesar_txt";
            this.cesar_txt.Size = new System.Drawing.Size(237, 157);
            this.cesar_txt.TabIndex = 0;
            // 
            // shifr_btn
            // 
            this.shifr_btn.Location = new System.Drawing.Point(295, 224);
            this.shifr_btn.Name = "shifr_btn";
            this.shifr_btn.Size = new System.Drawing.Size(94, 23);
            this.shifr_btn.TabIndex = 1;
            this.shifr_btn.Text = "Шифровать";
            this.shifr_btn.UseVisualStyleBackColor = true;
            this.shifr_btn.Click += new System.EventHandler(this.shifr_btn_Click);
            // 
            // rashifr_btn
            // 
            this.rashifr_btn.Location = new System.Drawing.Point(395, 224);
            this.rashifr_btn.Name = "rashifr_btn";
            this.rashifr_btn.Size = new System.Drawing.Size(91, 23);
            this.rashifr_btn.TabIndex = 2;
            this.rashifr_btn.Text = "Расшифровать";
            this.rashifr_btn.UseVisualStyleBackColor = true;
            this.rashifr_btn.Click += new System.EventHandler(this.rashifr_btn_Click);
            // 
            // refresh_btn
            // 
            this.refresh_btn.Location = new System.Drawing.Point(12, 198);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(75, 23);
            this.refresh_btn.TabIndex = 3;
            this.refresh_btn.Text = "Сбросить";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // cesar_res_txt
            // 
            this.cesar_res_txt.Location = new System.Drawing.Point(255, 35);
            this.cesar_res_txt.Multiline = true;
            this.cesar_res_txt.Name = "cesar_res_txt";
            this.cesar_res_txt.Size = new System.Drawing.Size(237, 157);
            this.cesar_res_txt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ввод текста";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(252, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Вывод результата";
            // 
            // step_txt
            // 
            this.step_txt.Location = new System.Drawing.Point(295, 198);
            this.step_txt.Name = "step_txt";
            this.step_txt.Size = new System.Drawing.Size(191, 20);
            this.step_txt.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Сдвиг (до 32):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 254);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.step_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cesar_res_txt);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.rashifr_btn);
            this.Controls.Add(this.shifr_btn);
            this.Controls.Add(this.cesar_txt);
            this.Name = "Form1";
            this.Text = "Cesar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cesar_txt;
        private System.Windows.Forms.Button shifr_btn;
        private System.Windows.Forms.Button rashifr_btn;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.TextBox cesar_res_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox step_txt;
        private System.Windows.Forms.Label label3;
    }
}

