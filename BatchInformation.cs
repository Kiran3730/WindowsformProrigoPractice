using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class BatchInformation : Form
    {
        public BatchInformation()
        {
            InitializeComponent();
        }
        FileStream fs;
        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {

                BatchInformation1 batch = new BatchInformation1();
                batch.BatchId = Convert.ToInt32(txtBatchId.Text);
                batch.BatchName = txtBatchName.Text;
                batch.StartDate = Convert.ToInt32(txtStartDate.Text);
                batch.EndDate = Convert.ToInt32(txtEndDate.Text);
                batch.Location = txtLocation.Text;
                batch.TrainerName = txtTrainerName.Text;

                fs = new FileStream(@"D:\TestFolder1\BatchInformation1", FileMode.Create, FileAccess.Write);
                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(fs, batch);
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

                BatchInformation1 batch = new BatchInformation1();
                fs = new FileStream(@"D:\TestFolder1\BatchInformation1", FileMode.Open, FileAccess.Read);
                BinaryFormatter binary = new BinaryFormatter();
                batch = (BatchInformation1)binary.Deserialize(fs);
                txtBatchId.Text = batch.BatchId.ToString();
                txtBatchName.Text = batch.BatchName;
                txtStartDate.Text = batch.StartDate.ToString();
                txtEndDate.Text = batch.EndDate.ToString();
                txtLocation.Text = batch.Location;
                txtTrainerName.Text = batch.TrainerName;

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
