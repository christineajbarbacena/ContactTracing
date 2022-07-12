namespace ContactTracingApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtboxDate = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtboxTime = new System.Windows.Forms.TextBox();
            this.lblPersonalInfo = new System.Windows.Forms.Label();
            this.lblFN = new System.Windows.Forms.Label();
            this.txtboxFirstName = new System.Windows.Forms.TextBox();
            this.lblMI = new System.Windows.Forms.Label();
            this.txtboxMiddleInitial = new System.Windows.Forms.TextBox();
            this.lblSN = new System.Windows.Forms.Label();
            this.lblSuffix = new System.Windows.Forms.Label();
            this.txtboxSurname = new System.Windows.Forms.TextBox();
            this.txtboxSuffix = new System.Windows.Forms.TextBox();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.txtboxBirthdate = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtboxAge = new System.Windows.Forms.TextBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.txtboxSex = new System.Windows.Forms.TextBox();
            this.lblProvince = new System.Windows.Forms.Label();
            this.txtboxProvince = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtboxCity = new System.Windows.Forms.TextBox();
            this.txtboxStreetName = new System.Windows.Forms.TextBox();
            this.lblStreetName = new System.Windows.Forms.Label();
            this.lblBarangay = new System.Windows.Forms.Label();
            this.txtboxBarangay = new System.Windows.Forms.TextBox();
            this.lblEmailAdd = new System.Windows.Forms.Label();
            this.txtboxEmailAdd = new System.Windows.Forms.TextBox();
            this.lblMobileNumber = new System.Windows.Forms.Label();
            this.txtboxMobileNum = new System.Windows.Forms.TextBox();
            this.lblVaccinationDetails = new System.Windows.Forms.Label();
            this.lblareyouvaccinated = new System.Windows.Forms.Label();
            this.lblVDInstruction = new System.Windows.Forms.Label();
            this.txtboxAYV = new System.Windows.Forms.TextBox();
            this.lbl1stDose = new System.Windows.Forms.Label();
            this.txtboxFirstDose = new System.Windows.Forms.TextBox();
            this.lbl2ndDose = new System.Windows.Forms.Label();
            this.txtbox2ndDose = new System.Windows.Forms.TextBox();
            this.lblBooster = new System.Windows.Forms.Label();
            this.txtboxBooster = new System.Windows.Forms.TextBox();
            this.bttnSubmit = new System.Windows.Forms.Button();
            this.lblInstruction1 = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.bttnAdminSignIn = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtboxUsername = new System.Windows.Forms.TextBox();
            this.bttnGenerate = new System.Windows.Forms.Button();
            this.bttnScan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(243, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(209, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Contact Tracing Form";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.BackColor = System.Drawing.Color.Transparent;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(13, 58);
            this.lblInstructions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(379, 16);
            this.lblInstructions.TabIndex = 1;
            this.lblInstructions.Text = "Kindly provide the needed information accurately and honestly.";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(12, 98);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(146, 15);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date (MM//DD//YY):";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtboxDate
            // 
            this.txtboxDate.Location = new System.Drawing.Point(164, 91);
            this.txtboxDate.Name = "txtboxDate";
            this.txtboxDate.Size = new System.Drawing.Size(211, 22);
            this.txtboxDate.TabIndex = 3;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(395, 98);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(43, 15);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Time:";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtboxTime
            // 
            this.txtboxTime.Location = new System.Drawing.Point(444, 91);
            this.txtboxTime.Name = "txtboxTime";
            this.txtboxTime.Size = new System.Drawing.Size(117, 22);
            this.txtboxTime.TabIndex = 5;
            // 
            // lblPersonalInfo
            // 
            this.lblPersonalInfo.AutoSize = true;
            this.lblPersonalInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblPersonalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonalInfo.Location = new System.Drawing.Point(13, 135);
            this.lblPersonalInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPersonalInfo.Name = "lblPersonalInfo";
            this.lblPersonalInfo.Size = new System.Drawing.Size(154, 16);
            this.lblPersonalInfo.TabIndex = 6;
            this.lblPersonalInfo.Text = "Personal Information:\r\n";
            // 
            // lblFN
            // 
            this.lblFN.AutoSize = true;
            this.lblFN.BackColor = System.Drawing.Color.Transparent;
            this.lblFN.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFN.Location = new System.Drawing.Point(10, 166);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(71, 15);
            this.lblFN.TabIndex = 7;
            this.lblFN.Text = "First Name:";
            this.lblFN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtboxFirstName
            // 
            this.txtboxFirstName.Location = new System.Drawing.Point(87, 159);
            this.txtboxFirstName.Name = "txtboxFirstName";
            this.txtboxFirstName.Size = new System.Drawing.Size(133, 22);
            this.txtboxFirstName.TabIndex = 8;
            // 
            // lblMI
            // 
            this.lblMI.AutoSize = true;
            this.lblMI.BackColor = System.Drawing.Color.Transparent;
            this.lblMI.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMI.Location = new System.Drawing.Point(226, 166);
            this.lblMI.Name = "lblMI";
            this.lblMI.Size = new System.Drawing.Size(85, 15);
            this.lblMI.TabIndex = 9;
            this.lblMI.Text = "Middle Initial:";
            this.lblMI.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtboxMiddleInitial
            // 
            this.txtboxMiddleInitial.Location = new System.Drawing.Point(317, 159);
            this.txtboxMiddleInitial.Name = "txtboxMiddleInitial";
            this.txtboxMiddleInitial.Size = new System.Drawing.Size(31, 22);
            this.txtboxMiddleInitial.TabIndex = 10;
            // 
            // lblSN
            // 
            this.lblSN.AutoSize = true;
            this.lblSN.BackColor = System.Drawing.Color.Transparent;
            this.lblSN.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSN.Location = new System.Drawing.Point(355, 166);
            this.lblSN.Name = "lblSN";
            this.lblSN.Size = new System.Drawing.Size(58, 15);
            this.lblSN.TabIndex = 11;
            this.lblSN.Text = "Surname:";
            this.lblSN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSuffix
            // 
            this.lblSuffix.AutoSize = true;
            this.lblSuffix.BackColor = System.Drawing.Color.Transparent;
            this.lblSuffix.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuffix.Location = new System.Drawing.Point(512, 166);
            this.lblSuffix.Name = "lblSuffix";
            this.lblSuffix.Size = new System.Drawing.Size(41, 15);
            this.lblSuffix.TabIndex = 12;
            this.lblSuffix.Text = "Suffix:";
            this.lblSuffix.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtboxSurname
            // 
            this.txtboxSurname.Location = new System.Drawing.Point(419, 159);
            this.txtboxSurname.Name = "txtboxSurname";
            this.txtboxSurname.Size = new System.Drawing.Size(87, 22);
            this.txtboxSurname.TabIndex = 13;
            // 
            // txtboxSuffix
            // 
            this.txtboxSuffix.Location = new System.Drawing.Point(559, 159);
            this.txtboxSuffix.Name = "txtboxSuffix";
            this.txtboxSuffix.Size = new System.Drawing.Size(57, 22);
            this.txtboxSuffix.TabIndex = 14;
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.BackColor = System.Drawing.Color.Transparent;
            this.lblBirthdate.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthdate.Location = new System.Drawing.Point(12, 204);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(153, 15);
            this.lblBirthdate.TabIndex = 15;
            this.lblBirthdate.Text = "Birth Date (mm//dd//yy):";
            this.lblBirthdate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtboxBirthdate
            // 
            this.txtboxBirthdate.Location = new System.Drawing.Point(171, 197);
            this.txtboxBirthdate.Name = "txtboxBirthdate";
            this.txtboxBirthdate.Size = new System.Drawing.Size(133, 22);
            this.txtboxBirthdate.TabIndex = 16;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.Transparent;
            this.lblAge.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(330, 204);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(30, 15);
            this.lblAge.TabIndex = 17;
            this.lblAge.Text = "Age:";
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtboxAge
            // 
            this.txtboxAge.Location = new System.Drawing.Point(366, 197);
            this.txtboxAge.Name = "txtboxAge";
            this.txtboxAge.Size = new System.Drawing.Size(86, 22);
            this.txtboxAge.TabIndex = 18;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.BackColor = System.Drawing.Color.Transparent;
            this.lblSex.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(488, 204);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(28, 15);
            this.lblSex.TabIndex = 19;
            this.lblSex.Text = "Sex:";
            this.lblSex.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtboxSex
            // 
            this.txtboxSex.Location = new System.Drawing.Point(522, 197);
            this.txtboxSex.Name = "txtboxSex";
            this.txtboxSex.Size = new System.Drawing.Size(94, 22);
            this.txtboxSex.TabIndex = 20;
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.BackColor = System.Drawing.Color.Transparent;
            this.lblProvince.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvince.Location = new System.Drawing.Point(13, 238);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(59, 15);
            this.lblProvince.TabIndex = 21;
            this.lblProvince.Text = "Province:";
            this.lblProvince.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtboxProvince
            // 
            this.txtboxProvince.Location = new System.Drawing.Point(78, 231);
            this.txtboxProvince.Name = "txtboxProvince";
            this.txtboxProvince.Size = new System.Drawing.Size(87, 22);
            this.txtboxProvince.TabIndex = 22;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(171, 238);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(32, 15);
            this.lblCity.TabIndex = 23;
            this.lblCity.Text = "City:";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtboxCity
            // 
            this.txtboxCity.Location = new System.Drawing.Point(209, 231);
            this.txtboxCity.Name = "txtboxCity";
            this.txtboxCity.Size = new System.Drawing.Size(83, 22);
            this.txtboxCity.TabIndex = 24;
            // 
            // txtboxStreetName
            // 
            this.txtboxStreetName.Location = new System.Drawing.Point(381, 231);
            this.txtboxStreetName.Name = "txtboxStreetName";
            this.txtboxStreetName.Size = new System.Drawing.Size(87, 22);
            this.txtboxStreetName.TabIndex = 25;
            // 
            // lblStreetName
            // 
            this.lblStreetName.AutoSize = true;
            this.lblStreetName.BackColor = System.Drawing.Color.Transparent;
            this.lblStreetName.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetName.Location = new System.Drawing.Point(299, 238);
            this.lblStreetName.Name = "lblStreetName";
            this.lblStreetName.Size = new System.Drawing.Size(76, 15);
            this.lblStreetName.TabIndex = 26;
            this.lblStreetName.Text = "Street Name:";
            this.lblStreetName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBarangay
            // 
            this.lblBarangay.AutoSize = true;
            this.lblBarangay.BackColor = System.Drawing.Color.Transparent;
            this.lblBarangay.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarangay.Location = new System.Drawing.Point(474, 238);
            this.lblBarangay.Name = "lblBarangay";
            this.lblBarangay.Size = new System.Drawing.Size(61, 15);
            this.lblBarangay.TabIndex = 27;
            this.lblBarangay.Text = "Barangay:";
            this.lblBarangay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtboxBarangay
            // 
            this.txtboxBarangay.Location = new System.Drawing.Point(541, 234);
            this.txtboxBarangay.Name = "txtboxBarangay";
            this.txtboxBarangay.Size = new System.Drawing.Size(75, 22);
            this.txtboxBarangay.TabIndex = 28;
            // 
            // lblEmailAdd
            // 
            this.lblEmailAdd.AutoSize = true;
            this.lblEmailAdd.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailAdd.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailAdd.Location = new System.Drawing.Point(13, 271);
            this.lblEmailAdd.Name = "lblEmailAdd";
            this.lblEmailAdd.Size = new System.Drawing.Size(90, 15);
            this.lblEmailAdd.TabIndex = 29;
            this.lblEmailAdd.Text = "Email Address:";
            this.lblEmailAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtboxEmailAdd
            // 
            this.txtboxEmailAdd.Location = new System.Drawing.Point(109, 264);
            this.txtboxEmailAdd.Name = "txtboxEmailAdd";
            this.txtboxEmailAdd.Size = new System.Drawing.Size(239, 22);
            this.txtboxEmailAdd.TabIndex = 30;
            // 
            // lblMobileNumber
            // 
            this.lblMobileNumber.AutoSize = true;
            this.lblMobileNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblMobileNumber.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobileNumber.Location = new System.Drawing.Point(363, 271);
            this.lblMobileNumber.Name = "lblMobileNumber";
            this.lblMobileNumber.Size = new System.Drawing.Size(97, 15);
            this.lblMobileNumber.TabIndex = 31;
            this.lblMobileNumber.Text = "Mobile Number:";
            this.lblMobileNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtboxMobileNum
            // 
            this.txtboxMobileNum.Location = new System.Drawing.Point(470, 264);
            this.txtboxMobileNum.Name = "txtboxMobileNum";
            this.txtboxMobileNum.Size = new System.Drawing.Size(146, 22);
            this.txtboxMobileNum.TabIndex = 32;
            // 
            // lblVaccinationDetails
            // 
            this.lblVaccinationDetails.AutoSize = true;
            this.lblVaccinationDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblVaccinationDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVaccinationDetails.Location = new System.Drawing.Point(13, 308);
            this.lblVaccinationDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVaccinationDetails.Name = "lblVaccinationDetails";
            this.lblVaccinationDetails.Size = new System.Drawing.Size(146, 16);
            this.lblVaccinationDetails.TabIndex = 33;
            this.lblVaccinationDetails.Text = "Vaccination Details:";
            // 
            // lblareyouvaccinated
            // 
            this.lblareyouvaccinated.AutoSize = true;
            this.lblareyouvaccinated.BackColor = System.Drawing.Color.Transparent;
            this.lblareyouvaccinated.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblareyouvaccinated.Location = new System.Drawing.Point(13, 336);
            this.lblareyouvaccinated.Name = "lblareyouvaccinated";
            this.lblareyouvaccinated.Size = new System.Drawing.Size(117, 15);
            this.lblareyouvaccinated.TabIndex = 34;
            this.lblareyouvaccinated.Text = "Are you vaccinated?";
            this.lblareyouvaccinated.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblVDInstruction
            // 
            this.lblVDInstruction.AutoSize = true;
            this.lblVDInstruction.BackColor = System.Drawing.Color.Transparent;
            this.lblVDInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVDInstruction.Location = new System.Drawing.Point(161, 310);
            this.lblVDInstruction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVDInstruction.Name = "lblVDInstruction";
            this.lblVDInstruction.Size = new System.Drawing.Size(204, 13);
            this.lblVDInstruction.TabIndex = 35;
            this.lblVDInstruction.Text = "(Answer YES if applicable, otherwise NO.)\r\n";
            // 
            // txtboxAYV
            // 
            this.txtboxAYV.Location = new System.Drawing.Point(16, 354);
            this.txtboxAYV.Name = "txtboxAYV";
            this.txtboxAYV.Size = new System.Drawing.Size(57, 22);
            this.txtboxAYV.TabIndex = 36;
            // 
            // lbl1stDose
            // 
            this.lbl1stDose.AutoSize = true;
            this.lbl1stDose.BackColor = System.Drawing.Color.Transparent;
            this.lbl1stDose.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1stDose.Location = new System.Drawing.Point(161, 336);
            this.lbl1stDose.Name = "lbl1stDose";
            this.lbl1stDose.Size = new System.Drawing.Size(60, 15);
            this.lbl1stDose.TabIndex = 37;
            this.lbl1stDose.Text = "1st Dose?\r\n";
            this.lbl1stDose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtboxFirstDose
            // 
            this.txtboxFirstDose.Location = new System.Drawing.Point(163, 354);
            this.txtboxFirstDose.Name = "txtboxFirstDose";
            this.txtboxFirstDose.Size = new System.Drawing.Size(57, 22);
            this.txtboxFirstDose.TabIndex = 38;
            // 
            // lbl2ndDose
            // 
            this.lbl2ndDose.AutoSize = true;
            this.lbl2ndDose.BackColor = System.Drawing.Color.Transparent;
            this.lbl2ndDose.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2ndDose.Location = new System.Drawing.Point(161, 394);
            this.lbl2ndDose.Name = "lbl2ndDose";
            this.lbl2ndDose.Size = new System.Drawing.Size(64, 15);
            this.lbl2ndDose.TabIndex = 39;
            this.lbl2ndDose.Text = "2nd Dose?\r\n";
            this.lbl2ndDose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtbox2ndDose
            // 
            this.txtbox2ndDose.Location = new System.Drawing.Point(164, 412);
            this.txtbox2ndDose.Name = "txtbox2ndDose";
            this.txtbox2ndDose.Size = new System.Drawing.Size(57, 22);
            this.txtbox2ndDose.TabIndex = 40;
            // 
            // lblBooster
            // 
            this.lblBooster.AutoSize = true;
            this.lblBooster.BackColor = System.Drawing.Color.Transparent;
            this.lblBooster.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooster.Location = new System.Drawing.Point(13, 394);
            this.lblBooster.Name = "lblBooster";
            this.lblBooster.Size = new System.Drawing.Size(82, 15);
            this.lblBooster.TabIndex = 41;
            this.lblBooster.Text = "Booster Shot?";
            this.lblBooster.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtboxBooster
            // 
            this.txtboxBooster.Location = new System.Drawing.Point(16, 412);
            this.txtboxBooster.Name = "txtboxBooster";
            this.txtboxBooster.Size = new System.Drawing.Size(57, 22);
            this.txtboxBooster.TabIndex = 42;
            // 
            // bttnSubmit
            // 
            this.bttnSubmit.BackColor = System.Drawing.Color.RosyBrown;
            this.bttnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSubmit.Location = new System.Drawing.Point(271, 344);
            this.bttnSubmit.Name = "bttnSubmit";
            this.bttnSubmit.Size = new System.Drawing.Size(77, 32);
            this.bttnSubmit.TabIndex = 43;
            this.bttnSubmit.Text = "Submit";
            this.bttnSubmit.UseVisualStyleBackColor = false;
            this.bttnSubmit.Click += new System.EventHandler(this.bttnSubmit_Click);
            // 
            // lblInstruction1
            // 
            this.lblInstruction1.AutoSize = true;
            this.lblInstruction1.BackColor = System.Drawing.Color.Transparent;
            this.lblInstruction1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction1.Location = new System.Drawing.Point(175, 138);
            this.lblInstruction1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstruction1.Name = "lblInstruction1";
            this.lblInstruction1.Size = new System.Drawing.Size(124, 13);
            this.lblInstruction1.TabIndex = 44;
            this.lblInstruction1.Text = "(Put NA if not applicable)\r\n";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.BackColor = System.Drawing.Color.Transparent;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAdmin.Location = new System.Drawing.Point(416, 310);
            this.lblAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(99, 32);
            this.lblAdmin.TabIndex = 45;
            this.lblAdmin.Text = "For admin only:\r\n\r\n";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(416, 374);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(64, 15);
            this.lblPassword.TabIndex = 48;
            this.lblPassword.Text = "Password:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Location = new System.Drawing.Point(486, 367);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.Size = new System.Drawing.Size(125, 22);
            this.txtboxPassword.TabIndex = 49;
            // 
            // bttnAdminSignIn
            // 
            this.bttnAdminSignIn.BackColor = System.Drawing.Color.DimGray;
            this.bttnAdminSignIn.Location = new System.Drawing.Point(536, 412);
            this.bttnAdminSignIn.Name = "bttnAdminSignIn";
            this.bttnAdminSignIn.Size = new System.Drawing.Size(75, 32);
            this.bttnAdminSignIn.TabIndex = 50;
            this.bttnAdminSignIn.Text = "Sign In";
            this.bttnAdminSignIn.UseVisualStyleBackColor = false;
            this.bttnAdminSignIn.Click += new System.EventHandler(this.bttnAdminSignIn_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(416, 340);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(65, 15);
            this.lblUsername.TabIndex = 46;
            this.lblUsername.Text = "Username:";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.Location = new System.Drawing.Point(491, 332);
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.Size = new System.Drawing.Size(125, 22);
            this.txtboxUsername.TabIndex = 47;
            // 
            // bttnGenerate
            // 
            this.bttnGenerate.BackColor = System.Drawing.Color.Salmon;
            this.bttnGenerate.Location = new System.Drawing.Point(247, 385);
            this.bttnGenerate.Name = "bttnGenerate";
            this.bttnGenerate.Size = new System.Drawing.Size(153, 32);
            this.bttnGenerate.TabIndex = 51;
            this.bttnGenerate.Text = "Generate Qr Code";
            this.bttnGenerate.UseVisualStyleBackColor = false;
            this.bttnGenerate.Click += new System.EventHandler(this.bttnGenerate_Click_1);
            // 
            // bttnScan
            // 
            this.bttnScan.BackColor = System.Drawing.Color.Salmon;
            this.bttnScan.Location = new System.Drawing.Point(247, 431);
            this.bttnScan.Name = "bttnScan";
            this.bttnScan.Size = new System.Drawing.Size(153, 32);
            this.bttnScan.TabIndex = 52;
            this.bttnScan.Text = "Scan Qr Code";
            this.bttnScan.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(676, 475);
            this.Controls.Add(this.bttnScan);
            this.Controls.Add(this.bttnGenerate);
            this.Controls.Add(this.bttnAdminSignIn);
            this.Controls.Add(this.txtboxPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtboxUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.lblInstruction1);
            this.Controls.Add(this.bttnSubmit);
            this.Controls.Add(this.txtboxBooster);
            this.Controls.Add(this.lblBooster);
            this.Controls.Add(this.txtbox2ndDose);
            this.Controls.Add(this.lbl2ndDose);
            this.Controls.Add(this.txtboxFirstDose);
            this.Controls.Add(this.lbl1stDose);
            this.Controls.Add(this.txtboxAYV);
            this.Controls.Add(this.lblVDInstruction);
            this.Controls.Add(this.lblareyouvaccinated);
            this.Controls.Add(this.lblVaccinationDetails);
            this.Controls.Add(this.txtboxMobileNum);
            this.Controls.Add(this.lblMobileNumber);
            this.Controls.Add(this.txtboxEmailAdd);
            this.Controls.Add(this.lblEmailAdd);
            this.Controls.Add(this.txtboxBarangay);
            this.Controls.Add(this.lblBarangay);
            this.Controls.Add(this.lblStreetName);
            this.Controls.Add(this.txtboxStreetName);
            this.Controls.Add(this.txtboxCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtboxProvince);
            this.Controls.Add(this.lblProvince);
            this.Controls.Add(this.txtboxSex);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.txtboxAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtboxBirthdate);
            this.Controls.Add(this.lblBirthdate);
            this.Controls.Add(this.txtboxSuffix);
            this.Controls.Add(this.txtboxSurname);
            this.Controls.Add(this.lblSuffix);
            this.Controls.Add(this.lblSN);
            this.Controls.Add(this.txtboxMiddleInitial);
            this.Controls.Add(this.lblMI);
            this.Controls.Add(this.txtboxFirstName);
            this.Controls.Add(this.lblFN);
            this.Controls.Add(this.lblPersonalInfo);
            this.Controls.Add(this.txtboxTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtboxDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblTitle);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Tracing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtboxDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtboxTime;
        private System.Windows.Forms.Label lblPersonalInfo;
        private System.Windows.Forms.Label lblFN;
        private System.Windows.Forms.TextBox txtboxFirstName;
        private System.Windows.Forms.Label lblMI;
        private System.Windows.Forms.TextBox txtboxMiddleInitial;
        private System.Windows.Forms.Label lblSN;
        private System.Windows.Forms.Label lblSuffix;
        private System.Windows.Forms.TextBox txtboxSurname;
        private System.Windows.Forms.TextBox txtboxSuffix;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.TextBox txtboxBirthdate;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtboxAge;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.TextBox txtboxSex;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.TextBox txtboxProvince;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtboxCity;
        private System.Windows.Forms.TextBox txtboxStreetName;
        private System.Windows.Forms.Label lblStreetName;
        private System.Windows.Forms.Label lblBarangay;
        private System.Windows.Forms.TextBox txtboxBarangay;
        private System.Windows.Forms.Label lblEmailAdd;
        private System.Windows.Forms.TextBox txtboxEmailAdd;
        private System.Windows.Forms.Label lblMobileNumber;
        private System.Windows.Forms.TextBox txtboxMobileNum;
        private System.Windows.Forms.Label lblVaccinationDetails;
        private System.Windows.Forms.Label lblareyouvaccinated;
        private System.Windows.Forms.Label lblVDInstruction;
        private System.Windows.Forms.TextBox txtboxAYV;
        private System.Windows.Forms.Label lbl1stDose;
        private System.Windows.Forms.TextBox txtboxFirstDose;
        private System.Windows.Forms.Label lbl2ndDose;
        private System.Windows.Forms.TextBox txtbox2ndDose;
        private System.Windows.Forms.Label lblBooster;
        private System.Windows.Forms.TextBox txtboxBooster;
        private System.Windows.Forms.Button bttnSubmit;
        private System.Windows.Forms.Label lblInstruction1;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtboxPassword;
        private System.Windows.Forms.Button bttnAdminSignIn;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtboxUsername;
        private System.Windows.Forms.Button bttnGenerate;
        private System.Windows.Forms.Button bttnScan;
    }
}

