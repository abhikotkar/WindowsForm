using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void loginform_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (textuserid.Text == "admin" && textpassword.Text == "123")
            {
                MessageBox.Show("Success");
            }
            else
                MessageBox.Show("Failed");
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            textuserid.Clear();
            textpassword.Clear();
        }

        private void labeluserid_Click(object sender, EventArgs e)
        {

        }
    }
}
