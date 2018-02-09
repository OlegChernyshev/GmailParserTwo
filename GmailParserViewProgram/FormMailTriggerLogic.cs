using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;

using GmailParserViewProgram.Model;
using GmailParserViewProgram.Act;

namespace GmailParserViewProgram
{
    public partial class FormMailTriggerLogic : Form
    {
        public FormMailTriggerLogic()
        {
            InitializeComponent();

            listView.View = View.Details;
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.Margin = new Padding(40, 0, 30, 0);

        }
        GMessage gMessage = null;
        private void FormMailTriggerLogic_Load(object sender, EventArgs e)
        {
            listView.Items.Clear();

            l_version.Text = Application.ProductVersion.ToString();
            l_status.Text = "tap start";
            l_count.Text = "0";
            GRule.Read();

            refreshListData();

            if (AutoRun.IsEnabled()) cb_autorun.Checked = true;
            else cb_autorun.Checked = false;
            

            if (GLogin.Glogin == null) GLogin.Init(); GLogin.Glogin.CreateGmailService();
            gMessage = new GMessage(GLogin.Glogin.GmailService);
            //string str1 = gMessage.GetMessageRaw(gMessage.Find( new GRule(tb_tag.Text, tb_local.Text) , gMessage.GetMessages()));
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView.ForeColor = Color.Black;
            ListView.SelectedListViewItemCollection breakfast = this.listView.SelectedItems;
            foreach (ListViewItem item in breakfast)
            {
                tb_local.Text = item.SubItems[0].Text;
                item.ForeColor = Color.Green;
            }

        }

        private void listView_Enter(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection breakfast = this.listView.SelectedItems;
            foreach (ListViewItem item in breakfast)
            {
                
            }
        }

        private void listViewMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ListView.SelectedListViewItemCollection breakfast = this.listView.SelectedItems;
            foreach (ListViewItem item in breakfast)
            {
                item.Remove();
                GRule.DeleteItem(item.Text);
                item.ForeColor = Color.Green;
            }
        }

        private void refreshListData ()
        {
            listView.Items.Clear();
            foreach (GRule item in GRule.GetGrules())
                listView.Items.Add(item.tag).SubItems.Add(item.path);
            //GRule.Save();
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            string path = String.Empty;

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                tb_local.Text = folderBrowserDialog.SelectedPath.Replace("\\", "/");
            }
        }

        private void tb_password_TextChanged(object sender, EventArgs e) { }
        private bool tb_local_text_find = false;
        private void tb_local_TextChanged(object sender, EventArgs e)
        {
            if (tb_local.Text != String.Empty) tb_local_text_find = true;
            else tb_local_text_find = false;
        }

        private bool tb_tag_text_find = false;
        private void tb_tag_TextChanged(object sender, EventArgs e)
        {
            if (tb_local.Text != String.Empty) tb_tag_text_find = true;
            else tb_tag_text_find = false;
        }

        private void Tick_Tick(object sender, EventArgs e)
        {
            if (gMessage != null)
            {
                l_counterMessage.Text = "message find : " + GMessage.messageFind.ToString();
                l_fileCounter.Text = "file find : " + GMessage.fileFind.ToString();
                l_counter.Text = "count message : " + GMessage.countMessage.ToString();
            }

            l_status.Text = status;
            l_count.Text = GMessage.counter.ToString();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var itemText = "sdf";

            //MessageBox.Show(itemText);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            GRule.Add(new GRule(tb_tag.Text, tb_local.Text));
            refreshListData();
        }

        private void Action_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GRule.Save();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            listView.Items.Clear();
            GRule.Reset();
        }

        private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Sweatch(Program.GetFormDownload());
        }

        private void FormMailTriggerLogic_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Program.ClearForm();
            FormMailTrigger formMailTrigger = new FormMailTrigger();
            formMailTrigger.ShowDialog();

        }

        private async void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await GLogin.Glogin.DeleteUserAuthorization();
        }

        private void cb_autorun_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_autorun.Checked)
            {
                if (!AutoRun.IsEnabled()) AutoRun.Enabled();
            }
            else if (AutoRun.IsEnabled()) AutoRun.Disabled();

        }

        Task findTask;

        static string str = String.Empty;
        static string status = String.Empty;
        private async void btn_start_Click(object sender, EventArgs e)
        {

            if (gMessage != null)
            {
                btn_start.Text = "Wait";
                btn_start.Text = await Task<string>.Run(() => {

                    GRule gRule = new GRule(tb_tag.Text, tb_local.Text);

                    l_counterMessage.Text = "message find : " + GMessage.messageFind.ToString();
                    l_fileCounter.Text = "file find : " + GMessage.fileFind.ToString();
                    //gMessage.GetFile(gMessage.Find(new GRule(tb_tag.Text, tb_local.Text), gMessage.GetMessages()), tb_local.Text);
                    status = "Get messages...";
                    List<string> messagesId = gMessage.GetMessages();
                    status = "find messages...";
                    messagesId = gMessage.Find(gRule , messagesId);
                    status  = "Get files...";
                    gMessage.GetFile(messagesId, gRule.path);
                    l_counter.Text = "count message : " + GMessage.countMessage.ToString();
                    return "Start";
                });

                //findTask.Wait();


                /*
                await findTask.Run(() => {
                    l_counterMessage.Text = "message find : " + gMessage.messageFind.ToString();
                    l_fileCounter.Text = "file find : " + gMessage.fileFind.ToString();
                    //gMessage.GetFile(gMessage.Find(new GRule(tb_tag.Text, tb_local.Text), gMessage.GetMessages()), tb_local.Text);
                    List<string> s1 = gMessage.GetMessages();
                    l_counter.Text = "count message : " + gMessage.countMessage.ToString();
                    var s2 = s1;
                });
                */
                l_counter.Text = "count message : " + GMessage.countMessage.ToString();


            }
        }

        static void ThreadFunction()
        {
            //Аналогично главному потоку выводим три раза текст
            int count = 3;
            while (count > 0)
            {
                Console.WriteLine("Это дочерний поток программы!");
                --count;
            }
        }
    }
}
