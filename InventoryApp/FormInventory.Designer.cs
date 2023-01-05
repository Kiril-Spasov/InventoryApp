namespace InventoryApp
{
    partial class FormInventory
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.receivePartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issuePartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayTotalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuInventory});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuInventory
            // 
            this.toolStripMenuInventory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.receivePartToolStripMenuItem,
            this.issuePartToolStripMenuItem,
            this.displayTotalsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuInventory.Name = "toolStripMenuInventory";
            this.toolStripMenuInventory.Size = new System.Drawing.Size(84, 24);
            this.toolStripMenuInventory.Text = "Inventory";
            // 
            // receivePartToolStripMenuItem
            // 
            this.receivePartToolStripMenuItem.Name = "receivePartToolStripMenuItem";
            this.receivePartToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.receivePartToolStripMenuItem.Text = "Receive Part";
            this.receivePartToolStripMenuItem.Click += new System.EventHandler(this.receivePartToolStripMenuItem_Click);
            // 
            // issuePartToolStripMenuItem
            // 
            this.issuePartToolStripMenuItem.Name = "issuePartToolStripMenuItem";
            this.issuePartToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.issuePartToolStripMenuItem.Text = "Issue Part";
            this.issuePartToolStripMenuItem.Click += new System.EventHandler(this.issuePartToolStripMenuItem_Click);
            // 
            // displayTotalsToolStripMenuItem
            // 
            this.displayTotalsToolStripMenuItem.Name = "displayTotalsToolStripMenuItem";
            this.displayTotalsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.displayTotalsToolStripMenuItem.Text = "Display Totals";
            this.displayTotalsToolStripMenuItem.Click += new System.EventHandler(this.displayTotalsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // FormInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormInventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.FormInventory_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuInventory;
        private System.Windows.Forms.ToolStripMenuItem receivePartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issuePartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayTotalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

