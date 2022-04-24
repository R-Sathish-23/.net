namespace WindowsFormsApp1
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this._Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Gavs = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.label_Password = new System.Windows.Forms.Label();
            this.label1_Login = new System.Windows.Forms.Label();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.label1_UserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Login
            // 
            this.textBox_Login.BackColor = System.Drawing.Color.White;
            this.textBox_Login.Location = new System.Drawing.Point(333, 196);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(209, 22);
            this.textBox_Login.TabIndex = 17;
            this.textBox_Login.TextChanged += new System.EventHandler(this.textBox_Login_TextChanged);
            // 
            // _Password
            // 
            this._Password.Location = new System.Drawing.Point(333, 272);
            this._Password.Name = "_Password";
            this._Password.Size = new System.Drawing.Size(209, 22);
            this._Password.TabIndex = 16;
            this._Password.TextChanged += new System.EventHandler(this._Password_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Welcome To Gavs";
            // 
            // btn_Gavs
            // 
            this.btn_Gavs.Location = new System.Drawing.Point(23, 62);
            this.btn_Gavs.Name = "btn_Gavs";
            this.btn_Gavs.Size = new System.Drawing.Size(75, 23);
            this.btn_Gavs.TabIndex = 14;
            this.btn_Gavs.Text = "Gavs";
            this.btn_Gavs.UseVisualStyleBackColor = true;
            this.btn_Gavs.Click += new System.EventHandler(this.btn_Gavs_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(430, 318);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 13;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Enter
            // 
            this.btn_Enter.Location = new System.Drawing.Point(333, 318);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(75, 23);
            this.btn_Enter.TabIndex = 12;
            this.btn_Enter.Text = "Enter";
            this.btn_Enter.UseVisualStyleBackColor = true;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.BackColor = System.Drawing.Color.Transparent;
            this.label_Password.Location = new System.Drawing.Point(221, 275);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(67, 16);
            this.label_Password.TabIndex = 11;
            this.label_Password.Text = "Password";
            this.label_Password.Click += new System.EventHandler(this.label_Password_Click);
            // 
            // label1_Login
            // 
            this.label1_Login.AutoSize = true;
            this.label1_Login.BackColor = System.Drawing.Color.Transparent;
            this.label1_Login.Location = new System.Drawing.Point(221, 199);
            this.label1_Login.Name = "label1_Login";
            this.label1_Login.Size = new System.Drawing.Size(51, 16);
            this.label1_Login.TabIndex = 10;
            this.label1_Login.Text = "LoginId";
            this.label1_Login.Click += new System.EventHandler(this.label1_Login_Click);
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.BackColor = System.Drawing.Color.White;
            this.textBox_UserName.Location = new System.Drawing.Point(333, 235);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(209, 22);
            this.textBox_UserName.TabIndex = 27;
            this.textBox_UserName.TextChanged += new System.EventHandler(this.textBox_UserName_TextChanged);
            // 
            // label1_UserName
            // 
            this.label1_UserName.AutoSize = true;
            this.label1_UserName.BackColor = System.Drawing.Color.Transparent;
            this.label1_UserName.Location = new System.Drawing.Point(221, 235);
            this.label1_UserName.Name = "label1_UserName";
            this.label1_UserName.Size = new System.Drawing.Size(73, 16);
            this.label1_UserName.TabIndex = 26;
            this.label1_UserName.Text = "UserName";
            this.label1_UserName.Click += new System.EventHandler(this.label1_UserName_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_UserName);
            this.Controls.Add(this.label1_UserName);
            this.Controls.Add(this.textBox_Login);
            this.Controls.Add(this._Password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Gavs);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Enter);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label1_Login);
            this.DoubleBuffered = true;
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.TextBox _Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Gavs;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label1_Login;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.Label label1_UserName;
    }
}