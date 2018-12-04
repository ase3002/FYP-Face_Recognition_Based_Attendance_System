using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Threading;
using System.Data.OleDb;
using System.Drawing.Imaging;
using System.Speech;
using System.Speech.Synthesis;
//====================Adding the OpenCV libraries================================
//Go to OpenCV file
//Add Emgu.CV.dll as a Reference
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.Media;
using System.Drawing.Drawing2D;
using IronPython.Runtime;
using IronPython.Hosting;
using System.Linq;

namespace MultiFaceRec
{
    public partial class FrmLBPH_Experiments : Form
    {
        string path_of_debug_folder = @"C:\Users\Tokyo\OneDrive\Desktop\facedataset-master";
        public FrmLBPH_Experiments()
        {
            InitializeComponent();
        }
        public List<FileInfo> GetFiles(string path, params string[] extensions)
        {
            List<FileInfo> list = new List<FileInfo>();
            foreach (string ext in extensions)
                list.AddRange(new DirectoryInfo(path).GetFiles("*" + ext).Where(p =>
                      p.Extension.Equals(ext, StringComparison.CurrentCultureIgnoreCase))
                      .ToArray());
            return list;
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            string error_messages_folder = Application.StartupPath + "/error images/";
            string incorrect_images_folder = Application.StartupPath + "/Incorrect Answer/";
            try
            {
                if (Directory.Exists(error_messages_folder) == true)
                {
                    var err_messages_dir = new DirectoryInfo(Application.StartupPath + "\\error images\\");
                    err_messages_dir.Delete(true);
                }
            }
            catch (IOException ex1)
            {
                MessageBox.Show(ex1.Message);
            }
            try
            {
                if (Directory.Exists(incorrect_images_folder) == true)
                {
                    var incorrect_images_dir = new DirectoryInfo(Application.StartupPath + "\\Incorrect Answer\\");
                    incorrect_images_dir.Delete(true);
                }
            }
            catch (IOException ex2)
            {
                MessageBox.Show(ex2.Message);
            }
            DirectoryInfo di = new DirectoryInfo(Application.StartupPath);
            List<FileInfo> files = GetFiles(Application.StartupPath, ".yml", ".pickle");
            foreach (FileInfo file in files)
                try
                {
                    file.Attributes = FileAttributes.Normal;
                    File.Delete(file.FullName);
                }
                catch { }
            DirectoryInfo di2 = new DirectoryInfo(Application.StartupPath);
            FileInfo[] files2 = di2.GetFiles("*.clf")
                                 .Where(p => p.Extension == ".clf").ToArray();
            foreach (FileInfo the_file in files2)
                try
                {
                    the_file.Attributes = FileAttributes.Normal;
                    File.Delete(the_file.FullName);
                }
                catch { }
            FrmAdministratorMainPage frmAMP = new FrmAdministratorMainPage();
            frmAMP.Show();
            this.Hide();
        }

