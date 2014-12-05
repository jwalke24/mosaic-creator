using System;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace GroupEMosaicator.View
{
    partial class MosaicForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MosaicForm));
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.createMosaicMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solidBlockMosaicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.squareBlockMosaicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triangleBlockMosaicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowerLeftToUpperRightTriangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upperLeftToLowerRightTriangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureMosaicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPane = new System.Windows.Forms.TabControl();
            this.originalTabPage = new System.Windows.Forms.TabPage();
            this.originalImagePanel = new System.Windows.Forms.Panel();
            this.originalImageBox = new System.Windows.Forms.PictureBox();
            this.mosaicTabPage = new System.Windows.Forms.TabPage();
            this.mosaicImagePanel = new System.Windows.Forms.Panel();
            this.mosaicImageBox = new System.Windows.Forms.PictureBox();
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.openButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripGridButton = new System.Windows.Forms.ToolStripSplitButton();
            this.addGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.squareGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traingleGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.blockSizeTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.createBlockMosaicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triangleBlocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowerLeftToUpperRightTriangleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.upperLeftToLowerRightTriangleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.squareBlocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPictureMosaicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.imagePaletteLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.viewPaletteButton = new System.Windows.Forms.ToolStripButton();
            this.imagePalette = new System.Windows.Forms.ImageList(this.components);
            this.menuBar.SuspendLayout();
            this.tabPane.SuspendLayout();
            this.originalTabPage.SuspendLayout();
            this.originalImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.originalImageBox)).BeginInit();
            this.mosaicTabPage.SuspendLayout();
            this.mosaicImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mosaicImageBox)).BeginInit();
            this.toolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.helpMenu});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(777, 24);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenuItem,
            this.openFolderToolStripMenuItem,
            this.saveMenuItem,
            this.exitMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openMenuItem.Size = new System.Drawing.Size(183, 22);
            this.openMenuItem.Text = "&Open";
            this.openMenuItem.Click += new System.EventHandler(this.openMenuItem_Click);
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.openFolderToolStripMenuItem.Text = "Open &Palette";
            this.openFolderToolStripMenuItem.Click += new System.EventHandler(this.openFolderToolStripMenuItem_Click);
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Enabled = false;
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveMenuItem.Size = new System.Drawing.Size(183, 22);
            this.saveMenuItem.Text = "&Save";
            this.saveMenuItem.Click += new System.EventHandler(this.saveMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitMenuItem.Size = new System.Drawing.Size(183, 22);
            this.exitMenuItem.Text = "E&xit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createMosaicMenuItem});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(39, 20);
            this.editMenu.Text = "&Edit";
            // 
            // createMosaicMenuItem
            // 
            this.createMosaicMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solidBlockMosaicToolStripMenuItem,
            this.pictureMosaicToolStripMenuItem});
            this.createMosaicMenuItem.Name = "createMosaicMenuItem";
            this.createMosaicMenuItem.Size = new System.Drawing.Size(158, 22);
            this.createMosaicMenuItem.Text = "Create &Mosaic...";
            // 
            // solidBlockMosaicToolStripMenuItem
            // 
            this.solidBlockMosaicToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.squareBlockMosaicToolStripMenuItem,
            this.triangleBlockMosaicToolStripMenuItem});
            this.solidBlockMosaicToolStripMenuItem.Enabled = false;
            this.solidBlockMosaicToolStripMenuItem.Name = "solidBlockMosaicToolStripMenuItem";
            this.solidBlockMosaicToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.solidBlockMosaicToolStripMenuItem.Text = "Block Mosaic";
            this.solidBlockMosaicToolStripMenuItem.Click += new System.EventHandler(this.solidBlockMosaicToolStripMenuItem_Click);
            // 
            // squareBlockMosaicToolStripMenuItem
            // 
            this.squareBlockMosaicToolStripMenuItem.Name = "squareBlockMosaicToolStripMenuItem";
            this.squareBlockMosaicToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.squareBlockMosaicToolStripMenuItem.Text = "Square Block Mosaic";
            this.squareBlockMosaicToolStripMenuItem.Click += new System.EventHandler(this.squareBlockMosaicToolStripMenuItem_Click);
            // 
            // triangleBlockMosaicToolStripMenuItem
            // 
            this.triangleBlockMosaicToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lowerLeftToUpperRightTriangleToolStripMenuItem,
            this.upperLeftToLowerRightTriangleToolStripMenuItem});
            this.triangleBlockMosaicToolStripMenuItem.Name = "triangleBlockMosaicToolStripMenuItem";
            this.triangleBlockMosaicToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.triangleBlockMosaicToolStripMenuItem.Text = "Triangle Block Mosaic";
            // 
            // lowerLeftToUpperRightTriangleToolStripMenuItem
            // 
            this.lowerLeftToUpperRightTriangleToolStripMenuItem.Name = "lowerLeftToUpperRightTriangleToolStripMenuItem";
            this.lowerLeftToUpperRightTriangleToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.lowerLeftToUpperRightTriangleToolStripMenuItem.Text = "Lower Left to Upper Right Triangle";
            this.lowerLeftToUpperRightTriangleToolStripMenuItem.Click += new System.EventHandler(this.lowerLeftToUpperRightTriangleToolStripMenuItem_Click);
            // 
            // upperLeftToLowerRightTriangleToolStripMenuItem
            // 
            this.upperLeftToLowerRightTriangleToolStripMenuItem.Name = "upperLeftToLowerRightTriangleToolStripMenuItem";
            this.upperLeftToLowerRightTriangleToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.upperLeftToLowerRightTriangleToolStripMenuItem.Text = "Upper Left to Lower Right Triangle";
            this.upperLeftToLowerRightTriangleToolStripMenuItem.Click += new System.EventHandler(this.upperLeftToLowerRightTriangleToolStripMenuItem_Click);
            // 
            // pictureMosaicToolStripMenuItem
            // 
            this.pictureMosaicToolStripMenuItem.Enabled = false;
            this.pictureMosaicToolStripMenuItem.Name = "pictureMosaicToolStripMenuItem";
            this.pictureMosaicToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pictureMosaicToolStripMenuItem.Text = "&Picture Mosaic";
            this.pictureMosaicToolStripMenuItem.Click += new System.EventHandler(this.pictureMosaicToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpMenuItem,
            this.aboutMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 20);
            this.helpMenu.Text = "&Help";
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.helpMenuItem.Size = new System.Drawing.Size(149, 22);
            this.helpMenuItem.Text = "&Help";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboutMenuItem.Text = "&About";
            // 
            // tabPane
            // 
            this.tabPane.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPane.Controls.Add(this.originalTabPage);
            this.tabPane.Controls.Add(this.mosaicTabPage);
            this.tabPane.Location = new System.Drawing.Point(0, 52);
            this.tabPane.Name = "tabPane";
            this.tabPane.SelectedIndex = 0;
            this.tabPane.Size = new System.Drawing.Size(779, 514);
            this.tabPane.TabIndex = 2;
            // 
            // originalTabPage
            // 
            this.originalTabPage.AutoScroll = true;
            this.originalTabPage.Controls.Add(this.originalImagePanel);
            this.originalTabPage.Location = new System.Drawing.Point(4, 22);
            this.originalTabPage.Name = "originalTabPage";
            this.originalTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.originalTabPage.Size = new System.Drawing.Size(771, 488);
            this.originalTabPage.TabIndex = 0;
            this.originalTabPage.Text = "Original Image";
            this.originalTabPage.UseVisualStyleBackColor = true;
            // 
            // originalImagePanel
            // 
            this.originalImagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.originalImagePanel.AutoScroll = true;
            this.originalImagePanel.Controls.Add(this.originalImageBox);
            this.originalImagePanel.Location = new System.Drawing.Point(3, 3);
            this.originalImagePanel.Name = "originalImagePanel";
            this.originalImagePanel.Size = new System.Drawing.Size(765, 482);
            this.originalImagePanel.TabIndex = 0;
            // 
            // originalImageBox
            // 
            this.originalImageBox.Location = new System.Drawing.Point(3, 3);
            this.originalImageBox.Name = "originalImageBox";
            this.originalImageBox.Size = new System.Drawing.Size(759, 476);
            this.originalImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.originalImageBox.TabIndex = 2;
            this.originalImageBox.TabStop = false;
            this.originalImageBox.MouseEnter += new System.EventHandler(this.originalImageBox_MouseEnter);
            this.originalImageBox.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.originalImageBox_MouseWheel);
            // 
            // mosaicTabPage
            // 
            this.mosaicTabPage.Controls.Add(this.mosaicImagePanel);
            this.mosaicTabPage.Location = new System.Drawing.Point(4, 22);
            this.mosaicTabPage.Name = "mosaicTabPage";
            this.mosaicTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.mosaicTabPage.Size = new System.Drawing.Size(771, 488);
            this.mosaicTabPage.TabIndex = 1;
            this.mosaicTabPage.Text = "Mosaic";
            this.mosaicTabPage.UseVisualStyleBackColor = true;
            // 
            // mosaicImagePanel
            // 
            this.mosaicImagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mosaicImagePanel.AutoScroll = true;
            this.mosaicImagePanel.Controls.Add(this.mosaicImageBox);
            this.mosaicImagePanel.Location = new System.Drawing.Point(3, 3);
            this.mosaicImagePanel.Name = "mosaicImagePanel";
            this.mosaicImagePanel.Size = new System.Drawing.Size(765, 482);
            this.mosaicImagePanel.TabIndex = 0;
            // 
            // mosaicImageBox
            // 
            this.mosaicImageBox.Location = new System.Drawing.Point(3, 3);
            this.mosaicImageBox.Name = "mosaicImageBox";
            this.mosaicImageBox.Size = new System.Drawing.Size(759, 476);
            this.mosaicImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mosaicImageBox.TabIndex = 1;
            this.mosaicImageBox.TabStop = false;
            this.mosaicImageBox.MouseEnter += new System.EventHandler(this.mosaicImageBox_MouseEnter);
            this.mosaicImageBox.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.mosaicImageBox_MouseWheel);
            // 
            // toolBar
            // 
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openButton,
            this.toolStripSeparator4,
            this.saveButton,
            this.toolStripSeparator2,
            this.toolStripGridButton,
            this.toolStripSeparator1,
            this.blockSizeTextBox,
            this.toolStripSeparator3,
            this.toolStripSplitButton1,
            this.toolStripSeparator5,
            this.viewPaletteButton,
            this.imagePaletteLabel,
            this.toolStripSeparator6});
            this.toolBar.Location = new System.Drawing.Point(0, 24);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(777, 25);
            this.toolBar.TabIndex = 8;
            this.toolBar.Text = "toolStrip1";
            // 
            // openButton
            // 
            this.openButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openButton.Image = ((System.Drawing.Image)(resources.GetObject("openButton.Image")));
            this.openButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(23, 22);
            this.openButton.ToolTipText = "Open Image";
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // saveButton
            // 
            this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveButton.Enabled = false;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(23, 22);
            this.saveButton.ToolTipText = "Save Image";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripGridButton
            // 
            this.toolStripGridButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addGridToolStripMenuItem,
            this.removeGridToolStripMenuItem});
            this.toolStripGridButton.Enabled = false;
            this.toolStripGridButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripGridButton.Image")));
            this.toolStripGridButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripGridButton.Name = "toolStripGridButton";
            this.toolStripGridButton.Size = new System.Drawing.Size(70, 22);
            this.toolStripGridButton.Text = "Grid...";
            this.toolStripGridButton.ToolTipText = "Display a grid for the current block size.";
            // 
            // addGridToolStripMenuItem
            // 
            this.addGridToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.squareGridToolStripMenuItem,
            this.traingleGridToolStripMenuItem});
            this.addGridToolStripMenuItem.Name = "addGridToolStripMenuItem";
            this.addGridToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.addGridToolStripMenuItem.Text = "Add Grid";
            // 
            // squareGridToolStripMenuItem
            // 
            this.squareGridToolStripMenuItem.Name = "squareGridToolStripMenuItem";
            this.squareGridToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.squareGridToolStripMenuItem.Text = "Square Grid";
            this.squareGridToolStripMenuItem.Click += new System.EventHandler(this.squareGridToolStripMenuItem_Click);
            // 
            // traingleGridToolStripMenuItem
            // 
            this.traingleGridToolStripMenuItem.Name = "traingleGridToolStripMenuItem";
            this.traingleGridToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.traingleGridToolStripMenuItem.Text = "Traingle Grid";
            this.traingleGridToolStripMenuItem.Click += new System.EventHandler(this.traingleGridToolStripMenuItem_Click);
            // 
            // removeGridToolStripMenuItem
            // 
            this.removeGridToolStripMenuItem.Name = "removeGridToolStripMenuItem";
            this.removeGridToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.removeGridToolStripMenuItem.Text = "Remove Grid";
            this.removeGridToolStripMenuItem.Click += new System.EventHandler(this.removeGridToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // blockSizeTextBox
            // 
            this.blockSizeTextBox.Enabled = false;
            this.blockSizeTextBox.Name = "blockSizeTextBox";
            this.blockSizeTextBox.Size = new System.Drawing.Size(90, 25);
            this.blockSizeTextBox.Text = "Enter Block Size";
            this.blockSizeTextBox.Leave += new System.EventHandler(this.blockSizeTextBox_Left);
            this.blockSizeTextBox.Click += new System.EventHandler(this.blockSizeTextBox_Click);
            this.blockSizeTextBox.TextChanged += new System.EventHandler(this.blockSizeTextBox_TextChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createBlockMosaicToolStripMenuItem,
            this.createPictureMosaicToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(123, 22);
            this.toolStripSplitButton1.Text = "Create Mosaic...";
            this.toolStripSplitButton1.ToolTipText = "Create a mosaic.";
            // 
            // createBlockMosaicToolStripMenuItem
            // 
            this.createBlockMosaicToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.triangleBlocksToolStripMenuItem,
            this.squareBlocksToolStripMenuItem});
            this.createBlockMosaicToolStripMenuItem.Enabled = false;
            this.createBlockMosaicToolStripMenuItem.Name = "createBlockMosaicToolStripMenuItem";
            this.createBlockMosaicToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.createBlockMosaicToolStripMenuItem.Text = "Create Block Mosaic";
            // 
            // triangleBlocksToolStripMenuItem
            // 
            this.triangleBlocksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lowerLeftToUpperRightTriangleToolStripMenuItem1,
            this.upperLeftToLowerRightTriangleToolStripMenuItem1});
            this.triangleBlocksToolStripMenuItem.Name = "triangleBlocksToolStripMenuItem";
            this.triangleBlocksToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.triangleBlocksToolStripMenuItem.Text = "Triangle Blocks";
            this.triangleBlocksToolStripMenuItem.ToolTipText = "Create a Triangle Mosaic";
            // 
            // lowerLeftToUpperRightTriangleToolStripMenuItem1
            // 
            this.lowerLeftToUpperRightTriangleToolStripMenuItem1.Name = "lowerLeftToUpperRightTriangleToolStripMenuItem1";
            this.lowerLeftToUpperRightTriangleToolStripMenuItem1.Size = new System.Drawing.Size(255, 22);
            this.lowerLeftToUpperRightTriangleToolStripMenuItem1.Text = "Lower Left to Upper Right Triangle";
            this.lowerLeftToUpperRightTriangleToolStripMenuItem1.Click += new System.EventHandler(this.lowerLeftToUpperRightTriangleToolStripMenuItem1_Click);
            // 
            // upperLeftToLowerRightTriangleToolStripMenuItem1
            // 
            this.upperLeftToLowerRightTriangleToolStripMenuItem1.Name = "upperLeftToLowerRightTriangleToolStripMenuItem1";
            this.upperLeftToLowerRightTriangleToolStripMenuItem1.Size = new System.Drawing.Size(255, 22);
            this.upperLeftToLowerRightTriangleToolStripMenuItem1.Text = "Upper Left to Lower Right Triangle";
            this.upperLeftToLowerRightTriangleToolStripMenuItem1.Click += new System.EventHandler(this.upperLeftToLowerRightTriangleToolStripMenuItem1_Click);
            // 
            // squareBlocksToolStripMenuItem
            // 
            this.squareBlocksToolStripMenuItem.Name = "squareBlocksToolStripMenuItem";
            this.squareBlocksToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.squareBlocksToolStripMenuItem.Text = "Square Blocks";
            this.squareBlocksToolStripMenuItem.ToolTipText = "Create a Square Mosaic";
            this.squareBlocksToolStripMenuItem.Click += new System.EventHandler(this.squareBlocksToolStripMenuItem_Click);
            // 
            // createPictureMosaicToolStripMenuItem
            // 
            this.createPictureMosaicToolStripMenuItem.Enabled = false;
            this.createPictureMosaicToolStripMenuItem.Name = "createPictureMosaicToolStripMenuItem";
            this.createPictureMosaicToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.createPictureMosaicToolStripMenuItem.Text = "Create Picture Mosaic";
            this.createPictureMosaicToolStripMenuItem.Click += new System.EventHandler(this.createPictureMosaicToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // imagePaletteLabel
            // 
            this.imagePaletteLabel.Name = "imagePaletteLabel";
            this.imagePaletteLabel.Size = new System.Drawing.Size(106, 22);
            this.imagePaletteLabel.Text = "0 images in palette";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // viewPaletteButton
            // 
            this.viewPaletteButton.Enabled = false;
            this.viewPaletteButton.Image = ((System.Drawing.Image)(resources.GetObject("viewPaletteButton.Image")));
            this.viewPaletteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.viewPaletteButton.Name = "viewPaletteButton";
            this.viewPaletteButton.Size = new System.Drawing.Size(91, 22);
            this.viewPaletteButton.Text = "View Palette";
            this.viewPaletteButton.ToolTipText = "View the images in the palette.";
            this.viewPaletteButton.Click += new System.EventHandler(this.viewPaletteButton_Click);
            // 
            // imagePalette
            // 
            this.imagePalette.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imagePalette.ImageSize = new System.Drawing.Size(16, 16);
            this.imagePalette.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MosaicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 565);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.tabPane);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Name = "MosaicForm";
            this.Text = "Mosaic Creator by Walker and Odom";
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.tabPane.ResumeLayout(false);
            this.originalTabPage.ResumeLayout(false);
            this.originalImagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.originalImageBox)).EndInit();
            this.mosaicTabPage.ResumeLayout(false);
            this.mosaicImagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mosaicImageBox)).EndInit();
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createMosaicMenuItem;
        private System.Windows.Forms.TabControl tabPane;
        private System.Windows.Forms.TabPage originalTabPage;
        private System.Windows.Forms.TabPage mosaicTabPage;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solidBlockMosaicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pictureMosaicToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripSplitButton toolStripGridButton;
        private System.Windows.Forms.ToolStripMenuItem addGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem squareGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traingleGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox blockSizeTextBox;
        private System.Windows.Forms.ToolStripButton openButton;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem createBlockMosaicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createPictureMosaicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel imagePaletteLabel;
        private System.Windows.Forms.ToolStripMenuItem triangleBlocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem squareBlocksToolStripMenuItem;
        private System.Windows.Forms.ImageList imagePalette;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton viewPaletteButton;
        private System.Windows.Forms.Panel originalImagePanel;
        private System.Windows.Forms.PictureBox originalImageBox;
        private Panel mosaicImagePanel;
        private PictureBox mosaicImageBox;
        private ToolStripMenuItem squareBlockMosaicToolStripMenuItem;
        private ToolStripMenuItem triangleBlockMosaicToolStripMenuItem;
        private ToolStripMenuItem lowerLeftToUpperRightTriangleToolStripMenuItem;
        private ToolStripMenuItem upperLeftToLowerRightTriangleToolStripMenuItem;
        private ToolStripMenuItem lowerLeftToUpperRightTriangleToolStripMenuItem1;
        private ToolStripMenuItem upperLeftToLowerRightTriangleToolStripMenuItem1;
    }
}

