namespace TATSim
{
    partial class TATSimForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TATSimForm));
            this.startScreenPanel = new System.Windows.Forms.Panel();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.motoSelectPanel = new System.Windows.Forms.Panel();
            this.xlrPicBox = new System.Windows.Forms.PictureBox();
            this.klrPicBox = new System.Windows.Forms.PictureBox();
            this.drPicBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startScreenPanel.SuspendLayout();
            this.motoSelectPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xlrPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klrPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // startScreenPanel
            // 
            this.startScreenPanel.Controls.Add(this.btnInstructions);
            this.startScreenPanel.Controls.Add(this.btnStart);
            this.startScreenPanel.Controls.Add(this.lblTitle);
            this.startScreenPanel.Controls.Add(this.pictureBox1);
            this.startScreenPanel.Location = new System.Drawing.Point(13, 13);
            this.startScreenPanel.Name = "startScreenPanel";
            this.startScreenPanel.Size = new System.Drawing.Size(1325, 704);
            this.startScreenPanel.TabIndex = 0;
            // 
            // btnInstructions
            // 
            this.btnInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstructions.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnInstructions.Location = new System.Drawing.Point(817, 640);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(212, 49);
            this.btnInstructions.TabIndex = 7;
            this.btnInstructions.Text = "Instructions";
            this.btnInstructions.UseVisualStyleBackColor = true;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnStart.Location = new System.Drawing.Point(295, 640);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(212, 49);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitle.Location = new System.Drawing.Point(251, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(895, 108);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "TAT Simulator 2014";
            // 
            // motoSelectPanel
            // 
            this.motoSelectPanel.Controls.Add(this.label3);
            this.motoSelectPanel.Controls.Add(this.label2);
            this.motoSelectPanel.Controls.Add(this.label1);
            this.motoSelectPanel.Controls.Add(this.xlrPicBox);
            this.motoSelectPanel.Controls.Add(this.klrPicBox);
            this.motoSelectPanel.Controls.Add(this.drPicBox);
            this.motoSelectPanel.Location = new System.Drawing.Point(13, 13);
            this.motoSelectPanel.Name = "motoSelectPanel";
            this.motoSelectPanel.Size = new System.Drawing.Size(1325, 704);
            this.motoSelectPanel.TabIndex = 1;
            // 
            // xlrPicBox
            // 
            this.xlrPicBox.Image = global::TATSim.Properties.Resources.XRLCutOut;
            this.xlrPicBox.Location = new System.Drawing.Point(918, 140);
            this.xlrPicBox.Name = "xlrPicBox";
            this.xlrPicBox.Size = new System.Drawing.Size(300, 250);
            this.xlrPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.xlrPicBox.TabIndex = 2;
            this.xlrPicBox.TabStop = false;
            // 
            // klrPicBox
            // 
            this.klrPicBox.Image = global::TATSim.Properties.Resources.KLRCutOut;
            this.klrPicBox.Location = new System.Drawing.Point(512, 140);
            this.klrPicBox.Name = "klrPicBox";
            this.klrPicBox.Size = new System.Drawing.Size(300, 250);
            this.klrPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.klrPicBox.TabIndex = 1;
            this.klrPicBox.TabStop = false;
            // 
            // drPicBox
            // 
            this.drPicBox.Image = global::TATSim.Properties.Resources.DRCutOut;
            this.drPicBox.Location = new System.Drawing.Point(106, 140);
            this.drPicBox.Name = "drPicBox";
            this.drPicBox.Size = new System.Drawing.Size(300, 250);
            this.drPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.drPicBox.TabIndex = 0;
            this.drPicBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(114, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1096, 472);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "The Dirty Ron";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(498, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "The Kind and Lonesome Ralph";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1014, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "The X Ray";
            // 
            // TATSimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.motoSelectPanel);
            this.Controls.Add(this.startScreenPanel);
            this.Name = "TATSimForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TAT Sim 2014";
            this.startScreenPanel.ResumeLayout(false);
            this.startScreenPanel.PerformLayout();
            this.motoSelectPanel.ResumeLayout(false);
            this.motoSelectPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xlrPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klrPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel startScreenPanel;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel motoSelectPanel;
        private System.Windows.Forms.PictureBox drPicBox;
        private System.Windows.Forms.PictureBox klrPicBox;
        private System.Windows.Forms.PictureBox xlrPicBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}

