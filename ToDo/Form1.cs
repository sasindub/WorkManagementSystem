using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;

namespace ToDo
{
    public partial class Form1 : Form
    {
       
        SqlConnection con = new SqlConnection("Data Source=caur;Initial Catalog=ToDo;Integrated Security=True");
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            lblIncoreect.Visible = false;

            picEyeOpen.Visible = true;
            picEyeHide.Visible = false;

            lblWork.Visible = false;
            pnlAbout.Visible = false; //about panel visiblity 
            lblAbout.Visible = false; //about lable visble

            DateTime a = DateTime.MaxValue;
            DateTime b = DateTime.Now;
          

            if(b.Hour >= 12 && b.Hour < 18)
            {
                lblGreet.Text = "Good Afternoon!";
            }

            else if (b.Hour > 6 && b.Hour < 24)
            {
                lblGreet.Text = "Good Evening!";
            }

            else if(b.Hour >= 00 )
            {
                lblGreet.Text = "Good Morning!";
            }

          



            lblDAte.Text = DateTime.Now.ToLongDateString();
            lblSignShow.Visible = false;
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblSignIn_MouseHover(object sender, EventArgs e)
        {
            lblSignIn.LinkColor = Color.MediumPurple;
            lblSignShow.Visible = true;
        }

        private void lblSignIn_MouseLeave(object sender, EventArgs e)
        {
            lblSignIn.LinkColor = Color.FromArgb(3, 32, 60);
            lblSignShow.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

            string a = "Enter here your user name or email and password to log in to the ToDo.";
            MessageBox.Show(a, "Help", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void lblSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 obj = new Form2();
            obj.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           String greet = lblGreet.Text;
            Form4 obj = new Form4();
            obj.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pnlAbout.Visible = true;
            lblAbout.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            lblAbout.Visible = true;//about label can see
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            lblAbout.Visible = false;
        }

        private void lblGreet_MouseHover(object sender, EventArgs e)
        {
            lblWork.Visible = true;
        }

        private void lblGreet_MouseLeave(object sender, EventArgs e)
        {
            lblWork.Visible = false;
        }

        private void picEyeHide_Click(object sender, EventArgs e)
        {
            txtPsw.UseSystemPasswordChar = true;

            picEyeOpen.Visible = true;
            picEyeHide.Visible = false;



        }

        private void picEyeOpen_Click(object sender, EventArgs e)
        {


           
            txtPsw.UseSystemPasswordChar = false;

            picEyeOpen.Visible = false;
            picEyeHide.Visible = true;



        }

        private void txtPsw_TextChanged(object sender, EventArgs e)
        {
            lblIncoreect.Visible = false;
            this.BackColor = Color.White;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                String user = txtUser.Text;
                String psw = txtPsw.Text;

                SqlCommand cmd = new SqlCommand("Select password, uName from UserDetails where uName =  '" + user + "' OR email = '" + user + "'", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();



                if (rdr.Read() == true)
                {

                    if (psw == rdr.GetString(0))
                    {
                        lblIncoreect.Visible = false;
                        this.BackColor = Color.White;

                        string userName = rdr.GetString(1);

                        Loading obj = new Loading(userName);
                        obj.Show();
                        this.Hide();
                    }
                    else
                    {
                        lblIncoreect.Visible = true;
                        this.BackColor = Color.MistyRose;
                    }

                }
                else
                {
                    lblIncoreect.Visible = true;
                    this.BackColor = Color.MistyRose;
                }
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

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            lblIncoreect.Visible = false;
            this.BackColor = Color.White;
        }
    }
}
