namespace SA44_Team10A_SportsFacBookingSystem
{
    partial class FormLogOut
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
            this.lblPrompt = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrompt
            // 
            this.lblPrompt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt.Location = new System.Drawing.Point(126, 49);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(211, 20);
            this.lblPrompt.TabIndex = 0;
            this.lblPrompt.Text = "Do you want to Log out?";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Location = new System.Drawing.Point(238, 94);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 25);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Gray;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogOut.Location = new System.Drawing.Point(76, 94);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(104, 25);
            this.btnLogOut.TabIndex = 10;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // FormLogOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(405, 158);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblPrompt);
            this.Name = "FormLogOut";
            this.Text = "FormLogOut";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLogOut;
    }
}