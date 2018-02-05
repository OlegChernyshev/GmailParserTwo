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
            this.tb_mail = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.l_autorization = new System.Windows.Forms.Label();
            this.btn_formLogicStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_savedata = new System.Windows.Forms.CheckBox();
            this.cb_showPassword = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.l_info = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tb_mail
            // 
            this.tb_mail.AccessibleDescription = "";
            this.tb_mail.AccessibleName = "";
            this.tb_mail.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_mail.Location = new System.Drawing.Point(12, 69);
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tb_mail.Size = new System.Drawing.Size(154, 26);
            this.tb_mail.TabIndex = 0;
            this.tb_mail.Tag = "";
            this.tb_mail.Text = "chernyshev360";
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tb_password.Location = new System.Drawing.Point(12, 127);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tb_password.Size = new System.Drawing.Size(284, 26);
            this.tb_password.TabIndex = 1;
            this.tb_password.Text = "1234";
            // 
            // l_autorization
            // 
            this.l_autorization.AutoSize = true;
            this.l_autorization.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_autorization.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.l_autorization.Location = new System.Drawing.Point(108, 13);
            this.l_autorization.Name = "l_autorization";
            this.l_autorization.Size = new System.Drawing.Size(107, 40);
            this.l_autorization.TabIndex = 2;
            this.l_autorization.Text = "log in.";
            // 
            // btn_formLogicStart
            // 
            this.btn_formLogicStart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_formLogicStart.Location = new System.Drawing.Point(214, 168);
            this.btn_formLogicStart.Name = "btn_formLogicStart";
            this.btn_formLogicStart.Size = new System.Drawing.Size(82, 29);
            this.btn_formLogicStart.TabIndex = 3;
            this.btn_formLogicStart.Text = "next";
            this.btn_formLogicStart.UseVisualStyleBackColor = true;
            this.btn_formLogicStart.Click += new System.EventHandler(this.btn_formLogicStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(172, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "@gmail.com";
            // 
            // cb_savedata
            // 
            this.cb_savedata.AutoSize = true;
            this.cb_savedata.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_savedata.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cb_savedata.Location = new System.Drawing.Point(21, 168);
            this.cb_savedata.Name = "cb_savedata";
            this.cb_savedata.Size = new System.Drawing.Size(95, 22);
            this.cb_savedata.TabIndex = 5;
            this.cb_savedata.Text = "save data";
            this.cb_savedata.UseVisualStyleBackColor = true;
            // 
            // cb_showPassword
            // 
            this.cb_showPassword.AutoSize = true;
            this.cb_showPassword.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cb_showPassword.Font = new System.Drawing.Font("Arial", 12F);
            this.cb_showPassword.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cb_showPassword.Location = new System.Drawing.Point(307, 130);
            this.cb_showPassword.Name = "cb_showPassword";
            this.cb_showPassword.Size = new System.Drawing.Size(63, 22);
            this.cb_showPassword.TabIndex = 6;
            this.cb_showPassword.Text = "show";
            this.cb_showPassword.UseVisualStyleBackColor = false;
            this.cb_showPassword.CheckedChanged += new System.EventHandler(this.cb_showPassword_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(18, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(18, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "password";
            // 
            // l_info
            // 
            this.l_info.AutoSize = true;
            this.l_info.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_info.ForeColor = System.Drawing.Color.Cornsilk;
            this.l_info.Location = new System.Drawing.Point(18, 217);
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
            this.ClientSize = new System.Drawing.Size(373, 273);
            this.Controls.Add(this.l_info);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_showPassword);
            this.Controls.Add(this.cb_savedata);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_formLogicStart);
            this.Controls.Add(this.l_autorization);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_mail);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMailTrigger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail Trigger";
            this.Load += new System.EventHandler(this.FormMailTrigger_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_mail;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label l_autorization;
        private System.Windows.Forms.Button btn_formLogicStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_savedata;
        private System.Windows.Forms.CheckBox cb_showPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label l_info;
        private System.Windows.Forms.Timer timer;
    }
}

