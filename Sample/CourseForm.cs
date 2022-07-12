using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Sample
{
    public partial class CourseForm : Form
    {
        public CourseForm()
        {
            InitializeComponent();
        }

        private void bnrywrt_Click(object sender, EventArgs e)
        {
            try
            {
                Course c = new Course();
                c.Courseid = Convert.ToInt32(txtid.Text);
                c.Coursename = txtname.Text;
                c.CourseFees = Convert.ToInt32(txtfees.Text);
                FileStream fs = new FileStream(@"D:\Course", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, c);
                MessageBox.Show("Add Binary file Succesfully");
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bnryread_Click(object sender, EventArgs e)
        {
            try
            {
                Course c = new Course();
                FileStream fs = new FileStream(@"D:\Course", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                c = (Course)bf.Deserialize(fs);
                txtid.Text = c.Courseid.ToString();
                txtname.Text = c.Coursename;
                txtfees.Text = c.CourseFees.ToString();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void xmlwrt_Click(object sender, EventArgs e)
        {
            try
            {
                Course c = new Course();
                c.Courseid = Convert.ToInt32(txtid.Text);
                c.Coursename = txtname.Text;
                c.CourseFees = Convert.ToInt32(txtfees.Text);
                FileStream fs = new FileStream(@"D:\CourseXml", FileMode.Create, FileAccess.Write);
                XmlSerializer xs = new XmlSerializer(typeof(Course));
                xs.Serialize(fs, c);
                MessageBox.Show("Add XML file Succesfully");
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void xmlread_Click(object sender, EventArgs e)
        {
            try
            {
                Course c = new Course();
                FileStream fs = new FileStream(@"D:\CourseXml", FileMode.Open, FileAccess.Read);
                XmlSerializer xs = new XmlSerializer(typeof(Course));
                c = (Course)xs.Deserialize(fs);
                txtid.Text = c.Courseid.ToString();
                txtname.Text = c.Coursename;
                txtfees.Text = c.CourseFees.ToString();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void soapwrt_Click(object sender, EventArgs e)
        {
            try
            {
                Course c = new Course();
                c.Courseid = Convert.ToInt32(txtid.Text);
                c.Coursename = txtname.Text;
                c.CourseFees = Convert.ToInt32(txtfees.Text);
                FileStream fs = new FileStream(@"D:\CourseSoap", FileMode.Create, FileAccess.Write);
                SoapFormatter sf = new SoapFormatter();
                sf.Serialize(fs, c);
                MessageBox.Show("Add SOAP file Succesfully");
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void soapread_Click(object sender, EventArgs e)
        {
            try
            {
                Course c = new Course();
                FileStream fs = new FileStream(@"D:\CourseSoap", FileMode.Open, FileAccess.Read);
                SoapFormatter sf = new SoapFormatter();
                c = (Course)sf.Deserialize(fs);
                txtid.Text = c.Courseid.ToString();
                txtname.Text = c.Coursename;
                txtfees.Text = c.CourseFees.ToString();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void jsonwrt_Click(object sender, EventArgs e)
        {
            try
            {
                Course c = new Course();
                c.Courseid = Convert.ToInt32(txtid.Text);
                c.Coursename = txtname.Text;
                c.CourseFees = Convert.ToInt32(txtfees.Text);
                FileStream fs = new FileStream(@"D:\CourseJson", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, c);
                MessageBox.Show("Add JSON file Succesfully");
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void jsonread_Click(object sender, EventArgs e)
        {

            try
            {
                Course c = new Course();
                FileStream fs = new FileStream(@"D:\CourseJson", FileMode.Open, FileAccess.Read);
                c = JsonSerializer.Deserialize<Course>(fs);
                txtid.Text = c.Courseid.ToString();
                txtname.Text = c.Coursename;
                txtfees.Text = c.CourseFees.ToString();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
