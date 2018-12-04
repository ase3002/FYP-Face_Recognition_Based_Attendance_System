namespace MultiFaceRec
{
    partial class FrmLBPH_Experiments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnBenchMarker = new System.Windows.Forms.Button();
            this.btnLBPH = new System.Windows.Forms.Button();
            this.cmbSelectDataSet = new System.Windows.Forms.ComboBox();
            this.btnTrainTestGenerator = new System.Windows.Forms.Button();
            this.cmbLBPHConfidenceLevel = new System.Windows.Forms.ComboBox();
            this.lblconfidence_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlRunLBPH = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDataSetGenerator = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlTrainingSetGenerator = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_No_Training_and_Testing_Images = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbBenchMarkerDataSet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlKnnAlgorithm = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbKnnDataSet = new System.Windows.Forms.ComboBox();
            this.btnKnnAlgorithm = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbKnnConfidenceLevel = new System.Windows.Forms.ComboBox();
            this.pnlRunLBPH.SuspendLayout();
            this.pnlTrainingSetGenerator.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlKnnAlgorithm.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(772, 536);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(282, 72);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Exit";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnBenchMarker
            // 
            this.btnBenchMarker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBenchMarker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBenchMarker.Location = new System.Drawing.Point(149, 97);
            this.btnBenchMarker.Name = "btnBenchMarker";
            this.btnBenchMarker.Size = new System.Drawing.Size(279, 72);
            this.btnBenchMarker.TabIndex = 7;
            this.btnBenchMarker.Text = "Bench Marker";
            this.btnBenchMarker.UseVisualStyleBackColor = false;
            this.btnBenchMarker.Click += new System.EventHandler(this.btnBenchMarker_Click);
            // 
            // btnLBPH
            // 
            this.btnLBPH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLBPH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLBPH.Location = new System.Drawing.Point(149, 179);
            this.btnLBPH.Name = "btnLBPH";
            this.btnLBPH.Size = new System.Drawing.Size(282, 60);
            this.btnLBPH.TabIndex = 8;
            this.btnLBPH.Text = "Run LBPH Algorithm";
            this.btnLBPH.UseVisualStyleBackColor = false;
            this.btnLBPH.Click += new System.EventHandler(this.btnLBPH_Click);
            // 
            // cmbSelectDataSet
            // 
            this.cmbSelectDataSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectDataSet.FormattingEnabled = true;
            this.cmbSelectDataSet.Items.AddRange(new object[] {
            "Data Set 1",
            "Data Set 2",
            "Data Set 3",
            "Data Set 4",
            "Data Set 5",
            "Data Set 6"});
            this.cmbSelectDataSet.Location = new System.Drawing.Point(149, 59);
            this.cmbSelectDataSet.Name = "cmbSelectDataSet";
            this.cmbSelectDataSet.Size = new System.Drawing.Size(330, 37);
            this.cmbSelectDataSet.TabIndex = 9;
            this.cmbSelectDataSet.Text = "Select Data Set";
            // 
            // btnTrainTestGenerator
            // 
            this.btnTrainTestGenerator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTrainTestGenerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrainTestGenerator.Location = new System.Drawing.Point(150, 166);
            this.btnTrainTestGenerator.Name = "btnTrainTestGenerator";
            this.btnTrainTestGenerator.Size = new System.Drawing.Size(290, 64);
            this.btnTrainTestGenerator.TabIndex = 10;
            this.btnTrainTestGenerator.Text = "Generate Training And Testing Sets";
            this.btnTrainTestGenerator.UseVisualStyleBackColor = false;
            this.btnTrainTestGenerator.Click += new System.EventHandler(this.btnTrainTestGenerator_Click);
            // 
            // cmbLBPHConfidenceLevel
            // 
            this.cmbLBPHConfidenceLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLBPHConfidenceLevel.FormattingEnabled = true;
            this.cmbLBPHConfidenceLevel.Items.AddRange(new object[] {
            "70%",
            "95%",
            "99%",
            "99.9%"});
            this.cmbLBPHConfidenceLevel.Location = new System.Drawing.Point(149, 119);
            this.cmbLBPHConfidenceLevel.Name = "cmbLBPHConfidenceLevel";
            this.cmbLBPHConfidenceLevel.Size = new System.Drawing.Size(330, 37);
            this.cmbLBPHConfidenceLevel.TabIndex = 12;
            this.cmbLBPHConfidenceLevel.Text = "Select Confidence Value";
            // 
            // lblconfidence_label
            // 
            this.lblconfidence_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconfidence_label.Location = new System.Drawing.Point(23, 122);
            this.lblconfidence_label.Name = "lblconfidence_label";
            this.lblconfidence_label.Size = new System.Drawing.Size(101, 27);
            this.lblconfidence_label.TabIndex = 13;
            this.lblconfidence_label.Text = "Confidence:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Data Set:";
            // 
            // pnlRunLBPH
            // 
            this.pnlRunLBPH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRunLBPH.Controls.Add(this.label2);
            this.pnlRunLBPH.Controls.Add(this.label1);
            this.pnlRunLBPH.Controls.Add(this.lblconfidence_label);
            this.pnlRunLBPH.Controls.Add(this.cmbLBPHConfidenceLevel);
            this.pnlRunLBPH.Controls.Add(this.cmbSelectDataSet);
            this.pnlRunLBPH.Controls.Add(this.btnLBPH);
            this.pnlRunLBPH.Location = new System.Drawing.Point(23, 20);
            this.pnlRunLBPH.Name = "pnlRunLBPH";
            this.pnlRunLBPH.Size = new System.Drawing.Size(499, 262);
            this.pnlRunLBPH.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(5, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "LBPH Test";
            // 
            // cmbDataSetGenerator
            // 
            this.cmbDataSetGenerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDataSetGenerator.FormattingEnabled = true;
            this.cmbDataSetGenerator.Items.AddRange(new object[] {
            "Data Set 1",
            "Data Set 2",
            "Data Set 3",
            "Data Set 4",
            "Data Set 6"});
            this.cmbDataSetGenerator.Location = new System.Drawing.Point(150, 51);
            this.cmbDataSetGenerator.Name = "cmbDataSetGenerator";
            this.cmbDataSetGenerator.Size = new System.Drawing.Size(369, 33);
            this.cmbDataSetGenerator.TabIndex = 16;
            this.cmbDataSetGenerator.Text = "Choose Data Set";
            this.cmbDataSetGenerator.SelectedIndexChanged += new System.EventHandler(this.cmbDataSetGenerator_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 31);
            this.label3.TabIndex = 17;
            this.label3.Text = "Data Set:";
            // 
            // pnlTrainingSetGenerator
            // 
            this.pnlTrainingSetGenerator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTrainingSetGenerator.Controls.Add(this.label5);
            this.pnlTrainingSetGenerator.Controls.Add(this.cmb_No_Training_and_Testing_Images);
            this.pnlTrainingSetGenerator.Controls.Add(this.label4);
            this.pnlTrainingSetGenerator.Controls.Add(this.label3);
            this.pnlTrainingSetGenerator.Controls.Add(this.cmbDataSetGenerator);
            this.pnlTrainingSetGenerator.Controls.Add(this.btnTrainTestGenerator);
            this.pnlTrainingSetGenerator.Location = new System.Drawing.Point(600, 246);
            this.pnlTrainingSetGenerator.Name = "pnlTrainingSetGenerator";
            this.pnlTrainingSetGenerator.Size = new System.Drawing.Size(597, 275);
            this.pnlTrainingSetGenerator.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 73);
            this.label5.TabIndex = 20;
            this.label5.Text = "No Training and Testing Images:";
            // 
            // cmb_No_Training_and_Testing_Images
            // 
            this.cmb_No_Training_and_Testing_Images.Enabled = false;
            this.cmb_No_Training_and_Testing_Images.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_No_Training_and_Testing_Images.FormattingEnabled = true;
            this.cmb_No_Training_and_Testing_Images.Location = new System.Drawing.Point(150, 116);
            this.cmb_No_Training_and_Testing_Images.Name = "cmb_No_Training_and_Testing_Images";
            this.cmb_No_Training_and_Testing_Images.Size = new System.Drawing.Size(440, 33);
            this.cmb_No_Training_and_Testing_Images.TabIndex = 19;
            this.cmb_No_Training_and_Testing_Images.Text = "Choose No of Training and Testing Images";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Training and Testing Set Generator";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmbBenchMarkerDataSet);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnBenchMarker);
            this.panel1.Location = new System.Drawing.Point(600, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 192);
            this.panel1.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Data Set:";
            // 
            // cmbBenchMarkerDataSet
            // 
            this.cmbBenchMarkerDataSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBenchMarkerDataSet.FormattingEnabled = true;
            this.cmbBenchMarkerDataSet.Items.AddRange(new object[] {
            "Data Set 1",
            "Data Set 2",
            "Data Set 3",
            "Data Set 4",
            "Data Set 5",
            "Data Set 6"});
            this.cmbBenchMarkerDataSet.Location = new System.Drawing.Point(146, 43);
            this.cmbBenchMarkerDataSet.Name = "cmbBenchMarkerDataSet";
            this.cmbBenchMarkerDataSet.Size = new System.Drawing.Size(330, 37);
            this.cmbBenchMarkerDataSet.TabIndex = 9;
            this.cmbBenchMarkerDataSet.Text = "Select Data Set";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 34);
            this.label6.TabIndex = 8;
            this.label6.Text = "Bench Marker";
            // 
            // pnlKnnAlgorithm
            // 
            this.pnlKnnAlgorithm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKnnAlgorithm.Controls.Add(this.cmbKnnConfidenceLevel);
            this.pnlKnnAlgorithm.Controls.Add(this.label10);
            this.pnlKnnAlgorithm.Controls.Add(this.btnKnnAlgorithm);
            this.pnlKnnAlgorithm.Controls.Add(this.cmbKnnDataSet);
            this.pnlKnnAlgorithm.Controls.Add(this.label9);
            this.pnlKnnAlgorithm.Controls.Add(this.label8);
            this.pnlKnnAlgorithm.Location = new System.Drawing.Point(23, 300);
            this.pnlKnnAlgorithm.Name = "pnlKnnAlgorithm";
            this.pnlKnnAlgorithm.Size = new System.Drawing.Size(499, 295);
            this.pnlKnnAlgorithm.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Knn Algorithm Test";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Data Set:";
            // 
            // cmbKnnDataSet
            // 
            this.cmbKnnDataSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKnnDataSet.FormattingEnabled = true;
            this.cmbKnnDataSet.Items.AddRange(new object[] {
            "Data Set 1",
            "Data Set 2",
            "Data Set 3",
            "Data Set 4",
            "Data Set 5",
            "Data Set 6"});
            this.cmbKnnDataSet.Location = new System.Drawing.Point(149, 52);
            this.cmbKnnDataSet.Name = "cmbKnnDataSet";
            this.cmbKnnDataSet.Size = new System.Drawing.Size(330, 37);
            this.cmbKnnDataSet.TabIndex = 2;
            this.cmbKnnDataSet.Text = "Select Data Set";
            // 
            // btnKnnAlgorithm
            // 
            this.btnKnnAlgorithm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnKnnAlgorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKnnAlgorithm.Location = new System.Drawing.Point(149, 186);
            this.btnKnnAlgorithm.Name = "btnKnnAlgorithm";
            this.btnKnnAlgorithm.Size = new System.Drawing.Size(282, 63);
            this.btnKnnAlgorithm.TabIndex = 3;
            this.btnKnnAlgorithm.Text = "Run Knn Algorithm";
            this.btnKnnAlgorithm.UseVisualStyleBackColor = false;
            this.btnKnnAlgorithm.Click += new System.EventHandler(this.btnKnnAlgorithm_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Confidence:";
            // 
            // cmbKnnConfidenceLevel
            // 
            this.cmbKnnConfidenceLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKnnConfidenceLevel.FormattingEnabled = true;
            this.cmbKnnConfidenceLevel.Items.AddRange(new object[] {
            "70%",
            "95%",
            "99%",
            "99.9%"});
            this.cmbKnnConfidenceLevel.Location = new System.Drawing.Point(149, 112);
            this.cmbKnnConfidenceLevel.Name = "cmbKnnConfidenceLevel";
            this.cmbKnnConfidenceLevel.Size = new System.Drawing.Size(330, 37);
            this.cmbKnnConfidenceLevel.TabIndex = 5;
            this.cmbKnnConfidenceLevel.Text = "Select Confidence Value";
            // 
            // FrmLBPH_Experiments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1243, 620);
            this.Controls.Add(this.pnlKnnAlgorithm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTrainingSetGenerator);
            this.Controls.Add(this.pnlRunLBPH);
            this.Controls.Add(this.btnLogOut);
            this.Name = "FrmLBPH_Experiments";
            this.Text = "Face Recognition LBPH Experiments";
            this.Load += new System.EventHandler(this.FrmLBPH_Experiments_Load);
            this.pnlRunLBPH.ResumeLayout(false);
            this.pnlRunLBPH.PerformLayout();
            this.pnlTrainingSetGenerator.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlKnnAlgorithm.ResumeLayout(false);
            this.pnlKnnAlgorithm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnBenchMarker;
        private System.Windows.Forms.Button btnLBPH;
        private System.Windows.Forms.ComboBox cmbSelectDataSet;
        private System.Windows.Forms.Button btnTrainTestGenerator;
        private System.Windows.Forms.ComboBox cmbLBPHConfidenceLevel;
        private System.Windows.Forms.Label lblconfidence_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlRunLBPH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDataSetGenerator;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlTrainingSetGenerator;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_No_Training_and_Testing_Images;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbBenchMarkerDataSet;
        private System.Windows.Forms.Panel pnlKnnAlgorithm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbKnnDataSet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnKnnAlgorithm;
        private System.Windows.Forms.ComboBox cmbKnnConfidenceLevel;
        private System.Windows.Forms.Label label10;
    }
}