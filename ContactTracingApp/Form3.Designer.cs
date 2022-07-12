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
            this.picboxGenerateQr = new System.Windows.Forms.PictureBox();
            this.lblGenerateQr = new System.Windows.Forms.Label();
            this.bttnGenerate = new System.Windows.Forms.Button();
            this.bttnsave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picboxGenerateQr)).BeginInit();
            this.SuspendLayout();
            // 
            // picboxGenerateQr
            // 
            this.picboxGenerateQr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picboxGenerateQr.Location = new System.Drawing.Point(16, 72);
            this.picboxGenerateQr.Name = "picboxGenerateQr";
            this.picboxGenerateQr.Size = new System.Drawing.Size(182, 174);
            this.picboxGenerateQr.TabIndex = 53;
            this.picboxGenerateQr.TabStop = false;
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
            this.bttnGenerate.BackColor = System.Drawing.Color.LightGray;
            this.bttnGenerate.Location = new System.Drawing.Point(16, 275);
            this.bttnGenerate.Name = "bttnGenerate";
            this.bttnGenerate.Size = new System.Drawing.Size(75, 29);
            this.bttnGenerate.TabIndex = 55;
            this.bttnGenerate.Text = "Generate";
            this.bttnGenerate.UseVisualStyleBackColor = false;
            // 
            // bttnsave
            // 
            this.bttnsave.BackColor = System.Drawing.Color.LightGray;
            this.bttnsave.Location = new System.Drawing.Point(123, 275);
            this.bttnsave.Name = "bttnsave";
            this.bttnsave.Size = new System.Drawing.Size(75, 29);
            this.bttnsave.TabIndex = 56;
            this.bttnsave.Text = "Save Qr ";
            this.bttnsave.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(615, 440);
            this.Controls.Add(this.bttnsave);
            this.Controls.Add(this.bttnGenerate);
            this.Controls.Add(this.lblGenerateQr);
            this.Controls.Add(this.picboxGenerateQr);
            this.Name = "Form3";
            this.Text = "QrCode Generator";
            ((System.ComponentModel.ISupportInitialize)(this.picboxGenerateQr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxGenerateQr;
        private System.Windows.Forms.Label lblGenerateQr;
        private System.Windows.Forms.Button bttnGenerate;
        private System.Windows.Forms.Button bttnsave;
    }
}