using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA44_Team10A_SportsFacBookingSystem
{
    public partial class FormSignUp : Form
    {
        BookingSystemEntities context;
        bool isValidPassword;
        bool isMatchingPassword;
        bool isValidName;
       
        public FormSignUp()
        {
            InitializeComponent();
            context = new BookingSystemEntities();
            btnSignUp.Enabled=false;
            txtConfirmPassword.Enabled = false;

        }
       
        // To check whether the entered name is of current format
        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (!txtUserName.Text.Equals(String.Empty))
            {
                Regex pattern = new Regex("^[a-zA-Z0-9]{1,15}$");
                if (pattern.IsMatch(txtUserName.Text))
                {
                    lblUserNameStatus.Text = "";
                    isValidName = true;
                    // to check whether user name is existing
                    isUserNameExisting();
                }
                else
                {
                    lblUserNameStatus.Text =Constants.INVALID_USERNAME;
                    lblUserNameStatus.ForeColor = Color.Red;
                    isValidName = false;
                }
            }
            enableDisableSignUpButton();
        }

        //when the password is changed and to validate the password content
        private void textPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(String.Empty))
            {
                lblPswdStatus.Text = "";
                txtConfirmPassword.Text="";
            }else
            {
                // checks whether the password entered is a valid one.
                passWordFormatValidation();
                if (isValidPassword&&!txtConfirmPassword.Text.Equals(String.Empty))
                     passwordMatchingValidation();
            }
            enableDisableSignUpButton();
        }

        //To confirm the password
        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (!txtConfirmPassword.Text.Equals(String.Empty))
            {
                passwordMatchingValidation();
            }else
            {
                lblConfirmPswdStatus.Text = "";
            }
                enableDisableSignUpButton();
        }

        //to check whether the password typed is matching with the previously entered password
        private void passwordMatchingValidation()
        {
            if (txtPassword.Text.Equals(txtConfirmPassword.Text))
            {
                lblConfirmPswdStatus.Text = "";
                isMatchingPassword = true;
            }
            else
            {
                lblConfirmPswdStatus.Text = Constants.ENTER_SAME_PSWD;
                lblConfirmPswdStatus.ForeColor = Color.Red;
                isMatchingPassword = false;
            }
        }

        
        //To validate the password length
        private void passWordFormatValidation()
        {
            if (txtPassword.Text.Length >= 6 && txtPassword.Text.Length <= 8)
            {
                lblPswdStatus.Text = "";
                isValidPassword = true;
                txtConfirmPassword.Enabled = true;
            }
            else
            {
                lblPswdStatus.Text = Constants.PSWD_LENGTH_ALERT;
                lblPswdStatus.ForeColor = Color.Red;
                txtConfirmPassword.Enabled = false;
                txtConfirmPassword.Text = "";
                lblConfirmPswdStatus.Text = "";
                isValidPassword = false;
            }
        }

        //To reset all the text fields in the sign up screen
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
        }

        //To sign up a new user
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.UserName = txtUserName.Text.Trim();
            user.Password = txtPassword.Text.Trim();
            context.Users.Add(user);
            context.SaveChanges();
            setDefaultValuesToTextBoxes();
            lblSignUpStatus.Text = Constants.USER_ADDED;
            lblSignUpStatus.ForeColor = Color.ForestGreen;
        }

        //to make the text box of username and passwords empty
        private void setDefaultValuesToTextBoxes()
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
        }

        // to enable and disable sign up button on proper input
        private void enableDisableSignUpButton()
        {
            if (isValidName&&isValidPassword&&isMatchingPassword&&(!txtUserName.Text.Trim().Equals(String.Empty) && !txtPassword.Text.Trim().Equals(String.Empty))
                && !txtConfirmPassword.Text.Trim().Equals(String.Empty))
            {
                btnSignUp.Enabled = true;
                btnSignUp.BackColor = Color.SteelBlue;
                btnSignUp.ForeColor = Color.White;
            }
            else
            {
                btnSignUp.Enabled = false;
                btnSignUp.BackColor = Color.Gray;
                btnSignUp.ForeColor = Color.DimGray;
            }
        }

        // Closes the Sign up form 
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // check whether the entered username is already existing or not
        private void isUserNameExisting()
        {
            List<String> userNameList = context.Users.Select(x => x.UserName).ToList();
            if (userNameList.Contains(txtUserName.Text))
            {
                lblUserNameStatus.Text = Constants.USERNAME_EXISTS;
                lblUserNameStatus.ForeColor = Color.Red;
                isValidName = false;
            }
            else
            {
                isValidName = true;
            }
        }

      
    }
}
