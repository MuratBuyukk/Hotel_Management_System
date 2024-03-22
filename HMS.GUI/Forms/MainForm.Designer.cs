namespace HMS.GUI.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnDepartedList = new System.Windows.Forms.Button();
            this.btnAccomadationList = new System.Windows.Forms.Button();
            this.btnRezervationList = new System.Windows.Forms.Button();
            this.btnCreateBooking = new System.Windows.Forms.Button();
            this.btnRooms = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelFormName = new System.Windows.Forms.Label();
            this.bntMainPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(116)))), ((int)(((byte)(155)))));
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.btnUser);
            this.panel1.Controls.Add(this.btnDepartedList);
            this.panel1.Controls.Add(this.btnAccomadationList);
            this.panel1.Controls.Add(this.btnRezervationList);
            this.panel1.Controls.Add(this.btnCreateBooking);
            this.panel1.Controls.Add(this.btnRooms);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 661);
            this.panel1.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(0, 590);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(220, 70);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "    Log-Out";
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 520);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(220, 70);
            this.btnDashboard.TabIndex = 7;
            this.btnDashboard.Text = "    Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnUser
            // 
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUser.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(0, 450);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(220, 70);
            this.btnUser.TabIndex = 6;
            this.btnUser.Text = "    Users";
            this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnDepartedList
            // 
            this.btnDepartedList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDepartedList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartedList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepartedList.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDepartedList.Image = ((System.Drawing.Image)(resources.GetObject("btnDepartedList.Image")));
            this.btnDepartedList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartedList.Location = new System.Drawing.Point(0, 380);
            this.btnDepartedList.Name = "btnDepartedList";
            this.btnDepartedList.Size = new System.Drawing.Size(220, 70);
            this.btnDepartedList.TabIndex = 5;
            this.btnDepartedList.Text = "    Departed";
            this.btnDepartedList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDepartedList.UseVisualStyleBackColor = true;
            this.btnDepartedList.Click += new System.EventHandler(this.btnDepartedList_Click);
            // 
            // btnAccomadationList
            // 
            this.btnAccomadationList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccomadationList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccomadationList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAccomadationList.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAccomadationList.Image = ((System.Drawing.Image)(resources.GetObject("btnAccomadationList.Image")));
            this.btnAccomadationList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccomadationList.Location = new System.Drawing.Point(0, 310);
            this.btnAccomadationList.Name = "btnAccomadationList";
            this.btnAccomadationList.Size = new System.Drawing.Size(220, 70);
            this.btnAccomadationList.TabIndex = 4;
            this.btnAccomadationList.Text = "    Accomadation";
            this.btnAccomadationList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccomadationList.UseVisualStyleBackColor = true;
            this.btnAccomadationList.Click += new System.EventHandler(this.btnAccomadationList_Click);
            // 
            // btnRezervationList
            // 
            this.btnRezervationList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRezervationList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRezervationList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRezervationList.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRezervationList.Image = ((System.Drawing.Image)(resources.GetObject("btnRezervationList.Image")));
            this.btnRezervationList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRezervationList.Location = new System.Drawing.Point(0, 240);
            this.btnRezervationList.Name = "btnRezervationList";
            this.btnRezervationList.Size = new System.Drawing.Size(220, 70);
            this.btnRezervationList.TabIndex = 3;
            this.btnRezervationList.Text = "    Rezervation List";
            this.btnRezervationList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRezervationList.UseVisualStyleBackColor = true;
            this.btnRezervationList.Click += new System.EventHandler(this.btnRezervationList_Click);
            // 
            // btnCreateBooking
            // 
            this.btnCreateBooking.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreateBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateBooking.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCreateBooking.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateBooking.Image")));
            this.btnCreateBooking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateBooking.Location = new System.Drawing.Point(0, 170);
            this.btnCreateBooking.Name = "btnCreateBooking";
            this.btnCreateBooking.Size = new System.Drawing.Size(220, 70);
            this.btnCreateBooking.TabIndex = 2;
            this.btnCreateBooking.Text = "    Create Booking";
            this.btnCreateBooking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreateBooking.UseVisualStyleBackColor = true;
            this.btnCreateBooking.Click += new System.EventHandler(this.btnCreateBooking_Click);
            // 
            // btnRooms
            // 
            this.btnRooms.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRooms.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRooms.Image = ((System.Drawing.Image)(resources.GetObject("btnRooms.Image")));
            this.btnRooms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRooms.Location = new System.Drawing.Point(0, 100);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(220, 70);
            this.btnRooms.TabIndex = 1;
            this.btnRooms.Text = "    Rooms";
            this.btnRooms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRooms.UseVisualStyleBackColor = true;
            this.btnRooms.Click += new System.EventHandler(this.btnRooms_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(78)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 100);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(116)))), ((int)(((byte)(155)))));
            this.panelTop.Controls.Add(this.labelUserName);
            this.panelTop.Controls.Add(this.labelFormName);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(220, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1039, 100);
            this.panelTop.TabIndex = 1;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUserName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelUserName.Location = new System.Drawing.Point(858, 63);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(140, 24);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "Welcome: User";
            // 
            // labelFormName
            // 
            this.labelFormName.AutoSize = true;
            this.labelFormName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFormName.ForeColor = System.Drawing.Color.White;
            this.labelFormName.Location = new System.Drawing.Point(68, 32);
            this.labelFormName.Name = "labelFormName";
            this.labelFormName.Size = new System.Drawing.Size(197, 37);
            this.labelFormName.TabIndex = 0;
            this.labelFormName.Text = "Form Name";
            // 
            // bntMainPanel
            // 
            this.bntMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bntMainPanel.Location = new System.Drawing.Point(220, 100);
            this.bntMainPanel.Name = "bntMainPanel";
            this.bntMainPanel.Size = new System.Drawing.Size(1039, 561);
            this.bntMainPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 661);
            this.Controls.Add(this.bntMainPanel);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HMS-CONTROL PANEL";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRooms;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnDepartedList;
        private System.Windows.Forms.Button btnAccomadationList;
        private System.Windows.Forms.Button btnRezervationList;
        private System.Windows.Forms.Button btnCreateBooking;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelFormName;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Panel bntMainPanel;
    }
}