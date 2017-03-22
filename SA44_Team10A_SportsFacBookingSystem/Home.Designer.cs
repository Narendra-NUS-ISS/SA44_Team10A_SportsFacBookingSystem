namespace SA44_Team10A_SportsFacBookingSystem
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.tabControl_Home = new System.Windows.Forms.TabControl();
            this.tabPage_Home = new System.Windows.Forms.TabPage();
            this.tabPage_Mmembers = new System.Windows.Forms.TabPage();
            this.tabPage_Mfacility = new System.Windows.Forms.TabPage();
            this.tabPage_Booking = new System.Windows.Forms.TabPage();
            this.groupBox_Facilityinfo = new System.Windows.Forms.GroupBox();
            this.dataGridView_Facilities = new System.Windows.Forms.DataGridView();
            this.grpBox_booking = new System.Windows.Forms.GroupBox();
            this.button_SearchFacility = new System.Windows.Forms.Button();
            this.label_Date = new System.Windows.Forms.Label();
            this.dateTimePicker_Facility = new System.Windows.Forms.DateTimePicker();
            this.combo_FacilityName = new System.Windows.Forms.ComboBox();
            this.labelFacility = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_Heading = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip_Home = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Legend = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl_Home.SuspendLayout();
            this.tabPage_Booking.SuspendLayout();
            this.groupBox_Facilityinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Facilities)).BeginInit();
            this.grpBox_booking.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip_Home.SuspendLayout();
            this.Legend.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Home
            // 
            this.tabControl_Home.Controls.Add(this.tabPage_Home);
            this.tabControl_Home.Controls.Add(this.tabPage_Mmembers);
            this.tabControl_Home.Controls.Add(this.tabPage_Mfacility);
            this.tabControl_Home.Controls.Add(this.tabPage_Booking);
            this.tabControl_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_Home.Location = new System.Drawing.Point(3, 64);
            this.tabControl_Home.Name = "tabControl_Home";
            this.tabControl_Home.SelectedIndex = 0;
            this.tabControl_Home.Size = new System.Drawing.Size(782, 472);
            this.tabControl_Home.TabIndex = 7;
            this.tabControl_Home.Click += new System.EventHandler(this.HomeLoadEvent);
            // 
            // tabPage_Home
            // 
            this.tabPage_Home.Location = new System.Drawing.Point(4, 29);
            this.tabPage_Home.Name = "tabPage_Home";
            this.tabPage_Home.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Home.Size = new System.Drawing.Size(774, 439);
            this.tabPage_Home.TabIndex = 0;
            this.tabPage_Home.Text = "Home";
            this.tabPage_Home.UseVisualStyleBackColor = true;
            this.tabPage_Home.Click += new System.EventHandler(this.HomeLoadEvent);
            // 
            // tabPage_Mmembers
            // 
            this.tabPage_Mmembers.Location = new System.Drawing.Point(4, 29);
            this.tabPage_Mmembers.Name = "tabPage_Mmembers";
            this.tabPage_Mmembers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Mmembers.Size = new System.Drawing.Size(774, 439);
            this.tabPage_Mmembers.TabIndex = 1;
            this.tabPage_Mmembers.Text = "Manage Members";
            this.tabPage_Mmembers.UseVisualStyleBackColor = true;
            this.tabPage_Mmembers.Click += new System.EventHandler(this.ManageMembersLoadEventHandler);
            // 
            // tabPage_Mfacility
            // 
            this.tabPage_Mfacility.Location = new System.Drawing.Point(4, 29);
            this.tabPage_Mfacility.Name = "tabPage_Mfacility";
            this.tabPage_Mfacility.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Mfacility.Size = new System.Drawing.Size(774, 439);
            this.tabPage_Mfacility.TabIndex = 2;
            this.tabPage_Mfacility.Text = "Manage Facility";
            this.tabPage_Mfacility.UseVisualStyleBackColor = true;
            this.tabPage_Mfacility.Click += new System.EventHandler(this.ManageFacilityLoadEventHandler);
            // 
            // tabPage_Booking
            // 
            this.tabPage_Booking.Controls.Add(this.groupBox_Facilityinfo);
            this.tabPage_Booking.Controls.Add(this.grpBox_booking);
            this.tabPage_Booking.Location = new System.Drawing.Point(4, 29);
            this.tabPage_Booking.Name = "tabPage_Booking";
            this.tabPage_Booking.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Booking.Size = new System.Drawing.Size(774, 439);
            this.tabPage_Booking.TabIndex = 3;
            this.tabPage_Booking.Text = "Booking/Cancellation";
            this.tabPage_Booking.UseVisualStyleBackColor = true;
            this.tabPage_Booking.Click += new System.EventHandler(this.ManageBookingEventHandler);
            this.tabPage_Booking.Enter += new System.EventHandler(this.ManageBookingEventHandler);
            // 
            // groupBox_Facilityinfo
            // 
            this.groupBox_Facilityinfo.Controls.Add(this.Legend);
            this.groupBox_Facilityinfo.Controls.Add(this.dataGridView_Facilities);
            this.groupBox_Facilityinfo.Location = new System.Drawing.Point(6, 113);
            this.groupBox_Facilityinfo.Name = "groupBox_Facilityinfo";
            this.groupBox_Facilityinfo.Size = new System.Drawing.Size(750, 320);
            this.groupBox_Facilityinfo.TabIndex = 1;
            this.groupBox_Facilityinfo.TabStop = false;
            this.groupBox_Facilityinfo.Text = "Facilities Availability";
            // 
            // dataGridView_Facilities
            // 
            this.dataGridView_Facilities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Facilities.Location = new System.Drawing.Point(9, 42);
            this.dataGridView_Facilities.Name = "dataGridView_Facilities";
            this.dataGridView_Facilities.Size = new System.Drawing.Size(724, 208);
            this.dataGridView_Facilities.TabIndex = 0;
            this.dataGridView_Facilities.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GetSlotDetailsEventHandler);
            // 
            // grpBox_booking
            // 
            this.grpBox_booking.Controls.Add(this.button_SearchFacility);
            this.grpBox_booking.Controls.Add(this.label_Date);
            this.grpBox_booking.Controls.Add(this.dateTimePicker_Facility);
            this.grpBox_booking.Controls.Add(this.combo_FacilityName);
            this.grpBox_booking.Controls.Add(this.labelFacility);
            this.grpBox_booking.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_booking.Location = new System.Drawing.Point(6, 31);
            this.grpBox_booking.Name = "grpBox_booking";
            this.grpBox_booking.Size = new System.Drawing.Size(750, 76);
            this.grpBox_booking.TabIndex = 0;
            this.grpBox_booking.TabStop = false;
            this.grpBox_booking.Text = "Search Facilities Availability";
            // 
            // button_SearchFacility
            // 
            this.button_SearchFacility.BackColor = System.Drawing.Color.SteelBlue;
            this.button_SearchFacility.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SearchFacility.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_SearchFacility.Location = new System.Drawing.Point(635, 27);
            this.button_SearchFacility.Name = "button_SearchFacility";
            this.button_SearchFacility.Size = new System.Drawing.Size(98, 33);
            this.button_SearchFacility.TabIndex = 5;
            this.button_SearchFacility.Text = "Search";
            this.button_SearchFacility.UseVisualStyleBackColor = false;
            this.button_SearchFacility.Click += new System.EventHandler(this.SearchFacilityEventHandler);
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Date.Location = new System.Drawing.Point(334, 33);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(38, 17);
            this.label_Date.TabIndex = 4;
            this.label_Date.Text = "Date";
            // 
            // dateTimePicker_Facility
            // 
            this.dateTimePicker_Facility.Location = new System.Drawing.Point(384, 31);
            this.dateTimePicker_Facility.Name = "dateTimePicker_Facility";
            this.dateTimePicker_Facility.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker_Facility.TabIndex = 3;
            // 
            // combo_FacilityName
            // 
            this.combo_FacilityName.FormattingEnabled = true;
            this.combo_FacilityName.Location = new System.Drawing.Point(81, 31);
            this.combo_FacilityName.Name = "combo_FacilityName";
            this.combo_FacilityName.Size = new System.Drawing.Size(237, 26);
            this.combo_FacilityName.TabIndex = 2;
            // 
            // labelFacility
            // 
            this.labelFacility.AutoSize = true;
            this.labelFacility.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFacility.Location = new System.Drawing.Point(6, 36);
            this.labelFacility.Name = "labelFacility";
            this.labelFacility.Size = new System.Drawing.Size(51, 17);
            this.labelFacility.TabIndex = 1;
            this.labelFacility.Text = "Facility";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.SteelBlue;
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(782, 67);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.SteelBlue;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.705883F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.29412F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 319F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 249F));
            this.tableLayoutPanel1.Controls.Add(this.label_Heading, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.56522F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.43478F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(779, 55);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label_Heading
            // 
            this.label_Heading.AutoSize = true;
            this.label_Heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Heading.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_Heading.Location = new System.Drawing.Point(203, 10);
            this.label_Heading.Name = "label_Heading";
            this.label_Heading.Size = new System.Drawing.Size(265, 24);
            this.label_Heading.TabIndex = 0;
            this.label_Heading.Text = "Sports Facility Booking System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip_Home
            // 
            this.statusStrip_Home.BackColor = System.Drawing.Color.SteelBlue;
            this.statusStrip_Home.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar,
            this.statusLabel});
            this.statusStrip_Home.Location = new System.Drawing.Point(0, 539);
            this.statusStrip_Home.Name = "statusStrip_Home";
            this.statusStrip_Home.Size = new System.Drawing.Size(784, 22);
            this.statusStrip_Home.TabIndex = 9;
            this.statusStrip_Home.Text = "statusStrip2";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // statusLabel
            // 
            this.statusLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // Legend
            // 
            this.Legend.Controls.Add(this.label2);
            this.Legend.Controls.Add(this.label1);
            this.Legend.Controls.Add(this.button2);
            this.Legend.Controls.Add(this.button1);
            this.Legend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Legend.Location = new System.Drawing.Point(9, 256);
            this.Legend.Name = "Legend";
            this.Legend.Size = new System.Drawing.Size(724, 58);
            this.Legend.TabIndex = 1;
            this.Legend.TabStop = false;
            this.Legend.Text = "Legend";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Location = new System.Drawing.Point(19, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 24);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(328, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 24);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Available for booking";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Booked and available for cancellation";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.statusStrip_Home);
            this.Controls.Add(this.tabControl_Home);
            this.Controls.Add(this.flowLayoutPanel1);
            this.IsMdiContainer = true;
            this.Name = "Home";
            this.Text = "Sports Facility Booking Centre";
            this.Load += new System.EventHandler(this.Home_Load);
            this.tabControl_Home.ResumeLayout(false);
            this.tabPage_Booking.ResumeLayout(false);
            this.groupBox_Facilityinfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Facilities)).EndInit();
            this.grpBox_booking.ResumeLayout(false);
            this.grpBox_booking.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip_Home.ResumeLayout(false);
            this.statusStrip_Home.PerformLayout();
            this.Legend.ResumeLayout(false);
            this.Legend.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.TabControl tabControl_Home;
        private System.Windows.Forms.TabPage tabPage_Home;
        private System.Windows.Forms.TabPage tabPage_Mmembers;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabPage tabPage_Mfacility;
        private System.Windows.Forms.TabPage tabPage_Booking;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_Heading;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip_Home;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.GroupBox grpBox_booking;
        private System.Windows.Forms.ComboBox combo_FacilityName;
        private System.Windows.Forms.Label labelFacility;
        private System.Windows.Forms.Button button_SearchFacility;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Facility;
        private System.Windows.Forms.GroupBox groupBox_Facilityinfo;
        private System.Windows.Forms.GroupBox Legend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView_Facilities;
    }
}



