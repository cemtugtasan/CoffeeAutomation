namespace WFA__CoffeeProgram__CKT
{
    partial class Coffees
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
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.flpCoffees = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.BackColor = System.Drawing.Color.Transparent;
            this.rbSmall.Checked = true;
            this.rbSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbSmall.ForeColor = System.Drawing.SystemColors.Window;
            this.rbSmall.Location = new System.Drawing.Point(60, 153);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(71, 24);
            this.rbSmall.TabIndex = 14;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = false;
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.BackColor = System.Drawing.Color.Transparent;
            this.rbMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbMedium.ForeColor = System.Drawing.SystemColors.Window;
            this.rbMedium.Location = new System.Drawing.Point(60, 183);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(89, 24);
            this.rbMedium.TabIndex = 15;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = false;
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.BackColor = System.Drawing.Color.Transparent;
            this.rbLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbLarge.ForeColor = System.Drawing.SystemColors.Window;
            this.rbLarge.Location = new System.Drawing.Point(60, 213);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(73, 24);
            this.rbLarge.TabIndex = 16;
            this.rbLarge.TabStop = true;
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Employee Name";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.BackColor = System.Drawing.Color.Black;
            this.lblEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmployeeName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblEmployeeName.Location = new System.Drawing.Point(11, 38);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(138, 20);
            this.lblEmployeeName.TabIndex = 22;
            this.lblEmployeeName.Text = "Employee Name";
            // 
            // flpCoffees
            // 
            this.flpCoffees.AutoScroll = true;
            this.flpCoffees.BackColor = System.Drawing.Color.Black;
            this.flpCoffees.Location = new System.Drawing.Point(60, 278);
            this.flpCoffees.Name = "flpCoffees";
            this.flpCoffees.Size = new System.Drawing.Size(584, 669);
            this.flpCoffees.TabIndex = 23;
            this.flpCoffees.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // Coffees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WFA__CoffeeProgram__CKT.Properties.Resources.Coffee_Menu;
            this.ClientSize = new System.Drawing.Size(691, 959);
            this.Controls.Add(this.flpCoffees);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbSmall);
            this.Controls.Add(this.rbMedium);
            this.Controls.Add(this.rbLarge);
            this.Name = "Coffees";
            this.Text = "Coffees";
            this.Load += new System.EventHandler(this.Coffees_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RadioButton rbSmall;
        public System.Windows.Forms.RadioButton rbMedium;
        public System.Windows.Forms.RadioButton rbLarge;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.FlowLayoutPanel flpCoffees;
    }
}