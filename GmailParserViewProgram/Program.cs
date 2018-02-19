using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GmailParserViewProgram
{
    static class Program
    {
        static private FormMailTriggerLogic FormMailTriggerLogic = null;
        static public FormMailTriggerLogic GetFormMailTriggerLogic()
        {
            FormMailTriggerLogic = new FormMailTriggerLogic();
            FormMailTriggerLogic.ShowDialog();
            return FormMailTriggerLogic;
        }

        static private FormDownload FormDownload = null;
        static public FormDownload GetFormDownload()
        {
            if (FormDownload == null) FormDownload = new FormDownload();
            return FormDownload;
        }

        static private FormMailTrigger FormMailTrigger = null;
        static public FormMailTrigger GetFormMailTrigger()
        {
            if (FormMailTrigger == null) FormMailTrigger = new FormMailTrigger();
            return FormMailTrigger;
        }

        static private Form activeForm = null;
        static public Form GetActiveForm()
        {
            return activeForm;
        }

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            FormMailTriggerLogic = new FormMailTriggerLogic();
            FormDownload = new FormDownload();
            activeForm = FormMailTrigger = new FormMailTrigger();

            Application.EnableVisualStyles();
            Application.Run(activeForm);
            //Application.Run(new FormMailTriggerLogic());
            //Application.Run(new FormDownload());
        }

        static public void ClearForm()
        {
            activeForm = null;
        }

        static public void Sweatch(Form next)
        {
            if (activeForm != null)
                activeForm.Hide();
            activeForm = next;
            next.Show();
            next.Focus();
            
        }
    }
}
