using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
   
    public partial class StudentForm5 : Form
    {
        public StudentForm5()
        {
            InitializeComponent();
        }
        FileStream fs;
       
        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            try
            {
                int RollNo = Convert.ToInt32(txtRollNo.Text);
                string Name = txtName.Text;
                int Percentage = Convert.ToInt32(txtPercentage.Text);
                string Stream = txtStream.Text;
                string City = txtCity.Text;
                fs = new FileStream(@"D:\VisualStudio2019\WindowsFormsApp1\FirstFile.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(RollNo);
                bw.Write(Name);
                bw.Write(Percentage);
                bw.Write(Stream);
                bw.Write(City);
                bw.Close();

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

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\VisualStudio2019\WindowsFormsApp1\FirstFile.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtRollNo.Text = br.ReadInt32().ToString();
                txtName.Text = br.ReadString();
                txtPercentage.Text = br.ReadInt32().ToString();
                txtStream.Text = br.ReadString();
                txtCity.Text = br.ReadString();
                br.Close(); 

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
    }
}
    
