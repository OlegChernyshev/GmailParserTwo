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
        static Form parent = null;
        const string applicationName = "Settings";

        public void SetParent (Form form)
        {
            parent = form;
        }

        GRule gRule = new GRule();

        public FormMailTriggerLogic()
        {
            InitializeComponent();
            
            this.Text = applicationName;

            listView.View = System.Windows.Forms.View.Details;
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.Margin = new Padding(40, 0, 30, 0);
            
        }

        GMessage gMessage = null;
        private async void FormMailTriggerLogic_Load(object sender, EventArgs e)
        {
            listView.Items.Clear();

            l_version.Text = "Version : " + Application.ProductVersion.ToString();
            var data = await GLogin.Glogin.GmailService.Users.GetProfile("me").ExecuteAsync();
            l_mail.Text = data.EmailAddress;
            l_status.Text = "tap start";
            l_count.Text = "0";

            gRule.Get().Clear();
            GRule[] massive = (GRule[])FileParser.Read(GRule.pathfile);
            if(massive != null) GRule.SetGrules(massive);

            refreshListData();

            GRule.SetChange(false);

            if (AutoRun.IsEnabled()) cb_autorun.Checked = true;
            else cb_autorun.Checked = false;
            

            if (GLogin.Glogin == null) GLogin.Init(); GLogin.Glogin.CreateGmailService();
            gMessage = new GMessage(GLogin.Glogin.GmailService);

            this.Select();

            //string query = Query(new GRule("wir-aliter-axi", "C:/user/document/s", "label", null));
            //List<string> ids = await gMessage.GetMessagesNew(query);
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
                gRule.DeleteItem(gRule.Predicate(item.Text));
                GRule.SetChange(true);
                item.ForeColor = Color.Green;
            }
        }

        private void refreshListData ()
        {
            listView.Items.Clear();
            foreach (GRule item in gRule.Get())
                listView.Items.Add(item.tag).SubItems.Add(item.path);
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
            //GMessage.BackCall(ref l_counter/*, null, null, null*/);
            //GMessage.countMessage += 1;
            l_counter.Text = GMessage.countMessage.ToString();
            if (gMessage != null)
            {
                l_counterMessage.Text = "message find : " + GMessage.messageFind.ToString();
                l_fileCounter.Text = "file find : " + GMessage.fileFind.ToString();
                l_counter.Text = "count message : " + GMessage.countMessage.ToString();
            }

            l_status.Text = status;
            l_count.Text = GMessage.counter.ToString();
            //l_counter.Text = "count message : " + GMessage.countMessage.ToString();
            l_counterMessage.Text = "last message : " + GMessage.counter;
            l_fileCounter.Text = "file find : " + GMessage.fileFind.ToString();

            if (GRule.IsChange())
            {
                Save_ToolStripMenuItem.Text = "Save*";
                this.Text = applicationName + " (you have change)*";
            }
            else
            {
                Save_ToolStripMenuItem.Text = "Save";
                this.Text = applicationName;
            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tb_tag.Text != String.Empty && 
                tb_local.Text != String.Empty &&
                listBoxMode.Text != String.Empty &&
                tb_type.Text != String.Empty)
            {
                gRule.Add(new GRule(tb_tag.Text, tb_local.Text , listBoxMode.Text , tb_type.Text));
                refreshListData();
                GRule.SetChange(true);
            }
            else
            {
                GRule.SetChange(false);
                Color col = tb_local.BackColor;
                if (tb_tag.Text == String.Empty) tb_tag.BackColor = Color.Red;
                if (tb_local.Text == String.Empty) tb_local.BackColor = Color.Red;
                if (listBoxMode.Text == String.Empty) listBoxMode.BackColor = Color.Red;
                if (tb_type.Text == String.Empty) tb_type.BackColor = Color.Red;
                //tb_tag.BackColor = tb_local.BackColor = Color.Red;
                if (MessageBox.Show("One of the fields does not have values!", "Warning") == DialogResult.OK)
                {
                    listBoxMode.BackColor = tb_type.BackColor = tb_tag.BackColor = tb_local.BackColor = col;
                }
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            tb_local.Text = String.Empty;
            tb_tag.Text = String.Empty;
        }

        private void FormMailTriggerLogic_FormClosed(object sender, FormClosedEventArgs e)
        {
            Exit();
        }

        private async void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await GLogin.Glogin.DeleteUserAuthorization();
            this.Close();
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
                //this.UseWaitCursor = true;
                btn_start.Text = await Task<string>.Run(() => {

                    GMessage.counter = 0;
                    //GRule gRule = new GRule(tb_tag.Text, tb_local.Text , null , null);

                    //l_counterMessage.Text = "message find : " + GMessage.messageFind.ToString();
                    //l_fileCounter.Text = "file find : " + GMessage.fileFind.ToString();
                    //gMessage.GetFile(gMessage.Find(new GRule(tb_tag.Text, tb_local.Text), gMessage.GetMessages()), tb_local.Text);
                    status = "Get messages...";
                    List<string> messagesId = null;
                    foreach (GRule gRule in gRule.Get())
                    {
                        messagesId = gMessage.GetMessages(Query(gRule));
                        status = "find messages...";

                        foreach (string id in messagesId)
                        {
                            //Task.Run(() => {
                            //GMessage.counter--;
                            //string str = gMessage.Find(gRule, id);
                            if (id != String.Empty)
                                gMessage.GetFile(id, gRule.path);
                            //});
                        }
                    }
                    status  = "Get files...";
                    return "Start";
                });
                l_counter.Text = "count message : " + GMessage.countMessage.ToString();
            }
        }

        private void Exit ()
        {
            parent.Show();
        }

        static FormDownload formDownload = null;
        private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                formDownload = new FormDownload();
                formDownload.SetParent(this);
                formDownload.Show();
            }
            catch (Exception) { }
        }

        private void Save_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileParser.Save(GRule.pathfile, gRule.Get().ToArray());
            GRule.SetChange(false);
        }

        private void btn_deleteAll_Click(object sender, EventArgs e)
        {
            listView.Items.Clear();
            gRule.Reset();
            GRule.SetChange(true);
        }

        private void listBoxMode_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (listBoxMode.Text)
            {
                
                case СONCEPT.MODE.label:
                    l_discrition.Text = СONCEPT.DISCRIPTION.label;
                    break;
                case СONCEPT.MODE.subject:
                    l_discrition.Text = СONCEPT.DISCRIPTION.subject;
                    break;
                default:
                    l_discrition.Text = "Don't select";
                    break;
            }

        }

        private string Query (GRule gRule)
        {
            string result = String.Empty;
            string type = gRule.type;
            string mode = gRule.mode;
            string tags = gRule.tag;

            switch (mode)
            {
                case СONCEPT.MODE.label :
                    result += Model.СONCEPT.GetLabel(tags);
                    break;
                case СONCEPT.MODE.subject:
                    result += Model.СONCEPT.GetSubject(tags);
                    break;
                default:
                    break;
            }

            result += " ";

            if (type != null && type != String.Empty)
            {
                result += СONCEPT.GetFilename(type);
                /*
                string[] strings = Regex.Split(type, " ");
                foreach (string str in strings)
                    result += str + " ";
                result += ") ";
                */
            }
            //result = "subject:(file_logic mm) filename:txt ";
            return result;

        }

    }
}
