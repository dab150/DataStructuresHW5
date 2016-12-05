﻿namespace DataStructuresHW5
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSlowDataSet = new System.Windows.Forms.ComboBox();
            this.cmbFastDataSet = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStartFast = new System.Windows.Forms.Button();
            this.btnStartSlow = new System.Windows.Forms.Button();
            this.prgInsertion = new System.Windows.Forms.ProgressBar();
            this.prgSelection = new System.Windows.Forms.ProgressBar();
            this.prgBubble = new System.Windows.Forms.ProgressBar();
            this.lblInsertion = new System.Windows.Forms.Label();
            this.lblSelection = new System.Windows.Forms.Label();
            this.lblBubble = new System.Windows.Forms.Label();
            this.lblQuickMiddle = new System.Windows.Forms.Label();
            this.lblQuickFirst = new System.Windows.Forms.Label();
            this.lblMerge = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPointsSlow = new System.Windows.Forms.ComboBox();
            this.cmbPointsFast = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(567, 385);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmbPointsSlow);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lblBubble);
            this.tabPage1.Controls.Add(this.lblSelection);
            this.tabPage1.Controls.Add(this.lblInsertion);
            this.tabPage1.Controls.Add(this.prgBubble);
            this.tabPage1.Controls.Add(this.prgSelection);
            this.tabPage1.Controls.Add(this.prgInsertion);
            this.tabPage1.Controls.Add(this.btnStartSlow);
            this.tabPage1.Controls.Add(this.cmbSlowDataSet);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(559, 359);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "N^2 Searches";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmbPointsFast);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.lblQuickMiddle);
            this.tabPage2.Controls.Add(this.lblQuickFirst);
            this.tabPage2.Controls.Add(this.lblMerge);
            this.tabPage2.Controls.Add(this.progressBar1);
            this.tabPage2.Controls.Add(this.progressBar2);
            this.tabPage2.Controls.Add(this.progressBar3);
            this.tabPage2.Controls.Add(this.btnStartFast);
            this.tabPage2.Controls.Add(this.cmbFastDataSet);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(559, 359);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "N*LOG(N) Searches";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select size of data set:";
            // 
            // cmbSlowDataSet
            // 
            this.cmbSlowDataSet.FormattingEnabled = true;
            this.cmbSlowDataSet.Items.AddRange(new object[] {
            "1000",
            "10000",
            "100000"});
            this.cmbSlowDataSet.Location = new System.Drawing.Point(123, 11);
            this.cmbSlowDataSet.Name = "cmbSlowDataSet";
            this.cmbSlowDataSet.Size = new System.Drawing.Size(121, 21);
            this.cmbSlowDataSet.TabIndex = 1;
            this.cmbSlowDataSet.Text = "1000";
            // 
            // cmbFastDataSet
            // 
            this.cmbFastDataSet.FormattingEnabled = true;
            this.cmbFastDataSet.Items.AddRange(new object[] {
            "10000",
            "100000",
            "1000000"});
            this.cmbFastDataSet.Location = new System.Drawing.Point(123, 10);
            this.cmbFastDataSet.Name = "cmbFastDataSet";
            this.cmbFastDataSet.Size = new System.Drawing.Size(121, 21);
            this.cmbFastDataSet.TabIndex = 3;
            this.cmbFastDataSet.Text = "10000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select size of data set:";
            // 
            // btnStartFast
            // 
            this.btnStartFast.Location = new System.Drawing.Point(42, 65);
            this.btnStartFast.Name = "btnStartFast";
            this.btnStartFast.Size = new System.Drawing.Size(75, 23);
            this.btnStartFast.TabIndex = 4;
            this.btnStartFast.Text = "Start!";
            this.btnStartFast.UseVisualStyleBackColor = true;
            // 
            // btnStartSlow
            // 
            this.btnStartSlow.Location = new System.Drawing.Point(42, 62);
            this.btnStartSlow.Name = "btnStartSlow";
            this.btnStartSlow.Size = new System.Drawing.Size(75, 23);
            this.btnStartSlow.TabIndex = 5;
            this.btnStartSlow.Text = "Start!";
            this.btnStartSlow.UseVisualStyleBackColor = true;
            // 
            // prgInsertion
            // 
            this.prgInsertion.Location = new System.Drawing.Point(99, 143);
            this.prgInsertion.Name = "prgInsertion";
            this.prgInsertion.Size = new System.Drawing.Size(355, 23);
            this.prgInsertion.TabIndex = 6;
            // 
            // prgSelection
            // 
            this.prgSelection.Location = new System.Drawing.Point(99, 180);
            this.prgSelection.Name = "prgSelection";
            this.prgSelection.Size = new System.Drawing.Size(355, 23);
            this.prgSelection.TabIndex = 7;
            // 
            // prgBubble
            // 
            this.prgBubble.Location = new System.Drawing.Point(99, 219);
            this.prgBubble.Name = "prgBubble";
            this.prgBubble.Size = new System.Drawing.Size(355, 23);
            this.prgBubble.TabIndex = 8;
            // 
            // lblInsertion
            // 
            this.lblInsertion.AutoSize = true;
            this.lblInsertion.Location = new System.Drawing.Point(17, 143);
            this.lblInsertion.Name = "lblInsertion";
            this.lblInsertion.Size = new System.Drawing.Size(72, 13);
            this.lblInsertion.TabIndex = 9;
            this.lblInsertion.Text = "Insertion Sort:";
            // 
            // lblSelection
            // 
            this.lblSelection.AutoSize = true;
            this.lblSelection.Location = new System.Drawing.Point(17, 180);
            this.lblSelection.Name = "lblSelection";
            this.lblSelection.Size = new System.Drawing.Size(76, 13);
            this.lblSelection.TabIndex = 10;
            this.lblSelection.Text = "Selection Sort:";
            // 
            // lblBubble
            // 
            this.lblBubble.AutoSize = true;
            this.lblBubble.Location = new System.Drawing.Point(17, 219);
            this.lblBubble.Name = "lblBubble";
            this.lblBubble.Size = new System.Drawing.Size(65, 13);
            this.lblBubble.TabIndex = 11;
            this.lblBubble.Text = "Bubble Sort:";
            // 
            // lblQuickMiddle
            // 
            this.lblQuickMiddle.AutoSize = true;
            this.lblQuickMiddle.Location = new System.Drawing.Point(34, 225);
            this.lblQuickMiddle.Name = "lblQuickMiddle";
            this.lblQuickMiddle.Size = new System.Drawing.Size(83, 26);
            this.lblQuickMiddle.TabIndex = 17;
            this.lblQuickMiddle.Text = "Quick Sort\r\n(Pivot = Middle):";
            // 
            // lblQuickFirst
            // 
            this.lblQuickFirst.AutoSize = true;
            this.lblQuickFirst.Location = new System.Drawing.Point(34, 186);
            this.lblQuickFirst.Name = "lblQuickFirst";
            this.lblQuickFirst.Size = new System.Drawing.Size(71, 26);
            this.lblQuickFirst.TabIndex = 16;
            this.lblQuickFirst.Text = "Quick Sort\r\n(Pivot = First):";
            // 
            // lblMerge
            // 
            this.lblMerge.AutoSize = true;
            this.lblMerge.Location = new System.Drawing.Point(34, 152);
            this.lblMerge.Name = "lblMerge";
            this.lblMerge.Size = new System.Drawing.Size(57, 13);
            this.lblMerge.TabIndex = 15;
            this.lblMerge.Text = "Mergesort:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(123, 228);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(355, 23);
            this.progressBar1.TabIndex = 14;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(123, 189);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(355, 23);
            this.progressBar2.TabIndex = 13;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(123, 152);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(355, 23);
            this.progressBar3.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Points to win:";
            // 
            // cmbPointsSlow
            // 
            this.cmbPointsSlow.FormattingEnabled = true;
            this.cmbPointsSlow.Items.AddRange(new object[] {
            "3",
            "10",
            "15",
            "25"});
            this.cmbPointsSlow.Location = new System.Drawing.Point(371, 11);
            this.cmbPointsSlow.Name = "cmbPointsSlow";
            this.cmbPointsSlow.Size = new System.Drawing.Size(121, 21);
            this.cmbPointsSlow.TabIndex = 13;
            this.cmbPointsSlow.Text = "15";
            // 
            // cmbPointsFast
            // 
            this.cmbPointsFast.FormattingEnabled = true;
            this.cmbPointsFast.Items.AddRange(new object[] {
            "3",
            "10",
            "15",
            "25"});
            this.cmbPointsFast.Location = new System.Drawing.Point(382, 10);
            this.cmbPointsFast.Name = "cmbPointsFast";
            this.cmbPointsFast.Size = new System.Drawing.Size(121, 21);
            this.cmbPointsFast.TabIndex = 19;
            this.cmbPointsFast.Text = "15";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Points to win:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 385);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "A Day at the Races!";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cmbSlowDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFastDataSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStartSlow;
        private System.Windows.Forms.Button btnStartFast;
        private System.Windows.Forms.Label lblBubble;
        private System.Windows.Forms.Label lblSelection;
        private System.Windows.Forms.Label lblInsertion;
        private System.Windows.Forms.ProgressBar prgBubble;
        private System.Windows.Forms.ProgressBar prgSelection;
        private System.Windows.Forms.ProgressBar prgInsertion;
        private System.Windows.Forms.Label lblQuickMiddle;
        private System.Windows.Forms.Label lblQuickFirst;
        private System.Windows.Forms.Label lblMerge;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ComboBox cmbPointsSlow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPointsFast;
        private System.Windows.Forms.Label label4;
    }
}
