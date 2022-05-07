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
    public partial class Book : Form
    {
        public Book()
        {
            InitializeComponent();
        }
        FileStream fs;
        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {

                Book1 bb = new Book1();
                bb.Id = Convert.ToInt32(txtId.Text);
                bb.Name = txtName.Text;
                bb.AuthorName = txtAuthorName.Text;
                bb.Price = Convert.ToInt32(txtPrice.Text);
                fs = new FileStream(@"D:\TestFolder1\Book1", FileMode.Create, FileAccess.Write);
                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(fs, bb);
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

                Book1 bb = new Book1();
                fs = new FileStream(@"D:\TestFolder1\Book1", FileMode.Open, FileAccess.Read);
                BinaryFormatter binary = new BinaryFormatter();
                bb = (Book1)binary.Deserialize(fs);
                txtId.Text = bb.Id.ToString();
                txtName.Text = bb.Name;
                txtPrice.Text = bb.Price.ToString();
                txtAuthorName.Text = bb.AuthorName;

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
                Book1 bb = new Book1();
                bb.Id = Convert.ToInt32(txtId.Text);
                bb.Name = txtName.Text;
                bb.Price = Convert.ToInt32(txtPrice.Text);
                bb.AuthorName = txtAuthorName.Text;

                fs = new FileStream(@"D:\TestFolder1\Book1Xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xml = new XmlSerializer(typeof(Book1));
                xml.Serialize(fs, bb);
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

                Book1 bb = new Book1();
                fs = new FileStream(@"D:\TestFolder1\Book1Xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xml = new XmlSerializer(typeof(Book1));
                bb = (Book1)xml.Deserialize(fs);
                txtId.Text = bb.Id.ToString();
                txtName.Text = bb.Name;
                txtPrice.Text = bb.Price.ToString();
                txtAuthorName.Text = bb.AuthorName;
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
                Book1 bb = new Book1();
                bb.Id = Convert.ToInt32(txtId.Text);
                bb.Name = txtName.Text;
                bb.Price = Convert.ToInt32(txtPrice.Text);
                bb.AuthorName = txtAuthorName.Text;

                fs = new FileStream(@"D:\TestFolder1\Book1Soap", FileMode.Create, FileAccess.Write);
                SoapFormatter soap = new SoapFormatter();
                soap.Serialize(fs, bb);
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

        private void btnSoapRead_Click(object sender, EventArgs e)
        {
            try
            {

                Book1 bb = new Book1();
                fs = new FileStream(@"D:\TestFolder1\Book1Soap", FileMode.Open, FileAccess.Read);
                SoapFormatter soap = new SoapFormatter();
                bb = (Book1)soap.Deserialize(fs);
                txtId.Text = bb.Id.ToString();
                txtName.Text = bb.Name;
                txtPrice.Text = bb.Price.ToString();
                txtAuthorName.Text = bb.AuthorName;
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
                Book1 bb = new Book1();
                bb.Id = Convert.ToInt32(txtId.Text);
                bb.Name = txtName.Text;
                bb.Price = Convert.ToInt32(txtPrice.Text);
                bb.AuthorName = txtAuthorName.Text;

                fs = new FileStream(@"D:\TestFolder1\Book1Json", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, bb);

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
                Book1 bb = new Book1();
                fs = new FileStream(@"D:\TestFolder1\Book1Json", FileMode.Open, FileAccess.Read);
                bb = JsonSerializer.Deserialize<Book1>(fs);
                txtId.Text = bb.Id.ToString();
                txtName.Text = bb.Name;
                txtPrice.Text = bb.Price.ToString();
                txtAuthorName.Text = bb.AuthorName;

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
