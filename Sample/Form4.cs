using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Text.Json;

namespace Sample
{
    public partial class serialization : Form
    {
        public serialization()
        {
            InitializeComponent();
        }

        private void bnrywrt_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = new Product();
                p.ID = Convert.ToInt32(txtid.Text);
                p.Name = txtname.Text;
                p.Prize = Convert.ToInt32(txtprize.Text);
                FileStream fs = new FileStream(@"D:\Product", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, p);
                MessageBox.Show("Add Succesfully");
                fs.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void bnryread_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = new Product();
                FileStream fs = new FileStream(@"D:\Product", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                p=(Product)bf.Deserialize(fs);
                txtid.Text = p.ID.ToString();
                txtname.Text = p.Name;
                txtprize.Text = p.Prize.ToString();
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
                Product p = new Product();
                p.ID = Convert.ToInt32(txtid.Text);
                p.Name = txtname.Text;
                p.Prize = Convert.ToInt32(txtprize.Text);
                FileStream fs = new FileStream(@"D:\Product XML", FileMode.Create, FileAccess.Write);
                XmlSerializer xs = new XmlSerializer(typeof(Product));
                xs.Serialize(fs, p);
                MessageBox.Show("Add XML file Succesfully");

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
                Product p = new Product();
                FileStream fs = new FileStream(@"D:\Product XML", FileMode.Open, FileAccess.Read);
                XmlSerializer xs = new XmlSerializer(typeof(Product));
                p = (Product)xs.Deserialize(fs);
                txtid.Text = p.ID.ToString();
                txtname.Text = p.Name;
                txtprize.Text = p.Prize.ToString();
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
                Product p = new Product();
                p.ID = Convert.ToInt32(txtid.Text);
                p.Name = txtname.Text;
                p.Prize = Convert.ToInt32(txtprize.Text);
                FileStream fs = new FileStream(@"D:\Product SOAP", FileMode.Create, FileAccess.Write);
                SoapFormatter sf = new SoapFormatter();
                sf.Serialize(fs, p);
                MessageBox.Show("Add SOAP file Succesfully");

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
                Product p = new Product();
                FileStream fs = new FileStream(@"D:\Product SOAP", FileMode.Open, FileAccess.Read);
                SoapFormatter sf = new SoapFormatter();
                p = (Product)sf.Deserialize(fs);
                txtid.Text = p.ID.ToString();
                txtname.Text = p.Name;
                txtprize.Text = p.Prize.ToString();
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
                Product p = new Product();
                p.ID = Convert.ToInt32(txtid.Text);
                p.Name = txtname.Text;
                p.Prize = Convert.ToInt32(txtprize.Text);
                FileStream fs = new FileStream(@"D:\Product JSON", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, p);
                
                MessageBox.Show("Add JSON file Succesfully");
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
                Product p = new Product();
                FileStream fs = new FileStream(@"D:\Product JSON", FileMode.Open, FileAccess.Read);
                p=JsonSerializer.Deserialize<Product>(fs);
                txtid.Text = p.ID.ToString();
                txtname.Text = p.Name;
                txtprize.Text = p.Prize.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
}
