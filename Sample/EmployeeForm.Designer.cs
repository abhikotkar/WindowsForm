
namespace Sample
{
    partial class EmployeeForm
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
            this.txtsal = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.empsal = new System.Windows.Forms.Label();
            this.empname = new System.Windows.Forms.Label();
            this.empid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // jsonwrt
            // 
            this.jsonwrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jsonwrt.Location = new System.Drawing.Point(286, 301);
            this.jsonwrt.Name = "jsonwrt";
            this.jsonwrt.Size = new System.Drawing.Size(109, 23);
            this.jsonwrt.TabIndex = 49;
            this.jsonwrt.Text = "JSON Write";
            this.jsonwrt.UseVisualStyleBackColor = true;
            this.jsonwrt.Click += new System.EventHandler(this.jsonwrt_Click);
            // 
            // jsonread
            // 
            this.jsonread.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jsonread.Location = new System.Drawing.Point(409, 301);
            this.jsonread.Name = "jsonread";
            this.jsonread.Size = new System.Drawing.Size(100, 23);
            this.jsonread.TabIndex = 48;
            this.jsonread.Text = "JSON Read";
            this.jsonread.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.jsonread.UseVisualStyleBackColor = true;
            this.jsonread.Click += new System.EventHandler(this.jsonread_Click);
            // 
            // soapread
            // 
            this.soapread.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soapread.Location = new System.Drawing.Point(409, 260);
            this.soapread.Name = "soapread";
            this.soapread.Size = new System.Drawing.Size(100, 23);
            this.soapread.TabIndex = 47;
            this.soapread.Text = "SOAP Read";
            this.soapread.UseVisualStyleBackColor = true;
            this.soapread.Click += new System.EventHandler(this.soapread_Click);
            // 
            // soapwrt
            // 
            this.soapwrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soapwrt.Location = new System.Drawing.Point(286, 260);
            this.soapwrt.Name = "soapwrt";
            this.soapwrt.Size = new System.Drawing.Size(109, 23);
            this.soapwrt.TabIndex = 46;
            this.soapwrt.Text = "SOAP Write";
            this.soapwrt.UseVisualStyleBackColor = true;
            this.soapwrt.Click += new System.EventHandler(this.soapwrt_Click);
            // 
            // xmlread
            // 
            this.xmlread.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xmlread.Location = new System.Drawing.Point(409, 222);
            this.xmlread.Name = "xmlread";
            this.xmlread.Size = new System.Drawing.Size(100, 23);
            this.xmlread.TabIndex = 45;
            this.xmlread.Text = "XML Read";
            this.xmlread.UseVisualStyleBackColor = true;
            this.xmlread.Click += new System.EventHandler(this.xmlread_Click);
            // 
            // xmlwrt
            // 
            this.xmlwrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xmlwrt.Location = new System.Drawing.Point(286, 222);
            this.xmlwrt.Name = "xmlwrt";
            this.xmlwrt.Size = new System.Drawing.Size(109, 23);
            this.xmlwrt.TabIndex = 44;
            this.xmlwrt.Text = "XML Write";
            this.xmlwrt.UseVisualStyleBackColor = true;
            this.xmlwrt.Click += new System.EventHandler(this.xmlwrt_Click);
            // 
            // bnryread
            // 
            this.bnryread.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnryread.Location = new System.Drawing.Point(409, 184);
            this.bnryread.Name = "bnryread";
            this.bnryread.Size = new System.Drawing.Size(100, 23);
            this.bnryread.TabIndex = 43;
            this.bnryread.Text = "Binary Read";
            this.bnryread.UseVisualStyleBackColor = true;
            this.bnryread.Click += new System.EventHandler(this.bnryread_Click);
            // 
            // bnrywrt
            // 
            this.bnrywrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnrywrt.Location = new System.Drawing.Point(286, 184);
            this.bnrywrt.Name = "bnrywrt";
            this.bnrywrt.Size = new System.Drawing.Size(109, 23);
            this.bnrywrt.TabIndex = 42;
            this.bnrywrt.Text = "Binary Write";
            this.bnrywrt.UseVisualStyleBackColor = true;
            this.bnrywrt.Click += new System.EventHandler(this.bnrywrt_Click);
            // 
            // txtsal
            // 
            this.txtsal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsal.Location = new System.Drawing.Point(409, 132);
            this.txtsal.Name = "txtsal";
            this.txtsal.Size = new System.Drawing.Size(100, 21);
            this.txtsal.TabIndex = 41;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(409, 85);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 21);
            this.txtname.TabIndex = 40;
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(409, 46);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 21);
            this.txtid.TabIndex = 39;
            // 
            // empsal
            // 
            this.empsal.AutoSize = true;
            this.empsal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empsal.Location = new System.Drawing.Point(283, 135);
            this.empsal.Name = "empsal";
            this.empsal.Size = new System.Drawing.Size(114, 15);
            this.empsal.TabIndex = 38;
            this.empsal.Text = "Employee Salary";
            this.empsal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // empname
            // 
            this.empname.AutoSize = true;
            this.empname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empname.Location = new System.Drawing.Point(283, 88);
            this.empname.Name = "empname";
            this.empname.Size = new System.Drawing.Size(112, 15);
            this.empname.TabIndex = 37;
            this.empname.Text = "Employee Name";
            // 
            // empid
            // 
            this.empid.AutoSize = true;
            this.empid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empid.Location = new System.Drawing.Point(307, 46);
            this.empid.Name = "empid";
            this.empid.Size = new System.Drawing.Size(88, 15);
            this.empid.TabIndex = 36;
            this.empid.Text = "Employee ID";
            // 
            // EmployeeForm
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
            this.Controls.Add(this.txtsal);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.empsal);
            this.Controls.Add(this.empname);
            this.Controls.Add(this.empid);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
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
        private System.Windows.Forms.TextBox txtsal;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label empsal;
        private System.Windows.Forms.Label empname;
        private System.Windows.Forms.Label empid;
    }
}