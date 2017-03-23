namespace SA44_Team10A_SportsFacBookingSystem
{
    partial class FormRegisterNewFacility
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.grpBoxNewFacility = new System.Windows.Forms.GroupBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtFacilityName = new System.Windows.Forms.TextBox();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.lblRegisterFacilityStatus = new System.Windows.Forms.Label();
            this.lblFacilityError = new System.Windows.Forms.Label();
            this.lblLocationError = new System.Windows.Forms.Label();
            this.grpBoxNewFacility.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(51, 200);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(280, 30);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Gray;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegister.Location = new System.Drawing.Point(51, 162);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(280, 30);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // grpBoxNewFacility
            // 
            this.grpBoxNewFacility.Controls.Add(this.txtFacilityName);
            this.grpBoxNewFacility.Controls.Add(this.txtLocation);
            this.grpBoxNewFacility.Controls.Add(this.lblLocationError);
            this.grpBoxNewFacility.Controls.Add(this.lblFacilityError);
            this.grpBoxNewFacility.Controls.Add(this.lblLocation);
            this.grpBoxNewFacility.Controls.Add(this.lblMemberName);
            this.grpBoxNewFacility.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxNewFacility.Location = new System.Drawing.Point(51, 21);
            this.grpBoxNewFacility.Name = "grpBoxNewFacility";
            this.grpBoxNewFacility.Size = new System.Drawing.Size(280, 135);
            this.grpBoxNewFacility.TabIndex = 3;
            this.grpBoxNewFacility.TabStop = false;
            this.grpBoxNewFacility.Text = "New Facility Registration";
            this.grpBoxNewFacility.Enter += new System.EventHandler(this.grpBoxNewFacility_Enter);
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(109, 82);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(144, 21);
            this.txtLocation.TabIndex = 3;
            this.txtLocation.TextChanged += new System.EventHandler(this.txtLocation_TextChanged);
            // 
            // lblLocation
            // 
            this.lblLocation.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(48, 85);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(55, 19);
            this.lblLocation.TabIndex = 0;
            this.lblLocation.Text = "Location\r\n\r\n\r\n";
            // 
            // txtFacilityName
            // 
            this.txtFacilityName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFacilityName.Location = new System.Drawing.Point(109, 39);
            this.txtFacilityName.Name = "txtFacilityName";
            this.txtFacilityName.Size = new System.Drawing.Size(144, 21);
            this.txtFacilityName.TabIndex = 2;
            this.txtFacilityName.TextChanged += new System.EventHandler(this.txtFacilityName_TextChanged);
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberName.Location = new System.Drawing.Point(19, 39);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(77, 14);
            this.lblMemberName.TabIndex = 1;
            this.lblMemberName.Text = "Facility Name";
            // 
            // lblRegisterFacilityStatus
            // 
            this.lblRegisterFacilityStatus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterFacilityStatus.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblRegisterFacilityStatus.Location = new System.Drawing.Point(48, 229);
            this.lblRegisterFacilityStatus.Name = "lblRegisterFacilityStatus";
            this.lblRegisterFacilityStatus.Size = new System.Drawing.Size(283, 23);
            this.lblRegisterFacilityStatus.TabIndex = 6;
            this.lblRegisterFacilityStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFacilityError
            // 
            this.lblFacilityError.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacilityError.ForeColor = System.Drawing.Color.Red;
            this.lblFacilityError.Location = new System.Drawing.Point(108, 62);
            this.lblFacilityError.Name = "lblFacilityError";
            this.lblFacilityError.Size = new System.Drawing.Size(166, 18);
            this.lblFacilityError.TabIndex = 7;
            // 
            // lblLocationError
            // 
            this.lblLocationError.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationError.ForeColor = System.Drawing.Color.Red;
            this.lblLocationError.Location = new System.Drawing.Point(108, 105);
            this.lblLocationError.Name = "lblLocationError";
            this.lblLocationError.Size = new System.Drawing.Size(166, 18);
            this.lblLocationError.TabIndex = 8;
            // 
            // FormRegisterNewFacility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.lblRegisterFacilityStatus);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.grpBoxNewFacility);
            this.Location = new System.Drawing.Point(430, 180);
            this.Name = "FormRegisterNewFacility";
            this.Text = "FormRegisterNewFacility";
            this.grpBoxNewFacility.ResumeLayout(false);
            this.grpBoxNewFacility.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.GroupBox grpBoxNewFacility;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtFacilityName;
        private System.Windows.Forms.Label lblRegisterFacilityStatus;
        private System.Windows.Forms.Label lblLocationError;
        private System.Windows.Forms.Label lblFacilityError;
    }
}