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

namespace WindowsFormsApp1
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }
        FileStream fs;
        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {

                Product1 prod = new Product1();
                prod.Id = Convert.ToInt32(txtId.Text);
                prod.Name = txtName.Text;       
                prod.Price = Convert.ToInt32(txtPrice.Text);
                prod.Category = txtCategory.Text;

                fs = new FileStream(@"D:\TestFolder1\Product1", FileMode.Create, FileAccess.Write);
                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(fs, prod);
                MessageBox.Show("Done");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();

            }
        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {

                Product1 prod = new Product1();
                fs = new FileStream(@"D:\TestFolder1\Product1", FileMode.Open, FileAccess.Read);
                BinaryFormatter binary = new BinaryFormatter();
                prod = (Product1)binary.Deserialize(fs);
                txtId.Text = prod.Id.ToString();
                txtName.Text = prod.Name;
                txtPrice.Text = prod.Price.ToString();
                txtCategory.Text = prod.Category;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnXmlWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Product1 prod = new Product1();
                prod.Id = Convert.ToInt32(txtId.Text);
                prod.Name = txtName.Text;
                prod.Price = Convert.ToInt32(txtPrice.Text);
                prod.Category = txtCategory.Text;

                fs = new FileStream(@"D:\TestFolder1\Product1Xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xml = new XmlSerializer(typeof(Product1));
                xml.Serialize(fs, prod);
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnXmlRead_Click(object sender, EventArgs e)
        {
            try
            {

                Product1 prod = new Product1();
                fs = new FileStream(@"D:\TestFolder1\Product1Xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xml = new XmlSerializer(typeof(Product1));
                prod = (Product1)xml.Deserialize(fs);
                txtId.Text = prod.Id.ToString();
                txtName.Text = prod.Name;
                txtPrice.Text = prod.Price.ToString();
                txtCategory.Text = prod.Category;
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnSoapWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Product1 prod = new Product1();
                prod.Id = Convert.ToInt32(txtId.Text);
                prod.Name = txtName.Text;
                prod.Price = Convert.ToInt32(txtPrice.Text);
                prod.Category = txtCategory.Text;

                fs = new FileStream(@"D:\TestFolder1\Product1Soap", FileMode.Create, FileAccess.Write);
                SoapFormatter soap = new SoapFormatter();
                soap.Serialize(fs, prod);
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnSoapread_Click(object sender, EventArgs e)
        {
            try
            {

                Product1 prod = new Product1();
                fs = new FileStream(@"D:\TestFolder1\Product1Soap", FileMode.Open, FileAccess.Read);
                SoapFormatter soap = new SoapFormatter();
                prod = (Product1)soap.Deserialize(fs);
                txtId.Text = prod.Id.ToString();
                txtName.Text = prod.Name;
                txtPrice.Text = prod.Price.ToString();
                txtCategory.Text = prod.Category;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();

            }
        }

        private void btnJsonWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Product1 prod = new Product1();
                prod.Id = Convert.ToInt32(txtId.Text);
                prod.Name = txtName.Text;
                prod.Price = Convert.ToInt32(txtPrice.Text);
                prod.Category = txtCategory.Text;

                fs = new FileStream(@"D:\TestFolder1\Product1Json", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, prod);

                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnJsonRead_Click(object sender, EventArgs e)
        {
            try
            {
                Product1 prod = new Product1();
                fs = new FileStream(@"D:\TestFolder1\Product1Json", FileMode.Open, FileAccess.Read);
                prod = JsonSerializer.Deserialize<Product1>(fs);
                txtId.Text = prod.Id.ToString();
                txtName.Text = prod.Name;
                txtPrice.Text = prod.Price.ToString();
                txtCategory.Text = prod.Category;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();

            }
        }
    }
}
