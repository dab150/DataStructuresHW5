namespace DataStructuresHW5
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
            this.lblBubbleTime = new System.Windows.Forms.Label();
            this.lblSelectionTime = new System.Windows.Forms.Label();
            this.lblInsertionTime = new System.Windows.Forms.Label();
            this.lblBubbleScore = new System.Windows.Forms.Label();
            this.lblSelectionScore = new System.Windows.Forms.Label();
            this.lblInsertionScore = new System.Windows.Forms.Label();
            this.btnStartSlow = new System.Windows.Forms.Button();
            this.cmbPointsSlow = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBubble = new System.Windows.Forms.Label();
            this.lblSelection = new System.Windows.Forms.Label();
            this.lblInsertion = new System.Windows.Forms.Label();
            this.prgBubble = new System.Windows.Forms.ProgressBar();
            this.prgSelection = new System.Windows.Forms.ProgressBar();
            this.prgInsertion = new System.Windows.Forms.ProgressBar();
            this.cmbSlowDataSet = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblQuickMidScore = new System.Windows.Forms.Label();
            this.lblQuickFirstScore = new System.Windows.Forms.Label();
            this.lblMergeScore = new System.Windows.Forms.Label();
            this.lblQuickMidTime = new System.Windows.Forms.Label();
            this.lblQuickFirstTime = new System.Windows.Forms.Label();
            this.lblMergeTime = new System.Windows.Forms.Label();
            this.btnStartFast = new System.Windows.Forms.Button();
            this.cmbPointsFast = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblQuickMiddle = new System.Windows.Forms.Label();
            this.lblQuickFirst = new System.Windows.Forms.Label();
            this.lblMerge = new System.Windows.Forms.Label();
            this.prgQuickMid = new System.Windows.Forms.ProgressBar();
            this.prgQuickFirst = new System.Windows.Forms.ProgressBar();
            this.prgMerge = new System.Windows.Forms.ProgressBar();
            this.cmbFastDataSet = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.tabPage1.Controls.Add(this.lblBubbleTime);
            this.tabPage1.Controls.Add(this.lblSelectionTime);
            this.tabPage1.Controls.Add(this.lblInsertionTime);
            this.tabPage1.Controls.Add(this.lblBubbleScore);
            this.tabPage1.Controls.Add(this.lblSelectionScore);
            this.tabPage1.Controls.Add(this.lblInsertionScore);
            this.tabPage1.Controls.Add(this.btnStartSlow);
            this.tabPage1.Controls.Add(this.cmbPointsSlow);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lblBubble);
            this.tabPage1.Controls.Add(this.lblSelection);
            this.tabPage1.Controls.Add(this.lblInsertion);
            this.tabPage1.Controls.Add(this.prgBubble);
            this.tabPage1.Controls.Add(this.prgSelection);
            this.tabPage1.Controls.Add(this.prgInsertion);
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
            // lblBubbleTime
            // 
            this.lblBubbleTime.AutoSize = true;
            this.lblBubbleTime.Location = new System.Drawing.Point(38, 231);
            this.lblBubbleTime.Name = "lblBubbleTime";
            this.lblBubbleTime.Size = new System.Drawing.Size(33, 13);
            this.lblBubbleTime.TabIndex = 20;
            this.lblBubbleTime.Text = "Time:";
            // 
            // lblSelectionTime
            // 
            this.lblSelectionTime.AutoSize = true;
            this.lblSelectionTime.Location = new System.Drawing.Point(38, 192);
            this.lblSelectionTime.Name = "lblSelectionTime";
            this.lblSelectionTime.Size = new System.Drawing.Size(33, 13);
            this.lblSelectionTime.TabIndex = 19;
            this.lblSelectionTime.Text = "Time:";
            // 
            // lblInsertionTime
            // 
            this.lblInsertionTime.AutoSize = true;
            this.lblInsertionTime.Location = new System.Drawing.Point(38, 155);
            this.lblInsertionTime.Name = "lblInsertionTime";
            this.lblInsertionTime.Size = new System.Drawing.Size(33, 13);
            this.lblInsertionTime.TabIndex = 18;
            this.lblInsertionTime.Text = "Time:";
            // 
            // lblBubbleScore
            // 
            this.lblBubbleScore.AutoSize = true;
            this.lblBubbleScore.Location = new System.Drawing.Point(481, 218);
            this.lblBubbleScore.Name = "lblBubbleScore";
            this.lblBubbleScore.Size = new System.Drawing.Size(13, 13);
            this.lblBubbleScore.TabIndex = 17;
            this.lblBubbleScore.Text = "0";
            // 
            // lblSelectionScore
            // 
            this.lblSelectionScore.AutoSize = true;
            this.lblSelectionScore.Location = new System.Drawing.Point(481, 179);
            this.lblSelectionScore.Name = "lblSelectionScore";
            this.lblSelectionScore.Size = new System.Drawing.Size(13, 13);
            this.lblSelectionScore.TabIndex = 16;
            this.lblSelectionScore.Text = "0";
            // 
            // lblInsertionScore
            // 
            this.lblInsertionScore.AutoSize = true;
            this.lblInsertionScore.Location = new System.Drawing.Point(481, 142);
            this.lblInsertionScore.Name = "lblInsertionScore";
            this.lblInsertionScore.Size = new System.Drawing.Size(13, 13);
            this.lblInsertionScore.TabIndex = 15;
            this.lblInsertionScore.Text = "0";
            // 
            // btnStartSlow
            // 
            this.btnStartSlow.Location = new System.Drawing.Point(120, 272);
            this.btnStartSlow.Name = "btnStartSlow";
            this.btnStartSlow.Size = new System.Drawing.Size(355, 52);
            this.btnStartSlow.TabIndex = 14;
            this.btnStartSlow.Text = "Start Race!";
            this.btnStartSlow.UseVisualStyleBackColor = true;
            this.btnStartSlow.Click += new System.EventHandler(this.btnStartSlow_Click);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Points to win:";
            // 
            // lblBubble
            // 
            this.lblBubble.AutoSize = true;
            this.lblBubble.Location = new System.Drawing.Point(38, 218);
            this.lblBubble.Name = "lblBubble";
            this.lblBubble.Size = new System.Drawing.Size(65, 13);
            this.lblBubble.TabIndex = 11;
            this.lblBubble.Text = "Bubble Sort:";
            // 
            // lblSelection
            // 
            this.lblSelection.AutoSize = true;
            this.lblSelection.Location = new System.Drawing.Point(38, 179);
            this.lblSelection.Name = "lblSelection";
            this.lblSelection.Size = new System.Drawing.Size(76, 13);
            this.lblSelection.TabIndex = 10;
            this.lblSelection.Text = "Selection Sort:";
            // 
            // lblInsertion
            // 
            this.lblInsertion.AutoSize = true;
            this.lblInsertion.Location = new System.Drawing.Point(38, 142);
            this.lblInsertion.Name = "lblInsertion";
            this.lblInsertion.Size = new System.Drawing.Size(72, 13);
            this.lblInsertion.TabIndex = 9;
            this.lblInsertion.Text = "Insertion Sort:";
            // 
            // prgBubble
            // 
            this.prgBubble.Location = new System.Drawing.Point(120, 218);
            this.prgBubble.Name = "prgBubble";
            this.prgBubble.Size = new System.Drawing.Size(355, 23);
            this.prgBubble.Step = 1;
            this.prgBubble.TabIndex = 8;
            // 
            // prgSelection
            // 
            this.prgSelection.Location = new System.Drawing.Point(120, 179);
            this.prgSelection.Name = "prgSelection";
            this.prgSelection.Size = new System.Drawing.Size(355, 23);
            this.prgSelection.Step = 1;
            this.prgSelection.TabIndex = 7;
            // 
            // prgInsertion
            // 
            this.prgInsertion.Location = new System.Drawing.Point(120, 142);
            this.prgInsertion.Name = "prgInsertion";
            this.prgInsertion.Size = new System.Drawing.Size(355, 23);
            this.prgInsertion.Step = 1;
            this.prgInsertion.TabIndex = 6;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select size of data set:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblQuickMidScore);
            this.tabPage2.Controls.Add(this.lblQuickFirstScore);
            this.tabPage2.Controls.Add(this.lblMergeScore);
            this.tabPage2.Controls.Add(this.lblQuickMidTime);
            this.tabPage2.Controls.Add(this.lblQuickFirstTime);
            this.tabPage2.Controls.Add(this.lblMergeTime);
            this.tabPage2.Controls.Add(this.btnStartFast);
            this.tabPage2.Controls.Add(this.cmbPointsFast);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.lblQuickMiddle);
            this.tabPage2.Controls.Add(this.lblQuickFirst);
            this.tabPage2.Controls.Add(this.lblMerge);
            this.tabPage2.Controls.Add(this.prgQuickMid);
            this.tabPage2.Controls.Add(this.prgQuickFirst);
            this.tabPage2.Controls.Add(this.prgMerge);
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
            // lblQuickMidScore
            // 
            this.lblQuickMidScore.AutoSize = true;
            this.lblQuickMidScore.Location = new System.Drawing.Point(484, 246);
            this.lblQuickMidScore.Name = "lblQuickMidScore";
            this.lblQuickMidScore.Size = new System.Drawing.Size(13, 13);
            this.lblQuickMidScore.TabIndex = 26;
            this.lblQuickMidScore.Text = "0";
            // 
            // lblQuickFirstScore
            // 
            this.lblQuickFirstScore.AutoSize = true;
            this.lblQuickFirstScore.Location = new System.Drawing.Point(484, 189);
            this.lblQuickFirstScore.Name = "lblQuickFirstScore";
            this.lblQuickFirstScore.Size = new System.Drawing.Size(13, 13);
            this.lblQuickFirstScore.TabIndex = 25;
            this.lblQuickFirstScore.Text = "0";
            // 
            // lblMergeScore
            // 
            this.lblMergeScore.AutoSize = true;
            this.lblMergeScore.Location = new System.Drawing.Point(484, 134);
            this.lblMergeScore.Name = "lblMergeScore";
            this.lblMergeScore.Size = new System.Drawing.Size(13, 13);
            this.lblMergeScore.TabIndex = 24;
            this.lblMergeScore.Text = "0";
            // 
            // lblQuickMidTime
            // 
            this.lblQuickMidTime.AutoSize = true;
            this.lblQuickMidTime.Location = new System.Drawing.Point(34, 269);
            this.lblQuickMidTime.Name = "lblQuickMidTime";
            this.lblQuickMidTime.Size = new System.Drawing.Size(33, 13);
            this.lblQuickMidTime.TabIndex = 23;
            this.lblQuickMidTime.Text = "Time:";
            // 
            // lblQuickFirstTime
            // 
            this.lblQuickFirstTime.AutoSize = true;
            this.lblQuickFirstTime.Location = new System.Drawing.Point(34, 212);
            this.lblQuickFirstTime.Name = "lblQuickFirstTime";
            this.lblQuickFirstTime.Size = new System.Drawing.Size(33, 13);
            this.lblQuickFirstTime.TabIndex = 22;
            this.lblQuickFirstTime.Text = "Time:";
            // 
            // lblMergeTime
            // 
            this.lblMergeTime.AutoSize = true;
            this.lblMergeTime.Location = new System.Drawing.Point(34, 147);
            this.lblMergeTime.Name = "lblMergeTime";
            this.lblMergeTime.Size = new System.Drawing.Size(33, 13);
            this.lblMergeTime.TabIndex = 21;
            this.lblMergeTime.Text = "Time:";
            // 
            // btnStartFast
            // 
            this.btnStartFast.Location = new System.Drawing.Point(123, 287);
            this.btnStartFast.Name = "btnStartFast";
            this.btnStartFast.Size = new System.Drawing.Size(355, 52);
            this.btnStartFast.TabIndex = 20;
            this.btnStartFast.Text = "Start Race!";
            this.btnStartFast.UseVisualStyleBackColor = true;
            this.btnStartFast.Click += new System.EventHandler(this.btnStartFast_Click);
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
            // lblQuickMiddle
            // 
            this.lblQuickMiddle.AutoSize = true;
            this.lblQuickMiddle.Location = new System.Drawing.Point(34, 243);
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
            this.lblMerge.Location = new System.Drawing.Point(34, 134);
            this.lblMerge.Name = "lblMerge";
            this.lblMerge.Size = new System.Drawing.Size(57, 13);
            this.lblMerge.TabIndex = 15;
            this.lblMerge.Text = "Mergesort:";
            // 
            // prgQuickMid
            // 
            this.prgQuickMid.Location = new System.Drawing.Point(123, 246);
            this.prgQuickMid.Name = "prgQuickMid";
            this.prgQuickMid.Size = new System.Drawing.Size(355, 23);
            this.prgQuickMid.Step = 1;
            this.prgQuickMid.TabIndex = 14;
            // 
            // prgQuickFirst
            // 
            this.prgQuickFirst.Location = new System.Drawing.Point(123, 189);
            this.prgQuickFirst.Name = "prgQuickFirst";
            this.prgQuickFirst.Size = new System.Drawing.Size(355, 23);
            this.prgQuickFirst.Step = 1;
            this.prgQuickFirst.TabIndex = 13;
            // 
            // prgMerge
            // 
            this.prgMerge.Location = new System.Drawing.Point(123, 134);
            this.prgMerge.Name = "prgMerge";
            this.prgMerge.Size = new System.Drawing.Size(355, 23);
            this.prgMerge.Step = 1;
            this.prgMerge.TabIndex = 12;
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
        private System.Windows.Forms.Label lblBubble;
        private System.Windows.Forms.Label lblSelection;
        private System.Windows.Forms.Label lblInsertion;
        private System.Windows.Forms.ProgressBar prgBubble;
        private System.Windows.Forms.ProgressBar prgSelection;
        private System.Windows.Forms.ProgressBar prgInsertion;
        private System.Windows.Forms.Label lblQuickMiddle;
        private System.Windows.Forms.Label lblQuickFirst;
        private System.Windows.Forms.Label lblMerge;
        private System.Windows.Forms.ProgressBar prgQuickMid;
        private System.Windows.Forms.ProgressBar prgQuickFirst;
        private System.Windows.Forms.ProgressBar prgMerge;
        private System.Windows.Forms.ComboBox cmbPointsSlow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPointsFast;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStartSlow;
        private System.Windows.Forms.Button btnStartFast;
        private System.Windows.Forms.Label lblBubbleScore;
        private System.Windows.Forms.Label lblSelectionScore;
        private System.Windows.Forms.Label lblInsertionScore;
        private System.Windows.Forms.Label lblBubbleTime;
        private System.Windows.Forms.Label lblSelectionTime;
        private System.Windows.Forms.Label lblInsertionTime;
        private System.Windows.Forms.Label lblQuickMidScore;
        private System.Windows.Forms.Label lblQuickFirstScore;
        private System.Windows.Forms.Label lblMergeScore;
        private System.Windows.Forms.Label lblQuickMidTime;
        private System.Windows.Forms.Label lblQuickFirstTime;
        private System.Windows.Forms.Label lblMergeTime;
    }
}

