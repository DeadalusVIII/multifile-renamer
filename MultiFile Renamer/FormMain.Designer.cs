namespace MultiFile_Renamer
{
    partial class FormMain
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("My Active Drives");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.explorerIntegrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uninstallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.treeViewFolder = new System.Windows.Forms.TreeView();
            this.imageListIcon = new System.Windows.Forms.ImageList(this.components);
            this.listViewFilesInFolder = new System.Windows.Forms.ListView();
            this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewFilesToRename = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonListAll = new System.Windows.Forms.Button();
            this.buttonListOne = new System.Windows.Forms.Button();
            this.buttonRemoveOne = new System.Windows.Forms.Button();
            this.buttonRemoveAll = new System.Windows.Forms.Button();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.groupPreview = new System.Windows.Forms.GroupBox();
            this.windowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.groupTree = new System.Windows.Forms.GroupBox();
            this.groupBoxFile = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxExtensions = new System.Windows.Forms.TextBox();
            this.groupBoxRename = new System.Windows.Forms.GroupBox();
            this.fixedTabControl1 = new MultiFile_Renamer.FixedTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonRename = new System.Windows.Forms.Button();
            this.textBoxLabel2 = new System.Windows.Forms.TextBox();
            this.textBoxDigitN = new System.Windows.Forms.TextBox();
            this.textBoxStartingN = new System.Windows.Forms.TextBox();
            this.textBoxLabel1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelExample = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonReplace = new System.Windows.Forms.Button();
            this.textBoxStringReplacement = new System.Windows.Forms.TextBox();
            this.textBoxStringReplace = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBoxChangeExtension = new System.Windows.Forms.CheckBox();
            this.radioButtonTitle = new System.Windows.Forms.RadioButton();
            this.radioButtonLowerCase = new System.Windows.Forms.RadioButton();
            this.radioButtonUpperCase = new System.Windows.Forms.RadioButton();
            this.buttonChangeCase = new System.Windows.Forms.Button();
            this.backgroundWorkerRename = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerReplace = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerCase = new System.ComponentModel.BackgroundWorker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.groupPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowsMediaPlayer)).BeginInit();
            this.groupTree.SuspendLayout();
            this.groupBoxFile.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxRename.SuspendLayout();
            this.fixedTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(866, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSettings,
            this.explorerIntegrationToolStripMenuItem,
            this.menuItemExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuItemSettings
            // 
            this.menuItemSettings.Name = "menuItemSettings";
            this.menuItemSettings.Size = new System.Drawing.Size(177, 22);
            this.menuItemSettings.Text = "Settings";
            this.menuItemSettings.Click += new System.EventHandler(this.MenuItemSettingsClick);
            // 
            // explorerIntegrationToolStripMenuItem
            // 
            this.explorerIntegrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.installToolStripMenuItem,
            this.uninstallToolStripMenuItem});
            this.explorerIntegrationToolStripMenuItem.Name = "explorerIntegrationToolStripMenuItem";
            this.explorerIntegrationToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.explorerIntegrationToolStripMenuItem.Text = "Explorer Integration";
            // 
            // installToolStripMenuItem
            // 
            this.installToolStripMenuItem.Name = "installToolStripMenuItem";
            this.installToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.installToolStripMenuItem.Text = "Install...";
            this.installToolStripMenuItem.Click += new System.EventHandler(this.InstallToolStripMenuItemClick);
            // 
            // uninstallToolStripMenuItem
            // 
            this.uninstallToolStripMenuItem.Name = "uninstallToolStripMenuItem";
            this.uninstallToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.uninstallToolStripMenuItem.Text = "Uninstall...";
            this.uninstallToolStripMenuItem.Click += new System.EventHandler(this.UninstallToolStripMenuItemClick);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(177, 22);
            this.menuItemExit.Text = "Exit";
            this.menuItemExit.Click += new System.EventHandler(this.MenuItemExitClick);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Name = "menuItemAbout";
            this.menuItemAbout.Size = new System.Drawing.Size(206, 22);
            this.menuItemAbout.Text = "About MultiFile Renamer";
            this.menuItemAbout.Click += new System.EventHandler(this.MenuItemAboutClick);
            // 
            // treeViewFolder
            // 
            this.treeViewFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewFolder.ImageIndex = 0;
            this.treeViewFolder.ImageList = this.imageListIcon;
            this.treeViewFolder.Indent = 35;
            this.treeViewFolder.ItemHeight = 20;
            this.treeViewFolder.Location = new System.Drawing.Point(8, 21);
            this.treeViewFolder.Margin = new System.Windows.Forms.Padding(10);
            this.treeViewFolder.Name = "treeViewFolder";
            treeNode1.Name = "activeDrives";
            treeNode1.Text = "My Active Drives";
            this.treeViewFolder.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeViewFolder.SelectedImageIndex = 0;
            this.treeViewFolder.Size = new System.Drawing.Size(228, 563);
            this.treeViewFolder.TabIndex = 1;
            this.treeViewFolder.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewFolderAfterSelect);
            // 
            // imageListIcon
            // 
            this.imageListIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListIcon.ImageStream")));
            this.imageListIcon.TransparentColor = System.Drawing.Color.Black;
            this.imageListIcon.Images.SetKeyName(0, "Display HQ 01.ico");
            this.imageListIcon.Images.SetKeyName(1, "DD HQ 04.ico");
            this.imageListIcon.Images.SetKeyName(2, "DD HQ 09.ico");
            this.imageListIcon.Images.SetKeyName(3, "DD HQ 05.ico");
            this.imageListIcon.Images.SetKeyName(4, "DD HQ 10.ico");
            this.imageListIcon.Images.SetKeyName(5, "Folder HQ 003.ico");
            this.imageListIcon.Images.SetKeyName(6, "Folder HQ 004.ico");
            // 
            // listViewFilesInFolder
            // 
            this.listViewFilesInFolder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName,
            this.FileDate});
            this.listViewFilesInFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewFilesInFolder.FullRowSelect = true;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "Files in Folder";
            listViewGroup1.Tag = "";
            this.listViewFilesInFolder.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listViewFilesInFolder.Location = new System.Drawing.Point(8, 66);
            this.listViewFilesInFolder.Name = "listViewFilesInFolder";
            this.listViewFilesInFolder.ShowGroups = false;
            this.listViewFilesInFolder.Size = new System.Drawing.Size(265, 277);
            this.listViewFilesInFolder.TabIndex = 2;
            this.listViewFilesInFolder.UseCompatibleStateImageBehavior = false;
            this.listViewFilesInFolder.View = System.Windows.Forms.View.Details;
            this.listViewFilesInFolder.SelectedIndexChanged += new System.EventHandler(this.ListViewFilesInFolderSelectedIndexChanged);
            this.listViewFilesInFolder.DoubleClick += new System.EventHandler(this.ListViewFilesInFolderDoubleClick);
            // 
            // FileName
            // 
            this.FileName.Text = "Name";
            this.FileName.Width = 113;
            // 
            // FileDate
            // 
            this.FileDate.Text = "Date";
            this.FileDate.Width = 143;
            // 
            // listViewFilesToRename
            // 
            this.listViewFilesToRename.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewFilesToRename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewFilesToRename.Location = new System.Drawing.Point(50, 0);
            this.listViewFilesToRename.Name = "listViewFilesToRename";
            this.listViewFilesToRename.Size = new System.Drawing.Size(283, 277);
            this.listViewFilesToRename.TabIndex = 3;
            this.listViewFilesToRename.UseCompatibleStateImageBehavior = false;
            this.listViewFilesToRename.View = System.Windows.Forms.View.Details;
            this.listViewFilesToRename.DoubleClick += new System.EventHandler(this.ListViewFilesToRenameDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 215;
            // 
            // buttonListAll
            // 
            this.buttonListAll.Location = new System.Drawing.Point(1, 12);
            this.buttonListAll.Name = "buttonListAll";
            this.buttonListAll.Size = new System.Drawing.Size(35, 35);
            this.buttonListAll.TabIndex = 4;
            this.buttonListAll.Text = ">>";
            this.buttonListAll.UseVisualStyleBackColor = true;
            this.buttonListAll.Click += new System.EventHandler(this.ButtonListAllClick);
            // 
            // buttonListOne
            // 
            this.buttonListOne.Location = new System.Drawing.Point(1, 53);
            this.buttonListOne.Name = "buttonListOne";
            this.buttonListOne.Size = new System.Drawing.Size(35, 35);
            this.buttonListOne.TabIndex = 5;
            this.buttonListOne.Text = ">";
            this.buttonListOne.UseVisualStyleBackColor = true;
            this.buttonListOne.Click += new System.EventHandler(this.ButtonListOneClick);
            // 
            // buttonRemoveOne
            // 
            this.buttonRemoveOne.Location = new System.Drawing.Point(1, 118);
            this.buttonRemoveOne.Name = "buttonRemoveOne";
            this.buttonRemoveOne.Size = new System.Drawing.Size(35, 35);
            this.buttonRemoveOne.TabIndex = 6;
            this.buttonRemoveOne.Text = "<";
            this.buttonRemoveOne.UseVisualStyleBackColor = true;
            this.buttonRemoveOne.Click += new System.EventHandler(this.ButtonRemoveOneClick);
            // 
            // buttonRemoveAll
            // 
            this.buttonRemoveAll.Location = new System.Drawing.Point(1, 159);
            this.buttonRemoveAll.Name = "buttonRemoveAll";
            this.buttonRemoveAll.Size = new System.Drawing.Size(35, 35);
            this.buttonRemoveAll.TabIndex = 7;
            this.buttonRemoveAll.Text = "<<";
            this.buttonRemoveAll.UseVisualStyleBackColor = true;
            this.buttonRemoveAll.Click += new System.EventHandler(this.ButtonRemoveAllClick);
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPreview.ImageLocation = "";
            this.pictureBoxPreview.Location = new System.Drawing.Point(8, 21);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(297, 202);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPreview.TabIndex = 8;
            this.pictureBoxPreview.TabStop = false;
            this.pictureBoxPreview.MouseEnter += new System.EventHandler(this.PictureBoxPreviewMouseEnter);
            this.pictureBoxPreview.MouseLeave += new System.EventHandler(this.PictureBoxPreviewMouseLeave);
            // 
            // groupPreview
            // 
            this.groupPreview.Controls.Add(this.windowsMediaPlayer);
            this.groupPreview.Controls.Add(this.pictureBoxPreview);
            this.groupPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPreview.Location = new System.Drawing.Point(5, 5);
            this.groupPreview.Name = "groupPreview";
            this.groupPreview.Padding = new System.Windows.Forms.Padding(8);
            this.groupPreview.Size = new System.Drawing.Size(313, 231);
            this.groupPreview.TabIndex = 9;
            this.groupPreview.TabStop = false;
            this.groupPreview.Text = "Preview";
            // 
            // windowsMediaPlayer
            // 
            this.windowsMediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windowsMediaPlayer.Enabled = true;
            this.windowsMediaPlayer.Location = new System.Drawing.Point(8, 21);
            this.windowsMediaPlayer.Name = "windowsMediaPlayer";
            this.windowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("windowsMediaPlayer.OcxState")));
            this.windowsMediaPlayer.Size = new System.Drawing.Size(297, 202);
            this.windowsMediaPlayer.TabIndex = 9;
            this.windowsMediaPlayer.Visible = false;
            // 
            // groupTree
            // 
            this.groupTree.Controls.Add(this.treeViewFolder);
            this.groupTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupTree.Location = new System.Drawing.Point(0, 24);
            this.groupTree.Name = "groupTree";
            this.groupTree.Padding = new System.Windows.Forms.Padding(8);
            this.groupTree.Size = new System.Drawing.Size(244, 592);
            this.groupTree.TabIndex = 10;
            this.groupTree.TabStop = false;
            this.groupTree.Text = "Folder View";
            // 
            // groupBoxFile
            // 
            this.groupBoxFile.Controls.Add(this.listViewFilesInFolder);
            this.groupBoxFile.Controls.Add(this.panel3);
            this.groupBoxFile.Controls.Add(this.panel2);
            this.groupBoxFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxFile.Location = new System.Drawing.Point(244, 24);
            this.groupBoxFile.Name = "groupBoxFile";
            this.groupBoxFile.Padding = new System.Windows.Forms.Padding(8);
            this.groupBoxFile.Size = new System.Drawing.Size(622, 351);
            this.groupBoxFile.TabIndex = 11;
            this.groupBoxFile.TabStop = false;
            this.groupBoxFile.Text = "File Rename ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listViewFilesToRename);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(273, 66);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.panel3.Size = new System.Drawing.Size(341, 277);
            this.panel3.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonRemoveOne);
            this.panel1.Controls.Add(this.buttonListOne);
            this.panel1.Controls.Add(this.buttonListAll);
            this.panel1.Controls.Add(this.buttonRemoveAll);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(8, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(42, 277);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBoxExtensions);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(8, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(606, 45);
            this.panel2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Filter extensions:\r\n(Example: jpeg,exe,txt) ";
            // 
            // textBoxExtensions
            // 
            this.textBoxExtensions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxExtensions.Location = new System.Drawing.Point(128, 11);
            this.textBoxExtensions.Name = "textBoxExtensions";
            this.textBoxExtensions.Size = new System.Drawing.Size(468, 20);
            this.textBoxExtensions.TabIndex = 9;
            this.textBoxExtensions.TextChanged += new System.EventHandler(this.TextBoxExtensionsTextChanged);
            // 
            // groupBoxRename
            // 
            this.groupBoxRename.Controls.Add(this.fixedTabControl1);
            this.groupBoxRename.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxRename.Location = new System.Drawing.Point(318, 5);
            this.groupBoxRename.Name = "groupBoxRename";
            this.groupBoxRename.Size = new System.Drawing.Size(299, 231);
            this.groupBoxRename.TabIndex = 12;
            this.groupBoxRename.TabStop = false;
            this.groupBoxRename.Text = "Renaming Options";
            // 
            // fixedTabControl1
            // 
            this.fixedTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.fixedTabControl1.Controls.Add(this.tabPage1);
            this.fixedTabControl1.Controls.Add(this.tabPage3);
            this.fixedTabControl1.Controls.Add(this.tabPage2);
            this.fixedTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fixedTabControl1.Location = new System.Drawing.Point(3, 16);
            this.fixedTabControl1.Multiline = true;
            this.fixedTabControl1.Name = "fixedTabControl1";
            this.fixedTabControl1.SelectedIndex = 0;
            this.fixedTabControl1.Size = new System.Drawing.Size(293, 212);
            this.fixedTabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.buttonRename);
            this.tabPage1.Controls.Add(this.textBoxLabel2);
            this.tabPage1.Controls.Add(this.textBoxDigitN);
            this.tabPage1.Controls.Add(this.textBoxStartingN);
            this.tabPage1.Controls.Add(this.textBoxLabel1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.labelExample);
            this.tabPage1.Location = new System.Drawing.Point(42, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(247, 204);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Standard Rename";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(114, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Number of Digits:";
            // 
            // buttonRename
            // 
            this.buttonRename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRename.Location = new System.Drawing.Point(8, 174);
            this.buttonRename.Name = "buttonRename";
            this.buttonRename.Size = new System.Drawing.Size(233, 24);
            this.buttonRename.TabIndex = 0;
            this.buttonRename.Text = "Rename!";
            this.buttonRename.UseVisualStyleBackColor = true;
            this.buttonRename.Click += new System.EventHandler(this.ButtonRenameClick);
            // 
            // textBoxLabel2
            // 
            this.textBoxLabel2.Location = new System.Drawing.Point(6, 65);
            this.textBoxLabel2.Name = "textBoxLabel2";
            this.textBoxLabel2.Size = new System.Drawing.Size(204, 20);
            this.textBoxLabel2.TabIndex = 4;
            this.textBoxLabel2.TextChanged += new System.EventHandler(this.RefreshTextExample);
            // 
            // textBoxDigitN
            // 
            this.textBoxDigitN.Location = new System.Drawing.Point(117, 104);
            this.textBoxDigitN.Name = "textBoxDigitN";
            this.textBoxDigitN.Size = new System.Drawing.Size(93, 20);
            this.textBoxDigitN.TabIndex = 8;
            this.textBoxDigitN.Text = "1";
            this.textBoxDigitN.TextChanged += new System.EventHandler(this.RefreshTextExample);
            // 
            // textBoxStartingN
            // 
            this.textBoxStartingN.Location = new System.Drawing.Point(6, 104);
            this.textBoxStartingN.Name = "textBoxStartingN";
            this.textBoxStartingN.Size = new System.Drawing.Size(93, 20);
            this.textBoxStartingN.TabIndex = 6;
            this.textBoxStartingN.Text = "0";
            this.textBoxStartingN.TextChanged += new System.EventHandler(this.RefreshTextExample);
            // 
            // textBoxLabel1
            // 
            this.textBoxLabel1.Location = new System.Drawing.Point(6, 26);
            this.textBoxLabel1.Name = "textBoxLabel1";
            this.textBoxLabel1.Size = new System.Drawing.Size(204, 20);
            this.textBoxLabel1.TabIndex = 2;
            this.textBoxLabel1.TextChanged += new System.EventHandler(this.RefreshTextExample);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Example:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Label 1 (Name, Location, Date...)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Starting Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Label 2 (Name, Location, Date...)";
            // 
            // labelExample
            // 
            this.labelExample.AutoSize = true;
            this.labelExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExample.Location = new System.Drawing.Point(11, 150);
            this.labelExample.MaximumSize = new System.Drawing.Size(220, 30);
            this.labelExample.Name = "labelExample";
            this.labelExample.Size = new System.Drawing.Size(35, 13);
            this.labelExample.TabIndex = 7;
            this.labelExample.Text = "0.ext";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.buttonReplace);
            this.tabPage3.Controls.Add(this.textBoxStringReplacement);
            this.tabPage3.Controls.Add(this.textBoxStringReplace);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(42, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(247, 204);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "String Replacement";
            // 
            // buttonReplace
            // 
            this.buttonReplace.Location = new System.Drawing.Point(6, 178);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(202, 24);
            this.buttonReplace.TabIndex = 0;
            this.buttonReplace.Text = "Rename!";
            this.buttonReplace.UseVisualStyleBackColor = true;
            this.buttonReplace.Click += new System.EventHandler(this.ButtonReplaceClick);
            // 
            // textBoxStringReplacement
            // 
            this.textBoxStringReplacement.Location = new System.Drawing.Point(20, 130);
            this.textBoxStringReplacement.Name = "textBoxStringReplacement";
            this.textBoxStringReplacement.Size = new System.Drawing.Size(176, 20);
            this.textBoxStringReplacement.TabIndex = 4;
            this.textBoxStringReplacement.TextChanged += new System.EventHandler(this.TextBoxTextChanged);
            // 
            // textBoxStringReplace
            // 
            this.textBoxStringReplace.Location = new System.Drawing.Point(20, 45);
            this.textBoxStringReplace.Name = "textBoxStringReplace";
            this.textBoxStringReplace.Size = new System.Drawing.Size(176, 20);
            this.textBoxStringReplace.TabIndex = 2;
            this.textBoxStringReplace.TextChanged += new System.EventHandler(this.TextBoxTextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Strings to replace:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 39);
            this.label8.TabIndex = 3;
            this.label8.Text = "String to replace to:\r\n(leave blank for removal, instead of \r\nreplacement)";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.checkBoxChangeExtension);
            this.tabPage2.Controls.Add(this.radioButtonTitle);
            this.tabPage2.Controls.Add(this.radioButtonLowerCase);
            this.tabPage2.Controls.Add(this.radioButtonUpperCase);
            this.tabPage2.Controls.Add(this.buttonChangeCase);
            this.tabPage2.Location = new System.Drawing.Point(42, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(247, 204);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Change Case";
            // 
            // checkBoxChangeExtension
            // 
            this.checkBoxChangeExtension.AutoSize = true;
            this.checkBoxChangeExtension.Location = new System.Drawing.Point(29, 135);
            this.checkBoxChangeExtension.Name = "checkBoxChangeExtension";
            this.checkBoxChangeExtension.Size = new System.Drawing.Size(146, 17);
            this.checkBoxChangeExtension.TabIndex = 9;
            this.checkBoxChangeExtension.Text = "Change extension as well";
            this.checkBoxChangeExtension.UseVisualStyleBackColor = true;
            // 
            // radioButtonTitle
            // 
            this.radioButtonTitle.AutoSize = true;
            this.radioButtonTitle.Location = new System.Drawing.Point(29, 88);
            this.radioButtonTitle.Name = "radioButtonTitle";
            this.radioButtonTitle.Size = new System.Drawing.Size(86, 17);
            this.radioButtonTitle.TabIndex = 8;
            this.radioButtonTitle.Text = "Titlecase.Ext";
            this.radioButtonTitle.UseVisualStyleBackColor = true;
            // 
            // radioButtonLowerCase
            // 
            this.radioButtonLowerCase.AutoSize = true;
            this.radioButtonLowerCase.Location = new System.Drawing.Point(29, 56);
            this.radioButtonLowerCase.Name = "radioButtonLowerCase";
            this.radioButtonLowerCase.Size = new System.Drawing.Size(90, 17);
            this.radioButtonLowerCase.TabIndex = 7;
            this.radioButtonLowerCase.Text = "lowercase.ext";
            this.radioButtonLowerCase.UseVisualStyleBackColor = true;
            // 
            // radioButtonUpperCase
            // 
            this.radioButtonUpperCase.AutoSize = true;
            this.radioButtonUpperCase.Checked = true;
            this.radioButtonUpperCase.Location = new System.Drawing.Point(29, 24);
            this.radioButtonUpperCase.Name = "radioButtonUpperCase";
            this.radioButtonUpperCase.Size = new System.Drawing.Size(114, 17);
            this.radioButtonUpperCase.TabIndex = 6;
            this.radioButtonUpperCase.TabStop = true;
            this.radioButtonUpperCase.Text = "UPPERCASE.EXT";
            this.radioButtonUpperCase.UseVisualStyleBackColor = true;
            // 
            // buttonChangeCase
            // 
            this.buttonChangeCase.Location = new System.Drawing.Point(8, 172);
            this.buttonChangeCase.Name = "buttonChangeCase";
            this.buttonChangeCase.Size = new System.Drawing.Size(202, 24);
            this.buttonChangeCase.TabIndex = 5;
            this.buttonChangeCase.Text = "Rename!";
            this.buttonChangeCase.UseVisualStyleBackColor = true;
            this.buttonChangeCase.Click += new System.EventHandler(this.ButtonChangeCaseClick);
            // 
            // backgroundWorkerRename
            // 
            this.backgroundWorkerRename.WorkerReportsProgress = true;
            this.backgroundWorkerRename.WorkerSupportsCancellation = true;
            this.backgroundWorkerRename.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerRenameDoWork);
            this.backgroundWorkerRename.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorkerProgressChanged);
            this.backgroundWorkerRename.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorkerRunWorkerCompleted);
            // 
            // backgroundWorkerReplace
            // 
            this.backgroundWorkerReplace.WorkerReportsProgress = true;
            this.backgroundWorkerReplace.WorkerSupportsCancellation = true;
            this.backgroundWorkerReplace.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerReplaceDoWork);
            this.backgroundWorkerReplace.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorkerProgressChanged);
            this.backgroundWorkerReplace.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorkerRunWorkerCompleted);
            // 
            // backgroundWorkerCase
            // 
            this.backgroundWorkerCase.WorkerReportsProgress = true;
            this.backgroundWorkerCase.WorkerSupportsCancellation = true;
            this.backgroundWorkerCase.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerCaseDoWork);
            this.backgroundWorkerCase.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorkerProgressChanged);
            this.backgroundWorkerCase.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorkerRunWorkerCompleted);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupPreview);
            this.panel4.Controls.Add(this.groupBoxRename);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(244, 375);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5);
            this.panel4.Size = new System.Drawing.Size(622, 241);
            this.panel4.TabIndex = 13;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 616);
            this.Controls.Add(this.groupBoxFile);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.groupTree);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "MultiFile Renamer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMainFormClosing);
            this.Load += new System.EventHandler(this.FormMainLoad);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.groupPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.windowsMediaPlayer)).EndInit();
            this.groupTree.ResumeLayout(false);
            this.groupBoxFile.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBoxRename.ResumeLayout(false);
            this.fixedTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemSettings;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemAbout;
        private System.Windows.Forms.TreeView treeViewFolder;
        private System.Windows.Forms.ImageList imageListIcon;
        private System.Windows.Forms.ListView listViewFilesToRename;
        private System.Windows.Forms.Button buttonListAll;
        private System.Windows.Forms.Button buttonListOne;
        private System.Windows.Forms.Button buttonRemoveOne;
        private System.Windows.Forms.Button buttonRemoveAll;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.GroupBox groupPreview;
        private System.Windows.Forms.GroupBox groupTree;
        private System.Windows.Forms.GroupBox groupBoxFile;
        private System.Windows.Forms.GroupBox groupBoxRename;
        private System.Windows.Forms.TextBox textBoxExtensions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.ColumnHeader FileDate;
        private AxWMPLib.AxWindowsMediaPlayer windowsMediaPlayer;
        private System.Windows.Forms.ListView listViewFilesInFolder;
        private FixedTabControl fixedTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonRename;
        private System.Windows.Forms.TextBox textBoxLabel2;
        private System.Windows.Forms.TextBox textBoxDigitN;
        private System.Windows.Forms.TextBox textBoxStartingN;
        private System.Windows.Forms.TextBox textBoxLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelExample;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonReplace;
        private System.Windows.Forms.TextBox textBoxStringReplacement;
        private System.Windows.Forms.TextBox textBoxStringReplace;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonChangeCase;
        private System.Windows.Forms.RadioButton radioButtonTitle;
        private System.Windows.Forms.RadioButton radioButtonLowerCase;
        private System.Windows.Forms.RadioButton radioButtonUpperCase;
        private System.Windows.Forms.CheckBox checkBoxChangeExtension;
        private System.ComponentModel.BackgroundWorker backgroundWorkerRename;
        private System.ComponentModel.BackgroundWorker backgroundWorkerReplace;
        private System.ComponentModel.BackgroundWorker backgroundWorkerCase;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolStripMenuItem explorerIntegrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem installToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uninstallToolStripMenuItem;
    }
}

