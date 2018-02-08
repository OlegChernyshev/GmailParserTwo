namespace GmailParserViewProgram
{
    partial class FormMailTrigger
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
            this.components = new System.ComponentModel.Container();
            this.l_autorization = new System.Windows.Forms.Label();
            this.btn_formLogicStart = new System.Windows.Forms.Button();
            this.l_info = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // l_autorization
            // 
            this.l_autorization.AutoSize = true;
            this.l_autorization.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_autorization.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.l_autorization.Location = new System.Drawing.Point(135, 9);
            this.l_autorization.Name = "l_autorization";
            this.l_autorization.Size = new System.Drawing.Size(107, 40);
            this.l_autorization.TabIndex = 2;
            this.l_autorization.Text = "log in.";
            // 
            // btn_formLogicStart
            // 
            this.btn_formLogicStart.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_formLogicStart.Location = new System.Drawing.Point(22, 61);
            this.btn_formLogicStart.Name = "btn_formLogicStart";
            this.btn_formLogicStart.Size = new System.Drawing.Size(325, 48);
            this.btn_formLogicStart.TabIndex = 3;
            this.btn_formLogicStart.Text = "autoriation";
            this.btn_formLogicStart.UseVisualStyleBackColor = true;
            this.btn_formLogicStart.Click += new System.EventHandler(this.btn_formLogicStart_Click);
            // 
            // l_info
            // 
            this.l_info.AutoSize = true;
            this.l_info.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_info.ForeColor = System.Drawing.Color.Cornsilk;
            this.l_info.Location = new System.Drawing.Point(40, 127);
            this.l_info.Name = "l_info";
            this.l_info.Size = new System.Drawing.Size(285, 23);
            this.l_info.TabIndex = 9;
            this.l_info.Text = "Enter your details from account!";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormMailTrigger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(373, 170);
            this.Controls.Add(this.l_info);
            this.Controls.Add(this.btn_formLogicStart);
            this.Controls.Add(this.l_autorization);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMailTrigger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autoriation";
            this.Load += new System.EventHandler(this.FormMailTrigger_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label l_autorization;
        private System.Windows.Forms.Button btn_formLogicStart;
        private System.Windows.Forms.Label l_info;
        private System.Windows.Forms.Timer timer;
    }
}

