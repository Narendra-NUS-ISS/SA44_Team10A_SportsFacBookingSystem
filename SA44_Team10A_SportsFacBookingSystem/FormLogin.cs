using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA44_Team10A_SportsFacBookingSystem
{
    public partial class FormLogin : Form
    {
        BookingSystemEntities context;
        FormSignUp formSignUp;
        Home homeForm;
        public FormLogin()
        {
            InitializeComponent();
            context = new BookingSystemEntities();
            btnLogin.ForeColor = Color.Gray;
            btnLogin.BackColor = Color.DarkGray;
            btnLogin.Enabled = false;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // Login button Functionalities
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!txtUsername.Text.Equals(String.Empty) && !txtPassword.Text.Equals(String.Empty))
            {
                List<User> userList=context.Users.Select(x=> x).ToList();
                bool isValid=false;
                foreach (User user in userList)
                {
                    if(user.UserName.Equals(txtUsername.Text.Trim())&& user.Password.Equals(txtPassword.Text.Trim()))
                    {
                        if (homeForm == null)
                        {
                            homeForm = new Home(GetUserName());
                            homeForm.Show();
                            homeForm.FormClosed += HomeForm_FormClosed;

                        }
                        else
                        {
                            homeForm.Activate();
                        }
                        isValid = true;
                        resetTextBoxValues();
                        btnLogin.Enabled = false;
                        break;

                    }                                              
                }
                if (!isValid)
                {
                    lblLoginStatus.ForeColor = Color.Red;
                    resetTextBoxValues();
                    enableDisableLoginButton();
                    lblLoginStatus.Text =Constants.INVALID_USER_NAME;
                }
                else
                {
                    lblLoginStatus.Text =Constants.LOGIN_SUCCESSFULL;
                    lblLoginStatus.ForeColor = Color.ForestGreen;
                }
            }
        }

        private void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            homeForm = null;
        }

        //To reset values for username and password in login page
        private void resetTextBoxValues()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        //T enable and disable login button 
        private void enableDisableLoginButton()
        {
            lblLoginStatus.Text = "";
            if (!txtUsername.Text.Trim().Equals(String.Empty) && !txtPassword.Text.Trim().Equals(String.Empty))
            {
                btnLogin.Enabled = true;
                btnLogin.BackColor = Color.SteelBlue;
                btnLogin.ForeColor = Color.White;
            }
            else
            {
                btnLogin.Enabled = false;
                btnLogin.BackColor = Color.Gray;
                btnLogin.ForeColor = Color.DimGray;
            }
        }
       
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            enableDisableLoginButton();
        }
               
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            enableDisableLoginButton();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //To reset the values of username and password
            resetTextBoxValues();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //To sign up a new user for the system
            if (formSignUp == null)
            {
                formSignUp = new FormSignUp();
                formSignUp.Show();
                formSignUp.FormClosed += FormSignUp_FormClosed;
            }
            else
            {
                formSignUp.Activate();
            }
        }

        private void FormSignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            formSignUp = null;
        }

        public String GetUserName()
        {
            return txtUsername.Text.ToString();
        }
    }
}
