namespace HMS.GUI.Forms.ReportsForm
{
    partial class UpdateBookingForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbGuestPassaportNo = new System.Windows.Forms.MaskedTextBox();
            this.cbGuestNationality = new System.Windows.Forms.ComboBox();
            this.tbGuestEmail = new System.Windows.Forms.TextBox();
            this.tbGuestTelNo = new System.Windows.Forms.MaskedTextBox();
            this.tbGuestLastName = new System.Windows.Forms.TextBox();
            this.tbGuestName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnUpdateBooking = new System.Windows.Forms.Button();
            this.dtpCout = new System.Windows.Forms.DateTimePicker();
            this.dtpCin = new System.Windows.Forms.DateTimePicker();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbTotalNight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(78)))));
            this.label7.Location = new System.Drawing.Point(513, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(246, 29);
            this.label7.TabIndex = 63;
            this.label7.Text = "Booking Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(78)))));
            this.label1.Location = new System.Drawing.Point(106, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 29);
            this.label1.TabIndex = 62;
            this.label1.Text = "Guest Information";
            // 
            // tbGuestPassaportNo
            // 
            this.tbGuestPassaportNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(78)))));
            this.tbGuestPassaportNo.ForeColor = System.Drawing.Color.White;
            this.tbGuestPassaportNo.Location = new System.Drawing.Point(178, 278);
            this.tbGuestPassaportNo.Mask = "0000000";
            this.tbGuestPassaportNo.Name = "tbGuestPassaportNo";
            this.tbGuestPassaportNo.Size = new System.Drawing.Size(200, 29);
            this.tbGuestPassaportNo.TabIndex = 61;
            this.tbGuestPassaportNo.ValidatingType = typeof(int);
            // 
            // cbGuestNationality
            // 
            this.cbGuestNationality.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbGuestNationality.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbGuestNationality.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(78)))));
            this.cbGuestNationality.ForeColor = System.Drawing.Color.White;
            this.cbGuestNationality.FormattingEnabled = true;
            this.cbGuestNationality.Items.AddRange(new object[] {
            "Select Nationality",
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Cabo Verde",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Central African Republic",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo (Brazzaville)",
            "Congo (Kinshasa)",
            "Costa Rica",
            "Cote d\'Ivoire",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czechia",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Honduras",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Kosovo",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macedonia (FYROM)",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Mauritania",
            "Mauritius",
            "Mexico",
            "Micronesia",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Myanmar (Burma)",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "North Korea",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Palestine",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Romania",
            "Russia",
            "Rwanda",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Vincent and the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome and Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "South Korea",
            "South Sudan",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Swaziland",
            "Sweden",
            "Switzerland",
            "Syria",
            "Taiwan",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Timor-Leste (East Timor)",
            "Togo",
            "Tonga",
            "Trinidad and Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates (UAE)",
            "United Kingdom (UK)",
            "United States of America (USA)",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu"});
            this.cbGuestNationality.Location = new System.Drawing.Point(178, 234);
            this.cbGuestNationality.Name = "cbGuestNationality";
            this.cbGuestNationality.Size = new System.Drawing.Size(200, 32);
            this.cbGuestNationality.TabIndex = 60;
            // 
            // tbGuestEmail
            // 
            this.tbGuestEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(78)))));
            this.tbGuestEmail.ForeColor = System.Drawing.Color.White;
            this.tbGuestEmail.Location = new System.Drawing.Point(178, 196);
            this.tbGuestEmail.Name = "tbGuestEmail";
            this.tbGuestEmail.Size = new System.Drawing.Size(200, 29);
            this.tbGuestEmail.TabIndex = 59;
            // 
            // tbGuestTelNo
            // 
            this.tbGuestTelNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(78)))));
            this.tbGuestTelNo.ForeColor = System.Drawing.Color.White;
            this.tbGuestTelNo.Location = new System.Drawing.Point(178, 156);
            this.tbGuestTelNo.Mask = "(999) 000-0000";
            this.tbGuestTelNo.Name = "tbGuestTelNo";
            this.tbGuestTelNo.Size = new System.Drawing.Size(200, 29);
            this.tbGuestTelNo.TabIndex = 58;
            // 
            // tbGuestLastName
            // 
            this.tbGuestLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(78)))));
            this.tbGuestLastName.ForeColor = System.Drawing.Color.White;
            this.tbGuestLastName.Location = new System.Drawing.Point(178, 115);
            this.tbGuestLastName.Name = "tbGuestLastName";
            this.tbGuestLastName.Size = new System.Drawing.Size(200, 29);
            this.tbGuestLastName.TabIndex = 57;
            // 
            // tbGuestName
            // 
            this.tbGuestName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(78)))));
            this.tbGuestName.ForeColor = System.Drawing.Color.White;
            this.tbGuestName.Location = new System.Drawing.Point(178, 73);
            this.tbGuestName.Name = "tbGuestName";
            this.tbGuestName.Size = new System.Drawing.Size(200, 29);
            this.tbGuestName.TabIndex = 56;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(78)))));
            this.label11.Location = new System.Drawing.Point(28, 278);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 24);
            this.label11.TabIndex = 55;
            this.label11.Text = "Passaport No";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(78)))));
            this.label12.Location = new System.Drawing.Point(28, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 24);
            this.label12.TabIndex = 54;
            this.label12.Text = "Nationality";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(78)))));
            this.label13.Location = new System.Drawing.Point(28, 198);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 24);
            this.label13.TabIndex = 53;
            this.label13.Text = "E-mail";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(78)))));
            this.label14.Location = new System.Drawing.Point(28, 158);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 24);
            this.label14.TabIndex = 52;
            this.label14.Text = "Tel-No";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(78)))));
            this.label15.Location = new System.Drawing.Point(28, 117);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 24);
            this.label15.TabIndex = 51;
            this.label15.Text = "Last Name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(78)))));
            this.label16.Location = new System.Drawing.Point(28, 75);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 24);
            this.label16.TabIndex = 50;
            this.label16.Text = "Name";
            // 
            // btnUpdateBooking
            // 
            this.btnUpdateBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(78)))));
            this.btnUpdateBooking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateBooking.ForeColor = System.Drawing.Color.White;
            this.btnUpdateBooking.Location = new System.Drawing.Point(270, 335);
            this.btnUpdateBooking.Name = "btnUpdateBooking";
            this.btnUpdateBooking.Size = new System.Drawing.Size(309, 53);
            this.btnUpdateBooking.TabIndex = 49;
            this.btnUpdateBooking.Text = "Update Booking";
            this.btnUpdateBooking.UseVisualStyleBackColor = false;
            this.btnUpdateBooking.Click += new System.EventHandler(this.btnUpdateBooking_Click);
            // 
            // dtpCout
            // 
            this.dtpCout.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(78)))));
            this.dtpCout.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(78)))));
            this.dtpCout.Location = new System.Drawing.Point(580, 115);
            this.dtpCout.Name = "dtpCout";
            this.dtpCout.Size = new System.Drawing.Size(200, 29);
            this.dtpCout.TabIndex = 48;
            // 
            // dtpCin
            // 
            this.dtpCin.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(78)))));
            this.dtpCin.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(78)))));
            this.dtpCin.Location = new System.Drawing.Point(580, 75);
            this.dtpCin.Name = "dtpCin";
            this.dtpCin.Size = new System.Drawing.Size(200, 29);
            this.dtpCin.TabIndex = 47;
            // 
            // tbPrice
            // 
            this.tbPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(78)))));
            this.tbPrice.ForeColor = System.Drawing.Color.White;
            this.tbPrice.Location = new System.Drawing.Point(580, 195);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(200, 29);
            this.tbPrice.TabIndex = 45;
            // 
            // tbTotalNight
            // 
            this.tbTotalNight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(78)))));
            this.tbTotalNight.ForeColor = System.Drawing.Color.White;
            this.tbTotalNight.Location = new System.Drawing.Point(580, 155);
            this.tbTotalNight.Name = "tbTotalNight";
            this.tbTotalNight.Size = new System.Drawing.Size(200, 29);
            this.tbTotalNight.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(78)))));
            this.label6.Location = new System.Drawing.Point(430, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 24);
            this.label6.TabIndex = 43;
            this.label6.Text = "Daily Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(78)))));
            this.label5.Location = new System.Drawing.Point(430, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 24);
            this.label5.TabIndex = 42;
            this.label5.Text = "Total Night";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(78)))));
            this.label4.Location = new System.Drawing.Point(430, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 24);
            this.label4.TabIndex = 41;
            this.label4.Text = "Check-Out";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(78)))));
            this.label3.Location = new System.Drawing.Point(430, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 40;
            this.label3.Text = "Check-In";
            // 
            // UpdateBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 422);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbGuestPassaportNo);
            this.Controls.Add(this.cbGuestNationality);
            this.Controls.Add(this.tbGuestEmail);
            this.Controls.Add(this.tbGuestTelNo);
            this.Controls.Add(this.tbGuestLastName);
            this.Controls.Add(this.tbGuestName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnUpdateBooking);
            this.Controls.Add(this.dtpCout);
            this.Controls.Add(this.dtpCin);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbTotalNight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateBookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateBookingForm";
            this.Load += new System.EventHandler(this.UpdateBookingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnUpdateBooking;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox tbGuestPassaportNo;
        private System.Windows.Forms.ComboBox cbGuestNationality;
        private System.Windows.Forms.TextBox tbGuestEmail;
        private System.Windows.Forms.MaskedTextBox tbGuestTelNo;
        private System.Windows.Forms.TextBox tbGuestLastName;
        private System.Windows.Forms.TextBox tbGuestName;
        private System.Windows.Forms.DateTimePicker dtpCout;
        private System.Windows.Forms.DateTimePicker dtpCin;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbTotalNight;
    }
}