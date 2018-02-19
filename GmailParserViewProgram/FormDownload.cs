using GmailParserViewProgram.Act;
using GmailParserViewProgram.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GmailParserViewProgram
{
    public partial class FormDownload : Form
    {

        GDownloads downloads = new GDownloads();

        static Form parent = null;

        public void SetParent(Form form)
        {
            parent = form;
        }
        private void Exit()
        {
            parent.Show();
        }
        public FormDownload()
        {
            InitializeComponent();
        }

        private void FormDownload_FormClosed(object sender, FormClosedEventArgs e)
        {
            Exit();
        }

        private void FormDownload_Load(object sender, EventArgs e)
        {
            listView.Items.Clear();
            downloads.Get().Clear();
            GDownloads[] massive = (GDownloads[])FileParser.Read(GDownloads.pathfile);
            if (massive != null) GDownloads.SetDownloads(massive);
            refreshListData();
        }

        private void refreshListData()
        {
            listView.Items.Clear();
            foreach (GDownloads item in downloads.Get())
                listView.Items.Add(item.filename).SubItems.Add(item.path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView.Items.Clear();
            downloads.Reset();
            GDownloads.SetChange(true);
        }

        private void Tick_Tick(object sender, EventArgs e)
        {
            if (GDownloads.IsChange())
            {
                button2.Text = button2.Text + "*";
            }
        }

        private void listViewMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ListView.SelectedListViewItemCollection breakfast = this.listView.SelectedItems;
            foreach (ListViewItem item in breakfast)
            {
                item.Remove();
                downloads.DeleteItem(downloads.Predicate(item.SubItems[1].Text));
                GDownloads.SetChange(true);
                item.ForeColor = Color.Green;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileParser.Save(GDownloads.pathfile, downloads.Get().ToArray());
            GDownloads.SetChange(false);
        }
    }
}
