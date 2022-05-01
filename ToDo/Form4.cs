using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;

namespace ToDo
{
    
    public partial class Form4 : Form
    {
        String from, pass, messageBody, to;
       
        String randomCode;
        SqlConnection con = new SqlConnection("Data Source=caur;Initial Catalog=ToDo;Integrated Security=True");
        public Form4()
        {
            InitializeComponent();
            Random rnd = new Random();
            randomCode = (rnd.Next(9999)).ToString();
           
                     
        }

        private void txtUserRest_MouseHover(object sender, EventArgs e)
        {
            lblHintuserName.Visible = true;
            lblHintuserName.Text = "Enter your email address or user name";
           

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            txtCode.Visible  = false;
            lblHintuserName.Visible = false;
            lblVerify.Visible = false;

            txtPswS.Enabled = false;
            txtRePswS.Enabled = false;

            btnResend.Visible = false;
            lblWait.Visible = false;

            pic8CharError.Visible = true;
            picUpperError.Visible = true;
            picDigitError.Visible = true;

            picUpperDone.Visible = false;
            pic8CharDone.Visible = false;
            picDigitDone.Visible = false;

            btnReset.Visible = false;

            pnlToDo.Visible = false;

            picEyeHide.Visible = false;
            picEyeOpen.Enabled = false;








        }