        private void btnBenchMarker_Click(object sender, EventArgs e)
        {
            if(cmbBenchMarkerDataSet.Text == "Select Data Set")
            {
                MessageBox.Show("Please select a Data Set for testing!");
            }
            else if(cmbBenchMarkerDataSet.Text == "Data Set 1")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python benchmarker_DS1.py";
                cmd.Start();
            }
            else if (cmbBenchMarkerDataSet.Text == "Data Set 2")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python benchmarker_DS2.py";
                cmd.Start();
            }
            else if (cmbBenchMarkerDataSet.Text == "Data Set 3")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python benchmarker_DS3.py";
                cmd.Start();
            }
            else if (cmbBenchMarkerDataSet.Text == "Data Set 4")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python benchmarker_DS4.py";
                cmd.Start();
            }
            else if (cmbBenchMarkerDataSet.Text == "Data Set 5")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python benchmarker_DS5.py";
                cmd.Start();
            }
            else if (cmbBenchMarkerDataSet.Text == "Data Set 6")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python benchmarker_DS6.py";
                cmd.Start();
            }
            else
            {

            }
        }
       
        private void btnLBPH_Click(object sender, EventArgs e)
        {
            if (cmbSelectDataSet.Text == "Choose Data Set")
            {
                MessageBox.Show("Please select a data set to run the LBPH algorithm");
            }
            else if(cmbLBPHConfidenceLevel.Text == "Select Confidence Value")
            {
                MessageBox.Show("Please select a confidence value to run the LBPH algorithm");
            }
            else if (cmbSelectDataSet.Text == "Data Set 1" && cmbLBPHConfidenceLevel.Text =="70%")
            {
                Process cmd = new Process();
                //  cmd.StartInfo.UseShellExecute = false;
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python LBPH_Algo_DataSet_1.py";
                // cmd.StartInfo.CreateNoWindow = false;          
                // cmd.StartInfo.RedirectStandardInput = true;
                cmd.Start();
            }
            else if (cmbSelectDataSet.Text == "Data Set 1" && cmbLBPHConfidenceLevel.Text == "95%")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python LBPH_Algo_DataSet_1_95-percent_Confidence.py";
                cmd.Start();
            }
            else if (cmbSelectDataSet.Text == "Data Set 1" && cmbLBPHConfidenceLevel.Text == "99%")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python LBPH_Algo_DataSet_1_99-percent_Confidence.py";
                cmd.Start();
            }
            else if (cmbSelectDataSet.Text == "Data Set 1" && cmbLBPHConfidenceLevel.Text == "99.9%")
            {
                Process cmd = new Process();
                //  cmd.StartInfo.UseShellExecute = false;
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python LBPH_Algo_DataSet_1_99.9-percent_Confidence.py";
                // cmd.StartInfo.CreateNoWindow = false;          
                // cmd.StartInfo.RedirectStandardInput = true;
                cmd.Start();
            }
            else if (cmbSelectDataSet.Text == "Data Set 2" && cmbLBPHConfidenceLevel.Text == "70%")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python LBPH_Algo_DataSet_2.py";
                cmd.Start();
            }
            else if (cmbSelectDataSet.Text == "Data Set 2" && cmbLBPHConfidenceLevel.Text == "95%")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python LBPH_Algo_DataSet_2_95-percent_Confidence.py";
                cmd.Start();
            }       
            else if (cmbSelectDataSet.Text == "Data Set 2" && cmbLBPHConfidenceLevel.Text == "99%")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python LBPH_Algo_DataSet_2_99-percent_Confidence.py";
                cmd.Start();
            }
            else if (cmbSelectDataSet.Text == "Data Set 2" && cmbLBPHConfidenceLevel.Text == "99.9%")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python LBPH_Algo_DataSet_2_99.9-percent_Confidence.py";
                cmd.Start();
            }
            else if (cmbSelectDataSet.Text =="Data Set 3" && cmbLBPHConfidenceLevel.Text == "70%")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python LBPH_Algo_DataSet_3.py";
                cmd.Start();
            }
            else if (cmbSelectDataSet.Text == "Data Set 3" && cmbLBPHConfidenceLevel.Text == "95%")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python LBPH_Algo_DataSet_3_95-percent_Confidence.py";
                cmd.Start();
            }
            else if (cmbSelectDataSet.Text == "Data Set 3" && cmbLBPHConfidenceLevel.Text == "99%")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python LBPH_Algo_DataSet_3_99-percent_Confidence.py";
                cmd.Start();
            }
            else if (cmbSelectDataSet.Text == "Data Set 3" && cmbLBPHConfidenceLevel.Text == "99.9%")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python LBPH_Algo_DataSet_3_99.9-percent_Confidence.py";
                cmd.Start();
            }
            else if (cmbSelectDataSet.Text == "Data Set 4" && cmbLBPHConfidenceLevel.Text == "70%")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python LBPH_Algo_DataSet_4.py";
                cmd.Start();
            }
            else if (cmbSelectDataSet.Text == "Data Set 4" && cmbLBPHConfidenceLevel.Text == "95%")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python LBPH_Algo_DataSet_4_95-percent_Confidence.py";
                cmd.Start();
            }
            else if (cmbSelectDataSet.Text == "Data Set 4" && cmbLBPHConfidenceLevel.Text == "99%")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python LBPH_Algo_DataSet_4_99-percent_Confidence.py";
                cmd.Start();
            }
            else if (cmbSelectDataSet.Text == "Data Set 4" && cmbLBPHConfidenceLevel.Text == "99.9%")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python LBPH_Algo_DataSet_4_99.9-percent_Confidence.py";
                cmd.Start();
            }
            else if (cmbSelectDataSet.Text == "Data Set 5" && cmbLBPHConfidenceLevel.Text == "70%")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python LBPH_Algo_DataSet_5.py";
                cmd.Start();
            }
             else if (cmbSelectDataSet.Text == "Data Set 5" && cmbLBPHConfidenceLevel.Text == "95%")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python LBPH_Algo_DataSet_5_95-percent_Confidence.py";
                cmd.Start();
            }
            else if (cmbSelectDataSet.Text == "Data Set 5" && cmbLBPHConfidenceLevel.Text == "99%")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python LBPH_Algo_DataSet_5_99-percent_Confidence.py";
                cmd.Start();
            }
            else if (cmbSelectDataSet.Text == "Data Set 5" && cmbLBPHConfidenceLevel.Text == "99.9%")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python LBPH_Algo_DataSet_5_99.9-percent_Confidence.py";
                cmd.Start();
            }
            else if (cmbSelectDataSet.Text == "Data Set 6" && cmbLBPHConfidenceLevel.Text == "70%")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python LBPH_Algo_DataSet_6.py";
                cmd.Start();
            }
            else if (cmbSelectDataSet.Text == "Data Set 6" && cmbLBPHConfidenceLevel.Text == "95%")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python LBPH_Algo_DataSet_6_95-percent_Confidence.py";
                cmd.Start();
            }
            else if (cmbSelectDataSet.Text == "Data Set 6" && cmbLBPHConfidenceLevel.Text == "99%")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python LBPH_Algo_DataSet_6_99-percent_Confidence.py";
                cmd.Start();
            }
            else if (cmbSelectDataSet.Text == "Data Set 6" && cmbLBPHConfidenceLevel.Text == "99.9%")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python LBPH_Algo_DataSet_6_99.9-percent_Confidence.py";
                cmd.Start();
            }
            else
            {

            }
        }

        private void btnTrainTestGenerator_Click(object sender, EventArgs e)
        {
            if(cmbDataSetGenerator.Text == "Choose Data Set")
            {
                MessageBox.Show("Select a Data Set!");
            }
            else if(cmb_No_Training_and_Testing_Images.Text == "Choose No of Training and Testing Images")
            {
                MessageBox.Show("Select the number of training and testing images!");
            }
            else if(cmbDataSetGenerator.Text == "Data Set 1" && cmb_No_Training_and_Testing_Images.Text =="40 Training Images, 20 Testing Images")
            {
                btnTrainTestGenerator.Enabled = true;
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python TrainTest_Generator_DS1_40Train_20Test.py";
                cmd.Start();
            }
            else if (cmbDataSetGenerator.Text == "Data Set 1" && cmb_No_Training_and_Testing_Images.Text =="50 Training Images, 10 Testing Images")
            {
                btnTrainTestGenerator.Enabled = true;
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python TrainTest_Generator_DS1_50Train_10Test.py";
                cmd.Start();
            }
            else if(cmbDataSetGenerator.Text == "Data Set 2" && cmb_No_Training_and_Testing_Images.Text =="40 Training Images, 20 Testing Images")
            {
                btnTrainTestGenerator.Enabled = true;
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python TrainTest_Generator_DS2_40Train_20Test.py";
                cmd.Start();
            }
            else if (cmbDataSetGenerator.Text == "Data Set 2" && cmb_No_Training_and_Testing_Images.Text == "50 Training Images, 10 Testing Images")
            {
                btnTrainTestGenerator.Enabled = true;
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python TrainTest_Generator_DS2_50Train_10Test.py";
                cmd.Start();
            }
            else if(cmbDataSetGenerator.Text == "Data Set 3" && cmb_No_Training_and_Testing_Images.Text == "30 Training Images, 20 Testing Images")
            {
                btnTrainTestGenerator.Enabled = true;
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python TrainTest_Generator_DS3_30Train_20Test.py";
                cmd.Start();
            }
            else if (cmbDataSetGenerator.Text == "Data Set 3" && cmb_No_Training_and_Testing_Images.Text == "40 Training Images, 10 Testing Images")
            {
                btnTrainTestGenerator.Enabled = true;
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python TrainTest_Generator_DS3_40Train_10Test.py";
                cmd.Start();
            }
            else if(cmbDataSetGenerator.Text == "Data Set 4" && cmb_No_Training_and_Testing_Images.Text == "40 Training Images, 20 Testing Images")
            {
                btnTrainTestGenerator.Enabled = true;
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python TrainTest_Generator_DS4_40Train_20Test.py";
                cmd.Start();
            }
            else if (cmbDataSetGenerator.Text == "Data Set 4" && cmb_No_Training_and_Testing_Images.Text == "50 Training Images, 10 Testing Images")
            {
                btnTrainTestGenerator.Enabled = true;
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python TrainTest_Generator_DS4_50Train_10Test.py";
                cmd.Start();
            }
            else if(cmbDataSetGenerator.Text == "Data Set 6" && cmb_No_Training_and_Testing_Images.Text == "4 Training Images, 7 Testing Images")
            {
                btnTrainTestGenerator.Enabled = true;
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python TrainTest_Generator_DS6_4Train_7Test.py";
                cmd.Start();
            }
            else if (cmbDataSetGenerator.Text == "Data Set 6" && cmb_No_Training_and_Testing_Images.Text == "5 Training Images, 6 Testing Images")
            {
                btnTrainTestGenerator.Enabled = true;
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python TrainTest_Generator_DS6_5Train_6Test.py";
                cmd.Start();
            }
            else if (cmbDataSetGenerator.Text == "Data Set 6" && cmb_No_Training_and_Testing_Images.Text == "6 Training Images, 5 Testing Images")
            {
                btnTrainTestGenerator.Enabled = true;
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python TrainTest_Generator_DS6_6Train_5Test.py";
                cmd.Start();
            }
            else if (cmbDataSetGenerator.Text == "Data Set 6" && cmb_No_Training_and_Testing_Images.Text == "7 Training Images, 4 Testing Images")
            {
                btnTrainTestGenerator.Enabled = true;
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python TrainTest_Generator_DS6_7Train_4Test.py";
                cmd.Start();
            }
            else if (cmbDataSetGenerator.Text == "Data Set 6" && cmb_No_Training_and_Testing_Images.Text == "8 Training Images, 3 Testing Images")
            {
                btnTrainTestGenerator.Enabled = true;
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python TrainTest_Generator_DS6_8Train_3Test.py";
                cmd.Start();
            }
            else if (cmbDataSetGenerator.Text == "Data Set 6" && cmb_No_Training_and_Testing_Images.Text == "9 Training Images, 2 Testing Images")
            {
                btnTrainTestGenerator.Enabled = true;
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python TrainTest_Generator_DS6_9Train_2Test.py";
                cmd.Start();
            }
            else
            {
                btnTrainTestGenerator.Enabled = false;
            }         
        }

        private void cmbDataSetGenerator_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbDataSetGenerator.Text == "Data Set 1")
            {
                cmb_No_Training_and_Testing_Images.Enabled = true;
                btnTrainTestGenerator.Enabled = true;
                cmb_No_Training_and_Testing_Images.Items.Clear();
                cmb_No_Training_and_Testing_Images.Items.Add("40 Training Images, 20 Testing Images");
                cmb_No_Training_and_Testing_Images.Items.Add("50 Training Images, 10 Testing Images");  
            }
            else if(cmbDataSetGenerator.Text == "Data Set 2")
            {
                cmb_No_Training_and_Testing_Images.Enabled = true;
                btnTrainTestGenerator.Enabled = true;
                cmb_No_Training_and_Testing_Images.Items.Clear();
                cmb_No_Training_and_Testing_Images.Items.Add("40 Training Images, 20 Testing Images");
                cmb_No_Training_and_Testing_Images.Items.Add("50 Training Images, 10 Testing Images");
            }
            else if(cmbDataSetGenerator.Text == "Data Set 3")
            {
                cmb_No_Training_and_Testing_Images.Enabled = true;
                btnTrainTestGenerator.Enabled = true;
                cmb_No_Training_and_Testing_Images.Items.Clear();
                cmb_No_Training_and_Testing_Images.Items.Add("30 Training Images, 20 Testing Images");
                cmb_No_Training_and_Testing_Images.Items.Add("40 Training Images, 10 Testing Images");
            }
            else if(cmbDataSetGenerator.Text == "Data Set 4")
            {
                cmb_No_Training_and_Testing_Images.Enabled = true;
                btnTrainTestGenerator.Enabled = true;
                cmb_No_Training_and_Testing_Images.Items.Clear();
                cmb_No_Training_and_Testing_Images.Items.Add("40 Training Images, 20 Testing Images");
                cmb_No_Training_and_Testing_Images.Items.Add("50 Training Images, 10 Testing Images");
            }
            else if(cmbDataSetGenerator.Text == "Data Set 6")
            {
                cmb_No_Training_and_Testing_Images.Enabled = true;
                btnTrainTestGenerator.Enabled = true;
                cmb_No_Training_and_Testing_Images.Items.Clear();
                cmb_No_Training_and_Testing_Images.Items.Add("4 Training Images, 7 Testing Images");
                cmb_No_Training_and_Testing_Images.Items.Add("5 Training Images, 6 Testing Images");
                cmb_No_Training_and_Testing_Images.Items.Add("6 Training Images, 5 Testing Images");
                cmb_No_Training_and_Testing_Images.Items.Add("7 Training Images, 4 Testing Images");
                cmb_No_Training_and_Testing_Images.Items.Add("8 Training Images, 3 Testing Images");
                cmb_No_Training_and_Testing_Images.Items.Add("9 Training Images, 2 Testing Images");
            }
            else
            {
                cmb_No_Training_and_Testing_Images.Enabled = false;
                btnTrainTestGenerator.Enabled = false;
            }
        }

        private void FrmLBPH_Experiments_Load(object sender, EventArgs e)
        {

        }

        private void btnKnnAlgorithm_Click(object sender, EventArgs e)
        {
            if(cmbKnnDataSet.Text =="Data Set 1" && cmbKnnConfidenceLevel.Text =="70%")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python knn_Algo_DataSet_1.py";
                cmd.Start();
            }
            else if (cmbKnnDataSet.Text == "Data Set 1" && cmbKnnConfidenceLevel.Text == "95%")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python knn_Algo_DataSet_1_95-percent_Confidence.py";
                cmd.Start();
            }
            else if (cmbKnnDataSet.Text == "Data Set 1" && cmbKnnConfidenceLevel.Text == "99%")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python knn_Algo_DataSet_1_99-percent_Confidence.py";
                cmd.Start();
            }
            else if (cmbKnnDataSet.Text == "Data Set 1" && cmbKnnConfidenceLevel.Text == "99.9%")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python knn_Algo_DataSet_1_99.9-percent_Confidence.py";
                cmd.Start();
            }
            else if(cmbKnnDataSet.Text=="Data Set 2" && cmbKnnConfidenceLevel.Text =="70%")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python knn_Algo_DataSet_2.py";
                cmd.Start();
            }
            else if (cmbKnnDataSet.Text == "Data Set 2" && cmbKnnConfidenceLevel.Text == "95%")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python knn_Algo_DataSet_2_95-percent_Confidence.py";
                cmd.Start();
            }
            else if (cmbKnnDataSet.Text == "Data Set 2" && cmbKnnConfidenceLevel.Text == "99%")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python knn_Algo_DataSet_2_99-percent_Confidence.py";
                cmd.Start();
            }
            else if (cmbKnnDataSet.Text == "Data Set 2" && cmbKnnConfidenceLevel.Text == "99.9%")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python knn_Algo_DataSet_2_99.9-percent_Confidence.py";
                cmd.Start();
            }
            else if(cmbKnnDataSet.Text=="Data Set 3" && cmbKnnConfidenceLevel.Text =="70%")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python knn_Algo_DataSet_3.py";
                cmd.Start();
            }
            else if (cmbKnnDataSet.Text == "Data Set 3" && cmbKnnConfidenceLevel.Text == "95%")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python knn_Algo_DataSet_3_95-percent_Confidence.py";
                cmd.Start();
            }
            else if (cmbKnnDataSet.Text == "Data Set 3" && cmbKnnConfidenceLevel.Text == "99%")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python knn_Algo_DataSet_3_99-percent_Confidence.py";
                cmd.Start();
            }
            else if (cmbKnnDataSet.Text == "Data Set 3" && cmbKnnConfidenceLevel.Text == "99.9%")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python knn_Algo_DataSet_3_99.9-percent_Confidence.py";
                cmd.Start();
            }
            else if (cmbKnnDataSet.Text == "Data Set 4" && cmbKnnConfidenceLevel.Text=="70%")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python knn_Algo_DataSet_4.py";
                cmd.Start();
            }
            else if (cmbKnnDataSet.Text == "Data Set 4" && cmbKnnConfidenceLevel.Text == "95%")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python knn_Algo_DataSet_4_95-percent_Confidence.py";
                cmd.Start();
            }
            else if (cmbKnnDataSet.Text == "Data Set 4" && cmbKnnConfidenceLevel.Text == "99%")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python knn_Algo_DataSet_4_99-percent_Confidence.py";
                cmd.Start();
            }
            else if (cmbKnnDataSet.Text == "Data Set 4" && cmbKnnConfidenceLevel.Text == "99.9%")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python knn_Algo_DataSet_4_99.9-percent_Confidence.py";
                cmd.Start();
            }
            else if (cmbKnnDataSet.Text == "Data Set 5" && cmbKnnConfidenceLevel.Text=="70%")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python knn_Algo_DataSet_5.py";
                cmd.Start();
            }
            else if (cmbKnnDataSet.Text == "Data Set 5" && cmbKnnConfidenceLevel.Text == "95%")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python knn_Algo_DataSet_5_95-percent_Confidence.py";
                cmd.Start();
            }
            else if (cmbKnnDataSet.Text == "Data Set 5" && cmbKnnConfidenceLevel.Text == "99%")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python knn_Algo_DataSet_5_99-percent_Confidence.py";
                cmd.Start();
            }
            else if (cmbKnnDataSet.Text == "Data Set 5" && cmbKnnConfidenceLevel.Text == "99.9%")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python knn_Algo_DataSet_5_99.9-percent_Confidence.py";
                cmd.Start();
            }
            else if (cmbKnnDataSet.Text == "Data Set 6" && cmbKnnConfidenceLevel.Text=="70%")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python knn_Algo_DataSet_6.py";
                cmd.Start();
            }
            else if (cmbKnnDataSet.Text == "Data Set 6" && cmbKnnConfidenceLevel.Text == "95%")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python knn_Algo_DataSet_6_95-percent_Confidence.py";
                cmd.Start();
            }
            else if (cmbKnnDataSet.Text == "Data Set 6" && cmbKnnConfidenceLevel.Text == "99%")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python knn_Algo_DataSet_6_99-percent_Confidence.py";
                cmd.Start();
            }
            else if (cmbKnnDataSet.Text == "Data Set 6" && cmbKnnConfidenceLevel.Text == "99.9%")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/k Python knn_Algo_DataSet_6_99.9-percent_Confidence.py";
                cmd.Start();
            }
            else
            {

            }
        }
    }
}
