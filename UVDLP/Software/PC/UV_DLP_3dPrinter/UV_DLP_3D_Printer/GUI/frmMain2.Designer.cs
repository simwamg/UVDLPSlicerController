﻿namespace UV_DLP_3D_Printer.GUI
{
    partial class frmMain2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain2));
            this.pnlTopIcons = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl3dview = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTopTabs = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSliceView = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSceneSTLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pluginTesterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plugInsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardwareGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ctlMainConfig1 = new UV_DLP_3D_Printer.GUI.Controls.ctlMainConfig();
            this.ctlMainManual1 = new UV_DLP_3D_Printer.GUI.Controls.ManualControls.ctlMainManual();
            this.ctlSliceGCodePanel1 = new UV_DLP_3D_Printer.GUI.Controls.ctlSliceGCodePanel();
            this.ctl3DView1 = new UV_DLP_3D_Printer.GUI.Controls.ctl3DView();
            this.buttExpandLeft = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.ctlSupports1 = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlSupports();
            this.ctlScene1 = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlScene();
            this.ctlObjectInfo1 = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlObjectInfo();
            this.ctlMoveExpand1 = new UV_DLP_3D_Printer.GUI.CustomGUI.Expanding.ctlMoveExpand();
            this.ctlMirror1 = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlMirror();
            this.ctlScale1 = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlScale();
            this.ctlRotate1 = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlRotate();
            this.ctlView1 = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlView();
            this.ctlTitle3dView = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlTitle();
            this.ctlTitleViewSlice = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlTitle();
            this.ctlTitleViewControls = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlTitle();
            this.ctlTitleConfigure = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlTitle();
            this.buttOpenFile = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.buttPlay = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.buttPause = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.buttStop = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.buttConnect = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.buttDisconnect = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.buttSlice = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.pnlTopIcons.SuspendLayout();
            this.pnl3dview.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlTopTabs.SuspendLayout();
            this.pnlSliceView.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopIcons
            // 
            this.pnlTopIcons.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlTopIcons.Controls.Add(this.buttOpenFile);
            this.pnlTopIcons.Controls.Add(this.buttPlay);
            this.pnlTopIcons.Controls.Add(this.buttPause);
            this.pnlTopIcons.Controls.Add(this.buttStop);
            this.pnlTopIcons.Controls.Add(this.buttConnect);
            this.pnlTopIcons.Controls.Add(this.buttDisconnect);
            this.pnlTopIcons.Controls.Add(this.buttSlice);
            this.pnlTopIcons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopIcons.Location = new System.Drawing.Point(0, 28);
            this.pnlTopIcons.Name = "pnlTopIcons";
            this.pnlTopIcons.Size = new System.Drawing.Size(1380, 56);
            this.pnlTopIcons.TabIndex = 0;
            // 
            // pnl3dview
            // 
            this.pnl3dview.Controls.Add(this.ctl3DView1);
            this.pnl3dview.Controls.Add(this.flowLayoutPanel2);
            this.pnl3dview.Controls.Add(this.flowLayoutPanel1);
            this.pnl3dview.Location = new System.Drawing.Point(19, 20);
            this.pnl3dview.Name = "pnl3dview";
            this.pnl3dview.Size = new System.Drawing.Size(697, 412);
            this.pnl3dview.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.flowLayoutPanel2.Controls.Add(this.buttExpandLeft);
            this.flowLayoutPanel2.Controls.Add(this.ctlSupports1);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(50, 412);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.flowLayoutPanel1.Controls.Add(this.ctlScene1);
            this.flowLayoutPanel1.Controls.Add(this.ctlObjectInfo1);
            this.flowLayoutPanel1.Controls.Add(this.ctlMoveExpand1);
            this.flowLayoutPanel1.Controls.Add(this.ctlMirror1);
            this.flowLayoutPanel1.Controls.Add(this.ctlScale1);
            this.flowLayoutPanel1.Controls.Add(this.ctlRotate1);
            this.flowLayoutPanel1.Controls.Add(this.ctlView1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(455, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(242, 412);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // pnlTopTabs
            // 
            this.pnlTopTabs.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlTopTabs.Controls.Add(this.ctlTitle3dView);
            this.pnlTopTabs.Controls.Add(this.ctlTitleViewSlice);
            this.pnlTopTabs.Controls.Add(this.ctlTitleViewControls);
            this.pnlTopTabs.Controls.Add(this.ctlTitleConfigure);
            this.pnlTopTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopTabs.Location = new System.Drawing.Point(0, 84);
            this.pnlTopTabs.Name = "pnlTopTabs";
            this.pnlTopTabs.Size = new System.Drawing.Size(1380, 47);
            this.pnlTopTabs.TabIndex = 2;
            // 
            // pnlSliceView
            // 
            this.pnlSliceView.Controls.Add(this.ctlSliceGCodePanel1);
            this.pnlSliceView.Location = new System.Drawing.Point(742, 3);
            this.pnlSliceView.Name = "pnlSliceView";
            this.pnlSliceView.Size = new System.Drawing.Size(373, 201);
            this.pnlSliceView.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 131);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ctlMainConfig1);
            this.splitContainer1.Panel1.Controls.Add(this.ctlMainManual1);
            this.splitContainer1.Panel1.Controls.Add(this.pnlSliceView);
            this.splitContainer1.Panel1.Controls.Add(this.pnl3dview);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtLog);
            this.splitContainer1.Size = new System.Drawing.Size(1380, 563);
            this.splitContainer1.SplitterDistance = 461;
            this.splitContainer1.TabIndex = 4;
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.White;
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.Location = new System.Drawing.Point(0, 0);
            this.txtLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(1380, 98);
            this.txtLog.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1380, 28);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveSceneSTLToolStripMenuItem,
            this.preferencesToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.testToolStripMenuItem,
            this.splashToolStripMenuItem,
            this.pluginTesterToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveSceneSTLToolStripMenuItem
            // 
            this.saveSceneSTLToolStripMenuItem.Name = "saveSceneSTLToolStripMenuItem";
            this.saveSceneSTLToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.saveSceneSTLToolStripMenuItem.Text = "Save Scene STL";
            this.saveSceneSTLToolStripMenuItem.Click += new System.EventHandler(this.saveSceneSTLToolStripMenuItem_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.testToolStripMenuItem.Text = "Dump Commands";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // splashToolStripMenuItem
            // 
            this.splashToolStripMenuItem.Name = "splashToolStripMenuItem";
            this.splashToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.splashToolStripMenuItem.Text = "Splash";
            // 
            // pluginTesterToolStripMenuItem
            // 
            this.pluginTesterToolStripMenuItem.Name = "pluginTesterToolStripMenuItem";
            this.pluginTesterToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.pluginTesterToolStripMenuItem.Text = "Plugin Tester";
            this.pluginTesterToolStripMenuItem.Click += new System.EventHandler(this.pluginTesterToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.plugInsToolStripMenuItem,
            this.userManualToolStripMenuItem,
            this.hardwareGuideToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // plugInsToolStripMenuItem
            // 
            this.plugInsToolStripMenuItem.Name = "plugInsToolStripMenuItem";
            this.plugInsToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.plugInsToolStripMenuItem.Text = "Plug-Ins";
            this.plugInsToolStripMenuItem.Click += new System.EventHandler(this.plugInsToolStripMenuItem_Click);
            // 
            // userManualToolStripMenuItem
            // 
            this.userManualToolStripMenuItem.Name = "userManualToolStripMenuItem";
            this.userManualToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.userManualToolStripMenuItem.Text = "User Manual";
            this.userManualToolStripMenuItem.Click += new System.EventHandler(this.userManualToolStripMenuItem_Click);
            // 
            // hardwareGuideToolStripMenuItem
            // 
            this.hardwareGuideToolStripMenuItem.Name = "hardwareGuideToolStripMenuItem";
            this.hardwareGuideToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.hardwareGuideToolStripMenuItem.Text = "Hardware Guide";
            this.hardwareGuideToolStripMenuItem.Click += new System.EventHandler(this.hardwareGuideToolStripMenuItem_Click);
            // 
            // ctlMainConfig1
            // 
            this.ctlMainConfig1.Location = new System.Drawing.Point(966, 220);
            this.ctlMainConfig1.Name = "ctlMainConfig1";
            this.ctlMainConfig1.Size = new System.Drawing.Size(308, 236);
            this.ctlMainConfig1.TabIndex = 5;
            // 
            // ctlMainManual1
            // 
            this.ctlMainManual1.Location = new System.Drawing.Point(742, 232);
            this.ctlMainManual1.Name = "ctlMainManual1";
            this.ctlMainManual1.Size = new System.Drawing.Size(215, 182);
            this.ctlMainManual1.TabIndex = 4;
            // 
            // ctlSliceGCodePanel1
            // 
            this.ctlSliceGCodePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlSliceGCodePanel1.Gapx = 0;
            this.ctlSliceGCodePanel1.Gapy = 0;
            this.ctlSliceGCodePanel1.GLBackgroundImage = null;
            this.ctlSliceGCodePanel1.GLVisible = false;
            this.ctlSliceGCodePanel1.GuiAnchor = null;
            this.ctlSliceGCodePanel1.Location = new System.Drawing.Point(0, 0);
            this.ctlSliceGCodePanel1.Name = "ctlSliceGCodePanel1";
            this.ctlSliceGCodePanel1.Size = new System.Drawing.Size(373, 201);
            this.ctlSliceGCodePanel1.StyleName = null;
            this.ctlSliceGCodePanel1.TabIndex = 0;
            // 
            // ctl3DView1
            // 
            this.ctl3DView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctl3DView1.Location = new System.Drawing.Point(50, 0);
            this.ctl3DView1.MainMessage = "";
            this.ctl3DView1.Name = "ctl3DView1";
            this.ctl3DView1.Size = new System.Drawing.Size(405, 412);
            this.ctl3DView1.TabIndex = 0;
            this.ctl3DView1.TimeMessage = "";
            // 
            // buttExpandLeft
            // 
            this.buttExpandLeft.Checked = false;
            this.buttExpandLeft.CheckImage = global::UV_DLP_3D_Printer.Properties.Resources.buttChecked;
            this.buttExpandLeft.Gapx = 5;
            this.buttExpandLeft.Gapy = 5;
            this.buttExpandLeft.GLBackgroundImage = null;
            this.buttExpandLeft.GLImage = null;
            this.buttExpandLeft.GLVisible = false;
            this.buttExpandLeft.GuiAnchor = null;
            this.buttExpandLeft.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttExpandLeft.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttPlus;
            this.buttExpandLeft.Location = new System.Drawing.Point(3, 3);
            this.buttExpandLeft.Name = "buttExpandLeft";
            this.buttExpandLeft.OnClickCallback = "ClickExpandLeft";
            this.buttExpandLeft.Size = new System.Drawing.Size(42, 42);
            this.buttExpandLeft.StyleName = null;
            this.buttExpandLeft.TabIndex = 0;
            this.buttExpandLeft.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            // 
            // ctlSupports1
            // 
            this.ctlSupports1.Gapx = 0;
            this.ctlSupports1.Gapy = 0;
            this.ctlSupports1.GLBackgroundImage = null;
            this.ctlSupports1.GLVisible = false;
            this.ctlSupports1.GuiAnchor = null;
            this.ctlSupports1.Location = new System.Drawing.Point(51, 3);
            this.ctlSupports1.Name = "ctlSupports1";
            this.ctlSupports1.Size = new System.Drawing.Size(381, 542);
            this.ctlSupports1.StyleName = null;
            this.ctlSupports1.TabIndex = 1;
            this.ctlSupports1.Visible = false;
            // 
            // ctlScene1
            // 
            this.ctlScene1.Checked = false;
            this.ctlScene1.Gapx = 5;
            this.ctlScene1.Gapy = 5;
            this.ctlScene1.GLBackgroundImage = null;
            this.ctlScene1.GLVisible = false;
            this.ctlScene1.GuiAnchor = null;
            this.ctlScene1.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.ctlScene1.Location = new System.Drawing.Point(3, 3);
            this.ctlScene1.Name = "ctlScene1";
            this.ctlScene1.Size = new System.Drawing.Size(235, 45);
            this.ctlScene1.StyleName = null;
            this.ctlScene1.TabIndex = 4;
            this.ctlScene1.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            // 
            // ctlObjectInfo1
            // 
            this.ctlObjectInfo1.Checked = false;
            this.ctlObjectInfo1.Gapx = 5;
            this.ctlObjectInfo1.Gapy = 5;
            this.ctlObjectInfo1.GLBackgroundImage = null;
            this.ctlObjectInfo1.GLVisible = false;
            this.ctlObjectInfo1.GuiAnchor = null;
            this.ctlObjectInfo1.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.ctlObjectInfo1.Location = new System.Drawing.Point(3, 54);
            this.ctlObjectInfo1.Name = "ctlObjectInfo1";
            this.ctlObjectInfo1.Size = new System.Drawing.Size(235, 45);
            this.ctlObjectInfo1.StyleName = null;
            this.ctlObjectInfo1.TabIndex = 5;
            this.ctlObjectInfo1.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            // 
            // ctlMoveExpand1
            // 
            this.ctlMoveExpand1.Gapx = 0;
            this.ctlMoveExpand1.Gapy = 0;
            this.ctlMoveExpand1.GLBackgroundImage = null;
            this.ctlMoveExpand1.GLVisible = false;
            this.ctlMoveExpand1.GuiAnchor = null;
            this.ctlMoveExpand1.Location = new System.Drawing.Point(3, 105);
            this.ctlMoveExpand1.Name = "ctlMoveExpand1";
            this.ctlMoveExpand1.Size = new System.Drawing.Size(235, 45);
            this.ctlMoveExpand1.StyleName = null;
            this.ctlMoveExpand1.TabIndex = 0;
            // 
            // ctlMirror1
            // 
            this.ctlMirror1.BackColor = System.Drawing.Color.RoyalBlue;
            this.ctlMirror1.Location = new System.Drawing.Point(3, 156);
            this.ctlMirror1.Name = "ctlMirror1";
            this.ctlMirror1.Size = new System.Drawing.Size(236, 50);
            this.ctlMirror1.TabIndex = 6;
            // 
            // ctlScale1
            // 
            this.ctlScale1.Gapx = 0;
            this.ctlScale1.Gapy = 0;
            this.ctlScale1.GLBackgroundImage = null;
            this.ctlScale1.GLVisible = false;
            this.ctlScale1.GuiAnchor = null;
            this.ctlScale1.Location = new System.Drawing.Point(3, 212);
            this.ctlScale1.Name = "ctlScale1";
            this.ctlScale1.Size = new System.Drawing.Size(235, 45);
            this.ctlScale1.StyleName = null;
            this.ctlScale1.TabIndex = 1;
            // 
            // ctlRotate1
            // 
            this.ctlRotate1.Gapx = 0;
            this.ctlRotate1.Gapy = 0;
            this.ctlRotate1.GLBackgroundImage = null;
            this.ctlRotate1.GLVisible = false;
            this.ctlRotate1.GuiAnchor = null;
            this.ctlRotate1.Location = new System.Drawing.Point(3, 263);
            this.ctlRotate1.Name = "ctlRotate1";
            this.ctlRotate1.Size = new System.Drawing.Size(235, 45);
            this.ctlRotate1.StyleName = null;
            this.ctlRotate1.TabIndex = 2;
            // 
            // ctlView1
            // 
            this.ctlView1.Gapx = 0;
            this.ctlView1.Gapy = 0;
            this.ctlView1.GLBackgroundImage = null;
            this.ctlView1.GLVisible = false;
            this.ctlView1.GuiAnchor = null;
            this.ctlView1.LayerNumberScroll = null;
            this.ctlView1.Location = new System.Drawing.Point(3, 314);
            this.ctlView1.MessagePanelHolder = null;
            this.ctlView1.Name = "ctlView1";
            this.ctlView1.ObjectInfoPanel = null;
            this.ctlView1.SceneControl = null;
            this.ctlView1.Size = new System.Drawing.Size(235, 45);
            this.ctlView1.StyleName = null;
            this.ctlView1.TabIndex = 3;
            this.ctlView1.TreeViewHolder = null;
            // 
            // ctlTitle3dView
            // 
            this.ctlTitle3dView.BackColor = System.Drawing.Color.RoyalBlue;
            this.ctlTitle3dView.Checked = false;
            this.ctlTitle3dView.CheckImage = global::UV_DLP_3D_Printer.Properties.Resources.buttChecked;
            this.ctlTitle3dView.Gapx = 0;
            this.ctlTitle3dView.Gapy = 0;
            this.ctlTitle3dView.GLBackgroundImage = null;
            this.ctlTitle3dView.GLVisible = false;
            this.ctlTitle3dView.GuiAnchor = null;
            this.ctlTitle3dView.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttViewModel;
            this.ctlTitle3dView.Location = new System.Drawing.Point(3, 3);
            this.ctlTitle3dView.Name = "ctlTitle3dView";
            this.ctlTitle3dView.OnClickCallback = "ClickView3d";
            this.ctlTitle3dView.Size = new System.Drawing.Size(180, 40);
            this.ctlTitle3dView.StyleName = null;
            this.ctlTitle3dView.TabIndex = 0;
            this.ctlTitle3dView.Text = "3D View";
            // 
            // ctlTitleViewSlice
            // 
            this.ctlTitleViewSlice.BackColor = System.Drawing.Color.RoyalBlue;
            this.ctlTitleViewSlice.Checked = false;
            this.ctlTitleViewSlice.CheckImage = global::UV_DLP_3D_Printer.Properties.Resources.buttChecked;
            this.ctlTitleViewSlice.Gapx = 0;
            this.ctlTitleViewSlice.Gapy = 0;
            this.ctlTitleViewSlice.GLBackgroundImage = null;
            this.ctlTitleViewSlice.GLVisible = false;
            this.ctlTitleViewSlice.GuiAnchor = null;
            this.ctlTitleViewSlice.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttViewSlice;
            this.ctlTitleViewSlice.Location = new System.Drawing.Point(189, 3);
            this.ctlTitleViewSlice.Name = "ctlTitleViewSlice";
            this.ctlTitleViewSlice.OnClickCallback = "ClickSliceView";
            this.ctlTitleViewSlice.Size = new System.Drawing.Size(180, 40);
            this.ctlTitleViewSlice.StyleName = null;
            this.ctlTitleViewSlice.TabIndex = 1;
            this.ctlTitleViewSlice.Text = "Slice View";
            // 
            // ctlTitleViewControls
            // 
            this.ctlTitleViewControls.BackColor = System.Drawing.Color.RoyalBlue;
            this.ctlTitleViewControls.Checked = false;
            this.ctlTitleViewControls.CheckImage = global::UV_DLP_3D_Printer.Properties.Resources.buttChecked;
            this.ctlTitleViewControls.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ctlTitleViewControls.Gapx = 0;
            this.ctlTitleViewControls.Gapy = 0;
            this.ctlTitleViewControls.GLBackgroundImage = null;
            this.ctlTitleViewControls.GLVisible = false;
            this.ctlTitleViewControls.GuiAnchor = null;
            this.ctlTitleViewControls.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttMachineControl;
            this.ctlTitleViewControls.Location = new System.Drawing.Point(375, 3);
            this.ctlTitleViewControls.Name = "ctlTitleViewControls";
            this.ctlTitleViewControls.OnClickCallback = "ClickManualCtlView";
            this.ctlTitleViewControls.Size = new System.Drawing.Size(180, 40);
            this.ctlTitleViewControls.StyleName = null;
            this.ctlTitleViewControls.TabIndex = 2;
            this.ctlTitleViewControls.Text = "Control";
            // 
            // ctlTitleConfigure
            // 
            this.ctlTitleConfigure.BackColor = System.Drawing.Color.RoyalBlue;
            this.ctlTitleConfigure.Checked = false;
            this.ctlTitleConfigure.CheckImage = global::UV_DLP_3D_Printer.Properties.Resources.buttChecked;
            this.ctlTitleConfigure.Gapx = 0;
            this.ctlTitleConfigure.Gapy = 0;
            this.ctlTitleConfigure.GLBackgroundImage = null;
            this.ctlTitleConfigure.GLVisible = false;
            this.ctlTitleConfigure.GuiAnchor = null;
            this.ctlTitleConfigure.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttMachineConfig;
            this.ctlTitleConfigure.Location = new System.Drawing.Point(561, 3);
            this.ctlTitleConfigure.Name = "ctlTitleConfigure";
            this.ctlTitleConfigure.OnClickCallback = "ClickMainConfigView";
            this.ctlTitleConfigure.Size = new System.Drawing.Size(180, 40);
            this.ctlTitleConfigure.StyleName = null;
            this.ctlTitleConfigure.TabIndex = 3;
            this.ctlTitleConfigure.Text = "Configure";
            // 
            // buttOpenFile
            // 
            this.buttOpenFile.BackColor = System.Drawing.Color.Navy;
            this.buttOpenFile.Checked = false;
            this.buttOpenFile.CheckImage = null;
            this.buttOpenFile.Gapx = 10;
            this.buttOpenFile.Gapy = 10;
            this.buttOpenFile.GLBackgroundImage = null;
            this.buttOpenFile.GLImage = null;
            this.buttOpenFile.GLVisible = false;
            this.buttOpenFile.GuiAnchor = null;
            this.buttOpenFile.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.Right;
            this.buttOpenFile.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttOpenFile;
            this.buttOpenFile.Location = new System.Drawing.Point(4, 4);
            this.buttOpenFile.Margin = new System.Windows.Forms.Padding(4, 4, 10, 4);
            this.buttOpenFile.Name = "buttOpenFile";
            this.buttOpenFile.OnClickCallback = "LoadSTLModel_Click";
            this.buttOpenFile.Size = new System.Drawing.Size(48, 48);
            this.buttOpenFile.StyleName = null;
            this.buttOpenFile.TabIndex = 36;
            this.buttOpenFile.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.Top;
            // 
            // buttPlay
            // 
            this.buttPlay.BackColor = System.Drawing.Color.Navy;
            this.buttPlay.Checked = false;
            this.buttPlay.CheckImage = null;
            this.buttPlay.Gapx = 10;
            this.buttPlay.Gapy = 10;
            this.buttPlay.GLBackgroundImage = null;
            this.buttPlay.GLImage = null;
            this.buttPlay.GLVisible = false;
            this.buttPlay.GuiAnchor = null;
            this.buttPlay.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.Right;
            this.buttPlay.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttPlay;
            this.buttPlay.Location = new System.Drawing.Point(66, 4);
            this.buttPlay.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.buttPlay.Name = "buttPlay";
            this.buttPlay.OnClickCallback = "StartPrint";
            this.buttPlay.Size = new System.Drawing.Size(48, 48);
            this.buttPlay.StyleName = null;
            this.buttPlay.TabIndex = 37;
            this.buttPlay.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.Top;
            // 
            // buttPause
            // 
            this.buttPause.BackColor = System.Drawing.Color.Navy;
            this.buttPause.Checked = false;
            this.buttPause.CheckImage = null;
            this.buttPause.Gapx = 10;
            this.buttPause.Gapy = 10;
            this.buttPause.GLBackgroundImage = null;
            this.buttPause.GLImage = null;
            this.buttPause.GLVisible = false;
            this.buttPause.GuiAnchor = null;
            this.buttPause.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.Right;
            this.buttPause.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttPause;
            this.buttPause.Location = new System.Drawing.Point(118, 4);
            this.buttPause.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.buttPause.Name = "buttPause";
            this.buttPause.OnClickCallback = "PausePrint";
            this.buttPause.Size = new System.Drawing.Size(48, 48);
            this.buttPause.StyleName = null;
            this.buttPause.TabIndex = 38;
            this.buttPause.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.Top;
            // 
            // buttStop
            // 
            this.buttStop.BackColor = System.Drawing.Color.Navy;
            this.buttStop.Checked = false;
            this.buttStop.CheckImage = null;
            this.buttStop.Gapx = 10;
            this.buttStop.Gapy = 10;
            this.buttStop.GLBackgroundImage = null;
            this.buttStop.GLImage = null;
            this.buttStop.GLVisible = false;
            this.buttStop.GuiAnchor = null;
            this.buttStop.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.Right;
            this.buttStop.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttStop;
            this.buttStop.Location = new System.Drawing.Point(170, 4);
            this.buttStop.Margin = new System.Windows.Forms.Padding(4, 4, 10, 4);
            this.buttStop.Name = "buttStop";
            this.buttStop.OnClickCallback = "StopPrint";
            this.buttStop.Size = new System.Drawing.Size(48, 48);
            this.buttStop.StyleName = null;
            this.buttStop.TabIndex = 39;
            this.buttStop.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.Top;
            // 
            // buttConnect
            // 
            this.buttConnect.BackColor = System.Drawing.Color.Navy;
            this.buttConnect.Checked = false;
            this.buttConnect.CheckImage = null;
            this.buttConnect.Gapx = 10;
            this.buttConnect.Gapy = 10;
            this.buttConnect.GLBackgroundImage = null;
            this.buttConnect.GLImage = null;
            this.buttConnect.GLVisible = false;
            this.buttConnect.GuiAnchor = null;
            this.buttConnect.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.Right;
            this.buttConnect.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttConnect;
            this.buttConnect.Location = new System.Drawing.Point(232, 4);
            this.buttConnect.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.buttConnect.Name = "buttConnect";
            this.buttConnect.OnClickCallback = "ConnectPrinter";
            this.buttConnect.Size = new System.Drawing.Size(48, 48);
            this.buttConnect.StyleName = null;
            this.buttConnect.TabIndex = 41;
            this.buttConnect.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.Top;
            // 
            // buttDisconnect
            // 
            this.buttDisconnect.BackColor = System.Drawing.Color.Navy;
            this.buttDisconnect.Checked = false;
            this.buttDisconnect.CheckImage = null;
            this.buttDisconnect.Gapx = 10;
            this.buttDisconnect.Gapy = 10;
            this.buttDisconnect.GLBackgroundImage = null;
            this.buttDisconnect.GLImage = null;
            this.buttDisconnect.GLVisible = false;
            this.buttDisconnect.GuiAnchor = null;
            this.buttDisconnect.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.Right;
            this.buttDisconnect.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttDisconnect;
            this.buttDisconnect.Location = new System.Drawing.Point(284, 4);
            this.buttDisconnect.Margin = new System.Windows.Forms.Padding(4, 4, 10, 4);
            this.buttDisconnect.Name = "buttDisconnect";
            this.buttDisconnect.OnClickCallback = "DisconnectPrinter";
            this.buttDisconnect.Size = new System.Drawing.Size(48, 48);
            this.buttDisconnect.StyleName = null;
            this.buttDisconnect.TabIndex = 42;
            this.buttDisconnect.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.Top;
            // 
            // buttSlice
            // 
            this.buttSlice.BackColor = System.Drawing.Color.Navy;
            this.buttSlice.Checked = false;
            this.buttSlice.CheckImage = null;
            this.buttSlice.Gapx = 10;
            this.buttSlice.Gapy = 10;
            this.buttSlice.GLBackgroundImage = null;
            this.buttSlice.GLImage = null;
            this.buttSlice.GLVisible = false;
            this.buttSlice.GuiAnchor = null;
            this.buttSlice.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.Right;
            this.buttSlice.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttSlice;
            this.buttSlice.Location = new System.Drawing.Point(346, 4);
            this.buttSlice.Margin = new System.Windows.Forms.Padding(4, 4, 10, 4);
            this.buttSlice.Name = "buttSlice";
            this.buttSlice.OnClickCallback = "StartSlice";
            this.buttSlice.Size = new System.Drawing.Size(48, 48);
            this.buttSlice.StyleName = null;
            this.buttSlice.TabIndex = 43;
            this.buttSlice.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.Top;
            // 
            // frmMain2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 694);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnlTopTabs);
            this.Controls.Add(this.pnlTopIcons);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creation Workshop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlTopIcons.ResumeLayout(false);
            this.pnl3dview.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlTopTabs.ResumeLayout(false);
            this.pnlSliceView.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlTopIcons;
        private CustomGUI.ctlImageButton buttOpenFile;
        private CustomGUI.ctlImageButton buttPlay;
        private CustomGUI.ctlImageButton buttPause;
        private CustomGUI.ctlImageButton buttStop;
        private CustomGUI.ctlImageButton buttDisconnect;
        private CustomGUI.ctlImageButton buttConnect;
        private System.Windows.Forms.Panel pnl3dview;
        private System.Windows.Forms.FlowLayoutPanel pnlTopTabs;
        private CustomGUI.ctlTitle ctlTitle3dView;
        private CustomGUI.ctlTitle ctlTitleViewSlice;
        private CustomGUI.ctlTitle ctlTitleViewControls;
        private CustomGUI.ctlTitle ctlTitleConfigure;
        private Controls.ctl3DView ctl3DView1;
        private System.Windows.Forms.Panel pnlSliceView;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtLog;
        private Controls.ManualControls.ctlMainManual ctlMainManual1;
        private Controls.ctlMainConfig ctlMainConfig1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private CustomGUI.Expanding.ctlMoveExpand ctlMoveExpand1;
        private CustomGUI.ctlScale ctlScale1;
        private CustomGUI.ctlRotate ctlRotate1;
        private CustomGUI.ctlView ctlView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSceneSTLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem splashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pluginTesterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plugInsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardwareGuideToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private CustomGUI.ctlImageButton buttSlice;
        private CustomGUI.ctlScene ctlScene1;
        private CustomGUI.ctlObjectInfo ctlObjectInfo1;
        private Controls.ctlSliceGCodePanel ctlSliceGCodePanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private CustomGUI.ctlImageButton buttExpandLeft;
        private CustomGUI.ctlSupports ctlSupports1;
        private CustomGUI.ctlMirror ctlMirror1;
    }
}