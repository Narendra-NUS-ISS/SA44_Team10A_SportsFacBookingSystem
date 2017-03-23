namespace SA44_Team10A_SportsFacBookingSystem
{
    partial class FormMmRegisterMembers
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
            this.lblRegMessage = new System.Windows.Forms.Label();
            this.btnMmRegClose = new System.Windows.Forms.Button();
            this.btnMmReg = new System.Windows.Forms.Button();
            this.grpBoxMmRegisterMemeber = new System.Windows.Forms.GroupBox();
            this.txtMmRegMemberName = new System.Windows.Forms.TextBox();
            this.txtMmRegPhone = new System.Windows.Forms.TextBox();
            this.lblMmRegInvalidPhone = new System.Windows.Forms.Label();
            this.lblMmRegInvalidName = new System.Windows.Forms.Label();
            this.lblMmRegMemberName = new System.Windows.Forms.Label();
            this.lblMmRegPhone = new System.Windows.Forms.Label();
            this.grpBoxMmRegisterMemeber.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRegMessage
            // 
            this.lblRegMessage.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegMessage.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblRegMessage.Location = new System.Drawing.Point(27, 210);
            this.lblRegMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegMessage.Name = "lblRegMessage";
            this.lblRegMessage.Size = new System.Drawing.Size(297, 19);
            this.lblRegMessage.TabIndex = 7;
            this.lblRegMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMmRegClose
            // 
            this.btnMmRegClose.BackColor = System.Drawing.Color.Transparent;
            this.btnMmRegClose.FlatAppearance.BorderSize = 0;
            this.btnMmRegClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMmRegClose.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMmRegClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMmRegClose.Location = new System.Drawing.Point(27, 184);
            this.btnMmRegClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnMmRegClose.Name = "btnMmRegClose";
            this.btnMmRegClose.Size = new System.Drawing.Size(297, 26);
            this.btnMmRegClose.TabIndex = 6;
            this.btnMmRegClose.Text = "Close";
            this.btnMmRegClose.UseVisualStyleBackColor = false;
            this.btnMmRegClose.Click += new System.EventHandler(this.btnMmRegClose_Click);
            // 
            // btnMmReg
            // 
            this.btnMmReg.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMmReg.FlatAppearance.BorderSize = 0;
            this.btnMmReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMmReg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMmReg.Location = new System.Drawing.Point(27, 154);
            this.btnMmReg.Margin = new System.Windows.Forms.Padding(2);
            this.btnMmReg.Name = "btnMmReg";
            this.btnMmReg.Size = new System.Drawing.Size(297, 26);
            this.btnMmReg.TabIndex = 5;
            this.btnMmReg.Text = "Register";
            this.btnMmReg.UseVisualStyleBackColor = false;
            this.btnMmReg.Click += new System.EventHandler(this.btnMmReg_Click);
            // 
            // grpBoxMmRegisterMemeber
            // 
            this.grpBoxMmRegisterMemeber.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxMmRegisterMemeber.Controls.Add(this.txtMmRegMemberName);
            this.grpBoxMmRegisterMemeber.Controls.Add(this.txtMmRegPhone);
            this.grpBoxMmRegisterMemeber.Controls.Add(this.lblMmRegInvalidPhone);
            this.grpBoxMmRegisterMemeber.Controls.Add(this.lblMmRegInvalidName);
            this.grpBoxMmRegisterMemeber.Controls.Add(this.lblMmRegMemberName);
            this.grpBoxMmRegisterMemeber.Controls.Add(this.lblMmRegPhone);
            this.grpBoxMmRegisterMemeber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpBoxMmRegisterMemeber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxMmRegisterMemeber.Location = new System.Drawing.Point(27, 29);
            this.grpBoxMmRegisterMemeber.Margin = new System.Windows.Forms.Padding(2);
            this.grpBoxMmRegisterMemeber.Name = "grpBoxMmRegisterMemeber";
            this.grpBoxMmRegisterMemeber.Padding = new System.Windows.Forms.Padding(2);
            this.grpBoxMmRegisterMemeber.Size = new System.Drawing.Size(297, 121);
            this.grpBoxMmRegisterMemeber.TabIndex = 4;
            this.grpBoxMmRegisterMemeber.TabStop = false;
            this.grpBoxMmRegisterMemeber.Text = "New Member Registration";
            // 
            // txtMmRegMemberName
            // 
            this.txtMmRegMemberName.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMmRegMemberName.Location = new System.Drawing.Point(109, 40);
            this.txtMmRegMemberName.Margin = new System.Windows.Forms.Padding(2);
            this.txtMmRegMemberName.Name = "txtMmRegMemberName";
            this.txtMmRegMemberName.Size = new System.Drawing.Size(163, 20);
            this.txtMmRegMemberName.TabIndex = 2;
            this.txtMmRegMemberName.TextChanged += new System.EventHandler(this.txtMmRegMemberName_TextChanged);
            // 
            // txtMmRegPhone
            // 
            this.txtMmRegPhone.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMmRegPhone.Location = new System.Drawing.Point(109, 76);
            this.txtMmRegPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtMmRegPhone.Name = "txtMmRegPhone";
            this.txtMmRegPhone.Size = new System.Drawing.Size(163, 20);
            this.txtMmRegPhone.TabIndex = 3;
            this.txtMmRegPhone.TextChanged += new System.EventHandler(this.txtMmRegPhone_TextChanged);
            // 
            // lblMmRegInvalidPhone
            // 
            this.lblMmRegInvalidPhone.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMmRegInvalidPhone.ForeColor = System.Drawing.Color.Red;
            this.lblMmRegInvalidPhone.Location = new System.Drawing.Point(109, 94);
            this.lblMmRegInvalidPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMmRegInvalidPhone.Name = "lblMmRegInvalidPhone";
            this.lblMmRegInvalidPhone.Size = new System.Drawing.Size(162, 18);
            this.lblMmRegInvalidPhone.TabIndex = 5;
            this.lblMmRegInvalidPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMmRegInvalidName
            // 
            this.lblMmRegInvalidName.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMmRegInvalidName.ForeColor = System.Drawing.Color.Red;
            this.lblMmRegInvalidName.Location = new System.Drawing.Point(109, 58);
            this.lblMmRegInvalidName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMmRegInvalidName.Name = "lblMmRegInvalidName";
            this.lblMmRegInvalidName.Size = new System.Drawing.Size(162, 18);
            this.lblMmRegInvalidName.TabIndex = 4;
            this.lblMmRegInvalidName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMmRegMemberName
            // 
            this.lblMmRegMemberName.AutoSize = true;
            this.lblMmRegMemberName.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMmRegMemberName.Location = new System.Drawing.Point(27, 43);
            this.lblMmRegMemberName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMmRegMemberName.Name = "lblMmRegMemberName";
            this.lblMmRegMemberName.Size = new System.Drawing.Size(75, 13);
            this.lblMmRegMemberName.TabIndex = 0;
            this.lblMmRegMemberName.Text = "Member Name";
            this.lblMmRegMemberName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMmRegPhone
            // 
            this.lblMmRegPhone.AutoSize = true;
            this.lblMmRegPhone.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMmRegPhone.Location = new System.Drawing.Point(25, 79);
            this.lblMmRegPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMmRegPhone.Name = "lblMmRegPhone";
            this.lblMmRegPhone.Size = new System.Drawing.Size(77, 13);
            this.lblMmRegPhone.TabIndex = 1;
            this.lblMmRegPhone.Text = "Phone Number";
            this.lblMmRegPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormMmRegisterMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 264);
            this.Controls.Add(this.lblRegMessage);
            this.Controls.Add(this.btnMmRegClose);
            this.Controls.Add(this.btnMmReg);
            this.Controls.Add(this.grpBoxMmRegisterMemeber);
            this.Name = "FormMmRegisterMembers";
            this.Text = "FormMmRegisterMembers";
            this.Load += new System.EventHandler(this.FormMmRegisterMembers_Load);
            this.grpBoxMmRegisterMemeber.ResumeLayout(false);
            this.grpBoxMmRegisterMemeber.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRegMessage;
        private System.Windows.Forms.Button btnMmRegClose;
        private System.Windows.Forms.Button btnMmReg;
        private System.Windows.Forms.GroupBox grpBoxMmRegisterMemeber;
        private System.Windows.Forms.TextBox txtMmRegMemberName;
        private System.Windows.Forms.TextBox txtMmRegPhone;
        private System.Windows.Forms.Label lblMmRegInvalidPhone;
        private System.Windows.Forms.Label lblMmRegInvalidName;
        private System.Windows.Forms.Label lblMmRegMemberName;
        private System.Windows.Forms.Label lblMmRegPhone;
    }
}