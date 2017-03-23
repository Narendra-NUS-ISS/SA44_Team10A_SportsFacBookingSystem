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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl_Home = new System.Windows.Forms.TabControl();
            this.tabPage_Home = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.lblHomeUserName = new System.Windows.Forms.Label();
            this.lblHomeWelcome = new System.Windows.Forms.Label();
            this.tabPage_Mmembers = new System.Windows.Forms.TabPage();
            this.lblMmSearch = new System.Windows.Forms.Label();
            this.dataGridMmViewMembers = new System.Windows.Forms.DataGridView();
            this.btnMmSearchMembers = new System.Windows.Forms.Button();
            this.lblSearchError = new System.Windows.Forms.Label();
            this.txtMmSearchMembers = new System.Windows.Forms.TextBox();
            this.btnMmRegisterMember = new System.Windows.Forms.Button();
            this.tabPage_Mfacility = new System.Windows.Forms.TabPage();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridFacility = new System.Windows.Forms.DataGridView();
            this.txtSearchFacility = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnRegisterFacility = new System.Windows.Forms.Button();
            this.tabPage_Booking = new System.Windows.Forms.TabPage();
            this.groupBox_Facilityinfo = new System.Windows.Forms.GroupBox();
            this.Note = new System.Windows.Forms.Label();
            this.Legend = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView_Facilities = new System.Windows.Forms.DataGridView();
            this.grpBox_booking = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_SearchFacility = new System.Windows.Forms.Button();
            this.label_Date = new System.Windows.Forms.Label();
            this.dateTimePicker_Facility = new System.Windows.Forms.DateTimePicker();
            this.combo_FacilityName = new System.Windows.Forms.ComboBox();
            this.labelFacility = new System.Windows.Forms.Label();
            this.label_Heading = new System.Windows.Forms.Label();
            this.statusStrip_Home = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.SignOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl_Home.SuspendLayout();
            this.tabPage_Home.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage_Mmembers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMmViewMembers)).BeginInit();
            this.tabPage_Mfacility.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFacility)).BeginInit();
            this.tabPage_Booking.SuspendLayout();
            this.groupBox_Facilityinfo.SuspendLayout();
            this.Legend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Facilities)).BeginInit();
            this.grpBox_booking.SuspendLayout();
            this.statusStrip_Home.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_Home
            // 
            this.tabControl_Home.Controls.Add(this.tabPage_Home);
            this.tabControl_Home.Controls.Add(this.tabPage_Mmembers);
            this.tabControl_Home.Controls.Add(this.tabPage_Mfacility);
            this.tabControl_Home.Controls.Add(this.tabPage_Booking);
            this.tabControl_Home.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_Home.Location = new System.Drawing.Point(3, 64);
            this.tabControl_Home.Name = "tabControl_Home";
            this.tabControl_Home.SelectedIndex = 0;
            this.tabControl_Home.Size = new System.Drawing.Size(782, 472);
            this.tabControl_Home.TabIndex = 7;
            this.tabControl_Home.SelectedIndexChanged += new System.EventHandler(this.tabControl_Home_SelectedIndexChanged);
            this.tabControl_Home.Click += new System.EventHandler(this.HomeLoadEvent);
            // 
            // tabPage_Home
            // 
            this.tabPage_Home.Controls.Add(this.panel2);
            this.tabPage_Home.Controls.Add(this.crystalReportViewer1);
            this.tabPage_Home.Controls.Add(this.lblHomeUserName);
            this.tabPage_Home.Controls.Add(this.lblHomeWelcome);
            this.tabPage_Home.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Home.Name = "tabPage_Home";
            this.tabPage_Home.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Home.Size = new System.Drawing.Size(774, 443);
            this.tabPage_Home.TabIndex = 0;
            this.tabPage_Home.Text = "Home";
            this.tabPage_Home.UseVisualStyleBackColor = true;
            this.tabPage_Home.Click += new System.EventHandler(this.HomeLoadEvent);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Location = new System.Drawing.Point(4, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 341);
            this.panel2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "Reports Dashboard";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(11, 241);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 48);
            this.button3.TabIndex = 0;
            this.button3.Text = "Current Day Booking Report";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(10, 149);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(173, 45);
            this.button4.TabIndex = 3;
            this.button4.Text = "Location Count By Facility Report";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Location = new System.Drawing.Point(10, 57);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(172, 46);
            this.button6.TabIndex = 5;
            this.button6.Text = "Booking Cross Tab Report";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(6, 42);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(762, 395);
            this.crystalReportViewer1.TabIndex = 6;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // lblHomeUserName
            // 
            this.lblHomeUserName.AutoSize = true;
            this.lblHomeUserName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeUserName.Location = new System.Drawing.Point(88, 17);
            this.lblHomeUserName.Name = "lblHomeUserName";
            this.lblHomeUserName.Size = new System.Drawing.Size(0, 14);
            this.lblHomeUserName.TabIndex = 2;
            // 
            // lblHomeWelcome
            // 
            this.lblHomeWelcome.AutoSize = true;
            this.lblHomeWelcome.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeWelcome.Location = new System.Drawing.Point(15, 17);
            this.lblHomeWelcome.Name = "lblHomeWelcome";
            this.lblHomeWelcome.Size = new System.Drawing.Size(61, 14);
            this.lblHomeWelcome.TabIndex = 1;
            this.lblHomeWelcome.Text = "Welcome";
            // 
            // tabPage_Mmembers
            // 
            this.tabPage_Mmembers.Controls.Add(this.lblMmSearch);
            this.tabPage_Mmembers.Controls.Add(this.dataGridMmViewMembers);
            this.tabPage_Mmembers.Controls.Add(this.btnMmSearchMembers);
            this.tabPage_Mmembers.Controls.Add(this.lblSearchError);
            this.tabPage_Mmembers.Controls.Add(this.txtMmSearchMembers);
            this.tabPage_Mmembers.Controls.Add(this.btnMmRegisterMember);
            this.tabPage_Mmembers.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Mmembers.Name = "tabPage_Mmembers";
            this.tabPage_Mmembers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Mmembers.Size = new System.Drawing.Size(774, 443);
            this.tabPage_Mmembers.TabIndex = 1;
            this.tabPage_Mmembers.Text = "Manage Members";
            this.tabPage_Mmembers.UseVisualStyleBackColor = true;
            this.tabPage_Mmembers.Click += new System.EventHandler(this.ManageMembersEventHandler);
            // 
            // lblMmSearch
            // 
            this.lblMmSearch.AutoSize = true;
            this.lblMmSearch.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMmSearch.Location = new System.Drawing.Point(86, 46);
            this.lblMmSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMmSearch.Name = "lblMmSearch";
            this.lblMmSearch.Size = new System.Drawing.Size(75, 13);
            this.lblMmSearch.TabIndex = 13;
            this.lblMmSearch.Text = "Member Name";
            // 
            // dataGridMmViewMembers
            // 
            this.dataGridMmViewMembers.AllowUserToAddRows = false;
            this.dataGridMmViewMembers.AllowUserToDeleteRows = false;
            this.dataGridMmViewMembers.AllowUserToResizeColumns = false;
            this.dataGridMmViewMembers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Menu;
            this.dataGridMmViewMembers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridMmViewMembers.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridMmViewMembers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridMmViewMembers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridMmViewMembers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridMmViewMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridMmViewMembers.ColumnHeadersHeight = 25;
            this.dataGridMmViewMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridMmViewMembers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridMmViewMembers.EnableHeadersVisualStyles = false;
            this.dataGridMmViewMembers.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridMmViewMembers.Location = new System.Drawing.Point(88, 106);
            this.dataGridMmViewMembers.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridMmViewMembers.MultiSelect = false;
            this.dataGridMmViewMembers.Name = "dataGridMmViewMembers";
            this.dataGridMmViewMembers.ReadOnly = true;
            this.dataGridMmViewMembers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridMmViewMembers.RowHeadersVisible = false;
            this.dataGridMmViewMembers.RowTemplate.Height = 40;
            this.dataGridMmViewMembers.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridMmViewMembers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridMmViewMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridMmViewMembers.ShowCellErrors = false;
            this.dataGridMmViewMembers.ShowCellToolTips = false;
            this.dataGridMmViewMembers.ShowEditingIcon = false;
            this.dataGridMmViewMembers.ShowRowErrors = false;
            this.dataGridMmViewMembers.Size = new System.Drawing.Size(587, 244);
            this.dataGridMmViewMembers.TabIndex = 9;
            this.dataGridMmViewMembers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMmViewMembers_CellContentClick);
            // 
            // btnMmSearchMembers
            // 
            this.btnMmSearchMembers.BackColor = System.Drawing.SystemColors.Menu;
            this.btnMmSearchMembers.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnMmSearchMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMmSearchMembers.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMmSearchMembers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMmSearchMembers.Image = ((System.Drawing.Image)(resources.GetObject("btnMmSearchMembers.Image")));
            this.btnMmSearchMembers.Location = new System.Drawing.Point(241, 63);
            this.btnMmSearchMembers.Margin = new System.Windows.Forms.Padding(2);
            this.btnMmSearchMembers.Name = "btnMmSearchMembers";
            this.btnMmSearchMembers.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.btnMmSearchMembers.Size = new System.Drawing.Size(23, 22);
            this.btnMmSearchMembers.TabIndex = 10;
            this.btnMmSearchMembers.UseVisualStyleBackColor = false;
            this.btnMmSearchMembers.Click += new System.EventHandler(this.btnMmSearchMembers_Click);
            // 
            // lblSearchError
            // 
            this.lblSearchError.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchError.ForeColor = System.Drawing.Color.Red;
            this.lblSearchError.Location = new System.Drawing.Point(318, 62);
            this.lblSearchError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchError.Name = "lblSearchError";
            this.lblSearchError.Size = new System.Drawing.Size(142, 21);
            this.lblSearchError.TabIndex = 8;
            this.lblSearchError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMmSearchMembers
            // 
            this.txtMmSearchMembers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMmSearchMembers.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMmSearchMembers.ForeColor = System.Drawing.Color.Black;
            this.txtMmSearchMembers.Location = new System.Drawing.Point(88, 63);
            this.txtMmSearchMembers.Margin = new System.Windows.Forms.Padding(2);
            this.txtMmSearchMembers.Name = "txtMmSearchMembers";
            this.txtMmSearchMembers.Size = new System.Drawing.Size(147, 24);
            this.txtMmSearchMembers.TabIndex = 11;
            // 
            // btnMmRegisterMember
            // 
            this.btnMmRegisterMember.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMmRegisterMember.FlatAppearance.BorderSize = 0;
            this.btnMmRegisterMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMmRegisterMember.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMmRegisterMember.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMmRegisterMember.Image = ((System.Drawing.Image)(resources.GetObject("btnMmRegisterMember.Image")));
            this.btnMmRegisterMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMmRegisterMember.Location = new System.Drawing.Point(460, 62);
            this.btnMmRegisterMember.Margin = new System.Windows.Forms.Padding(2);
            this.btnMmRegisterMember.Name = "btnMmRegisterMember";
            this.btnMmRegisterMember.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.btnMmRegisterMember.Size = new System.Drawing.Size(223, 25);
            this.btnMmRegisterMember.TabIndex = 12;
            this.btnMmRegisterMember.Text = "Register New Member";
            this.btnMmRegisterMember.UseVisualStyleBackColor = false;
            this.btnMmRegisterMember.Click += new System.EventHandler(this.btnMmRegisterMember_Click_1);
            // 
            // tabPage_Mfacility
            // 
            this.tabPage_Mfacility.Controls.Add(this.btnSearch);
            this.tabPage_Mfacility.Controls.Add(this.label4);
            this.tabPage_Mfacility.Controls.Add(this.dataGridFacility);
            this.tabPage_Mfacility.Controls.Add(this.txtSearchFacility);
            this.tabPage_Mfacility.Controls.Add(this.lblSearch);
            this.tabPage_Mfacility.Controls.Add(this.btnRegisterFacility);
            this.tabPage_Mfacility.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Mfacility.Name = "tabPage_Mfacility";
            this.tabPage_Mfacility.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Mfacility.Size = new System.Drawing.Size(774, 443);
            this.tabPage_Mfacility.TabIndex = 2;
            this.tabPage_Mfacility.Text = "Manage Facility";
            this.tabPage_Mfacility.UseVisualStyleBackColor = true;
            this.tabPage_Mfacility.Click += new System.EventHandler(this.ManageFacilityLoadEventHandler);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Menu;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(242, 62);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.btnSearch.Size = new System.Drawing.Size(23, 22);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(310, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 16;
            // 
            // dataGridFacility
            // 
            this.dataGridFacility.AllowUserToAddRows = false;
            this.dataGridFacility.AllowUserToDeleteRows = false;
            this.dataGridFacility.AllowUserToResizeColumns = false;
            this.dataGridFacility.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Menu;
            this.dataGridFacility.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridFacility.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridFacility.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridFacility.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridFacility.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridFacility.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridFacility.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridFacility.ColumnHeadersHeight = 25;
            this.dataGridFacility.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridFacility.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridFacility.EnableHeadersVisualStyles = false;
            this.dataGridFacility.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridFacility.Location = new System.Drawing.Point(85, 98);
            this.dataGridFacility.MultiSelect = false;
            this.dataGridFacility.Name = "dataGridFacility";
            this.dataGridFacility.ReadOnly = true;
            this.dataGridFacility.RowHeadersVisible = false;
            this.dataGridFacility.RowTemplate.Height = 40;
            this.dataGridFacility.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridFacility.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridFacility.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridFacility.ShowCellErrors = false;
            this.dataGridFacility.ShowCellToolTips = false;
            this.dataGridFacility.ShowEditingIcon = false;
            this.dataGridFacility.ShowRowErrors = false;
            this.dataGridFacility.Size = new System.Drawing.Size(597, 267);
            this.dataGridFacility.TabIndex = 14;
            // 
            // txtSearchFacility
            // 
            this.txtSearchFacility.Location = new System.Drawing.Point(89, 62);
            this.txtSearchFacility.Multiline = true;
            this.txtSearchFacility.Name = "txtSearchFacility";
            this.txtSearchFacility.Size = new System.Drawing.Size(147, 24);
            this.txtSearchFacility.TabIndex = 13;
            // 
            // lblSearch
            // 
            this.lblSearch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(87, 44);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(91, 23);
            this.lblSearch.TabIndex = 12;
            this.lblSearch.Text = "Facility Name";
            // 
            // btnRegisterFacility
            // 
            this.btnRegisterFacility.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRegisterFacility.FlatAppearance.BorderSize = 0;
            this.btnRegisterFacility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterFacility.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterFacility.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegisterFacility.Image = ((System.Drawing.Image)(resources.GetObject("btnRegisterFacility.Image")));
            this.btnRegisterFacility.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegisterFacility.Location = new System.Drawing.Point(460, 61);
            this.btnRegisterFacility.Name = "btnRegisterFacility";
            this.btnRegisterFacility.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.btnRegisterFacility.Size = new System.Drawing.Size(223, 25);
            this.btnRegisterFacility.TabIndex = 11;
            this.btnRegisterFacility.Text = "Register New Facility";
            this.btnRegisterFacility.UseVisualStyleBackColor = false;
            this.btnRegisterFacility.Click += new System.EventHandler(this.btnRegisterFacility_Click);
            // 
            // tabPage_Booking
            // 
            this.tabPage_Booking.Controls.Add(this.groupBox_Facilityinfo);
            this.tabPage_Booking.Controls.Add(this.grpBox_booking);
            this.tabPage_Booking.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Booking.Name = "tabPage_Booking";
            this.tabPage_Booking.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Booking.Size = new System.Drawing.Size(774, 443);
            this.tabPage_Booking.TabIndex = 3;
            this.tabPage_Booking.Text = "Booking/Cancellation";
            this.tabPage_Booking.UseVisualStyleBackColor = true;
            this.tabPage_Booking.Click += new System.EventHandler(this.ManageBookingEventHandler);
            this.tabPage_Booking.Enter += new System.EventHandler(this.ManageBookingEventHandler);
            // 
            // groupBox_Facilityinfo
            // 
            this.groupBox_Facilityinfo.Controls.Add(this.Note);
            this.groupBox_Facilityinfo.Controls.Add(this.Legend);
            this.groupBox_Facilityinfo.Controls.Add(this.dataGridView_Facilities);
            this.groupBox_Facilityinfo.Location = new System.Drawing.Point(6, 113);
            this.groupBox_Facilityinfo.Name = "groupBox_Facilityinfo";
            this.groupBox_Facilityinfo.Size = new System.Drawing.Size(750, 320);
            this.groupBox_Facilityinfo.TabIndex = 1;
            this.groupBox_Facilityinfo.TabStop = false;
            this.groupBox_Facilityinfo.Text = "Facilities Availability";
            // 
            // Note
            // 
            this.Note.AutoSize = true;
            this.Note.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note.ForeColor = System.Drawing.Color.Navy;
            this.Note.Location = new System.Drawing.Point(483, 23);
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(250, 15);
            this.Note.TabIndex = 2;
            this.Note.Text = "NOTE : Click on cell for Booking/Cancellation";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Booked and available for cancellation";
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(328, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 24);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
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
            this.grpBox_booking.Controls.Add(this.label3);
            this.grpBox_booking.Controls.Add(this.button_SearchFacility);
            this.grpBox_booking.Controls.Add(this.label_Date);
            this.grpBox_booking.Controls.Add(this.dateTimePicker_Facility);
            this.grpBox_booking.Controls.Add(this.combo_FacilityName);
            this.grpBox_booking.Controls.Add(this.labelFacility);
            this.grpBox_booking.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_booking.Location = new System.Drawing.Point(6, 8);
            this.grpBox_booking.Name = "grpBox_booking";
            this.grpBox_booking.Size = new System.Drawing.Size(750, 92);
            this.grpBox_booking.TabIndex = 0;
            this.grpBox_booking.TabStop = false;
            this.grpBox_booking.Text = "Search Facilities Availability";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(83, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 2;
            // 
            // button_SearchFacility
            // 
            this.button_SearchFacility.BackColor = System.Drawing.Color.SteelBlue;
            this.button_SearchFacility.FlatAppearance.BorderSize = 0;
            this.button_SearchFacility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SearchFacility.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label_Date.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Date.Location = new System.Drawing.Point(343, 35);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(34, 16);
            this.label_Date.TabIndex = 4;
            this.label_Date.Text = "Date";
            // 
            // dateTimePicker_Facility
            // 
            this.dateTimePicker_Facility.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_Facility.Location = new System.Drawing.Point(384, 31);
            this.dateTimePicker_Facility.Name = "dateTimePicker_Facility";
            this.dateTimePicker_Facility.Size = new System.Drawing.Size(200, 23);
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
            this.labelFacility.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFacility.Location = new System.Drawing.Point(30, 35);
            this.labelFacility.Name = "labelFacility";
            this.labelFacility.Size = new System.Drawing.Size(47, 16);
            this.labelFacility.TabIndex = 1;
            this.labelFacility.Text = "Facility";
            // 
            // label_Heading
            // 
            this.label_Heading.AutoSize = true;
            this.label_Heading.BackColor = System.Drawing.Color.Transparent;
            this.label_Heading.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Heading.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_Heading.Location = new System.Drawing.Point(211, 18);
            this.label_Heading.Name = "label_Heading";
            this.label_Heading.Size = new System.Drawing.Size(336, 29);
            this.label_Heading.TabIndex = 0;
            this.label_Heading.Text = "Sports Facility Booking System";
            // 
            // statusStrip_Home
            // 
            this.statusStrip_Home.BackColor = System.Drawing.Color.Black;
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
            // SignOut
            // 
            this.SignOut.BackColor = System.Drawing.Color.Transparent;
            this.SignOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SignOut.FlatAppearance.BorderSize = 0;
            this.SignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignOut.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SignOut.Image = ((System.Drawing.Image)(resources.GetObject("SignOut.Image")));
            this.SignOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SignOut.Location = new System.Drawing.Point(654, 25);
            this.SignOut.Name = "SignOut";
            this.SignOut.Padding = new System.Windows.Forms.Padding(20, 0, 10, 0);
            this.SignOut.Size = new System.Drawing.Size(133, 28);
            this.SignOut.TabIndex = 18;
            this.SignOut.Text = "Sign Out";
            this.SignOut.UseVisualStyleBackColor = false;
            this.SignOut.Click += new System.EventHandler(this.SignOut_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label_Heading);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.SignOut);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 93);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.statusStrip_Home);
            this.Controls.Add(this.tabControl_Home);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "Home";
            this.Text = "Sports Facility Booking Centre";
            this.Load += new System.EventHandler(this.Home_Load);
            this.tabControl_Home.ResumeLayout(false);
            this.tabPage_Home.ResumeLayout(false);
            this.tabPage_Home.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage_Mmembers.ResumeLayout(false);
            this.tabPage_Mmembers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMmViewMembers)).EndInit();
            this.tabPage_Mfacility.ResumeLayout(false);
            this.tabPage_Mfacility.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFacility)).EndInit();
            this.tabPage_Booking.ResumeLayout(false);
            this.groupBox_Facilityinfo.ResumeLayout(false);
            this.groupBox_Facilityinfo.PerformLayout();
            this.Legend.ResumeLayout(false);
            this.Legend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Facilities)).EndInit();
            this.grpBox_booking.ResumeLayout(false);
            this.grpBox_booking.PerformLayout();
            this.statusStrip_Home.ResumeLayout(false);
            this.statusStrip_Home.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.TabControl tabControl_Home;
        private System.Windows.Forms.TabPage tabPage_Home;
        private System.Windows.Forms.TabPage tabPage_Mmembers;
        private System.Windows.Forms.TabPage tabPage_Mfacility;
        private System.Windows.Forms.TabPage tabPage_Booking;
        private System.Windows.Forms.Label label_Heading;
        private System.Windows.Forms.StatusStrip statusStrip_Home;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Note;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.Label lblMmSearch;
        private System.Windows.Forms.DataGridView dataGridMmViewMembers;
        private System.Windows.Forms.Button btnMmSearchMembers;
        private System.Windows.Forms.Label lblSearchError;
        private System.Windows.Forms.TextBox txtMmSearchMembers;
        private System.Windows.Forms.Button btnMmRegisterMember;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridFacility;
        private System.Windows.Forms.TextBox txtSearchFacility;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnRegisterFacility;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button SignOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHomeUserName;
        private System.Windows.Forms.Label lblHomeWelcome;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
    }
}



