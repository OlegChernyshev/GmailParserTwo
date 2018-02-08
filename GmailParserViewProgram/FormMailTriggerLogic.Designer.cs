namespace GmailParserViewProgram
{
    partial class FormMailTriggerLogic
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
            this.label3 = new System.Windows.Forms.Label();
            this.tb_local = new System.Windows.Forms.TextBox();
            this.btn_select = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.tag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_tag = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Action_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.действиеНазадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tick = new System.Windows.Forms.Timer(this.components);
            this.cb_autorun = new System.Windows.Forms.CheckBox();
            this.l_version = new System.Windows.Forms.Label();
            this.listViewMenuStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(12, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "path";
            // 
            // tb_local
            // 
<<<<<<< HEAD


=======
>>>>>>> 2ae205d30d9660f7d8ba0975eb374791d72f2551
            this.tb_local.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tb_local.Location = new System.Drawing.Point(71, 32);
            this.tb_local.Name = "tb_local";
            this.tb_local.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tb_local.Size = new System.Drawing.Size(351, 26);
            this.tb_local.TabIndex = 9;
<<<<<<< HEAD

=======
>>>>>>> 2ae205d30d9660f7d8ba0975eb374791d72f2551
            // 
            // btn_select
            // 
            this.btn_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_select.Location = new System.Drawing.Point(428, 32);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(90, 26);
            this.btn_select.TabIndex = 11;
            this.btn_select.Text = "select";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // listView
            // 
            this.listView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tag,
            this.path});
            this.listView.ContextMenuStrip = this.listViewMenuStrip;
            this.listView.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.Location = new System.Drawing.Point(15, 108);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(506, 312);
            this.listView.TabIndex = 12;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.Enter += new System.EventHandler(this.listView_Enter);
            // 
            // tag
            // 
            this.tag.Text = "Tags";
            this.tag.Width = 150;
            // 
            // path
            // 
            this.path.Text = "Paths";
            this.path.Width = 352;
            // 
            // listViewMenuStrip
            // 
            this.listViewMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.listViewMenuStrip.Name = "listViewMenuStrip";
            this.listViewMenuStrip.Size = new System.Drawing.Size(107, 26);
            this.listViewMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.listViewMenuStrip_ItemClicked);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.файлToolStripMenuItem.Text = "delete";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(11, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "tag";
            // 
            // tb_tag
            // 
            this.tb_tag.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tb_tag.Location = new System.Drawing.Point(70, 70);
            this.tb_tag.Name = "tb_tag";
            this.tb_tag.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tb_tag.Size = new System.Drawing.Size(256, 26);
            this.tb_tag.TabIndex = 13;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_add.Location = new System.Drawing.Point(332, 70);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(90, 26);
            this.btn_add.TabIndex = 15;
            this.btn_add.Text = "add";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_reset.Location = new System.Drawing.Point(428, 70);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(90, 26);
            this.btn_reset.TabIndex = 17;
            this.btn_reset.Text = "reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.downloadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(533, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Action_ToolStripMenuItem,
            this.действиеНазадToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
            this.toolStripMenuItem1.Text = "Action";
            // 
            // Action_ToolStripMenuItem
            // 
            this.Action_ToolStripMenuItem.Name = "Action_ToolStripMenuItem";
            this.Action_ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.Action_ToolStripMenuItem.Text = "Save";
            // 
            // действиеНазадToolStripMenuItem
            // 
            this.действиеНазадToolStripMenuItem.Name = "действиеНазадToolStripMenuItem";
            this.действиеНазадToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.действиеНазадToolStripMenuItem.Text = "Действие назад";
            // 
            // downloadToolStripMenuItem
            // 
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            this.downloadToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.downloadToolStripMenuItem.Text = "Download";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.exitToolStripMenuItem.Text = "Log out";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Tick
            // 
            this.Tick.Enabled = true;
            this.Tick.Interval = 400;
            // 
            // cb_autorun
            // 
            this.cb_autorun.AutoSize = true;
            this.cb_autorun.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cb_autorun.Location = new System.Drawing.Point(210, 5);
            this.cb_autorun.Name = "cb_autorun";
            this.cb_autorun.Size = new System.Drawing.Size(62, 17);
            this.cb_autorun.TabIndex = 20;
            this.cb_autorun.Text = "autorun";
            this.cb_autorun.UseVisualStyleBackColor = false;
            this.cb_autorun.CheckedChanged += new System.EventHandler(this.cb_autorun_CheckedChanged);
            // 
            // l_version
            // 
            this.l_version.AutoSize = true;
            this.l_version.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.l_version.Location = new System.Drawing.Point(444, 5);
            this.l_version.Name = "l_version";
            this.l_version.Size = new System.Drawing.Size(31, 13);
            this.l_version.TabIndex = 21;
            this.l_version.Text = "v 0.1";
            // 
            // FormMailTriggerLogic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(533, 432);
            this.Controls.Add(this.l_version);
            this.Controls.Add(this.cb_autorun);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_tag);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_local);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMailTriggerLogic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
<<<<<<< HEAD
            this.Text = "FormMailTriggerLogic";
=======
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMailTriggerLogic_FormClosed);
>>>>>>> 2ae205d30d9660f7d8ba0975eb374791d72f2551
            this.Load += new System.EventHandler(this.FormMailTriggerLogic_Load);
            this.listViewMenuStrip.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_local;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader tag;
        private System.Windows.Forms.ColumnHeader path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_tag;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.ContextMenuStrip listViewMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Action_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem действиеНазадToolStripMenuItem;
        private System.Windows.Forms.Timer Tick;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.CheckBox cb_autorun;
        private System.Windows.Forms.Label l_version;
    }
}