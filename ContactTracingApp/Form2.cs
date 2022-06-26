using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactTracingApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bttnAlldata_Click(object sender, EventArgs e)
        {

            string date = txtboxDate.Text;
            try
            {
                StreamReader responses = new StreamReader(@"C:\Users\barbacena\Desktop\ContactTracingResponses\" + date + ".txt");
                MessageBox.Show(responses.ReadToEnd());
                responses.Close();

            }//end of try
            
            catch
            {
                MessageBox.Show("No data on date " + txtboxDate.Text);

            }//end of catch 
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void bttnViewall_Click(object sender, EventArgs e)
        {
            var DataFile = Directory.EnumerateFiles(@"C:\Users\barbacena\Desktop\ContactTracingResponses");
            foreach (string file in DataFile)
            {
                string viewall = File.ReadAllText(file);
                MessageBox.Show (viewall);
            }
        }

    }
}
