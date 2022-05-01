using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace ToDo
{
    public partial class LessonAdd : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
 (
     int nLeftRect,
     int nTopRect,
     int nRightRect,
     int nBottomRect,
     int nWidthEllipse,
     int nHeightEllipse
 );
        SqlConnection con = new SqlConnection("Data Source=caur;Initial Catalog=ToDo;Integrated Security=True");
        public int totalTime = 0;
        string user;
        string btnType;
        string pName;
      
        
        public LessonAdd(string user, string btnType, string pName)
        {
           
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            this.user = user;
            this.btnType = btnType;
            this.pName = pName;

            
           
            
            
        }
        

        private void LessonAdd_Load(object sender, EventArgs e)
        {
            //if project

            if (btnType == "Project")
            {
                txtSubjectName.PlaceholderText = "Task Name";
                lblLessons.Text = "PROJECTS";
                pnlUpline2.Visible = true;
                pnlUpline.Visible = false;
            }
           

            //visiblity
            numUpDown.Visible = false;
            picTimeOn1.Visible = false;
            picTimeOn2.Visible = false;
            picTimeOn3.Visible = false;
            picTimeOn4.Visible = false;

            picMoreTime.Visible = false;

            lblTime.Visible = false;
            lblTimePeriod.Visible = false;



            
            


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 obj = new Form3(user);
            obj.Show();
        }
        //get more time
        private void moreTime()
        {
            if (picTimeOn1.Visible == true && picTimeOn2.Visible == true && picTimeOn3.Visible == true && picTimeOn4.Visible == true)
            {
                picMoreTime.Visible = true;
            }
            else
            {
                picMoreTime.Visible = false;
            }
        }


        private void getTime()
        {
            try
            {
                int gettime = 0;
                int time = 0;
                if (String.IsNullOrEmpty(numUpDown.Text) == false)
                {
                    gettime = Int32.Parse(numUpDown.Text);
                }

                if (picTimeOn1.Visible == true)
                {
                    time += 20;

                }

                if (picTimeOn2.Visible == true)
                {
                    time += 20;
                }

                if (picTimeOn3.Visible == true)
                {
                    time += 20;
                }

                if (picTimeOn4.Visible == true)
                {
                    time += 20;
                }
                //calculate time
                totalTime = time + gettime;

                
                lblTime.Text = totalTime.ToString() + " min";//assign the time to label
            }
            catch (NullReferenceException)
            { 
            
            }

        }

        //insert product task details

        private void Pinsert()
        {

            string tName = txtSubjectName.Text;
            string des = txtDiscription.Text;

            try
            {

                //insert tasks details to project table


                SqlCommand cmd1 = new SqlCommand("Insert into " + user + pName + " values ('" + tName + "','" + des + "'," + totalTime + ")", con);
                con.Open();
                cmd1.ExecuteNonQuery();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                if (btnType == "Lesson")
                {
                    
                    if (txtSubjectName.Text.Length != 0 && totalTime != 0)
                    {
                        lblTimePeriod.Visible = false;

    
                        string subName = txtSubjectName.Text;
                        string description = txtDiscription.Text;
                        getTime();
                        // moreTime();

                        SqlCommand cmd = new SqlCommand("Insert into " + user + "Lesson values ('" + subName + "','" + description + "'," + totalTime + ")", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        Form3 obj1 = new Form3(user);
                        obj1.Show();
                        this.Close();
                



                    }
                    else
                    {
                        
                        if (txtSubjectName.Text.Length == 0)
                        {
                            lblTimePeriod.Visible = true;
                            lblTimePeriod.Text = "Enter the Subject Name";

                           
                        }

                        if (totalTime == 0)
                        {
                            lblTimePeriod.Visible = true;
                            lblTimePeriod.Text = "Select a time period";
                        }
                    }
                }
               


                if (btnType == "Project")
                {
                    
                    
                    lblTimePeriod.Visible = false;

                   

                    if (txtSubjectName.Text.Length != 0 && totalTime != 0)
                    {
                       

                        Pinsert();

                       

                        Form3 obj = new Form3(user);
                        obj.Show();
                        this.Close();

                       

                    }
                    else
                    {
                        if (txtSubjectName.Text.Length == 0)
                        {
                            lblTimePeriod.Visible = true;
                            lblTimePeriod.Text = "Enter the Task Name";

                        }

                        if (totalTime == 0)
                        {
                            lblTimePeriod.Visible = true;
                            lblTimePeriod.Text = "Select a time period";

                        }
                    }
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


            //Form3 obj = new Form3(user);
            //obj.Show();


        }

        private void picTime4_Click(object sender, EventArgs e)
        {
            picTime4.Visible = false;
            picTimeOn4.Visible = true;
            lblTime.Visible = true;
            getTime();
            moreTime();
        }

        private void picTime3_Click(object sender, EventArgs e)
        {
            picTime3.Visible = false;
            picTimeOn3.Visible = true;
            lblTime.Visible = true;
            getTime();
            moreTime();
        }

        private void picTIme2_Click(object sender, EventArgs e)
        {
            picTIme2.Visible = false;
            picTimeOn2.Visible = true;
            getTime();
            moreTime();


        }

        private void picTime1_Click(object sender, EventArgs e)
        {
            picTime1.Visible = false;
            picTimeOn1.Visible = true;
            lblTime.Visible = true;
            getTime();
            moreTime();

        }

        private void picTimeOn1_Click(object sender, EventArgs e)
        {
            picTime1.Visible = true;
            picTimeOn1.Visible = false;
            lblTime.Visible = true;
            getTime();
            moreTime();
        }

        private void picTmeOn2_Click(object sender, EventArgs e)
        {
            picTIme2.Visible = true;
            picTimeOn2.Visible = false;
            getTime();
            moreTime();
        }

        private void picTmeOn3_Click(object sender, EventArgs e)
        {
            picTime3.Visible = true;
            picTimeOn3.Visible = false;
            lblTime.Visible = true;
            getTime();
            moreTime();
        }

        private void picTmeOn4_Click(object sender, EventArgs e)
        {
            picTime4.Visible = true;
            picTimeOn4.Visible = false;
            lblTime.Visible = true;
            getTime();
            moreTime();
        }

        private void picMoreTime_Click(object sender, EventArgs e)
        {
            numUpDown.Visible = true;
            lblTime.Visible = false;
            getTime();
            moreTime();
        }

        private void numUpDown_Leave(object sender, EventArgs e)
        {
            numUpDown.Visible = false;
            lblTime.Visible = true;
            getTime();
            moreTime();
        }

        private void numUpDown_ValueChanged(object sender, EventArgs e)
        {
            lblTime.Visible = false;
            getTime();
            moreTime();
        }

        private void numUpDown_Click(object sender, EventArgs e)
        {
            lblTime.Visible = false;
        }

        private void LessonAdd_Activated(object sender, EventArgs e)
        {
            if (txtSubjectName.Text.Length == 0 && totalTime == 0)
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }
    }
}
