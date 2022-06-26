namespace ContactTracingApp
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.bttnSearch = new System.Windows.Forms.Button();
            this.lblInstruction1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxDate = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblViewAll = new System.Windows.Forms.Label();
            this.bttnViewall = new System.Windows.Forms.Button();
            this.bttnBacktoForm1 = new System.Windows.Forms.Button();
            this.bttnCloseall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttnSearch
            // 
            this.bttnSearch.Location = new System.Drawing.Point(250, 66);
            this.bttnSearch.Name = "bttnSearch";
            this.bttnSearch.Size = new System.Drawing.Size(75, 23);
            this.bttnSearch.TabIndex = 0;
            this.bttnSearch.Text = "Search";
            this.bttnSearch.UseVisualStyleBackColor = true;
            this.bttnSearch.Click += new System.EventHandler(this.bttnAlldata_Click);
            // 
            // lblInstruction1
            // 
            this.lblInstruction1.AutoSize = true;
            this.lblInstruction1.ForeColor = System.Drawing.Color.Black;
            this.lblInstruction1.Location = new System.Drawing.Point(12, 38);
            this.lblInstruction1.Name = "lblInstruction1";
            this.lblInstruction1.Size = new System.Drawing.Size(204, 13);
            this.lblInstruction1.TabIndex = 1;
            this.lblInstruction1.Text = "Show all the responses by the given date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // txtboxDate
            // 
            this.txtboxDate.Location = new System.Drawing.Point(51, 68);
            this.txtboxDate.Name = "txtboxDate";
            this.txtboxDate.Size = new System.Drawing.Size(176, 20);
            this.txtboxDate.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 75);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date:";
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // lblViewAll
            // 
            this.lblViewAll.AutoSize = true;
            this.lblViewAll.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblViewAll.Location = new System.Drawing.Point(12, 127);
            this.lblViewAll.Name = "lblViewAll";
            this.lblViewAll.Size = new System.Drawing.Size(97, 13);
            this.lblViewAll.TabIndex = 5;
            this.lblViewAll.Text = "View all responses:";
            // 
            // bttnViewall
            // 
            this.bttnViewall.Location = new System.Drawing.Point(143, 117);
            this.bttnViewall.Name = "bttnViewall";
            this.bttnViewall.Size = new System.Drawing.Size(182, 23);
            this.bttnViewall.TabIndex = 6;
            this.bttnViewall.Text = "View all";
            this.bttnViewall.UseVisualStyleBackColor = true;
            this.bttnViewall.Click += new System.EventHandler(this.bttnViewall_Click);
            // 
            // bttnBacktoForm1
            // 
            this.bttnBacktoForm1.Location = new System.Drawing.Point(73, 170);
            this.bttnBacktoForm1.Name = "bttnBacktoForm1";
            this.bttnBacktoForm1.Size = new System.Drawing.Size(75, 23);
            this.bttnBacktoForm1.TabIndex = 7;
            this.bttnBacktoForm1.Text = "Back";
            this.bttnBacktoForm1.UseVisualStyleBackColor = true;
            this.bttnBacktoForm1.Click += new System.EventHandler(this.bttnBacktoForm1_Click);
            // 
            // bttnCloseall
            // 
            this.bttnCloseall.Location = new System.Drawing.Point(181, 170);
            this.bttnCloseall.Name = "bttnCloseall";
            this.bttnCloseall.Size = new System.Drawing.Size(75, 23);
            this.bttnCloseall.TabIndex = 8;
            this.bttnCloseall.Text = "Close";
            this.bttnCloseall.UseVisualStyleBackColor = true;
            this.bttnCloseall.Click += new System.EventHandler(this.bttnCloseall_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(357, 214);
            this.Controls.Add(this.bttnCloseall);
            this.Controls.Add(this.bttnBacktoForm1);
            this.Controls.Add(this.bttnViewall);
            this.Controls.Add(this.lblViewAll);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtboxDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblInstruction1);
            this.Controls.Add(this.bttnSearch);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.Text = "AdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnSearch;
        private System.Windows.Forms.Label lblInstruction1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblViewAll;
        private System.Windows.Forms.Button bttnViewall;
        private System.Windows.Forms.Button bttnBacktoForm1;
        private System.Windows.Forms.Button bttnCloseall;
    }
}