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
using System.Security.Cryptography;

namespace ToDo
{
    public partial class Form2 : Form
    {
        public String to;
        public String randomCode;
        public String gender;
        public String student;
        public bool codeSend;

        SqlConnection con = new SqlConnection("Data Source=caur;Initial Catalog=ToDo;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();

          
        }

        //create tables of user

        

        //lessonTable
        public void lessonTable()
        {
            try
            {
                string userName = txtUserS.Text;

                SqlCommand cmd = new SqlCommand("Create table " + userName + "Lesson (lessonNo int NOT NULL Primary key Identity(1,1)," +
                    "SubjectName varchar(50), description varchar(255), time int);", con);
                con.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
            finally
            {
                con.Close();
            }
        }

        //projectTable
        public void projectTable()
        {
            try
            {
                string userName = txtUserS.Text;
                SqlCommand cmd = new SqlCommand("Create table " + userName + "Project (pNo int Not null primary key ," +
                    "projectName varchar(255));", con);
                con.Open();
                cmd.ExecuteNonQuery();
              
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
            finally
            {
                con.Close();
            }
        }

        //inportant table
        public void important()
        {
            try
            {

                string userName = txtUserS.Text;
                SqlCommand cmd = new SqlCommand("Create table " + userName + "Important (noteName varchar(50) Not null primary key" +
                        ",impNote text);", con);
                con.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
            finally
            {
                con.Close();
            }
        }

        //remindTable
        public void remindTable()
        {
            string userName = txtUserS.Text;
            try
            {
                SqlCommand cmd = new SqlCommand("Create table " + userName + "Remind (rno int Not null primary key identity(1,1), time varchar(50), date varchar(50), text varchar(255))", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                con.Close();
            }
        }

        //noteTable
        public void noteTable()
        {
            try
            {
                string userName = txtUserS.Text;
                SqlCommand cmd = new SqlCommand("Create table " + userName + "Note (NoteNo int Not null primary key identity(1,1)" +
                            ", senderName varchar(10),note text, time varchar(50));", con);
                con.Open();
                cmd.ExecuteNonQuery();
                
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message);
            }
            finally
            {
                con.Close();
            }

        }

        //otherTaskTable
        public void otherTaskTable()
        {
            try
            {
                string userName = txtUserS.Text;
                SqlCommand cmd = new SqlCommand("Create table " + userName + "OtherTask (taskNo int Not null primary key identity(1,1)," +
                        "taskName varchar(50),time int);", con);
                con.Open();
                cmd.ExecuteNonQuery();
                
            }

            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
            finally
            {
                con.Close();
            }
        }

        

        private void btnHelp_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 obj = new Form1();
            obj.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 obj = new Form1();
            obj.Close();
           
        }

        private void lblSignShow_Click(object sender, EventArgs e)
        {

        }

        private void chkStu_MouseHover(object sender, EventArgs e)
        {
            lbltick.Visible = true;
        }

        private void chkStu_MouseLeave(object sender, EventArgs e)
        {
            lbltick.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            

            picEyeHide.Visible = false;
            picEyeOpenP.Visible = true;

            lblWait.Visible = false;
            lbltick.Visible = false;
            lblDone.Visible = false;
            picDone.Visible = false;
            lblVerify.Visible = false;
            txtCode.Visible = false;
            lblStudent.Visible = false;

               //password validations
            picUpperDone.Visible = false;
            pic8CharDone.Visible = false;
            picUpperError.Visible = false;
            pic8CharError.Visible = false;
            lblUppercase.Visible = false;
            lbl8Char.Visible = false;
            picErrorDigit.Visible = false;
            picDigitDone.Visible = false;
            lblDigits.Visible = false;
            //re enter password hide
            lblPswR.Visible = false;
            //hide available of user and email lable
            lblUserAvailable.Visible = false;
            lblEmailAvailble.Visible = false;
            //hide btn resend
            btnResend.Visible = false;
            //hide hint email
            lblEmail.Visible = false;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            String email = txtEmail.Text;
            String user = txtUserS.Text;
            String psw = txtPswS.Text;
            String pswR = txtRePswS.Text;

            

           
        }

        
        

        private void btnDone_MouseHover(object sender, EventArgs e)
        {
            btnDone.ForeColor = Color.LightGreen;
        }

        private void btnDone_MouseLeave(object sender, EventArgs e)
        {
            btnDone.ForeColor = Color.White;
        }

        private void emailVerify()
        {
            String from;
            String pas;
            String messageBody;

            String email = txtEmail.Text;
            Random rnd = new Random();
            //send the random code
            randomCode = (rnd.Next(9999)).ToString();
            MailMessage message = new MailMessage();
            to = email;
            from = "sazubandara@gmail.com";
            pas = "sazu12345@1"; 

            messageBody = "Your verification code - " + randomCode;

            try
            {
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messageBody;
                message.Subject = "ToDo verification";

                SmtpClient stmp = new SmtpClient("smtp.gmail.com");
                stmp.EnableSsl = true;
                stmp.Port = 587;
                stmp.DeliveryMethod = SmtpDeliveryMethod.Network;
                stmp.Credentials = new NetworkCredential(from, pas);

                try
                {
                    stmp.Send(message);
                    Notify obj = new Notify("Email");
                    obj.Show();
                    btnBack.Visible = false;
                    codeSend = true;

                }

                catch (Exception ee)
                {
                    MessageBox.Show((ee).ToString());
                    codeSend = false;
                }

            }
            catch (System.FormatException)
            {
                erroEmail.SetError(txtEmail, "Invalid email address!");
                
                codeSend = false;
            }
            


        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            String pswR = txtRePswS.Text;
            String psw = txtPswS.Text;
            String user = txtUserS.Text;
            String email = txtEmail.Text;



            //here user validation
            if (String.IsNullOrEmpty(user))
            {
                erroUser.SetError(txtUserS,"Enter the user name");
            }

            if (String.IsNullOrEmpty(email))
            {
                erroEmail.SetError(txtEmail, "Enter the email");
            }

            //here email validation


            if (psw.Length > 8 && psw.Any(Char.IsUpper) == true && psw.Any(Char.IsDigit) == true && rdoFemale.Checked == true || rdoMale.Checked == true || lblUserAvailable.Text == "Available")//validation true
            {
                errorGender.Clear();//clear the gender error 

                if (pswR == psw)
                {
                    errorProvider1.Clear();//clear the error  provider if validation done

                    DialogResult d;
                    d = MessageBox.Show("Do You Confirm Your Details ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (d == DialogResult.Yes)//details confirmation massage box
                    {
                        lblWait.Visible = true;
                        MessageBox.Show("Please wait...");
                        
                        emailVerify();// verification code sending
                        if (codeSend == true)
                        {
                            lblWait.Visible = false;
                                                

                            lblDone.Visible = true;
                            picDone.Visible = true;

                            btnDone.Visible = false;
                            //visible verify code text box

                            txtCode.Visible = true;
                            lblVerify.Visible = true;
                            btnResend.Visible = true;

                            txtEmail.Enabled = false;
                            txtEmail.Text = email;
                            txtPswS.Enabled = false;
                            txtUserS.Enabled = false;
                            txtRePswS.Enabled = false;

                            if (chkStu.Checked)
                            {
                                lblStudent.Visible = true;
                                lblStudent.Text = "I am Student";
                                chkStu.Visible = false;

                            }
                            else
                            {
                                lblStudent.Visible = false;
                                chkStu.Visible = false;
                            }

                            if (rdoFemale.Checked)
                            {
                                rdoFemale.Visible = false;
                                rdoMale.Visible = false;
                                lblGender.Text = "Female";

                            }

                            else if (rdoMale.Checked)
                            {
                                rdoFemale.Visible = false;
                                rdoMale.Visible = false;
                                lblGender.Text = "Male";
                            }
                            //validation done
                            picUpperDone.Visible = true;
                            lblUppercase.Visible = true;

                            pic8CharDone.Visible = true;
                            lbl8Char.Visible = true;

                            lblDigits.Visible = true;
                            picDigitDone.Visible = true;


                        }



                    }
                }
                else
                {
                    errorProvider1.SetError(txtRePswS, "Password is not matching!");
                }
            }



            else
            {

                if (lblUserAvailable.Text == "Unavailable")
                {
                    erroUser.SetError(txtUserS,"This user name already used");
                }

                //Showing the validation that should do
                if (psw.Length < 8 || psw.Any(Char.IsUpper) == false || psw.Any(Char.IsDigit) == false)
                {
                    errorProvider1.SetError(txtPswS, "Follow instructions");
                    //8 characters validation
                    if (txtPswS.Text.Length > 8)
                    {
                        pic8CharError.Visible = false;

                        pic8CharDone.Visible = true;
                        lbl8Char.Visible = true;
                    }

                    else
                    {

                        pic8CharError.Visible = true;
                        pic8CharDone.Visible = false;
                        lbl8Char.Visible = true;

                    }

                    //Upper case validation
                    if (txtPswS.Text.Any(Char.IsUpper))
                    {
                        picUpperDone.Visible = true;
                        lblUppercase.Visible = true;

                        picUpperError.Visible = false;

                    }
                    else
                    {
                        picUpperDone.Visible = false;
                        picUpperError.Visible = true;

                        lblUppercase.Visible = true;
                    }

                    if (txtPswS.Text.Any(Char.IsDigit))
                    {
                        picErrorDigit.Visible = false;
                        picDigitDone.Visible = true;

                        lblDigits.Visible = true;
                    }
                    else
                    {
                        picErrorDigit.Visible = true;
                        picDigitDone.Visible = false;

                        lblDigits.Visible = true;
                    }


                    if (txtPswS.Text.Length == 0)
                    {

                        picUpperError.Visible = true;
                        pic8CharError.Visible = true;
                        lblUppercase.Visible = true;

                        lbl8Char.Visible = true;
                    }
                }

                if (rdoFemale.Checked == false && rdoMale.Checked == false)
                {
                    errorGender.SetError(groupBox1, "Chose the gender!");//gender validation
                }


                }
            
           




        }

        private void GetGender()//chose the gender
        {
            if (rdoFemale.Checked == true)
            {
                gender = "Female";
            }

            else if (rdoMale.Checked == true)
            {
                gender = "Male";
            }

        }

        private void GetStudent()
        {
            if (chkStu.Checked == true)
            {
                student = "yes";
            }
            else
            {
                student = "no";


            }
        }

        private void database()//create and add database
        {
            GetGender();//called gender
            GetStudent();//called student 

            String user = txtUserS.Text;
            String psw = txtPswS.Text;
            String pswR = txtRePswS.Text;
            String email = txtEmail.Text;
            String code = txtCode.Text;                 


            try
            {

                SqlCommand cmd = new SqlCommand("Insert into UserDetails values('" + user + "','" + psw + "','" + email + "','" + gender + "','" + student + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                con.Close();
            }






        }
     

        private void txtPswS_MouseHover(object sender, EventArgs e)
        {
            String password = txtPswS.Text;
           
                lbl8Char.Visible = true;
                pic8CharError.Visible = true;
            
                lblUppercase.Visible = true;
                picUpperError.Visible = true;

                picErrorDigit.Visible = true;
                lblDigits.Visible = true;

            if (password.Length > 8)
            {
                pic8CharError.Visible = false;
                pic8CharDone.Visible = true;
                
            }
            else
            {

                pic8CharError.Visible = true;
                pic8CharDone.Visible = false;

            }


            if (password.Any(Char.IsUpper))
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
                picErrorDigit.Visible = false;
                picDigitDone.Visible = true;
            }
            else
            {
                picErrorDigit.Visible = true;
                picDigitDone.Visible = false;
            }



        }

        private void txtPswS_MouseLeave(object sender, EventArgs e)
        {

           
            picUpperDone.Visible = false;
            pic8CharDone.Visible = false;
            picUpperError.Visible = false;
            pic8CharError.Visible = false;
            lblUppercase.Visible = false;
            lbl8Char.Visible = false;
            picErrorDigit.Visible = false;
            picDigitDone.Visible = false;
            lblDigits.Visible = false;

            //leave from the textPassowrd hide validation instructions


        }

        private void txtPswS_TextChanged(object sender, EventArgs e)
        {
            
            //8 characters validation
            if (txtPswS.Text.Length > 8)
            {
                pic8CharError.Visible = false;

                pic8CharDone.Visible = true;
                lbl8Char.Visible = true;
            }

            else 
            {

                pic8CharError.Visible = true;
                pic8CharDone.Visible = false;
                lbl8Char.Visible = true;

            }

            //Upper case validation
            if (txtPswS.Text.Any(Char.IsUpper))
            {
                picUpperDone.Visible = true;
                lblUppercase.Visible = true;

                picUpperError.Visible = false;
                
            }
            else
            {
               picUpperDone.Visible = false;
               picUpperError.Visible = true;
               lblUppercase.Visible = true;
            }

            if(txtPswS.Text.Length == 0)
            {
                picUpperDone.Visible = false;
                pic8CharDone.Visible = false;
                picUpperError.Visible = false;
                pic8CharError.Visible = false;
                lblUppercase.Visible = false;
                lbl8Char.Visible = false;
                errorProvider1.Clear();
            }

            if(txtPswS.Text.Any(Char.IsUpper) == true && txtPswS.Text.Length > 8 )
            {
                errorProvider1.Clear();
            }

            if (txtPswS.Text.Any(Char.IsDigit))
            {
                picErrorDigit.Visible = false;
                picDigitDone.Visible = true;

                lblDigits.Visible = true;
            }
            else
            {
                picErrorDigit.Visible = true;
                picDigitDone.Visible = false;

                lblDigits.Visible = true;
            }
            
        }

        private void txtPswS_Validating(object sender, CancelEventArgs e)
        {
        }

        private void txtRePswS_TextChanged(object sender, EventArgs e)
        {
            String pswR = txtRePswS.Text;
            String psw = txtPswS.Text;
            //re enter passowrd validation

           

            if(pswR.Length == 0)
            {
                lblPswR.Visible = false;
            }

            if(pswR == psw)
            {
                errorProvider1.Clear();
                lblPswR.Visible = false;
            }
            else
            {
                lblPswR.Visible = true;
            }

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {
            
        }

        private void rdoFemale_CheckedChanged(object sender, EventArgs e)
        {
           
                errorGender.Clear();
           
        }

        private void rdoMale_CheckedChanged(object sender, EventArgs e)
        {
            errorGender.Clear();
        }

        private void txtUserS_TextChanged(object sender, EventArgs e)
        {
            


            String user = txtUserS.Text;

            

            //check the user name availability
            SqlCommand cmd = new SqlCommand("Select uName from UserDetails where uName = '" + user + "'",con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read() == true)
            {
                lblUserAvailable.Visible = true;
                lblUserAvailable.Text = "Unavailable";
                lblUserAvailable.ForeColor = Color.Salmon;
                
            }

            else
            {

                

                lblUserAvailable.Visible = true;
                lblUserAvailable.Text = "Availble";
                lblUserAvailable.ForeColor = Color.LimeGreen;

              
            }

            con.Close();

            if (user.Length == 0)
            {
                lblUserAvailable.Text = " ";
            }
            if(user.Length > 0)
            {
                erroUser.Clear();
            }
        }

        private void lblUserAvailable_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            String email = txtEmail.Text;
            //check availability of emails
            SqlCommand cmd = new SqlCommand("Select email from UserDetails where email = '" + email + "'",con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read() == true)
            {
                lblEmailAvailble.Visible = true;
            }
            else 
            {
                lblEmailAvailble.Visible = false;
            }
            con.Close();

            if(lblEmailAvailble.Visible == false)
            {
                erroEmail.Clear();
            }

        }

        private void txtCode_MouseHover(object sender, EventArgs e)
        {
            String email = txtEmail.Text;

            btnResend.Visible = false;
            lblEmail.Visible = true;
            lblEmail.Text = "verification code sent to " + email;
        }

        private void txtCode_MouseLeave(object sender, EventArgs e)
        {
            lblEmail.Visible = false;
            btnResend.Visible = true;
            
        }

        private void btnResend_Click(object sender, EventArgs e)
        {
            String email = txtEmail.Text;

            String from, pas, messageBody;

            Random rmd = new Random();
            randomCode = (rmd.Next(9999)).ToString();
            MailMessage message = new MailMessage();

            to = email;
            from = "sazubandara@gmail.com";
            pas = "sazu12345@1";

            messageBody = "Your verification code is - " + randomCode;
            message.To.Add(to);
            message.Body = messageBody;
            message.Subject = "ToDoo email verification!";

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from,pas);

            try
            {
                smtp.Send(message);


            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }


        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (randomCode == txtCode.Text)
                {
                    btnResend.Visible = false;
                    txtCode.Enabled = false;

                    if (chkStu.Checked)
                    {
                        lessonTable();//create lesson table
                    }
                    else
                    {
                        projectTable();//create project table
                    }

                    otherTaskTable();//create other task table
                    
                    important();//create importatnt table
                    noteTable();//create note table
                    remindTable();//create remind table
                    database();// add details to database




                    DialogResult d = MessageBox.Show("You have signed in successfully", "ToDo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                    if (d == DialogResult.OK)
                    {
                        Form1 obj = new Form1();
                        obj.Show();
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }


        }

        

        

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form1 obj = new Form1();
            obj.Show();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void picEyeOpenP_Click(object sender, EventArgs e)
        {
            picEyeHide.Visible = true;
            picEyeOpenP.Visible = false;
            
            txtPswS.UseSystemPasswordChar = false;

                      


        }

        private void picEyeHide_Click_1(object sender, EventArgs e)
        {
            picEyeHide.Visible = false;
            picEyeOpenP.Visible = true;
                        
            txtPswS.UseSystemPasswordChar = true;
                    
        }

    }
}
