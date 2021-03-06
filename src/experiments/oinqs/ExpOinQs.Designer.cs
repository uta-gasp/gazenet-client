﻿namespace GazeNetClient.Experiment.OinQs
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTopic = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudRepetitions = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkPointerVisibility = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudPort = new System.Windows.Forms.NumericUpDown();
            this.txbServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nudDistance = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nudScreenSizeHeight = new System.Windows.Forms.NumericUpDown();
            this.nudScreenSizeWidth = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.stsStatus = new System.Windows.Forms.StatusStrip();
            this.tsslProgress = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nudRepetitions)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScreenSizeHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScreenSizeWidth)).BeginInit();
            this.stsStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(12, 302);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(232, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Topic";
            // 
            // txbTopic
            // 
            this.txbTopic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbTopic.Location = new System.Drawing.Point(116, 71);
            this.txbTopic.Name = "txbTopic";
            this.txbTopic.Size = new System.Drawing.Size(104, 20);
            this.txbTopic.TabIndex = 2;
            this.txbTopic.TextChanged += new System.EventHandler(this.txbTopic_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Repetitions";
            // 
            // nudRepetitions
            // 
            this.nudRepetitions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudRepetitions.Location = new System.Drawing.Point(116, 42);
            this.nudRepetitions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRepetitions.Name = "nudRepetitions";
            this.nudRepetitions.Size = new System.Drawing.Size(104, 20);
            this.nudRepetitions.TabIndex = 3;
            this.nudRepetitions.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRepetitions.ValueChanged += new System.EventHandler(this.nudRepetitions_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkPointerVisibility);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nudRepetitions);
            this.groupBox1.Location = new System.Drawing.Point(12, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 74);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Session";
            // 
            // chkPointerVisibility
            // 
            this.chkPointerVisibility.AutoSize = true;
            this.chkPointerVisibility.Location = new System.Drawing.Point(116, 19);
            this.chkPointerVisibility.Name = "chkPointerVisibility";
            this.chkPointerVisibility.Size = new System.Drawing.Size(91, 17);
            this.chkPointerVisibility.TabIndex = 4;
            this.chkPointerVisibility.Text = "Pointer visible";
            this.chkPointerVisibility.UseVisualStyleBackColor = true;
            this.chkPointerVisibility.CheckedChanged += new System.EventHandler(this.chkPointerVisibility_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.nudPort);
            this.groupBox2.Controls.Add(this.txbServer);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txbTopic);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 101);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connection";
            // 
            // nudPort
            // 
            this.nudPort.Location = new System.Drawing.Point(116, 45);
            this.nudPort.Maximum = new decimal(new int[] {
            65355,
            0,
            0,
            0});
            this.nudPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPort.Name = "nudPort";
            this.nudPort.Size = new System.Drawing.Size(104, 20);
            this.nudPort.TabIndex = 3;
            this.nudPort.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPort.ValueChanged += new System.EventHandler(this.nudPort_ValueChanged);
            // 
            // txbServer
            // 
            this.txbServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbServer.Location = new System.Drawing.Point(116, 19);
            this.txbServer.Name = "txbServer";
            this.txbServer.Size = new System.Drawing.Size(104, 20);
            this.txbServer.TabIndex = 2;
            this.txbServer.TextChanged += new System.EventHandler(this.txbServer_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Server";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Port";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.nudDistance);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.nudScreenSizeHeight);
            this.groupBox3.Controls.Add(this.nudScreenSizeWidth);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 199);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(232, 75);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Geometry";
            // 
            // nudDistance
            // 
            this.nudDistance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudDistance.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudDistance.Location = new System.Drawing.Point(116, 45);
            this.nudDistance.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.nudDistance.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudDistance.Name = "nudDistance";
            this.nudDistance.Size = new System.Drawing.Size(104, 20);
            this.nudDistance.TabIndex = 3;
            this.nudDistance.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudDistance.ValueChanged += new System.EventHandler(this.nudDistance_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Distance, mm";
            // 
            // nudScreenSizeHeight
            // 
            this.nudScreenSizeHeight.Location = new System.Drawing.Point(171, 19);
            this.nudScreenSizeHeight.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudScreenSizeHeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudScreenSizeHeight.Name = "nudScreenSizeHeight";
            this.nudScreenSizeHeight.Size = new System.Drawing.Size(49, 20);
            this.nudScreenSizeHeight.TabIndex = 3;
            this.nudScreenSizeHeight.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudScreenSizeHeight.ValueChanged += new System.EventHandler(this.nudScreenSizeHeight_ValueChanged);
            // 
            // nudScreenSizeWidth
            // 
            this.nudScreenSizeWidth.Location = new System.Drawing.Point(116, 19);
            this.nudScreenSizeWidth.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudScreenSizeWidth.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudScreenSizeWidth.Name = "nudScreenSizeWidth";
            this.nudScreenSizeWidth.Size = new System.Drawing.Size(49, 20);
            this.nudScreenSizeWidth.TabIndex = 3;
            this.nudScreenSizeWidth.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudScreenSizeWidth.ValueChanged += new System.EventHandler(this.nudScreenSizeWidth_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Screen size, mm";
            // 
            // stsStatus
            // 
            this.stsStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslProgress});
            this.stsStatus.Location = new System.Drawing.Point(0, 328);
            this.stsStatus.Name = "stsStatus";
            this.stsStatus.Size = new System.Drawing.Size(256, 22);
            this.stsStatus.TabIndex = 7;
            this.stsStatus.Text = "statusStrip1";
            // 
            // tsslProgress
            // 
            this.tsslProgress.Name = "tsslProgress";
            this.tsslProgress.Size = new System.Drawing.Size(0, 17);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 350);
            this.Controls.Add(this.stsStatus);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "O-in-Qs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nudRepetitions)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScreenSizeHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScreenSizeWidth)).EndInit();
            this.stsStatus.ResumeLayout(false);
            this.stsStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTopic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudRepetitions;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown nudDistance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudScreenSizeHeight;
        private System.Windows.Forms.NumericUpDown nudScreenSizeWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkPointerVisibility;
        private System.Windows.Forms.TextBox txbServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudPort;
        private System.Windows.Forms.StatusStrip stsStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsslProgress;
    }
}

