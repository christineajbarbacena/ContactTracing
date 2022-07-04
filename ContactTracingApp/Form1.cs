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
using System.Text.Encoding;

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
            StreamWriter file = new StreamWriter(@"C:\Users\barbacena\Desktop\ContactTracingResponses\" + txtboxDate.Text + ".txt", true);
            file.WriteLine("Contact Tracing Response ");
            file.WriteLine("Date and Time: " + txtboxDate.Text + " , " + txtboxTime.Text);
            file.WriteLine("Name: " + txtboxSurname.Text + "," + txtboxFirstName.Text + " " + txtboxMiddleInitial.Text + "." + " " + txtboxSuffix.Text);
            file.WriteLine("Birth Date: " + txtboxBirthdate.Text);
            file.WriteLine("Age: " + txtboxAge.Text + " years old");
            file.WriteLine("Sex: " + txtboxSex.Text);
            file.WriteLine("ADDRESS ");
            file.WriteLine("Province: " + txtboxProvince.Text);
            file.WriteLine("City: " + txtboxCity.Text);
            file.WriteLine("Street Name: " + txtboxStreetName.Text);
            file.WriteLine("Barangay: " + txtboxBarangay.Text);
            file.WriteLine("Vaccination Information");
            file.WriteLine("Vaccinated: " + txtboxAYV.Text);
            file.WriteLine("Booster Shot: " + txtboxBooster.Text);
            file.WriteLine("1st Dose: " + txtboxFirstDose.Text);
            file.WriteLine("2nd Dose: " + txtbox2ndDose.Text);
            file.WriteLine("----End of Response----");
            file.WriteLine("");
            file.Close();
            MessageBox.Show("I HEREBY CERTIFY that the information provided in this form is complete, true and correct.");
            MessageBox.Show("Thank you Mr/Ms." + txtboxSurname.Text);
            this.Close();
        }

        private void bttnAdminSignIn_Click(object sender, EventArgs e)
        {
            //adding username and password for sign in button
            string username = txtboxUsername.Text;
            string password = txtboxPassword.Text;

            if ((username == "admin") && (password == "admin"))

            //right password and username
            {
                this.Hide();
                Form2 adminForm = new Form2();
                adminForm.ShowDialog();
            }

          //incorrect username and password
            else
            {
            MessageBox.Show ("Incorrect Username and/or Password");
            }

        }

        private void bttnGenerate_Click(object sender, EventArgs e)
        {
            string name = txtboxFirstName.Text +" ," + txtboxMiddleInitial.Text + ". " + txtboxSurname.Text + " ,"+ txtboxSuffix.Text;
            string bday = txtboxBirthdate.Text;
            string age = txtboxAge.Text;
            string sex = txtboxSex.Text;
            string address = txtboxProvince.Text + ", " + txtboxCity.Text + ", " +txtboxStreetName.Text + ", "+ txtboxBarangay.Text;
            string email = txtboxEmailAdd.Text;
            string number = txtboxMobileNum.Text;
            string vor = txtboxAYV.Text;
            string stdose = txtboxFirstDose.Text;
            string secdose = txtbox2ndDose.Text;
            string booster = txtboxBooster.Text;

            string info = "Name: " + name + "  ,  " + "Birthdate: " + bday + " , " + "Age: "+ age + " , " + "Sex: " + sex + " , " + "Address: " + address + "Email Address: "  + email + " , " + "Mobile Number: " + number + " , " + "Are you Vaccinated?: " + vor + " , " + "First Dose: " + stdose + " , " + "Second Dose: " + secdose + " , " + "Booster Shot: " + booster; 
            MessageBox.Show("Continue?");
            MessageBox.Show("This will be generated into Qr Code");

            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            picboxGenerateQr.SizeMode = PictureBoxSizeMode.AutoSize;
            picboxGenerateQr.Image = qrcode.Draw(name + bday + age + sex + address + email + number + vor + stdose + secdose + booster, 1);

        }

        private void bttnsave_Click(object sender, EventArgs e)
        {
            SaveFileDialog qr = new SaveFileDialog();
            qr.ShowDialog();
            picboxGenerateQr.Image.Save(qr.FileName);
            MessageBox.Show("Image Saved");
        }

    }
}
