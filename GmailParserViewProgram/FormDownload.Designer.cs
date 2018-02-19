namespace GmailParserViewProgram
{
    partial class FormDownload
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView = new System.Windows.Forms.ListView();
            this.filename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.filename,
            this.path});
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(12, 12);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(428, 332);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // filename
            // 
            this.filename.Text = "filename";
            this.filename.Width = 150;
            // 
            // path
            // 
            this.path.Text = "path";
            this.path.Width = 275;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Удалить все";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(107, 26);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.listViewMenuStrip_ItemClicked);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.deleteToolStripMenuItem.Text = "delete";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Tick_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(272, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(452, 453);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView);
            this.Name = "FormDownload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Download";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDownload_FormClosed);
            this.Load += new System.EventHandler(this.FormDownload_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader filename;
        private System.Windows.Forms.ColumnHeader path;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
    }
}