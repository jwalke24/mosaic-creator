﻿using System.Security.AccessControl;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MosaicForm));
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.createMosaicMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solidBlockMosaicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureMosaicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.originalImageBox = new System.Windows.Forms.PictureBox();
            this.tabPane = new System.Windows.Forms.TabControl();
            this.originalTabPage = new System.Windows.Forms.TabPage();
            this.mosaicTabPage = new System.Windows.Forms.TabPage();
            this.mosaicImageBox = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripGridButton = new System.Windows.Forms.ToolStripSplitButton();
            this.addGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.squareGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traingleGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blockSizeTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.menuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.originalImageBox)).BeginInit();
            this.tabPane.SuspendLayout();
            this.originalTabPage.SuspendLayout();
            this.mosaicTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mosaicImageBox)).BeginInit();
            this.toolStrip1.SuspendLayout();
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
            this.saveMenuItem,
            this.exitMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "File";
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openMenuItem.Text = "Open";
            this.openMenuItem.Click += new System.EventHandler(this.openMenuItem_Click);
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveMenuItem.Text = "Save";
            this.saveMenuItem.Click += new System.EventHandler(this.saveMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createMosaicMenuItem});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(39, 20);
            this.editMenu.Text = "Edit";
            // 
            // createMosaicMenuItem
            // 
            this.createMosaicMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solidBlockMosaicToolStripMenuItem,
            this.pictureMosaicToolStripMenuItem});
            this.createMosaicMenuItem.Name = "createMosaicMenuItem";
            this.createMosaicMenuItem.Size = new System.Drawing.Size(158, 22);
            this.createMosaicMenuItem.Text = "Create Mosaic...";
            // 
            // solidBlockMosaicToolStripMenuItem
            // 
            this.solidBlockMosaicToolStripMenuItem.Name = "solidBlockMosaicToolStripMenuItem";
            this.solidBlockMosaicToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.solidBlockMosaicToolStripMenuItem.Text = "Solid Block Mosaic";
            // 
            // pictureMosaicToolStripMenuItem
            // 
            this.pictureMosaicToolStripMenuItem.Name = "pictureMosaicToolStripMenuItem";
            this.pictureMosaicToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.pictureMosaicToolStripMenuItem.Text = "Picture Mosaic";
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpMenuItem,
            this.aboutMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 20);
            this.helpMenu.Text = "Help";
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(107, 22);
            this.helpMenuItem.Text = "Help";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutMenuItem.Text = "About";
            // 
            // originalImageBox
            // 
            this.originalImageBox.Location = new System.Drawing.Point(0, 0);
            this.originalImageBox.Name = "originalImageBox";
            this.originalImageBox.Size = new System.Drawing.Size(775, 488);
            this.originalImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.originalImageBox.TabIndex = 1;
            this.originalImageBox.TabStop = false;
            // 
            // tabPane
            // 
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
            this.originalTabPage.Controls.Add(this.originalImageBox);
            this.originalTabPage.Location = new System.Drawing.Point(4, 22);
            this.originalTabPage.Name = "originalTabPage";
            this.originalTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.originalTabPage.Size = new System.Drawing.Size(771, 488);
            this.originalTabPage.TabIndex = 0;
            this.originalTabPage.Text = "Original Image";
            this.originalTabPage.UseVisualStyleBackColor = true;
            // 
            // mosaicTabPage
            // 
            this.mosaicTabPage.Controls.Add(this.mosaicImageBox);
            this.mosaicTabPage.Location = new System.Drawing.Point(4, 22);
            this.mosaicTabPage.Name = "mosaicTabPage";
            this.mosaicTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.mosaicTabPage.Size = new System.Drawing.Size(771, 488);
            this.mosaicTabPage.TabIndex = 1;
            this.mosaicTabPage.Text = "Mosaic";
            this.mosaicTabPage.UseVisualStyleBackColor = true;
            // 
            // mosaicImageBox
            // 
            this.mosaicImageBox.Location = new System.Drawing.Point(0, 0);
            this.mosaicImageBox.Name = "mosaicImageBox";
            this.mosaicImageBox.Size = new System.Drawing.Size(771, 488);
            this.mosaicImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mosaicImageBox.TabIndex = 0;
            this.mosaicImageBox.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripGridButton,
            this.blockSizeTextBox});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(777, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripGridButton
            // 
            this.toolStripGridButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripGridButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addGridToolStripMenuItem,
            this.removeGridToolStripMenuItem});
            this.toolStripGridButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripGridButton.Image")));
            this.toolStripGridButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripGridButton.Name = "toolStripGridButton";
            this.toolStripGridButton.Size = new System.Drawing.Size(45, 22);
            this.toolStripGridButton.Text = "Grid";
            // 
            // addGridToolStripMenuItem
            // 
            this.addGridToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.squareGridToolStripMenuItem,
            this.traingleGridToolStripMenuItem});
            this.addGridToolStripMenuItem.Name = "addGridToolStripMenuItem";
            this.addGridToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addGridToolStripMenuItem.Text = "Add Grid";
            // 
            // squareGridToolStripMenuItem
            // 
            this.squareGridToolStripMenuItem.Name = "squareGridToolStripMenuItem";
            this.squareGridToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.squareGridToolStripMenuItem.Text = "Square Grid";
            this.squareGridToolStripMenuItem.Click += new System.EventHandler(this.squareGridToolStripMenuItem_Click);
            // 
            // traingleGridToolStripMenuItem
            // 
            this.traingleGridToolStripMenuItem.Name = "traingleGridToolStripMenuItem";
            this.traingleGridToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.traingleGridToolStripMenuItem.Text = "Traingle Grid";
            this.traingleGridToolStripMenuItem.Click += new System.EventHandler(this.traingleGridToolStripMenuItem_Click);
            // 
            // removeGridToolStripMenuItem
            // 
            this.removeGridToolStripMenuItem.Name = "removeGridToolStripMenuItem";
            this.removeGridToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.removeGridToolStripMenuItem.Text = "Remove Grid";
            this.removeGridToolStripMenuItem.Click += new System.EventHandler(this.removeGridToolStripMenuItem_Click);
            // 
            // blockSizeTextBox
            // 
            this.blockSizeTextBox.Name = "blockSizeTextBox";
            this.blockSizeTextBox.Size = new System.Drawing.Size(100, 25);
            this.blockSizeTextBox.Text = "Enter Block Size";
            this.blockSizeTextBox.Click += new System.EventHandler(this.blockSizeTextBox_Click);
            // 
            // MosaicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 565);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabPane);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Name = "MosaicForm";
            this.Text = "Mosaic Creator by Walker and Odom";
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.originalImageBox)).EndInit();
            this.tabPane.ResumeLayout(false);
            this.originalTabPage.ResumeLayout(false);
            this.mosaicTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mosaicImageBox)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.PictureBox originalImageBox;
        private System.Windows.Forms.TabControl tabPane;
        private System.Windows.Forms.TabPage originalTabPage;
        private System.Windows.Forms.TabPage mosaicTabPage;
        private System.Windows.Forms.PictureBox mosaicImageBox;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solidBlockMosaicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pictureMosaicToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripGridButton;
        private System.Windows.Forms.ToolStripMenuItem addGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem squareGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traingleGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox blockSizeTextBox;
    }
}