        private void txtUserRest_MouseLeave(object sender, EventArgs e)
        {
            lblHintuserName.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {

            try
            {
                String user = txtUserRest.Text;
                SqlCommand cmd = new SqlCommand("Select uName,email from UserDetails where email = '" + user + "'or uName = '" + user + "'", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read() == true)
                {
                    //after send the verification code done button will hide 
                    btnDone.Visible = false;
                    lblWait.Visible = true;
                    MessageBox.Show("Please Wait...", "ToDo");






                    MailMessage message = new MailMessage();
                    to = rdr.GetString(1);
                    from = "sazubandara@gmail.com";
                    pass = "sazu12345@1";

                    messageBody = "Your Password Reset Code " + randomCode;
                    message.To.Add(to);
                    message.From = new MailAddress(from);
                    message.Body = messageBody;
                    message.Subject = "ToDo Password Reset";

                    SmtpClient stmp = new SmtpClient("smtp.gmail.com");
                    stmp.EnableSsl = true;
                    stmp.Port = 587;
                    stmp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    stmp.Credentials = new NetworkCredential(from, pass);

                    try
                    {

                        stmp.Send(message);// sending code to email
                        if (txtUserRest.Text == rdr.GetString(0))// if user input user name
                            MessageBox.Show("Dear " + rdr.GetString(0) + " verification has been sent to your e-mail", "ToDo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else if (txtUserRest.Text == rdr.GetString(1))// if enter email                            
                            MessageBox.Show("Verification code has been sent to " + rdr.GetString(0), "ToDo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("there is an error");
                    }




                    lblUserName.Visible = false;
                    txtCode.Visible = true;
                    lblVerify.Visible = true;
                    btnDone.Visible = false;
                    txtUserRest.Visible = false;
                    btnResend.Visible = true;
                    lblWait.Visible = false;
                    con.Close();

                    //enable all reset text box after email send
                    // if verification done                  





                }
                else
                {
                    MessageBox.Show("Incorrect email or user name!");
                    con.Close();
                }
            }
            catch (System.InvalidOperationException)
            {
                con.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("There is an error.Make sure the email address or user name is correct", "ToDo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }


            // if verification code is correct
           
            // verification is not correct
            
               
            



        }

        private void txtUserRest_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtCode_MouseHover(object sender, EventArgs e)
        {
            lblHintuserName.Visible = true;
            lblHintuserName.Text = "Check your email and enter the verification code";
        }

        private void txtCode_MouseLeave(object sender, EventArgs e)
        {
            lblHintuserName.Visible = false;
        }

        private void txtUserRest_KeyPress(object sender, KeyPressEventArgs e)
        {
          


        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtUserRest_KeyDown(object sender, KeyEventArgs e)// press enter function
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    String user = txtUserRest.Text;
                    SqlCommand cmd = new SqlCommand("Select uName,email from UserDetails where email = '" + user + "'or uName = '" + user + "'", con);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read() == true)
                    {


                        // should sent the verification code to the email .
                        String email = rdr.GetString(1);
                        MessageBox.Show("Verification code has been sent to " + email);

                        lblUserName.Visible = false;
                        txtCode.Visible = true;
                        lblVerify.Visible = true;
                        btnDone.Visible = false;
                        txtUserRest.Visible = false;
                        con.Close();

                    }

                    else
                    {
                        MessageBox.Show("Incorrect email or user name!");
                    }
                }
                catch (System.InvalidOperationException)
                {
                    con.Close();
                }

            }
        }//press enter function

        private void txtPswS_TextChanged(object sender, EventArgs e)
        {
            if (txtPswS.Text.Length > 8)
            {
                pic8CharError.Visible = false;
                pic8CharDone.Visible = true;
            }

            else
            {
                pic8CharError.Visible = true;
                pic8CharDone.Visible = false;
            }

            if (txtPswS.Text.Any(Char.IsUpper))
            {
                picUpperDone.Visible = true;
                picUpperError.Visible = false;
            }
            else
            {
                picUpperDone.Visible = false;
                picUpperError.Visible = true;
            }

            if (txtPswS.Text.Any(Char.IsDigit))
            {
                picDigitError.Visible = false;
                picDigitDone.Visible = true;
            }
            else
            {
                picDigitError.Visible = true;
                picDigitDone.Visible = false;
            }

        }

        private void txtRePswS_TextChanged(object sender, EventArgs e)
        {
            if (txtPswS.Text == txtRePswS.Text)
            {
                errVerify.Clear();
                btnReset.Visible = true;
                
            }
            else
            {
                errVerify.SetError(txtRePswS, "Passowrd is not matching");
                btnReset.Visible = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                String pass = txtPswS.Text;
                String user = txtUserRest.Text;
                SqlCommand cmd = new SqlCommand("Update UserDetails set password = '" + pass + "' where uName = '" + user + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("There is an errro","ToDo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            //go to the login form
            pnlToDo.Visible = true;
            pnlReset.Visible = false;
            lblReset.Visible = false;
            btnReset.Visible = false;
            btnBack.Visible = false;

            
        }

        private void lblLogIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }

        private void picEyeHide_Click(object sender, EventArgs e)
        {
            picEyeHide.Visible = false;
            picEyeOpen.Visible = true;

            txtPswS.UseSystemPasswordChar = true;
        }

        private void picEyeOpen_Click(object sender, EventArgs e)
        {
            picEyeHide.Visible = true;
            picEyeOpen.Visible = false;


            txtPswS.UseSystemPasswordChar = false;
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            if (randomCode == txtCode.Text)
            {
                txtCode.Enabled = false;
               
                txtPswS.Enabled = true;
                txtRePswS.Enabled = true;
                txtPswS.BackColor = Color.PaleTurquoise;
                txtRePswS.BackColor = Color.PaleTurquoise;
                picEyeOpen.Enabled = true;
               


                btnResend.Visible = false;

                
            }

            if (txtCode.Text.Length > 4)
            {
                txtCode.Text = null;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Close();
        }

        private void btnResend_Click(object sender, EventArgs e)
        {
            btnResend.Enabled = false;
            try
            {
                String user = txtUserRest.Text;
                SqlCommand cmd = new SqlCommand("Select uName,email from UserDetails where email = '" + user + "'or uName = '" + user + "'", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read() == true)
                {
                    //after send the verification code done button will hide 
                    btnDone.Visible = false;
                    lblWait.Visible = true;
                    MessageBox.Show("Please Wait...", "ToDo");






                    MailMessage message = new MailMessage();
                    to = rdr.GetString(1);
                    from = "sazubandara@gmail.com";
                    pass = "sazu12345@1";

                    messageBody = "Your Password Reset Code " + randomCode;
                    message.To.Add(to);
                    message.From = new MailAddress(from);
                    message.Body = messageBody;
                    message.Subject = "ToDo Password Reset";

                    SmtpClient stmp = new SmtpClient("smtp.gmail.com");
                    stmp.EnableSsl = true;
                    stmp.Port = 587;
                    stmp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    stmp.Credentials = new NetworkCredential(from, pass);

                    try
                    {

                        stmp.Send(message);// sending code to email
                        if (txtUserRest.Text == rdr.GetString(0))// if user input user name
                            MessageBox.Show("Verification code has been sent to " + rdr.GetString(0), "ToDo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else if (txtUserRest.Text == rdr.GetString(1))// if enter email
                            MessageBox.Show("Dear " + rdr.GetString(0) + " verification has been sent to your e-mail", "ToDo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        btnResend.Enabled = true;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("there is an error");
                    }




                    lblUserName.Visible = false;
                    txtCode.Visible = true;
                    lblVerify.Visible = true;
                    btnDone.Visible = false;
                    txtUserRest.Visible = false;
                    btnResend.Visible = true;
                    lblWait.Visible = false;
                    con.Close();

                    //enable all reset text box after email send
                    // if verification done                  





                }
                else
                {
                    MessageBox.Show("Incorrect email or user name!");
                    con.Close();
                }
            }
            catch (System.InvalidOperationException)
            {
                con.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("There is an error.Make sure the email address or user name is correct", "ToDo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }


            // if verification code is correct

            // verification is not correct



        }
    }
}
