namespace ContactTracingApp
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.lblGenerateQr = new System.Windows.Forms.Label();
            this.bttnGenerate = new System.Windows.Forms.Button();
            this.bttnsave = new System.Windows.Forms.Button();
            this.txtboxresponses = new System.Windows.Forms.TextBox();
            this.pbqrcode = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbqrcode)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGenerateQr
            // 
            this.lblGenerateQr.AutoSize = true;
            this.lblGenerateQr.BackColor = System.Drawing.Color.Transparent;
            this.lblGenerateQr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerateQr.Location = new System.Drawing.Point(13, 29);
            this.lblGenerateQr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenerateQr.Name = "lblGenerateQr";
            this.lblGenerateQr.Size = new System.Drawing.Size(137, 16);
            this.lblGenerateQr.TabIndex = 54;
            this.lblGenerateQr.Text = "Generate Qr Code:";
            // 
            // bttnGenerate
            // 
            this.bttnGenerate.BackColor = System.Drawing.Color.OrangeRed;
            this.bttnGenerate.Location = new System.Drawing.Point(343, 293);
            this.bttnGenerate.Name = "bttnGenerate";
            this.bttnGenerate.Size = new System.Drawing.Size(125, 25);
            this.bttnGenerate.TabIndex = 55;
            this.bttnGenerate.Text = "Generate";
            this.bttnGenerate.UseVisualStyleBackColor = false;
            this.bttnGenerate.Click += new System.EventHandler(this.bttnGenerate_Click);
            // 
            // bttnsave
            // 
            this.bttnsave.BackColor = System.Drawing.Color.LightGray;
            this.bttnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnsave.Location = new System.Drawing.Point(101, 342);
            this.bttnsave.Name = "bttnsave";
            this.bttnsave.Size = new System.Drawing.Size(126, 30);
            this.bttnsave.TabIndex = 56;
            this.bttnsave.Text = "Save Qr ";
            this.bttnsave.UseVisualStyleBackColor = false;
            this.bttnsave.Click += new System.EventHandler(this.bttnsave_Click);
            // 
            // txtboxresponses
            // 
            this.txtboxresponses.BackColor = System.Drawing.SystemColors.Info;
            this.txtboxresponses.Location = new System.Drawing.Point(352, 72);
            this.txtboxresponses.Multiline = true;
            this.txtboxresponses.Name = "txtboxresponses";
            this.txtboxresponses.Size = new System.Drawing.Size(106, 201);
            this.txtboxresponses.TabIndex = 57;
            // 
            // pbqrcode
            // 
            this.pbqrcode.Location = new System.Drawing.Point(16, 72);
            this.pbqrcode.Name = "pbqrcode";
            this.pbqrcode.Size = new System.Drawing.Size(301, 253);
            this.pbqrcode.TabIndex = 58;
            this.pbqrcode.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(480, 394);
            this.Controls.Add(this.pbqrcode);
            this.Controls.Add(this.txtboxresponses);
            this.Controls.Add(this.bttnsave);
            this.Controls.Add(this.bttnGenerate);
            this.Controls.Add(this.lblGenerateQr);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QrCode Generator";
            ((System.ComponentModel.ISupportInitialize)(this.pbqrcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGenerateQr;
        private System.Windows.Forms.Button bttnGenerate;
        private System.Windows.Forms.Button bttnsave;
        private System.Windows.Forms.TextBox txtboxresponses;
        private System.Windows.Forms.PictureBox pbqrcode;
    }
}