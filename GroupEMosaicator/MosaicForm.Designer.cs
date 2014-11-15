namespace GroupEMosaicator
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
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createMosaicMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.originalImageBox = new System.Windows.Forms.PictureBox();
            this.tabPane = new System.Windows.Forms.TabControl();
            this.originalTabPage = new System.Windows.Forms.TabPage();
            this.mosaicTabPage = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.originalImageBox)).BeginInit();
            this.tabPane.SuspendLayout();
            this.originalTabPage.SuspendLayout();
            this.mosaicTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.menuBar.Size = new System.Drawing.Size(667, 24);
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
            this.openMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openMenuItem.Text = "Open";
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveMenuItem.Text = "Save";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitMenuItem.Text = "Exit";
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createMosaicMenuItem});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(39, 20);
            this.editMenu.Text = "Edit";
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
            this.helpMenuItem.Size = new System.Drawing.Size(152, 22);
            this.helpMenuItem.Text = "Help";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutMenuItem.Text = "About";
            // 
            // createMosaicMenuItem
            // 
            this.createMosaicMenuItem.Name = "createMosaicMenuItem";
            this.createMosaicMenuItem.Size = new System.Drawing.Size(158, 22);
            this.createMosaicMenuItem.Text = "Create Mosaic...";
            // 
            // originalImageBox
            // 
            this.originalImageBox.Location = new System.Drawing.Point(0, 0);
            this.originalImageBox.Name = "originalImageBox";
            this.originalImageBox.Size = new System.Drawing.Size(659, 291);
            this.originalImageBox.TabIndex = 1;
            this.originalImageBox.TabStop = false;
            // 
            // tabPane
            // 
            this.tabPane.Controls.Add(this.originalTabPage);
            this.tabPane.Controls.Add(this.mosaicTabPage);
            this.tabPane.Location = new System.Drawing.Point(0, 27);
            this.tabPane.Name = "tabPane";
            this.tabPane.SelectedIndex = 0;
            this.tabPane.Size = new System.Drawing.Size(667, 317);
            this.tabPane.TabIndex = 2;
            // 
            // originalTabPage
            // 
            this.originalTabPage.Controls.Add(this.originalImageBox);
            this.originalTabPage.Location = new System.Drawing.Point(4, 22);
            this.originalTabPage.Name = "originalTabPage";
            this.originalTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.originalTabPage.Size = new System.Drawing.Size(659, 291);
            this.originalTabPage.TabIndex = 0;
            this.originalTabPage.Text = "Original Image";
            this.originalTabPage.UseVisualStyleBackColor = true;
            // 
            // mosaicTabPage
            // 
            this.mosaicTabPage.Controls.Add(this.pictureBox1);
            this.mosaicTabPage.Location = new System.Drawing.Point(4, 22);
            this.mosaicTabPage.Name = "mosaicTabPage";
            this.mosaicTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.mosaicTabPage.Size = new System.Drawing.Size(659, 291);
            this.mosaicTabPage.TabIndex = 1;
            this.mosaicTabPage.Text = "Mosaic";
            this.mosaicTabPage.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(659, 291);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MosaicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 346);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

