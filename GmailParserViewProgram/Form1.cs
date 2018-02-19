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

using GmailParserViewProgram.Model;

namespace GmailParserViewProgram
{
    public partial class FormMailTrigger : System.Windows.Forms.Form
    {
        

        public FormMailTrigger()
        {
            InitializeComponent();

            //Act.DataLoginAct.Read();


            //DataLoginModel dataLogin = new DataLoginModel("me" , "1234");

            //GMessage gMessage = new GMessage(GLogin.Glogin.GmailService);
            //string str = gMessage.GetMessageRaw(gMessage.Find( new GRule("TestTag" , "testpath") , gMessage.GetMessages()));

            //CheckMessages(dataLogin);


            //UserData.GetUserData().CreateGmailService();
            //UserData.GetUserData().ListMessagesMatchungQuerty(UserData.GetUserData().GmailService, "me", String.Empty);



            //Google.Apis.Gmail.v1.Data.Message mes = UserData.GetMessage(UserData.GetUserData().GmailService, "chernyshev360@gmail.com", "0");
            //tb_mail.Text = mes.Payload.Headers.ToString();
        }

        private async void FormMailTrigger_Load(object sender, EventArgs e)
        {
            MailTrigerHide = false;
            /*
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
            */

        }
        static FormMailTriggerLogic formMailTriggerLogic = null;
        private async void btn_formLogicStart_Click(object sender, EventArgs e)
        {
            //Program.Sweatch(Program.GetFormMailTriggerLogic());
            GLogin.Init();
            try
            {
               await GLogin.Glogin.CreateGmailService();
                this.Hide();
                formMailTriggerLogic = new FormMailTriggerLogic();
                formMailTriggerLogic.SetParent(this);
                formMailTriggerLogic.Show();
            }
            catch(Exception) { }
            
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
                Program.Sweatch(Program.GetFormMailTriggerLogic());
            });
        }

        private bool MailTrigerHide;

        private void timer_Tick(object sender, EventArgs e)
        {
            if (MailTrigerHide) FormMailTrigger.ActiveForm.Hide();
        }

    }
}
