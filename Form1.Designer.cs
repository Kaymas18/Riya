namespace simpleapp
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
            this.logo = new System.Windows.Forms.PictureBox();
            this.username = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.rbtnadmin = new System.Windows.Forms.RadioButton();
            this.rbtnemp = new System.Windows.Forms.RadioButton();
            this.btnlogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(-1, -1);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(501, 173);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Calibri", 10F);
            this.username.Location = new System.Drawing.Point(219, 185);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(66, 17);
            this.username.TabIndex = 1;
            this.username.Text = "Username";
            this.username.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(182, 203);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(142, 20);
            this.txtusername.TabIndex = 2;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Calibri", 10F);
            this.password.Location = new System.Drawing.Point(219, 234);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(61, 17);
            this.password.TabIndex = 3;
            this.password.Text = "Password";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(182, 255);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(142, 20);
            this.txtpassword.TabIndex = 4;
            // 
            // rbtnadmin
            // 
            this.rbtnadmin.AutoSize = true;
            this.rbtnadmin.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnadmin.Location = new System.Drawing.Point(212, 292);
            this.rbtnadmin.Name = "rbtnadmin";
            this.rbtnadmin.Size = new System.Drawing.Size(102, 19);
            this.rbtnadmin.TabIndex = 5;
            this.rbtnadmin.TabStop = true;
            this.rbtnadmin.Text = "Administrator";
            this.rbtnadmin.UseVisualStyleBackColor = true;
            // 
            // rbtnemp
            // 
            this.rbtnemp.AutoSize = true;
            this.rbtnemp.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnemp.Location = new System.Drawing.Point(212, 315);
            this.rbtnemp.Name = "rbtnemp";
            this.rbtnemp.Size = new System.Drawing.Size(77, 19);
            this.rbtnemp.TabIndex = 6;
            this.rbtnemp.TabStop = true;
            this.rbtnemp.Text = "Employee";
            this.rbtnemp.UseVisualStyleBackColor = true;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnlogin.Location = new System.Drawing.Point(364, 219);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(108, 56);
            this.btnlogin.TabIndex = 7;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 350);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.rbtnemp);
            this.Controls.Add(this.rbtnadmin);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.username);
            this.Controls.Add(this.logo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.RadioButton rbtnadmin;
        private System.Windows.Forms.RadioButton rbtnemp;
        private System.Windows.Forms.Button btnlogin;
    }
}

