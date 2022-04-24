namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Gavs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1_Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.nEWREGISTRATIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGININToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTAFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nEWREGISTRATIONToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTUDENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nEWREGISTRATIONToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGINToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Gavs
            // 
            this.btn_Gavs.Location = new System.Drawing.Point(38, 55);
            this.btn_Gavs.Name = "btn_Gavs";
            this.btn_Gavs.Size = new System.Drawing.Size(75, 23);
            this.btn_Gavs.TabIndex = 6;
            this.btn_Gavs.Text = "Gavs";
            this.btn_Gavs.UseVisualStyleBackColor = true;
            this.btn_Gavs.Click += new System.EventHandler(this.btn_Gavs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Welcome To Gavs";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1_Admin,
            this.sTAFFToolStripMenuItem,
            this.sTUDENTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(879, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1_Admin
            // 
            this.toolStripMenuItem1_Admin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nEWREGISTRATIONToolStripMenuItem,
            this.lOGININToolStripMenuItem});
            this.toolStripMenuItem1_Admin.Name = "toolStripMenuItem1_Admin";
            this.toolStripMenuItem1_Admin.Size = new System.Drawing.Size(72, 24);
            this.toolStripMenuItem1_Admin.Text = "ADMIN";
            this.toolStripMenuItem1_Admin.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // nEWREGISTRATIONToolStripMenuItem
            // 
            this.nEWREGISTRATIONToolStripMenuItem.Name = "nEWREGISTRATIONToolStripMenuItem";
            this.nEWREGISTRATIONToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.nEWREGISTRATIONToolStripMenuItem.Text = "NEW REGISTRATION";
            this.nEWREGISTRATIONToolStripMenuItem.Click += new System.EventHandler(this.nEWREGISTRATIONToolStripMenuItem_Click);
            // 
            // lOGININToolStripMenuItem
            // 
            this.lOGININToolStripMenuItem.Name = "lOGININToolStripMenuItem";
            this.lOGININToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.lOGININToolStripMenuItem.Text = "LOGIN ";
            this.lOGININToolStripMenuItem.Click += new System.EventHandler(this.lOGININToolStripMenuItem_Click);
            // 
            // sTAFFToolStripMenuItem
            // 
            this.sTAFFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nEWREGISTRATIONToolStripMenuItem1,
            this.lOGINToolStripMenuItem});
            this.sTAFFToolStripMenuItem.Name = "sTAFFToolStripMenuItem";
            this.sTAFFToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.sTAFFToolStripMenuItem.Text = "STAFF";
            this.sTAFFToolStripMenuItem.Click += new System.EventHandler(this.sTAFFToolStripMenuItem_Click);
            // 
            // nEWREGISTRATIONToolStripMenuItem1
            // 
            this.nEWREGISTRATIONToolStripMenuItem1.Name = "nEWREGISTRATIONToolStripMenuItem1";
            this.nEWREGISTRATIONToolStripMenuItem1.Size = new System.Drawing.Size(228, 26);
            this.nEWREGISTRATIONToolStripMenuItem1.Text = "NEW REGISTRATION";
            this.nEWREGISTRATIONToolStripMenuItem1.Click += new System.EventHandler(this.nEWREGISTRATIONToolStripMenuItem1_Click);
            // 
            // lOGINToolStripMenuItem
            // 
            this.lOGINToolStripMenuItem.Name = "lOGINToolStripMenuItem";
            this.lOGINToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.lOGINToolStripMenuItem.Text = "LOGIN  ";
            this.lOGINToolStripMenuItem.Click += new System.EventHandler(this.lOGINToolStripMenuItem_Click);
            // 
            // sTUDENTToolStripMenuItem
            // 
            this.sTUDENTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nEWREGISTRATIONToolStripMenuItem2,
            this.lOGINToolStripMenuItem1});
            this.sTUDENTToolStripMenuItem.Name = "sTUDENTToolStripMenuItem";
            this.sTUDENTToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.sTUDENTToolStripMenuItem.Text = "STUDENT";
            this.sTUDENTToolStripMenuItem.Click += new System.EventHandler(this.sTUDENTToolStripMenuItem_Click);
            // 
            // nEWREGISTRATIONToolStripMenuItem2
            // 
            this.nEWREGISTRATIONToolStripMenuItem2.Name = "nEWREGISTRATIONToolStripMenuItem2";
            this.nEWREGISTRATIONToolStripMenuItem2.Size = new System.Drawing.Size(228, 26);
            this.nEWREGISTRATIONToolStripMenuItem2.Text = "NEW REGISTRATION";
            this.nEWREGISTRATIONToolStripMenuItem2.Click += new System.EventHandler(this.nEWREGISTRATIONToolStripMenuItem2_Click);
            // 
            // lOGINToolStripMenuItem1
            // 
            this.lOGINToolStripMenuItem1.Name = "lOGINToolStripMenuItem1";
            this.lOGINToolStripMenuItem1.Size = new System.Drawing.Size(228, 26);
            this.lOGINToolStripMenuItem1.Text = "LOGIN";
            this.lOGINToolStripMenuItem1.Click += new System.EventHandler(this.lOGINToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(879, 533);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Gavs);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Gavs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1_Admin;
        private System.Windows.Forms.ToolStripMenuItem nEWREGISTRATIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGININToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTAFFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nEWREGISTRATIONToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lOGINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTUDENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nEWREGISTRATIONToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem lOGINToolStripMenuItem1;
    }
}

