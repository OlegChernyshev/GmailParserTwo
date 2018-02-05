using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using GmailParser;
using GmailParserViewProgram.Model;

namespace GmailParserViewProgram
{
    public partial class FormMailTrigger : System.Windows.Forms.Form
    {
        private FormMailTriggerLogic fmtl = null;

        public FormMailTrigger()
        {
            InitializeComponent();
            this.Show();
            fmtl = new FormMailTriggerLogic();

            //Act.DataLoginAct.Read();

            UserData.Init().Email = "oleg";
            tb_mail.Text = UserData.GetUserData().Email;

            DataLoginModel dataLogin = new DataLoginModel("chernyshev360@gmail.com" , "1234");

            GLogin.Init();
            GLogin.Glogin.CreateGmailService();
            GMessage gMessage = new GMessage(GLogin.Glogin.GmailService, dataLogin);

            string str = gMessage.GetMessageRaw(gMessage.Find( new GRule("TestTag" , "testpath") , gMessage.GetMessages()));



            //UserData.GetUserData().CreateGmailService();
            //UserData.GetUserData().ListMessagesMatchungQuerty(UserData.GetUserData().GmailService, "me", String.Empty);

            

            //Google.Apis.Gmail.v1.Data.Message mes = UserData.GetMessage(UserData.GetUserData().GmailService, "chernyshev360@gmail.com", "0");
            //tb_mail.Text = mes.Payload.Headers.ToString();
        }

        private async void FormMailTrigger_Load(object sender, EventArgs e)
        {
            MailTrigerHide = false;

            await Task.Run(() =>
            {
                byte n = 1;
                while (true)
                {
                    Thread.Sleep(600);
                    if (ActiveForm != null)
                    {
                        ActiveForm.Invoke(new Action(() => l_autorization.Text += "."));
                        ++n;
                        if (n >= 4)
                        {
                            ActiveForm.Invoke(new Action(() => l_autorization.Text = "log in"));
                            n = 0;
                        }
                    }
                }
            });

        }

        private async void btn_formLogicStart_Click(object sender, EventArgs e)
        {
            if (tb_mail.Text == "chernyshev360" || tb_password.Text == "1234")
            {
                SetInfo("Connecting to email...\nWait please!", Color.GreenYellow);

                await ConnectionGmail();
            }
            if (tb_mail.Text != "chernyshev360" || tb_password.Text != "1234")
                SetInfo("Invalid email or password!", Color.Red);
            if (tb_mail.Text == String.Empty || tb_password.Text == String.Empty)
                SetInfo("Enter your details from account.", Color.Cornsilk);
        }

        private void cb_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_showPassword.Checked)
            {
                tb_password.PasswordChar = '\0';
            }
            else tb_password.PasswordChar = '*';
        }

        // Задает информационную строку
        private void SetInfo(String str, Color color)
        {
            l_info.Text = str;
            l_info.ForeColor = color;
        }

        private Task ConnectionGmail()
        {
            return Task.Run(() =>
            {
                Thread.Sleep(2000);
                //MailTrigerHide = true;
                fmtl.Show();
                fmtl.SetParent(this);
                fmtl.Focus();
            });
        }

        private bool MailTrigerHide;

        private void timer_Tick(object sender, EventArgs e)
        {
            if (MailTrigerHide) FormMailTrigger.ActiveForm.Hide();
        }
    }
}
