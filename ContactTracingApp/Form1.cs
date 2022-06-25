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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttnSubmit_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\barbacena\Desktop\ContactTracingResponses\" + txtboxSurname.Text + " " + txtboxFirstName.Text + ".txt", true);
            file.WriteLine("Contact Tracing Response");
            file.WriteLine("Date and Time:" + txtboxDate.Text + " ," + txtboxTime.Text);
            file.WriteLine("Name:" + txtboxSurname.Text + "," + txtboxFirstName.Text + " " + txtboxMiddleInitial.Text + "." + " " + txtboxSuffix.Text);
            file.WriteLine("Birth Date: " + txtboxBirthdate.Text);
            file.WriteLine("Age: " + txtboxAge.Text + " years old");
            file.WriteLine("Sex:" + txtboxSex.Text);
            file.WriteLine("Address");
            file.WriteLine("Province:" + txtboxProvince.Text);
            file.WriteLine("City:" + txtboxCity.Text);
            file.WriteLine("Street Name:" + txtboxStreetName.Text);
            file.WriteLine("Barangay:" + txtboxBarangay.Text);
            file.WriteLine("Vaccination Information");
            file.WriteLine("Vaccinated:" + txtboxAYV.Text);
            file.WriteLine("Booster Shot:" + txtboxBooster.Text);
            file.WriteLine("1st Dose:" + txtboxFirstDose.Text);
            file.WriteLine("2nd Dose:" + txtbox2ndDose.Text);
            file.WriteLine("----End of Response----");
            file.Close();


        }

    }
}
