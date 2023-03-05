namespace WFA__CoffeeProgram__CKT
{
    partial class Main
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
            this.siparişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toplamCiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ekstrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalTurnoverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siparişToolStripMenuItem
            // 
            this.siparişToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siparişToolStripMenuItem.Name = "siparişToolStripMenuItem";
            this.siparişToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.siparişToolStripMenuItem.Text = "Order";
            this.siparişToolStripMenuItem.Click += new System.EventHandler(this.siparişToolStripMenuItem_Click);
            // 
            // toplamCiroToolStripMenuItem
            // 
            this.toplamCiroToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toplamCiroToolStripMenuItem.Name = "toplamCiroToolStripMenuItem";
            this.toplamCiroToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.toplamCiroToolStripMenuItem.Text = "Total Turnover";
            this.toplamCiroToolStripMenuItem.Click += new System.EventHandler(this.toplamCiroToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 24);
            // 
            // ekstrasToolStripMenuItem
            // 
            this.ekstrasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ekstrasToolStripMenuItem.Name = "ekstrasToolStripMenuItem";
            this.ekstrasToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.ekstrasToolStripMenuItem.Text = "Ekstras";
            this.ekstrasToolStripMenuItem.Click += new System.EventHandler(this.ekstrasToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.stockToolStripMenuItem.Text = "Stock";
            this.stockToolStripMenuItem.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
            // 
            // totalTurnoverToolStripMenuItem
            // 
            this.totalTurnoverToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.totalTurnoverToolStripMenuItem.Name = "totalTurnoverToolStripMenuItem";
            this.totalTurnoverToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.totalTurnoverToolStripMenuItem.Text = "Coffees";
            this.totalTurnoverToolStripMenuItem.Click += new System.EventHandler(this.totalTurnoverToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Enabled = false;
            this.menuStrip1.Font = new System.Drawing.Font("Dutch801 XBd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişToolStripMenuItem,
            this.toplamCiroToolStripMenuItem,
            this.toolStripMenuItem1,
            this.ekstrasToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.totalTurnoverToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(691, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WFA__CoffeeProgram__CKT.Properties.Resources.Coffee_Menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(691, 959);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Coffee Program";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem siparişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toplamCiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ekstrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalTurnoverToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip1;
    }
}

