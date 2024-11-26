namespace WinFormsApp1
{
    partial class Form4
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
            menuStrip1 = new MenuStrip();
            功能ToolStripMenuItem = new ToolStripMenuItem();
            類別管理ToolStripMenuItem = new ToolStripMenuItem();
            資料管理ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { 功能ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 功能ToolStripMenuItem
            // 
            功能ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 類別管理ToolStripMenuItem, 資料管理ToolStripMenuItem });
            功能ToolStripMenuItem.Name = "功能ToolStripMenuItem";
            功能ToolStripMenuItem.Size = new Size(43, 20);
            功能ToolStripMenuItem.Text = "功能";
            // 
            // 類別管理ToolStripMenuItem
            // 
            類別管理ToolStripMenuItem.Name = "類別管理ToolStripMenuItem";
            類別管理ToolStripMenuItem.Size = new Size(180, 22);
            類別管理ToolStripMenuItem.Text = "類別管理";
            類別管理ToolStripMenuItem.Click += 類別管理ToolStripMenuItem_Click;
            // 
            // 資料管理ToolStripMenuItem
            // 
            資料管理ToolStripMenuItem.Name = "資料管理ToolStripMenuItem";
            資料管理ToolStripMenuItem.Size = new Size(180, 22);
            資料管理ToolStripMenuItem.Text = "資料管理";
            資料管理ToolStripMenuItem.Click += 資料管理ToolStripMenuItem_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form4";
            Text = "Form4";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 功能ToolStripMenuItem;
        private ToolStripMenuItem 類別管理ToolStripMenuItem;
        private ToolStripMenuItem 資料管理ToolStripMenuItem;
    }
}