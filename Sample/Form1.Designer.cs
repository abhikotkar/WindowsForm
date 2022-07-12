
namespace Sample
{
    partial class loginform
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
            this.labeluserid = new System.Windows.Forms.Label();
            this.textuserid = new System.Windows.Forms.TextBox();
            this.labelpassword = new System.Windows.Forms.Label();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labeluserid
            // 
            this.labeluserid.AutoSize = true;
            this.labeluserid.Location = new System.Drawing.Point(179, 114);
            this.labeluserid.Name = "labeluserid";
            this.labeluserid.Size = new System.Drawing.Size(40, 13);
            this.labeluserid.TabIndex = 0;
            this.labeluserid.Text = "UserID";
            this.labeluserid.Click += new System.EventHandler(this.labeluserid_Click);
            // 
            // textuserid
            // 
            this.textuserid.Location = new System.Drawing.Point(266, 114);
            this.textuserid.Name = "textuserid";
            this.textuserid.Size = new System.Drawing.Size(100, 20);
            this.textuserid.TabIndex = 1;
            // 
            // labelpassword
            // 
            this.labelpassword.AutoSize = true;
            this.labelpassword.Location = new System.Drawing.Point(179, 164);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(53, 13);
            this.labelpassword.TabIndex = 2;
            this.labelpassword.Text = "Password";
            // 
            // textpassword
            // 
            this.textpassword.Location = new System.Drawing.Point(266, 164);
            this.textpassword.Name = "textpassword";
            this.textpassword.PasswordChar = '*';
            this.textpassword.Size = new System.Drawing.Size(100, 20);
            this.textpassword.TabIndex = 3;
            this.textpassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(182, 212);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(61, 21);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(309, 210);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(57, 23);
            this.btnreset.TabIndex = 5;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 370);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.labelpassword);
            this.Controls.Add(this.textuserid);
            this.Controls.Add(this.labeluserid);
            this.Name = "loginform";
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.loginform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeluserid;
        private System.Windows.Forms.TextBox textuserid;
        private System.Windows.Forms.Label labelpassword;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnreset;
    }
}

