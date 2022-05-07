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
    public partial class EmployeeLoginForm : Form
    {
        public EmployeeLoginForm()
        {
            InitializeComponent();
        }
        FileStream fs;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int EmpId = Convert.ToInt32(txtEmpId.Text);
                string EmpName = txtEmpName.Text;
                String Designation = txtDesignation.Text;
                int Salary  = Convert.ToInt32(txtSalary.Text);
                string Department = txtDepartment.Text;
                fs = new FileStream(@"D:\VisualStudio2019\WindowsFormsApp1\FirstFile.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(EmpId);
                bw.Write(EmpName);
                bw.Write(Designation);
                bw.Write(Salary);
                bw.Write(Department);
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\VisualStudio2019\WindowsFormsApp1\FirstFile.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtEmpId.Text = br.ReadInt32().ToString();
                txtEmpName.Text = br.ReadString();
                txtDesignation.Text = br.ReadString();
                txtSalary.Text = br.ReadInt32().ToString();
                txtDepartment.Text = br.ReadString();
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
    


