namespace ContactTracingApp
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.cbcamera = new System.Windows.Forms.ComboBox();
            this.bttnstart = new System.Windows.Forms.Button();
            this.pbImageScan = new System.Windows.Forms.PictureBox();
            this.txtboxScanQr = new System.Windows.Forms.TextBox();
            this.lblCamera = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.bttnstop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageScan)).BeginInit();
            this.SuspendLayout();
            // 
            // cbcamera
            // 
            this.cbcamera.FormattingEnabled = true;
            this.cbcamera.Location = new System.Drawing.Point(114, 15);
            this.cbcamera.Name = "cbcamera";
            this.cbcamera.Size = new System.Drawing.Size(207, 21);
            this.cbcamera.TabIndex = 0;
            // 
            // bttnstart
            // 
            this.bttnstart.Location = new System.Drawing.Point(278, 251);
            this.bttnstart.Name = "bttnstart";
            this.bttnstart.Size = new System.Drawing.Size(75, 23);
            this.bttnstart.TabIndex = 1;
            this.bttnstart.Text = "Scan";
            this.bttnstart.UseVisualStyleBackColor = true;
            this.bttnstart.Click += new System.EventHandler(this.bttnstart_Click);
            // 
            // pbImageScan
            // 
            this.pbImageScan.Location = new System.Drawing.Point(25, 65);
            this.pbImageScan.Name = "pbImageScan";
            this.pbImageScan.Size = new System.Drawing.Size(226, 209);
            this.pbImageScan.TabIndex = 2;
            this.pbImageScan.TabStop = false;
            this.pbImageScan.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtboxScanQr
            // 
            this.txtboxScanQr.Location = new System.Drawing.Point(269, 65);
            this.txtboxScanQr.Multiline = true;
            this.txtboxScanQr.Name = "txtboxScanQr";
            this.txtboxScanQr.Size = new System.Drawing.Size(161, 158);
            this.txtboxScanQr.TabIndex = 3;
            // 
            // lblCamera
            // 
            this.lblCamera.AutoSize = true;
            this.lblCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamera.Location = new System.Drawing.Point(49, 20);
            this.lblCamera.Name = "lblCamera";
            this.lblCamera.Size = new System.Drawing.Size(59, 16);
            this.lblCamera.TabIndex = 4;
            this.lblCamera.Text = "Camera:";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // bttnstop
            // 
            this.bttnstop.Location = new System.Drawing.Point(359, 251);
            this.bttnstop.Name = "bttnstop";
            this.bttnstop.Size = new System.Drawing.Size(75, 23);
            this.bttnstop.TabIndex = 5;
            this.bttnstop.Text = "stop";
            this.bttnstop.UseVisualStyleBackColor = true;
            this.bttnstop.Click += new System.EventHandler(this.bttnstop_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(442, 311);
            this.Controls.Add(this.bttnstop);
            this.Controls.Add(this.lblCamera);
            this.Controls.Add(this.txtboxScanQr);
            this.Controls.Add(this.pbImageScan);
            this.Controls.Add(this.bttnstart);
            this.Controls.Add(this.cbcamera);
            this.Name = "Form4";
            this.Text = "Qr Scan Form";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImageScan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbcamera;
        private System.Windows.Forms.Button bttnstart;
        private System.Windows.Forms.PictureBox pbImageScan;
        private System.Windows.Forms.TextBox txtboxScanQr;
        private System.Windows.Forms.Label lblCamera;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button bttnstop;
    }
}