using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using GmailParserViewProgram.Model;

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

            GRule.Read();

            refreshListData();
        }

        private void FormMailTriggerLogic_Load(object sender, EventArgs e)
        {

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

<<<<<<< HEAD
        private void tb_password_TextChanged(object sender, EventArgs e)
        {
=======

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
            if (tb_local_text_find && tb_tag_text_find) ;    
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
>>>>>>> 4cc6251531fb85721edfc6cd40e8a899e4ac9ed6

        }
    }
}
