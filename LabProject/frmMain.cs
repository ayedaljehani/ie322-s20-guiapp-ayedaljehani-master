using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace IE322_App_KAU
{
    public partial class frmMain : Form
    {
        string username = "Ayed aljehani";
        string myPassword = "1996";
        bool loggedIn = false;
        
        int attempt = 1;
        int MaxAttempts = 3;


        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRadio_Click(object sender, EventArgs e)
        {
            frmRadio frm = new frmRadio();
            frm.ShowDialog();

        }

        private void BtnEXIT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCombo_Click(object sender, EventArgs e)
        {
            frmCombo frm = new frmCombo();
            frm.ShowDialog();
            //to close the form
            this.DialogResult = DialogResult.OK;
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPic_Click(object sender, EventArgs e)
        {
            frmPic01 frm = new frmPic01();
            frm.ShowDialog();
            //to close the form
            this.DialogResult = DialogResult.OK;
        }

        private void btnPic2_Click(object sender, EventArgs e)
        {
            frmPic02 frm = new frmPic02();
            frm.ShowDialog();
            //to close the form
            this.DialogResult = DialogResult.OK;
        }

        

      
        

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (! loggedIn)
            {

                while (attempt <= MaxAttempts)
                {
                    if (txtUser.Text != username)
                    {
                        // username is incorrect
                        MessageBox.Show("Invalid username, " + (MaxAttempts - attempt) + " attempts remaining");
                        attempt++;
                        return;
                    }
                    else
                    {   // username is correct
                        // so check password			
                        if (txtPassword.Text != myPassword)
                        {
                            // Incorrect password
                            attempt++;
                            MessageBox.Show("Incorrect password," + (MaxAttempts - attempt) + " attempts remaining");
                            return;
                        }
                        else
                        {
                            //Both are correct
                            attempt = 1; // reset the number of attempts
                            loggedIn = true;
                           // MessageBox.Show("Hi " + username + ", your login successful", "Welcome!!");                          
                           

                            foreach (var grp in groupBox1.Controls.OfType<GroupBox>())
                            {
                                foreach (var btn in grp.Controls.OfType<Button>())
                                {
                                    btn.Enabled = true;
                                    btn.ForeColor = Color.Black;
                                }
                            }

                            
                            // this.Width = 1600;
                            break; // come out of while loop
                        }//endif

                    }//endif
                }//end while
            }
            else 
            {
                btnLogin.Text = "Login";
              
                loggedIn = false;

                txtUser.Clear();
                txtPassword.Clear();

                foreach (var grp in groupBox1.Controls.OfType<GroupBox>())
                {
                    foreach (var btn in grp.Controls.OfType<Button>())
                    {
                        btn.Enabled = false;
                    }
                }
            }
           



        } //end login Button

        private void btnRandom_Click(object sender, EventArgs e)
        {
            frmRandom frm = new frmRandom();
            frm.ShowDialog();
            //to close the form
            this.DialogResult = DialogResult.OK;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        

        private void btnCheck_Click(object sender, EventArgs e)
        {
            frmCheck frm = new frmCheck();
            frm.ShowDialog();
            //to close the form
            this.DialogResult = DialogResult.OK;
        }

        private void BtnRoboticCell_Click(object sender, EventArgs e)
        {

        }

       
        
        private void BtnRandomCombo_Click(object sender, EventArgs e)
        {
            frmRandomCombo frm = new frmRandomCombo();
            frm.ShowDialog();
        }

      

        private void txtUser_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            this.txtUser.BackColor = Color.FromName("black");
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            this.txtUser.BackColor = Color.FromName("blue");
        }


        private void txtPW_Enter(object sender, EventArgs e)
        {
            this.txtPassword.BackColor = Color.FromName("black");
        }

        private void txtPW_Leave(object sender, EventArgs e)
        {
            this.txtPassword.BackColor = Color.FromName("blue");
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        

        
      

        private void BtnIteration_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnMethods_Click(object sender, EventArgs e)
        {
            frmMethods frm = new frmMethods();
            frm.ShowDialog();
        }

      
        private void BtnArray_Click(object sender, EventArgs e)
        {
            frmArray frm = new frmArray();
            frm.Show();
        }

        private void btnGroupieApp_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }
    }
}
