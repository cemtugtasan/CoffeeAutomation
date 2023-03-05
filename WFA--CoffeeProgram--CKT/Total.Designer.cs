namespace WFA__CoffeeProgram__CKT
{
    partial class Total
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
            this.lbTotalOrders = new System.Windows.Forms.ListBox();
            this.lblTotalOrderValue = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTotalTurnover = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTotalOrders
            // 
            this.lbTotalOrders.BackColor = System.Drawing.Color.Black;
            this.lbTotalOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbTotalOrders.ForeColor = System.Drawing.SystemColors.Window;
            this.lbTotalOrders.FormattingEnabled = true;
            this.lbTotalOrders.ItemHeight = 20;
            this.lbTotalOrders.Location = new System.Drawing.Point(12, 145);
            this.lbTotalOrders.Name = "lbTotalOrders";
            this.lbTotalOrders.Size = new System.Drawing.Size(651, 464);
            this.lbTotalOrders.TabIndex = 1;
            // 
            // lblTotalOrderValue
            // 
            this.lblTotalOrderValue.AutoSize = true;
            this.lblTotalOrderValue.BackColor = System.Drawing.Color.Black;
            this.lblTotalOrderValue.CausesValidation = false;
            this.lblTotalOrderValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalOrderValue.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTotalOrderValue.Location = new System.Drawing.Point(6, 33);
            this.lblTotalOrderValue.Name = "lblTotalOrderValue";
            this.lblTotalOrderValue.Size = new System.Drawing.Size(104, 20);
            this.lblTotalOrderValue.TabIndex = 3;
            this.lblTotalOrderValue.Text = "Total Price :";
            this.lblTotalOrderValue.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotalOrderValue);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(12, 685);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 72);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total Order Value";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotalTurnover);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Location = new System.Drawing.Point(12, 763);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 72);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total Turnover";
            // 
            // lblTotalTurnover
            // 
            this.lblTotalTurnover.AutoSize = true;
            this.lblTotalTurnover.BackColor = System.Drawing.Color.Black;
            this.lblTotalTurnover.CausesValidation = false;
            this.lblTotalTurnover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalTurnover.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTotalTurnover.Location = new System.Drawing.Point(6, 33);
            this.lblTotalTurnover.Name = "lblTotalTurnover";
            this.lblTotalTurnover.Size = new System.Drawing.Size(104, 20);
            this.lblTotalTurnover.TabIndex = 3;
            this.lblTotalTurnover.Text = "Total Price :";
            this.lblTotalTurnover.Click += new System.EventHandler(this.label1_Click);
            // 
            // Total
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(707, 998);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbTotalOrders);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Total";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Total_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTotalOrderValue;
        private System.Windows.Forms.Label lblTotalTurnover;
        public System.Windows.Forms.ListBox lbTotalOrders;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.GroupBox groupBox2;
    }
}