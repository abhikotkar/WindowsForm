
namespace Sample
{
    partial class serialization
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
            this.jsonwrt = new System.Windows.Forms.Button();
            this.jsonread = new System.Windows.Forms.Button();
            this.soapread = new System.Windows.Forms.Button();
            this.soapwrt = new System.Windows.Forms.Button();
            this.xmlread = new System.Windows.Forms.Button();
            this.xmlwrt = new System.Windows.Forms.Button();
            this.bnryread = new System.Windows.Forms.Button();
            this.bnrywrt = new System.Windows.Forms.Button();
            this.txtprize = new System.Windows.Forms.TextBox();
            this.lblprize = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // jsonwrt
            // 
            this.jsonwrt.Location = new System.Drawing.Point(293, 294);
            this.jsonwrt.Name = "jsonwrt";
            this.jsonwrt.Size = new System.Drawing.Size(75, 23);
            this.jsonwrt.TabIndex = 27;
            this.jsonwrt.Text = "JSON Write";
            this.jsonwrt.UseVisualStyleBackColor = true;
            this.jsonwrt.Click += new System.EventHandler(this.jsonwrt_Click);
            // 
            // jsonread
            // 
            this.jsonread.Location = new System.Drawing.Point(441, 294);
            this.jsonread.Name = "jsonread";
            this.jsonread.Size = new System.Drawing.Size(75, 23);
            this.jsonread.TabIndex = 26;
            this.jsonread.Text = "JSON Read";
            this.jsonread.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.jsonread.UseVisualStyleBackColor = true;
            this.jsonread.Click += new System.EventHandler(this.jsonread_Click);
            // 
            // soapread
            // 
            this.soapread.Location = new System.Drawing.Point(441, 253);
            this.soapread.Name = "soapread";
            this.soapread.Size = new System.Drawing.Size(75, 23);
            this.soapread.TabIndex = 25;
            this.soapread.Text = "SOAP Read";
            this.soapread.UseVisualStyleBackColor = true;
            this.soapread.Click += new System.EventHandler(this.soapread_Click);
            // 
            // soapwrt
            // 
            this.soapwrt.Location = new System.Drawing.Point(293, 253);
            this.soapwrt.Name = "soapwrt";
            this.soapwrt.Size = new System.Drawing.Size(75, 23);
            this.soapwrt.TabIndex = 24;
            this.soapwrt.Text = "SOAP Write";
            this.soapwrt.UseVisualStyleBackColor = true;
            this.soapwrt.Click += new System.EventHandler(this.soapwrt_Click);
            // 
            // xmlread
            // 
            this.xmlread.Location = new System.Drawing.Point(441, 215);
            this.xmlread.Name = "xmlread";
            this.xmlread.Size = new System.Drawing.Size(75, 23);
            this.xmlread.TabIndex = 23;
            this.xmlread.Text = "XML Read";
            this.xmlread.UseVisualStyleBackColor = true;
            this.xmlread.Click += new System.EventHandler(this.xmlread_Click);
            // 
            // xmlwrt
            // 
            this.xmlwrt.Location = new System.Drawing.Point(293, 215);
            this.xmlwrt.Name = "xmlwrt";
            this.xmlwrt.Size = new System.Drawing.Size(75, 23);
            this.xmlwrt.TabIndex = 22;
            this.xmlwrt.Text = "XML Write";
            this.xmlwrt.UseVisualStyleBackColor = true;
            this.xmlwrt.Click += new System.EventHandler(this.xmlwrt_Click);
            // 
            // bnryread
            // 
            this.bnryread.Location = new System.Drawing.Point(441, 177);
            this.bnryread.Name = "bnryread";
            this.bnryread.Size = new System.Drawing.Size(75, 23);
            this.bnryread.TabIndex = 21;
            this.bnryread.Text = "Binary Read";
            this.bnryread.UseVisualStyleBackColor = true;
            this.bnryread.Click += new System.EventHandler(this.bnryread_Click);
            // 
            // bnrywrt
            // 
            this.bnrywrt.Location = new System.Drawing.Point(293, 177);
            this.bnrywrt.Name = "bnrywrt";
            this.bnrywrt.Size = new System.Drawing.Size(75, 23);
            this.bnrywrt.TabIndex = 20;
            this.bnrywrt.Text = "Binary Write";
            this.bnrywrt.UseVisualStyleBackColor = true;
            this.bnrywrt.Click += new System.EventHandler(this.bnrywrt_Click);
            // 
            // txtprize
            // 
            this.txtprize.Location = new System.Drawing.Point(364, 137);
            this.txtprize.Name = "txtprize";
            this.txtprize.Size = new System.Drawing.Size(152, 20);
            this.txtprize.TabIndex = 19;
            // 
            // lblprize
            // 
            this.lblprize.AutoSize = true;
            this.lblprize.Location = new System.Drawing.Point(316, 137);
            this.lblprize.Name = "lblprize";
            this.lblprize.Size = new System.Drawing.Size(30, 13);
            this.lblprize.TabIndex = 18;
            this.lblprize.Text = "Prize";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(364, 91);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(152, 20);
            this.txtname.TabIndex = 17;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(271, 98);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(75, 13);
            this.lblname.TabIndex = 16;
            this.lblname.Text = "Product Name";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(364, 53);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(152, 20);
            this.txtid.TabIndex = 15;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(290, 56);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(56, 13);
            this.lblid.TabIndex = 14;
            this.lblid.Text = "Product Id";
            // 
            // serialization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.jsonwrt);
            this.Controls.Add(this.jsonread);
            this.Controls.Add(this.soapread);
            this.Controls.Add(this.soapwrt);
            this.Controls.Add(this.xmlread);
            this.Controls.Add(this.xmlwrt);
            this.Controls.Add(this.bnryread);
            this.Controls.Add(this.bnrywrt);
            this.Controls.Add(this.txtprize);
            this.Controls.Add(this.lblprize);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblid);
            this.Name = "serialization";
            this.Text = "Serialization Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button jsonwrt;
        private System.Windows.Forms.Button jsonread;
        private System.Windows.Forms.Button soapread;
        private System.Windows.Forms.Button soapwrt;
        private System.Windows.Forms.Button xmlread;
        private System.Windows.Forms.Button xmlwrt;
        private System.Windows.Forms.Button bnryread;
        private System.Windows.Forms.Button bnrywrt;
        private System.Windows.Forms.TextBox txtprize;
        private System.Windows.Forms.Label lblprize;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblid;
    }
}