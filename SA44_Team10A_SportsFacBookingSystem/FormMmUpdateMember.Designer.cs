namespace SA44_Team10A_SportsFacBookingSystem
{
    partial class FormMmUpdateMember
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
            this.lblUpdateMessage = new System.Windows.Forms.Label();
            this.grpBoxMmUpdateMemeber = new System.Windows.Forms.GroupBox();
            this.txtMmUpdateName = new System.Windows.Forms.TextBox();
            this.txtMmUpdatePhone = new System.Windows.Forms.TextBox();
            this.lblMmRegInvalidPhone = new System.Windows.Forms.Label();
            this.lblMmRegInvalidName = new System.Windows.Forms.Label();
            this.lblMmUpdateName = new System.Windows.Forms.Label();
            this.lblMmUpdatePhone = new System.Windows.Forms.Label();
            this.btnMmUpdateClose = new System.Windows.Forms.Button();
            this.btnMmUpdate = new System.Windows.Forms.Button();
            this.grpBoxMmUpdateMemeber.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUpdateMessage
            // 
            this.lblUpdateMessage.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateMessage.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblUpdateMessage.Location = new System.Drawing.Point(36, 215);
            this.lblUpdateMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateMessage.Name = "lblUpdateMessage";
            this.lblUpdateMessage.Size = new System.Drawing.Size(297, 19);
            this.lblUpdateMessage.TabIndex = 13;
            this.lblUpdateMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpBoxMmUpdateMemeber
            // 
            this.grpBoxMmUpdateMemeber.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxMmUpdateMemeber.Controls.Add(this.txtMmUpdateName);
            this.grpBoxMmUpdateMemeber.Controls.Add(this.txtMmUpdatePhone);
            this.grpBoxMmUpdateMemeber.Controls.Add(this.lblMmRegInvalidPhone);
            this.grpBoxMmUpdateMemeber.Controls.Add(this.lblMmRegInvalidName);
            this.grpBoxMmUpdateMemeber.Controls.Add(this.lblMmUpdateName);
            this.grpBoxMmUpdateMemeber.Controls.Add(this.lblMmUpdatePhone);
            this.grpBoxMmUpdateMemeber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpBoxMmUpdateMemeber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxMmUpdateMemeber.Location = new System.Drawing.Point(36, 34);
            this.grpBoxMmUpdateMemeber.Margin = new System.Windows.Forms.Padding(2);
            this.grpBoxMmUpdateMemeber.Name = "grpBoxMmUpdateMemeber";
            this.grpBoxMmUpdateMemeber.Padding = new System.Windows.Forms.Padding(2);
            this.grpBoxMmUpdateMemeber.Size = new System.Drawing.Size(297, 121);
            this.grpBoxMmUpdateMemeber.TabIndex = 10;
            this.grpBoxMmUpdateMemeber.TabStop = false;
            this.grpBoxMmUpdateMemeber.Text = "Update Member Details";
            // 
            // txtMmUpdateName
            // 
            this.txtMmUpdateName.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMmUpdateName.Location = new System.Drawing.Point(109, 40);
            this.txtMmUpdateName.Margin = new System.Windows.Forms.Padding(2);
            this.txtMmUpdateName.Name = "txtMmUpdateName";
            this.txtMmUpdateName.Size = new System.Drawing.Size(163, 20);
            this.txtMmUpdateName.TabIndex = 2;
            this.txtMmUpdateName.TextChanged += new System.EventHandler(this.txtMmRegMemberName_TextChanged);
            // 
            // txtMmUpdatePhone
            // 
            this.txtMmUpdatePhone.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMmUpdatePhone.Location = new System.Drawing.Point(109, 76);
            this.txtMmUpdatePhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtMmUpdatePhone.Name = "txtMmUpdatePhone";
            this.txtMmUpdatePhone.Size = new System.Drawing.Size(163, 20);
            this.txtMmUpdatePhone.TabIndex = 3;
            this.txtMmUpdatePhone.TextChanged += new System.EventHandler(this.txtMmRegPhone_TextChanged);
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
            // lblMmUpdateName
            // 
            this.lblMmUpdateName.AutoSize = true;
            this.lblMmUpdateName.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMmUpdateName.Location = new System.Drawing.Point(27, 43);
            this.lblMmUpdateName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMmUpdateName.Name = "lblMmUpdateName";
            this.lblMmUpdateName.Size = new System.Drawing.Size(75, 13);
            this.lblMmUpdateName.TabIndex = 0;
            this.lblMmUpdateName.Text = "Member Name";
            this.lblMmUpdateName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMmUpdatePhone
            // 
            this.lblMmUpdatePhone.AutoSize = true;
            this.lblMmUpdatePhone.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMmUpdatePhone.Location = new System.Drawing.Point(25, 79);
            this.lblMmUpdatePhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMmUpdatePhone.Name = "lblMmUpdatePhone";
            this.lblMmUpdatePhone.Size = new System.Drawing.Size(77, 13);
            this.lblMmUpdatePhone.TabIndex = 1;
            this.lblMmUpdatePhone.Text = "Phone Number";
            this.lblMmUpdatePhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnMmUpdateClose
            // 
            this.btnMmUpdateClose.BackColor = System.Drawing.Color.Transparent;
            this.btnMmUpdateClose.FlatAppearance.BorderSize = 0;
            this.btnMmUpdateClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMmUpdateClose.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMmUpdateClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMmUpdateClose.Location = new System.Drawing.Point(36, 189);
            this.btnMmUpdateClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnMmUpdateClose.Name = "btnMmUpdateClose";
            this.btnMmUpdateClose.Size = new System.Drawing.Size(297, 26);
            this.btnMmUpdateClose.TabIndex = 12;
            this.btnMmUpdateClose.Text = "Close";
            this.btnMmUpdateClose.UseVisualStyleBackColor = false;
            this.btnMmUpdateClose.Click += new System.EventHandler(this.btnMmRegClose_Click);
            // 
            // btnMmUpdate
            // 
            this.btnMmUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMmUpdate.FlatAppearance.BorderSize = 0;
            this.btnMmUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMmUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMmUpdate.Location = new System.Drawing.Point(36, 159);
            this.btnMmUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnMmUpdate.Name = "btnMmUpdate";
            this.btnMmUpdate.Size = new System.Drawing.Size(297, 26);
            this.btnMmUpdate.TabIndex = 11;
            this.btnMmUpdate.Text = "Submit";
            this.btnMmUpdate.UseVisualStyleBackColor = false;
            this.btnMmUpdate.Click += new System.EventHandler(this.btnMmReg_Click);
            // 
            // FormMmUpdateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(373, 262);
            this.Controls.Add(this.lblUpdateMessage);
            this.Controls.Add(this.grpBoxMmUpdateMemeber);
            this.Controls.Add(this.btnMmUpdateClose);
            this.Controls.Add(this.btnMmUpdate);
            this.Name = "FormMmUpdateMember";
            this.Text = "FormMmUpdateMember";
            this.Load += new System.EventHandler(this.FormMmUpdateMember_Load);
            this.grpBoxMmUpdateMemeber.ResumeLayout(false);
            this.grpBoxMmUpdateMemeber.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUpdateMessage;
        private System.Windows.Forms.GroupBox grpBoxMmUpdateMemeber;
        private System.Windows.Forms.TextBox txtMmUpdateName;
        private System.Windows.Forms.TextBox txtMmUpdatePhone;
        private System.Windows.Forms.Label lblMmRegInvalidPhone;
        private System.Windows.Forms.Label lblMmRegInvalidName;
        private System.Windows.Forms.Label lblMmUpdateName;
        private System.Windows.Forms.Label lblMmUpdatePhone;
        private System.Windows.Forms.Button btnMmUpdateClose;
        private System.Windows.Forms.Button btnMmUpdate;
    }
}