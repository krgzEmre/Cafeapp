namespace cafe
{
    partial class Form1
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.başlangıçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siyahToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beyazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cıkısToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn1.Location = new System.Drawing.Point(60, 171);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(146, 73);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Masa 1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn2.Location = new System.Drawing.Point(232, 171);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(146, 73);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "Masa 2";
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn3.Location = new System.Drawing.Point(406, 171);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(146, 73);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "Masa 3";
            this.btn3.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn4.Location = new System.Drawing.Point(581, 171);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(146, 73);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "Masa 4";
            this.btn4.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.başlangıçToolStripMenuItem,
            this.cıkısToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // başlangıçToolStripMenuItem
            // 
            this.başlangıçToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siyahToolStripMenuItem,
            this.beyazToolStripMenuItem});
            this.başlangıçToolStripMenuItem.Name = "başlangıçToolStripMenuItem";
            this.başlangıçToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.başlangıçToolStripMenuItem.Text = "Başlangıç";
            // 
            // siyahToolStripMenuItem
            // 
            this.siyahToolStripMenuItem.Name = "siyahToolStripMenuItem";
            this.siyahToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.siyahToolStripMenuItem.Text = "Siyah";
            this.siyahToolStripMenuItem.Click += new System.EventHandler(this.siyahToolStripMenuItem_Click);
            // 
            // beyazToolStripMenuItem
            // 
            this.beyazToolStripMenuItem.Name = "beyazToolStripMenuItem";
            this.beyazToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.beyazToolStripMenuItem.Text = "Beyaz";
            this.beyazToolStripMenuItem.Click += new System.EventHandler(this.beyazToolStripMenuItem_Click);
            // 
            // cıkısToolStripMenuItem
            // 
            this.cıkısToolStripMenuItem.Name = "cıkısToolStripMenuItem";
            this.cıkısToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.cıkısToolStripMenuItem.Text = "Cıkıs";
            this.cıkısToolStripMenuItem.Click += new System.EventHandler(this.cıkısToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem başlangıçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siyahToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beyazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cıkısToolStripMenuItem;
    }
}

