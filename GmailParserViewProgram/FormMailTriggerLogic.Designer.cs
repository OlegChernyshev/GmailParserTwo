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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.menuStripTop = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Save_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.действиеНазадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tick = new System.Windows.Forms.Timer(this.components);
            this.cb_autorun = new System.Windows.Forms.CheckBox();
            this.l_version = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.l_counterMessage = new System.Windows.Forms.Label();
            this.l_fileCounter = new System.Windows.Forms.Label();
            this.l_counter = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBarAll = new System.Windows.Forms.ProgressBar();
            this.l_count = new System.Windows.Forms.Label();
            this.l_status = new System.Windows.Forms.Label();
            this.btn_deleteAll = new System.Windows.Forms.Button();
            this.listBoxMode = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_tag = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_type = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.l_discrition = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStripDown = new System.Windows.Forms.MenuStrip();
            this.l_mail = new System.Windows.Forms.Label();
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gRuleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listViewMenuStrip.SuspendLayout();
            this.menuStripTop.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRuleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(36, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Path";
            // 
            // tb_local
            // 
            this.tb_local.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tb_local.Location = new System.Drawing.Point(107, 35);
            this.tb_local.Name = "tb_local";
            this.tb_local.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tb_local.Size = new System.Drawing.Size(530, 26);
            this.tb_local.TabIndex = 9;
            // 
            // btn_select
            // 
            this.btn_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_select.Location = new System.Drawing.Point(643, 36);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(74, 24);
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
            this.type,
            this.path,
            this.subject});
            this.listView.ContextMenuStrip = this.listViewMenuStrip;
            this.listView.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.Location = new System.Drawing.Point(10, 28);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(502, 303);
            this.listView.TabIndex = 12;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.Enter += new System.EventHandler(this.listView_Enter);
            // 
            // tag
            // 
            this.tag.Text = "Tag";
            this.tag.Width = 150;
            // 
            // path
            // 
            this.path.DisplayIndex = 1;
            this.path.Text = "Path";
            this.path.Width = 352;
            // 
            // listViewMenuStrip
            // 
            this.listViewMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.listViewMenuStrip.Name = "listViewMenuStrip";
            this.listViewMenuStrip.Size = new System.Drawing.Size(153, 48);
            this.listViewMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.listViewMenuStrip_ItemClicked);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.файлToolStripMenuItem.Text = "delete";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_add.Location = new System.Drawing.Point(533, 450);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(89, 24);
            this.btn_add.TabIndex = 15;
            this.btn_add.Text = "add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_reset.Location = new System.Drawing.Point(628, 450);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(89, 24);
            this.btn_reset.TabIndex = 17;
            this.btn_reset.Text = "reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // menuStripTop
            // 
            this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.downloadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStripTop.Location = new System.Drawing.Point(0, 0);
            this.menuStripTop.Name = "menuStripTop";
            this.menuStripTop.Size = new System.Drawing.Size(1283, 24);
            this.menuStripTop.TabIndex = 19;
            this.menuStripTop.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Save_ToolStripMenuItem,
            this.действиеНазадToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
            this.toolStripMenuItem1.Text = "Action";
            // 
            // Save_ToolStripMenuItem
            // 
            this.Save_ToolStripMenuItem.Name = "Save_ToolStripMenuItem";
            this.Save_ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.Save_ToolStripMenuItem.Text = "Save";
            this.Save_ToolStripMenuItem.Click += new System.EventHandler(this.Save_ToolStripMenuItem_Click);
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
            this.downloadToolStripMenuItem.Click += new System.EventHandler(this.downloadToolStripMenuItem_Click);
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
            this.Tick.Tick += new System.EventHandler(this.Tick_Tick);
            // 
            // cb_autorun
            // 
            this.cb_autorun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_autorun.AutoSize = true;
            this.cb_autorun.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cb_autorun.Location = new System.Drawing.Point(1037, 4);
            this.cb_autorun.Name = "cb_autorun";
            this.cb_autorun.Size = new System.Drawing.Size(117, 17);
            this.cb_autorun.TabIndex = 20;
            this.cb_autorun.Text = "Autorun application";
            this.cb_autorun.UseVisualStyleBackColor = false;
            this.cb_autorun.CheckedChanged += new System.EventHandler(this.cb_autorun_CheckedChanged);
            // 
            // l_version
            // 
            this.l_version.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.l_version.AutoSize = true;
            this.l_version.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.l_version.Location = new System.Drawing.Point(1164, 672);
            this.l_version.Name = "l_version";
            this.l_version.Size = new System.Drawing.Size(31, 13);
            this.l_version.TabIndex = 21;
            this.l_version.Text = "v 0.1";
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_start.Location = new System.Drawing.Point(271, 18);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(219, 43);
            this.btn_start.TabIndex = 22;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // l_counterMessage
            // 
            this.l_counterMessage.AutoSize = true;
            this.l_counterMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_counterMessage.Location = new System.Drawing.Point(28, 52);
            this.l_counterMessage.Name = "l_counterMessage";
            this.l_counterMessage.Size = new System.Drawing.Size(45, 16);
            this.l_counterMessage.TabIndex = 23;
            this.l_counterMessage.Text = "label2";
            // 
            // l_fileCounter
            // 
            this.l_fileCounter.AutoSize = true;
            this.l_fileCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_fileCounter.Location = new System.Drawing.Point(28, 79);
            this.l_fileCounter.Name = "l_fileCounter";
            this.l_fileCounter.Size = new System.Drawing.Size(45, 16);
            this.l_fileCounter.TabIndex = 24;
            this.l_fileCounter.Text = "label2";
            // 
            // l_counter
            // 
            this.l_counter.AutoSize = true;
            this.l_counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_counter.Location = new System.Drawing.Point(28, 25);
            this.l_counter.Name = "l_counter";
            this.l_counter.Size = new System.Drawing.Size(45, 16);
            this.l_counter.TabIndex = 25;
            this.l_counter.Text = "label2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBarAll);
            this.groupBox1.Controls.Add(this.l_count);
            this.groupBox1.Controls.Add(this.l_status);
            this.groupBox1.Controls.Add(this.btn_start);
            this.groupBox1.Controls.Add(this.l_counter);
            this.groupBox1.Controls.Add(this.l_counterMessage);
            this.groupBox1.Controls.Add(this.l_fileCounter);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(10, 371);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 141);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Processing";
            // 
            // progressBarAll
            // 
            this.progressBarAll.Location = new System.Drawing.Point(31, 105);
            this.progressBarAll.Name = "progressBarAll";
            this.progressBarAll.Size = new System.Drawing.Size(447, 22);
            this.progressBarAll.TabIndex = 28;
            // 
            // l_count
            // 
            this.l_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_count.Location = new System.Drawing.Point(163, 64);
            this.l_count.Name = "l_count";
            this.l_count.Size = new System.Drawing.Size(119, 38);
            this.l_count.TabIndex = 27;
            this.l_count.Text = "label2";
            this.l_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l_status
            // 
            this.l_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_status.Location = new System.Drawing.Point(271, 64);
            this.l_status.Name = "l_status";
            this.l_status.Size = new System.Drawing.Size(219, 38);
            this.l_status.TabIndex = 26;
            this.l_status.Text = "label2";
            this.l_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_deleteAll
            // 
            this.btn_deleteAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_deleteAll.Location = new System.Drawing.Point(365, 343);
            this.btn_deleteAll.Name = "btn_deleteAll";
            this.btn_deleteAll.Size = new System.Drawing.Size(135, 28);
            this.btn_deleteAll.TabIndex = 28;
            this.btn_deleteAll.Text = "delete all";
            this.btn_deleteAll.UseVisualStyleBackColor = true;
            this.btn_deleteAll.Click += new System.EventHandler(this.btn_deleteAll_Click);
            // 
            // listBoxMode
            // 
            this.listBoxMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxMode.FormattingEnabled = true;
            this.listBoxMode.ItemHeight = 20;
            this.listBoxMode.Items.AddRange(new object[] {
            "label",
            "subject"});
            this.listBoxMode.Location = new System.Drawing.Point(41, 109);
            this.listBoxMode.Name = "listBoxMode";
            this.listBoxMode.Size = new System.Drawing.Size(205, 64);
            this.listBoxMode.TabIndex = 29;
            this.listBoxMode.SelectedIndexChanged += new System.EventHandler(this.listBoxMode_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.listView);
            this.groupBox2.Controls.Add(this.btn_deleteAll);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(747, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(524, 525);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inforamation";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(41, 248);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(685, 180);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Settings";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Controls.Add(this.tb_tag);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(237, 28);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(215, 137);
            this.groupBox5.TabIndex = 34;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tags";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox7.Location = new System.Drawing.Point(19, 56);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(182, 71);
            this.groupBox7.TabIndex = 35;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Example";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 36);
            this.label4.TabIndex = 32;
            this.label4.Text = "One : one\r\nSeveral : one two three";
            // 
            // tb_tag
            // 
            this.tb_tag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_tag.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_tag.Location = new System.Drawing.Point(19, 23);
            this.tb_tag.Name = "tb_tag";
            this.tb_tag.Size = new System.Drawing.Size(176, 24);
            this.tb_tag.TabIndex = 31;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.tb_type);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(24, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(183, 137);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "File type";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox6.Location = new System.Drawing.Point(17, 56);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(140, 71);
            this.groupBox6.TabIndex = 34;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Example";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(15, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 36);
            this.label5.TabIndex = 32;
            this.label5.Text = "One : txt \r\nSeveral : txt pdf";
            // 
            // tb_type
            // 
            this.tb_type.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_type.Location = new System.Drawing.Point(17, 23);
            this.tb_type.Name = "tb_type";
            this.tb_type.Size = new System.Drawing.Size(150, 24);
            this.tb_type.TabIndex = 31;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.panel1);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox8.Location = new System.Drawing.Point(252, 80);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(474, 133);
            this.groupBox8.TabIndex = 35;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Discription";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.l_discrition);
            this.panel1.Location = new System.Drawing.Point(6, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 109);
            this.panel1.TabIndex = 35;
            // 
            // l_discrition
            // 
            this.l_discrition.AutoSize = true;
            this.l_discrition.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_discrition.Location = new System.Drawing.Point(23, 4);
            this.l_discrition.Name = "l_discrition";
            this.l_discrition.Size = new System.Drawing.Size(86, 18);
            this.l_discrition.TabIndex = 32;
            this.l_discrition.Text = "Don\'t select";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(36, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 26);
            this.label1.TabIndex = 36;
            this.label1.Text = "Mode";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(80, 179);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 22);
            this.checkBox1.TabIndex = 37;
            this.checkBox1.Text = "file type sorting";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.gRuleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 560);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(652, 100);
            this.dataGridView1.TabIndex = 39;
            // 
            // menuStripDown
            // 
            this.menuStripDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStripDown.Location = new System.Drawing.Point(0, 666);
            this.menuStripDown.Name = "menuStripDown";
            this.menuStripDown.Size = new System.Drawing.Size(1283, 24);
            this.menuStripDown.TabIndex = 40;
            this.menuStripDown.Text = "menuStrip1";
            // 
            // l_mail
            // 
            this.l_mail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.l_mail.AutoSize = true;
            this.l_mail.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.l_mail.Location = new System.Drawing.Point(23, 672);
            this.l_mail.Name = "l_mail";
            this.l_mail.Size = new System.Drawing.Size(45, 13);
            this.l_mail.TabIndex = 41;
            this.l_mail.Text = "mail info";
            // 
            // type
            // 
            this.type.DisplayIndex = 2;
            this.type.Text = "Type";
            // 
            // subject
            // 
            this.subject.Text = "Subject";
            // 
            // gRuleBindingSource
            // 
            this.gRuleBindingSource.DataSource = typeof(GmailParserViewProgram.Model.GRule);
            // 
            // FormMailTriggerLogic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1283, 690);
            this.Controls.Add(this.l_mail);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.l_version);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.listBoxMode);
            this.Controls.Add(this.cb_autorun);
            this.Controls.Add(this.menuStripTop);
            this.Controls.Add(this.menuStripDown);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_local);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.MainMenuStrip = this.menuStripTop;
            this.Name = "FormMailTriggerLogic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMailTriggerLogic_FormClosed);
            this.Load += new System.EventHandler(this.FormMailTriggerLogic_Load);
            this.listViewMenuStrip.ResumeLayout(false);
            this.menuStripTop.ResumeLayout(false);
            this.menuStripTop.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRuleBindingSource)).EndInit();
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
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.ContextMenuStrip listViewMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStripTop;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Save_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem действиеНазадToolStripMenuItem;
        private System.Windows.Forms.Timer Tick;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.CheckBox cb_autorun;
        private System.Windows.Forms.Label l_version;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label l_counterMessage;
        private System.Windows.Forms.Label l_fileCounter;
        private System.Windows.Forms.Label l_counter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label l_status;
        private System.Windows.Forms.Label l_count;
        private System.Windows.Forms.Button btn_deleteAll;
        private System.Windows.Forms.ListBox listBoxMode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_type;
        private System.Windows.Forms.ProgressBar progressBarAll;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tb_tag;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label l_discrition;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource gRuleBindingSource;
        private System.Windows.Forms.MenuStrip menuStripDown;
        private System.Windows.Forms.Label l_mail;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader subject;
    }
}