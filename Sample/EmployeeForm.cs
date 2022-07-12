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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void bnrywrt_Click(object sender, EventArgs e)
        {
            try
            {
                Employee ee = new Employee();
                ee.Empid = Convert.ToInt32(txtid.Text);
                ee.Empname = txtname.Text;
                ee.Empsal = Convert.ToInt32(txtsal.Text);
                FileStream fs = new FileStream(@"D:\Employee", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, ee);
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
                Employee ep = new Employee();
                FileStream fs = new FileStream(@"D:\Employee", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                ep = (Employee)bf.Deserialize(fs);
                txtid.Text = ep.Empid.ToString();
                txtname.Text = ep.Empname;
                txtsal.Text = ep.Empsal.ToString();
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
                Employee ee = new Employee();
                ee.Empid = Convert.ToInt32(txtid.Text);
                ee.Empname = txtname.Text;
                ee.Empsal = Convert.ToInt32(txtsal.Text);
                FileStream fs = new FileStream(@"D:\EmployeeXml", FileMode.Create, FileAccess.Write);
                XmlSerializer xs = new XmlSerializer(typeof(Employee));
                xs.Serialize(fs, ee);
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
                Employee ep = new Employee();
                FileStream fs = new FileStream(@"D:\EmployeeXml", FileMode.Open, FileAccess.Read);
                XmlSerializer xs = new XmlSerializer(typeof(Employee));
                ep = (Employee)xs.Deserialize(fs);
                txtid.Text = ep.Empid.ToString();
                txtname.Text = ep.Empname;
                txtsal.Text = ep.Empsal.ToString();
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
                Employee ee = new Employee();
                ee.Empid = Convert.ToInt32(txtid.Text);
                ee.Empname = txtname.Text;
                ee.Empsal = Convert.ToInt32(txtsal.Text);
                FileStream fs = new FileStream(@"D:\EmployeeSoap", FileMode.Create, FileAccess.Write);
                SoapFormatter sf = new SoapFormatter();
                sf.Serialize(fs, ee);
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
                Employee ep = new Employee();
                FileStream fs = new FileStream(@"D:\EmployeeSoap", FileMode.Open, FileAccess.Read);
                SoapFormatter sf = new SoapFormatter();
                ep = (Employee)sf.Deserialize(fs);
                txtid.Text = ep.Empid.ToString();
                txtname.Text = ep.Empname;
                txtsal.Text = ep.Empsal.ToString();
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
                Employee ee = new Employee();
                ee.Empid = Convert.ToInt32(txtid.Text);
                ee.Empname = txtname.Text;
                ee.Empsal = Convert.ToInt32(txtsal.Text);
                FileStream fs = new FileStream(@"D:\EmployeeJson", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, ee);
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
                Employee ep = new Employee();
                FileStream fs = new FileStream(@"D:\EmployeeJson", FileMode.Open, FileAccess.Read);
                ep = JsonSerializer.Deserialize<Employee>(fs);
                txtid.Text = ep.Empid.ToString();
                txtname.Text = ep.Empname;
                txtsal.Text = ep.Empsal.ToString();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
