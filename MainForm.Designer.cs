namespace v5yxBrowser
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStripTab = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuCloseTab = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCloseOtherTabs = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TxtURL = new System.Windows.Forms.TextBox();
            this.TabPages = new FarsiLibrary.Win.FATabStrip();
            this.tabStrip1 = new FarsiLibrary.Win.FATabStripItem();
            this.XS = new System.Windows.Forms.Button();
            this.tabStripAdd = new FarsiLibrary.Win.FATabStripItem();
            this.PanelSearch = new System.Windows.Forms.Panel();
            this.BtnNextSearch = new System.Windows.Forms.Button();
            this.BtnPrevSearch = new System.Windows.Forms.Button();
            this.BtnCloseSearch = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.butt_zuidah = new System.Windows.Forms.Button();
            this.butt_syin = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.butt_BtnRefresh = new System.Windows.Forms.Button();
            this.butt_qingli = new System.Windows.Forms.Button();
            this.pic_Mxi = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.BtnDownloads = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnForward = new System.Windows.Forms.Button();
            this.menuStripTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabPages)).BeginInit();
            this.TabPages.SuspendLayout();
            this.tabStrip1.SuspendLayout();
            this.PanelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Mxi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripTab
            // 
            this.menuStripTab.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripTab.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCloseTab,
            this.menuCloseOtherTabs});
            this.menuStripTab.Name = "menuStripTab";
            this.menuStripTab.Size = new System.Drawing.Size(249, 64);
            // 
            // menuCloseTab
            // 
            this.menuCloseTab.Name = "menuCloseTab";
            this.menuCloseTab.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.menuCloseTab.Size = new System.Drawing.Size(248, 30);
            this.menuCloseTab.Text = "Close tab";
            this.menuCloseTab.Click += new System.EventHandler(this.menuCloseTab_Click);
            // 
            // menuCloseOtherTabs
            // 
            this.menuCloseOtherTabs.Name = "menuCloseOtherTabs";
            this.menuCloseOtherTabs.Size = new System.Drawing.Size(248, 30);
            this.menuCloseOtherTabs.Text = "Close other tabs";
            this.menuCloseOtherTabs.Click += new System.EventHandler(this.menuCloseOtherTabs_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TxtURL
            // 
            this.TxtURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtURL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtURL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtURL.Location = new System.Drawing.Point(1071, 12);
            this.TxtURL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtURL.Name = "TxtURL";
            this.TxtURL.Size = new System.Drawing.Size(134, 32);
            this.TxtURL.TabIndex = 5;
            this.TxtURL.Visible = false;
            this.TxtURL.Click += new System.EventHandler(this.txtUrl_Click);
            this.TxtURL.TextChanged += new System.EventHandler(this.txtUrl_TextChanged);
            this.TxtURL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtURL_KeyDown);
            // 
            // TabPages
            // 
            this.TabPages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabPages.ContextMenuStrip = this.menuStripTab;
            this.TabPages.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPages.Items.AddRange(new FarsiLibrary.Win.FATabStripItem[] {
            this.tabStrip1,
            this.tabStripAdd});
            this.TabPages.Location = new System.Drawing.Point(1, 64);
            this.TabPages.Name = "TabPages";
            this.TabPages.SelectedItem = this.tabStrip1;
            this.TabPages.Size = new System.Drawing.Size(1465, 595);
            this.TabPages.TabIndex = 4;
            this.TabPages.Text = "faTabStrip1";
            this.TabPages.TabStripItemSelectionChanged += new FarsiLibrary.Win.TabStripItemChangedHandler(this.OnTabsChanged);
            this.TabPages.TabStripItemClosed += new System.EventHandler(this.OnTabClosed);
            this.TabPages.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabPages_MouseClick);
            // 
            // tabStrip1
            // 
            this.tabStrip1.Controls.Add(this.XS);
            this.tabStrip1.IsDrawn = true;
            this.tabStrip1.Name = "tabStrip1";
            this.tabStrip1.Selected = true;
            this.tabStrip1.Size = new System.Drawing.Size(1463, 565);
            this.tabStrip1.TabIndex = 0;
            this.tabStrip1.Title = "Loading...";
            // 
            // XS
            // 
            this.XS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.XS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XS.Location = new System.Drawing.Point(1444, 575);
            this.XS.Name = "XS";
            this.XS.Size = new System.Drawing.Size(18, 23);
            this.XS.TabIndex = 2;
            this.XS.UseVisualStyleBackColor = true;
            // 
            // tabStripAdd
            // 
            this.tabStripAdd.CanClose = false;
            this.tabStripAdd.IsDrawn = true;
            this.tabStripAdd.Name = "tabStripAdd";
            this.tabStripAdd.Size = new System.Drawing.Size(931, 601);
            this.tabStripAdd.TabIndex = 1;
            this.tabStripAdd.Title = "+";
            this.tabStripAdd.Visible = false;
            // 
            // PanelSearch
            // 
            this.PanelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelSearch.BackColor = System.Drawing.Color.White;
            this.PanelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelSearch.Controls.Add(this.BtnNextSearch);
            this.PanelSearch.Controls.Add(this.BtnPrevSearch);
            this.PanelSearch.Controls.Add(this.BtnCloseSearch);
            this.PanelSearch.Controls.Add(this.TxtSearch);
            this.PanelSearch.Location = new System.Drawing.Point(1158, 29);
            this.PanelSearch.Name = "PanelSearch";
            this.PanelSearch.Size = new System.Drawing.Size(307, 40);
            this.PanelSearch.TabIndex = 9;
            this.PanelSearch.Visible = false;
            // 
            // BtnNextSearch
            // 
            this.BtnNextSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNextSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNextSearch.ForeColor = System.Drawing.Color.White;
            this.BtnNextSearch.Image = ((System.Drawing.Image)(resources.GetObject("BtnNextSearch.Image")));
            this.BtnNextSearch.Location = new System.Drawing.Point(239, 4);
            this.BtnNextSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnNextSearch.Name = "BtnNextSearch";
            this.BtnNextSearch.Size = new System.Drawing.Size(25, 30);
            this.BtnNextSearch.TabIndex = 9;
            this.BtnNextSearch.Tag = "Find next (Enter)";
            this.BtnNextSearch.UseVisualStyleBackColor = true;
            this.BtnNextSearch.Click += new System.EventHandler(this.BtnNextSearch_Click);
            // 
            // BtnPrevSearch
            // 
            this.BtnPrevSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPrevSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrevSearch.ForeColor = System.Drawing.Color.White;
            this.BtnPrevSearch.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrevSearch.Image")));
            this.BtnPrevSearch.Location = new System.Drawing.Point(206, 4);
            this.BtnPrevSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnPrevSearch.Name = "BtnPrevSearch";
            this.BtnPrevSearch.Size = new System.Drawing.Size(25, 30);
            this.BtnPrevSearch.TabIndex = 8;
            this.BtnPrevSearch.Tag = "Find previous (Shift+Enter)";
            this.BtnPrevSearch.UseVisualStyleBackColor = true;
            this.BtnPrevSearch.Click += new System.EventHandler(this.BtnPrevSearch_Click);
            // 
            // BtnCloseSearch
            // 
            this.BtnCloseSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCloseSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCloseSearch.ForeColor = System.Drawing.Color.White;
            this.BtnCloseSearch.Image = ((System.Drawing.Image)(resources.GetObject("BtnCloseSearch.Image")));
            this.BtnCloseSearch.Location = new System.Drawing.Point(272, 4);
            this.BtnCloseSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCloseSearch.Name = "BtnCloseSearch";
            this.BtnCloseSearch.Size = new System.Drawing.Size(25, 30);
            this.BtnCloseSearch.TabIndex = 7;
            this.BtnCloseSearch.Tag = "Close (Esc)";
            this.BtnCloseSearch.UseVisualStyleBackColor = true;
            this.BtnCloseSearch.Click += new System.EventHandler(this.BtnClearSearch_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSearch.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearch.Location = new System.Drawing.Point(10, 6);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(181, 37);
            this.TxtSearch.TabIndex = 6;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            this.TxtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSearch_KeyDown);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(316, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(974, 32);
            this.label1.TabIndex = 47;
            this.label1.Text = "温馨提示：     F5刷新         Alt+Z老板键         两次Alt+Z可以在任何时间恢复全屏游戏哟！ ";
            this.label1.Visible = false;
            // 
            // butt_zuidah
            // 
            this.butt_zuidah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butt_zuidah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butt_zuidah.ForeColor = System.Drawing.Color.White;
            this.butt_zuidah.Image = global::v5yxBrowser.Properties.Resources.最大化;
            this.butt_zuidah.Location = new System.Drawing.Point(1323, 11);
            this.butt_zuidah.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butt_zuidah.Name = "butt_zuidah";
            this.butt_zuidah.Size = new System.Drawing.Size(40, 39);
            this.butt_zuidah.TabIndex = 48;
            this.butt_zuidah.UseVisualStyleBackColor = true;
            this.butt_zuidah.Visible = false;
            this.butt_zuidah.Click += new System.EventHandler(this.butt_zuidah_Click);
            // 
            // butt_syin
            // 
            this.butt_syin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butt_syin.ForeColor = System.Drawing.Color.White;
            this.butt_syin.Image = global::v5yxBrowser.Properties.Resources.声音;
            this.butt_syin.Location = new System.Drawing.Point(137, 12);
            this.butt_syin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butt_syin.Name = "butt_syin";
            this.butt_syin.Size = new System.Drawing.Size(40, 39);
            this.butt_syin.TabIndex = 46;
            this.butt_syin.UseVisualStyleBackColor = true;
            this.butt_syin.Click += new System.EventHandler(this.butt_syin_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStop.ForeColor = System.Drawing.Color.White;
            this.BtnStop.Image = global::v5yxBrowser.Properties.Resources.停止2;
            this.BtnStop.Location = new System.Drawing.Point(1371, 12);
            this.BtnStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(40, 39);
            this.BtnStop.TabIndex = 45;
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // butt_BtnRefresh
            // 
            this.butt_BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butt_BtnRefresh.ForeColor = System.Drawing.Color.White;
            this.butt_BtnRefresh.Image = global::v5yxBrowser.Properties.Resources.刷新;
            this.butt_BtnRefresh.Location = new System.Drawing.Point(197, 12);
            this.butt_BtnRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butt_BtnRefresh.Name = "butt_BtnRefresh";
            this.butt_BtnRefresh.Size = new System.Drawing.Size(40, 39);
            this.butt_BtnRefresh.TabIndex = 44;
            this.butt_BtnRefresh.UseVisualStyleBackColor = true;
            this.butt_BtnRefresh.Click += new System.EventHandler(this.bRefresh_Click);
            // 
            // butt_qingli
            // 
            this.butt_qingli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butt_qingli.ForeColor = System.Drawing.Color.Transparent;
            this.butt_qingli.Image = global::v5yxBrowser.Properties.Resources.清理;
            this.butt_qingli.Location = new System.Drawing.Point(257, 12);
            this.butt_qingli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butt_qingli.Name = "butt_qingli";
            this.butt_qingli.Size = new System.Drawing.Size(40, 39);
            this.butt_qingli.TabIndex = 43;
            this.butt_qingli.UseVisualStyleBackColor = true;
            this.butt_qingli.Click += new System.EventHandler(this.butt_qingli_Click);
            // 
            // pic_Mxi
            // 
            this.pic_Mxi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Mxi.BackColor = System.Drawing.Color.Transparent;
            this.pic_Mxi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Mxi.ErrorImage = null;
            this.pic_Mxi.Image = ((System.Drawing.Image)(resources.GetObject("pic_Mxi.Image")));
            this.pic_Mxi.Location = new System.Drawing.Point(1422, 4);
            this.pic_Mxi.Name = "pic_Mxi";
            this.pic_Mxi.Size = new System.Drawing.Size(20, 20);
            this.pic_Mxi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_Mxi.TabIndex = 41;
            this.pic_Mxi.TabStop = false;
            this.pic_Mxi.Click += new System.EventHandler(this.pic_Mxi_Click);
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(1446, 4);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(20, 20);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picClose.TabIndex = 42;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // BtnDownloads
            // 
            this.BtnDownloads.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDownloads.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDownloads.ForeColor = System.Drawing.Color.White;
            this.BtnDownloads.Image = ((System.Drawing.Image)(resources.GetObject("BtnDownloads.Image")));
            this.BtnDownloads.Location = new System.Drawing.Point(1076, -31);
            this.BtnDownloads.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnDownloads.Name = "BtnDownloads";
            this.BtnDownloads.Size = new System.Drawing.Size(25, 30);
            this.BtnDownloads.TabIndex = 4;
            this.BtnDownloads.Tag = "Downloads";
            this.BtnDownloads.UseVisualStyleBackColor = true;
            this.BtnDownloads.Visible = false;
            this.BtnDownloads.Click += new System.EventHandler(this.bDownloads_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefresh.ForeColor = System.Drawing.Color.White;
            this.BtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("BtnRefresh.Image")));
            this.BtnRefresh.Location = new System.Drawing.Point(1030, -30);
            this.BtnRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(25, 30);
            this.BtnRefresh.TabIndex = 3;
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.bRefresh_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.Image = global::v5yxBrowser.Properties.Resources.后退;
            this.BtnBack.Location = new System.Drawing.Point(17, 12);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(40, 39);
            this.BtnBack.TabIndex = 0;
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // BtnForward
            // 
            this.BtnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnForward.ForeColor = System.Drawing.Color.White;
            this.BtnForward.Image = global::v5yxBrowser.Properties.Resources.前进;
            this.BtnForward.Location = new System.Drawing.Point(77, 12);
            this.BtnForward.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnForward.Name = "BtnForward";
            this.BtnForward.Size = new System.Drawing.Size(40, 39);
            this.BtnForward.TabIndex = 1;
            this.BtnForward.UseVisualStyleBackColor = true;
            this.BtnForward.Click += new System.EventHandler(this.bForward_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1468, 671);
            this.Controls.Add(this.butt_zuidah);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butt_syin);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.butt_BtnRefresh);
            this.Controls.Add(this.butt_qingli);
            this.Controls.Add(this.pic_Mxi);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.BtnDownloads);
            this.Controls.Add(this.TxtURL);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnForward);
            this.Controls.Add(this.TabPages);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Title";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStripTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabPages)).EndInit();
            this.TabPages.ResumeLayout(false);
            this.tabStrip1.ResumeLayout(false);
            this.PanelSearch.ResumeLayout(false);
            this.PanelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Mxi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

		private FarsiLibrary.Win.FATabStrip TabPages;
        private FarsiLibrary.Win.FATabStripItem tabStrip1;
        private FarsiLibrary.Win.FATabStripItem tabStripAdd;
		private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip menuStripTab;
        private System.Windows.Forms.ToolStripMenuItem menuCloseTab;
        private System.Windows.Forms.ToolStripMenuItem menuCloseOtherTabs;
		private System.Windows.Forms.Button BtnForward;
		private System.Windows.Forms.Button BtnBack;
		private System.Windows.Forms.Button BtnRefresh;
		private System.Windows.Forms.Button BtnDownloads;
		private System.Windows.Forms.TextBox TxtURL;
		private System.Windows.Forms.Panel PanelSearch;
		private System.Windows.Forms.TextBox TxtSearch;
		private System.Windows.Forms.Button BtnCloseSearch;
		private System.Windows.Forms.Button BtnPrevSearch;
		private System.Windows.Forms.Button BtnNextSearch;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button XS;
        private System.Windows.Forms.PictureBox pic_Mxi;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Button butt_qingli;
        private System.Windows.Forms.Button butt_BtnRefresh;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button butt_syin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butt_zuidah;
    }
}

