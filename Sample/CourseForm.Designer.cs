
namespace Sample
{
    partial class CourseForm
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
            this.txtfees = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.coursefees = new System.Windows.Forms.Label();
            this.coursename = new System.Windows.Forms.Label();
            this.courseid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // jsonwrt
            // 
            this.jsonwrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jsonwrt.Location = new System.Drawing.Point(242, 274);
            this.jsonwrt.Name = "jsonwrt";
            this.jsonwrt.Size = new System.Drawing.Size(109, 23);
            this.jsonwrt.TabIndex = 63;
            this.jsonwrt.Text = "JSON Write";
            this.jsonwrt.UseVisualStyleBackColor = true;
            this.jsonwrt.Click += new System.EventHandler(this.jsonwrt_Click);
            // 
            // jsonread
            // 
            this.jsonread.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jsonread.Location = new System.Drawing.Point(365, 274);
            this.jsonread.Name = "jsonread";
            this.jsonread.Size = new System.Drawing.Size(100, 23);
            this.jsonread.TabIndex = 62;
            this.jsonread.Text = "JSON Read";
            this.jsonread.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.jsonread.UseVisualStyleBackColor = true;
            this.jsonread.Click += new System.EventHandler(this.jsonread_Click);
            // 
            // soapread
            // 
            this.soapread.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soapread.Location = new System.Drawing.Point(365, 233);
            this.soapread.Name = "soapread";
            this.soapread.Size = new System.Drawing.Size(100, 23);
            this.soapread.TabIndex = 61;
            this.soapread.Text = "SOAP Read";
            this.soapread.UseVisualStyleBackColor = true;
            this.soapread.Click += new System.EventHandler(this.soapread_Click);
            // 
            // soapwrt
            // 
            this.soapwrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soapwrt.Location = new System.Drawing.Point(242, 233);
            this.soapwrt.Name = "soapwrt";
            this.soapwrt.Size = new System.Drawing.Size(109, 23);
            this.soapwrt.TabIndex = 60;
            this.soapwrt.Text = "SOAP Write";
            this.soapwrt.UseVisualStyleBackColor = true;
            this.soapwrt.Click += new System.EventHandler(this.soapwrt_Click);
            // 
            // xmlread
            // 
            this.xmlread.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xmlread.Location = new System.Drawing.Point(365, 195);
            this.xmlread.Name = "xmlread";
            this.xmlread.Size = new System.Drawing.Size(100, 23);
            this.xmlread.TabIndex = 59;
            this.xmlread.Text = "XML Read";
            this.xmlread.UseVisualStyleBackColor = true;
            this.xmlread.Click += new System.EventHandler(this.xmlread_Click);
            // 
            // xmlwrt
            // 
            this.xmlwrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xmlwrt.Location = new System.Drawing.Point(242, 195);
            this.xmlwrt.Name = "xmlwrt";
            this.xmlwrt.Size = new System.Drawing.Size(109, 23);
            this.xmlwrt.TabIndex = 58;
            this.xmlwrt.Text = "XML Write";
            this.xmlwrt.UseVisualStyleBackColor = true;
            this.xmlwrt.Click += new System.EventHandler(this.xmlwrt_Click);
            // 
            // bnryread
            // 
            this.bnryread.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnryread.Location = new System.Drawing.Point(365, 157);
            this.bnryread.Name = "bnryread";
            this.bnryread.Size = new System.Drawing.Size(100, 23);
            this.bnryread.TabIndex = 57;
            this.bnryread.Text = "Binary Read";
            this.bnryread.UseVisualStyleBackColor = true;
            this.bnryread.Click += new System.EventHandler(this.bnryread_Click);
            // 
            // bnrywrt
            // 
            this.bnrywrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnrywrt.Location = new System.Drawing.Point(242, 157);
            this.bnrywrt.Name = "bnrywrt";
            this.bnrywrt.Size = new System.Drawing.Size(109, 23);
            this.bnrywrt.TabIndex = 56;
            this.bnrywrt.Text = "Binary Write";
            this.bnrywrt.UseVisualStyleBackColor = true;
            this.bnrywrt.Click += new System.EventHandler(this.bnrywrt_Click);
            // 
            // txtfees
            // 
            this.txtfees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfees.Location = new System.Drawing.Point(365, 105);
            this.txtfees.Name = "txtfees";
            this.txtfees.Size = new System.Drawing.Size(100, 21);
            this.txtfees.TabIndex = 55;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(365, 58);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 21);
            this.txtname.TabIndex = 54;
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(365, 19);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 21);
            this.txtid.TabIndex = 53;
            // 
            // coursefees
            // 
            this.coursefees.AutoSize = true;
            this.coursefees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursefees.Location = new System.Drawing.Point(239, 108);
            this.coursefees.Name = "coursefees";
            this.coursefees.Size = new System.Drawing.Size(87, 15);
            this.coursefees.TabIndex = 52;
            this.coursefees.Text = "Course Fees";
            this.coursefees.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // coursename
            // 
            this.coursename.AutoSize = true;
            this.coursename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursename.Location = new System.Drawing.Point(239, 61);
            this.coursename.Name = "coursename";
            this.coursename.Size = new System.Drawing.Size(94, 15);
            this.coursename.TabIndex = 51;
            this.coursename.Text = "Course Name";
            // 
            // courseid
            // 
            this.courseid.AutoSize = true;
            this.courseid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseid.Location = new System.Drawing.Point(263, 19);
            this.courseid.Name = "courseid";
            this.courseid.Size = new System.Drawing.Size(70, 15);
            this.courseid.TabIndex = 50;
            this.courseid.Text = "Course ID";
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 450);
            this.Controls.Add(this.jsonwrt);
            this.Controls.Add(this.jsonread);
            this.Controls.Add(this.soapread);
            this.Controls.Add(this.soapwrt);
            this.Controls.Add(this.xmlread);
            this.Controls.Add(this.xmlwrt);
            this.Controls.Add(this.bnryread);
            this.Controls.Add(this.bnrywrt);
            this.Controls.Add(this.txtfees);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.coursefees);
            this.Controls.Add(this.coursename);
            this.Controls.Add(this.courseid);
            this.Name = "CourseForm";
            this.Text = "CourseForm";
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
        private System.Windows.Forms.TextBox txtfees;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label coursefees;
        private System.Windows.Forms.Label coursename;
        private System.Windows.Forms.Label courseid;
    }
}