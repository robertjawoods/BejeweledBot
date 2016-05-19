namespace BejeweledBot
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.calibrateBtn = new System.Windows.Forms.Button();
            this.playBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.captureTimer = new System.Windows.Forms.Timer(this.components);
            this.colourGridPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.colourGridPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // calibrateBtn
            // 
            this.calibrateBtn.Location = new System.Drawing.Point(21, 366);
            this.calibrateBtn.Name = "calibrateBtn";
            this.calibrateBtn.Size = new System.Drawing.Size(126, 44);
            this.calibrateBtn.TabIndex = 0;
            this.calibrateBtn.Text = "Calibrate";
            this.calibrateBtn.UseVisualStyleBackColor = true;
            this.calibrateBtn.Click += new System.EventHandler(this.calibrateBtn_Click);
            // 
            // playBtn
            // 
            this.playBtn.Location = new System.Drawing.Point(180, 366);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(126, 44);
            this.playBtn.TabIndex = 1;
            this.playBtn.Text = "Play";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(342, 366);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(126, 44);
            this.stopBtn.TabIndex = 2;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // captureTimer
            // 
            this.captureTimer.Interval = 200;
            // 
            // colourGridPicture
            // 
            this.colourGridPicture.Location = new System.Drawing.Point(21, 12);
            this.colourGridPicture.Name = "colourGridPicture";
            this.colourGridPicture.Size = new System.Drawing.Size(447, 348);
            this.colourGridPicture.TabIndex = 3;
            this.colourGridPicture.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 422);
            this.Controls.Add(this.colourGridPicture);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.calibrateBtn);
            this.Name = "MainWindow";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.colourGridPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button calibrateBtn;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Timer captureTimer;
        private System.Windows.Forms.PictureBox colourGridPicture;
    }
}

