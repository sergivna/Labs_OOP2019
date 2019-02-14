namespace Lab_ado_net
{
    partial class AdminMainForm
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
            this.табліциToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.містаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аптекиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.постачальникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.препаратиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.табліциToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(746, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // табліциToolStripMenuItem
            // 
            this.табліциToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.містаToolStripMenuItem,
            this.аптекиToolStripMenuItem,
            this.постачальникиToolStripMenuItem,
            this.препаратиToolStripMenuItem});
            this.табліциToolStripMenuItem.Name = "табліциToolStripMenuItem";
            this.табліциToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.табліциToolStripMenuItem.Text = "Довідник";
            this.табліциToolStripMenuItem.Click += new System.EventHandler(this.табліциToolStripMenuItem_Click);
            // 
            // містаToolStripMenuItem
            // 
            this.містаToolStripMenuItem.Name = "містаToolStripMenuItem";
            this.містаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.містаToolStripMenuItem.Text = "Міста";
            this.містаToolStripMenuItem.Click += new System.EventHandler(this.містаToolStripMenuItem_Click);
            // 
            // аптекиToolStripMenuItem
            // 
            this.аптекиToolStripMenuItem.Name = "аптекиToolStripMenuItem";
            this.аптекиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.аптекиToolStripMenuItem.Text = "Аптеки";
            this.аптекиToolStripMenuItem.Click += new System.EventHandler(this.аптекиToolStripMenuItem_Click);
            // 
            // постачальникиToolStripMenuItem
            // 
            this.постачальникиToolStripMenuItem.Name = "постачальникиToolStripMenuItem";
            this.постачальникиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.постачальникиToolStripMenuItem.Text = "Постачальники";
            this.постачальникиToolStripMenuItem.Click += new System.EventHandler(this.постачальникиToolStripMenuItem_Click);
            // 
            // препаратиToolStripMenuItem
            // 
            this.препаратиToolStripMenuItem.Name = "препаратиToolStripMenuItem";
            this.препаратиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.препаратиToolStripMenuItem.Text = "Товари";
            this.препаратиToolStripMenuItem.Click += new System.EventHandler(this.препаратиToolStripMenuItem_Click);
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 445);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminMainForm";
            this.Text = "AdminMainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminMainForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem табліциToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem містаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem аптекиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem постачальникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem препаратиToolStripMenuItem;
    }
}