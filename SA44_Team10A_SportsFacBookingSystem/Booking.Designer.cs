namespace SA44_Team10A_SportsFacBookingSystem
{
    partial class Booking
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
            this.groupBox_booking = new System.Windows.Forms.GroupBox();
            this.MemberId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMemPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtFacility = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtSlot = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblErrorLabel = new System.Windows.Forms.Label();
            this.groupBox_booking.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_booking
            // 
            this.groupBox_booking.Controls.Add(this.lblErrorLabel);
            this.groupBox_booking.Controls.Add(this.btnSearch);
            this.groupBox_booking.Controls.Add(this.btnClose);
            this.groupBox_booking.Controls.Add(this.btnBook);
            this.groupBox_booking.Controls.Add(this.txtMemberName);
            this.groupBox_booking.Controls.Add(this.txtSlot);
            this.groupBox_booking.Controls.Add(this.txtLocation);
            this.groupBox_booking.Controls.Add(this.txtFacility);
            this.groupBox_booking.Controls.Add(this.txtMemPhoneNumber);
            this.groupBox_booking.Controls.Add(this.label5);
            this.groupBox_booking.Controls.Add(this.label4);
            this.groupBox_booking.Controls.Add(this.label3);
            this.groupBox_booking.Controls.Add(this.label2);
            this.groupBox_booking.Controls.Add(this.MemberId);
            this.groupBox_booking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_booking.Location = new System.Drawing.Point(26, 45);
            this.groupBox_booking.Name = "groupBox_booking";
            this.groupBox_booking.Size = new System.Drawing.Size(378, 278);
            this.groupBox_booking.TabIndex = 0;
            this.groupBox_booking.TabStop = false;
            this.groupBox_booking.Text = "Book available slot";
            // 
            // MemberId
            // 
            this.MemberId.AutoSize = true;
            this.MemberId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberId.Location = new System.Drawing.Point(16, 44);
            this.MemberId.Name = "MemberId";
            this.MemberId.Size = new System.Drawing.Size(141, 15);
            this.MemberId.TabIndex = 0;
            this.MemberId.Text = "Member Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "MemberName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Slot";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Facility";
            // 
            // txtMemPhoneNumber
            // 
            this.txtMemPhoneNumber.Location = new System.Drawing.Point(154, 44);
            this.txtMemPhoneNumber.Name = "txtMemPhoneNumber";
            this.txtMemPhoneNumber.Size = new System.Drawing.Size(111, 23);
            this.txtMemPhoneNumber.TabIndex = 5;
            // 
            // txtFacility
            // 
            this.txtFacility.Enabled = false;
            this.txtFacility.Location = new System.Drawing.Point(154, 165);
            this.txtFacility.Name = "txtFacility";
            this.txtFacility.Size = new System.Drawing.Size(170, 23);
            this.txtFacility.TabIndex = 6;
            // 
            // txtLocation
            // 
            this.txtLocation.Enabled = false;
            this.txtLocation.Location = new System.Drawing.Point(154, 137);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(170, 23);
            this.txtLocation.TabIndex = 7;
            // 
            // txtSlot
            // 
            this.txtSlot.Enabled = false;
            this.txtSlot.Location = new System.Drawing.Point(154, 111);
            this.txtSlot.Name = "txtSlot";
            this.txtSlot.Size = new System.Drawing.Size(170, 23);
            this.txtSlot.TabIndex = 8;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Enabled = false;
            this.txtMemberName.Location = new System.Drawing.Point(154, 77);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(170, 23);
            this.txtMemberName.TabIndex = 9;
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.Location = new System.Drawing.Point(53, 214);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(82, 32);
            this.btnBook.TabIndex = 10;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.BookSlotEventHandler);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(174, 214);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 32);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.CloseEventHandler);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(272, 44);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(52, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.SearchMemberEventHandler);
            // 
            // lblErrorLabel
            // 
            this.lblErrorLabel.AutoSize = true;
            this.lblErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.lblErrorLabel.Location = new System.Drawing.Point(27, 16);
            this.lblErrorLabel.Name = "lblErrorLabel";
            this.lblErrorLabel.Size = new System.Drawing.Size(0, 17);
            this.lblErrorLabel.TabIndex = 1;
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(416, 353);
            this.Controls.Add(this.groupBox_booking);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Booking";
            this.Text = "Booking";
            this.groupBox_booking.ResumeLayout(false);
            this.groupBox_booking.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_booking;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TextBox txtSlot;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtFacility;
        private System.Windows.Forms.TextBox txtMemPhoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MemberId;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblErrorLabel;
    }
}