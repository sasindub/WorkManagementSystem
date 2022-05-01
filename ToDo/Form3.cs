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
using System.IO;
using System.Media;


namespace ToDo
{
    public partial class Form3 : Form
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

        String user;
        String btnType;
        String pName;
        String task;
        String lblTask;
        bool projectIstrue = false;
        bool isPvalid = true;

        //alarm

        string selectedTime;


        string time;

        SqlConnection con = new SqlConnection("Data Source=caur;Initial Catalog=ToDo;Integrated Security=True");
        public Form3(String user)
        {

            InitializeComponent();


            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNavi.Height = pnlUser.Height;
            pnlNavi.Top = pnlUser.Top;
            pnlNavi.Left = pnlUser.Left;
            //pnlUser.BackColor = Color.FromArgb(46, 51, 73);

            pnlNavi2.Height = btnProf.Height;
            pnlNavi2.Top = btnProf.Top;
            pnlNavi2.Left = btnProf.Left;
            btnProf.BackColor = Color.FromArgb(46, 51, 73);

            //panel visiblity

            //pnlLesson.Visible = false;




            this.user = user; //get the user name from login form
            //get user details
            lblUserName.Text = user;
            lblUser2.Text = user;
            try
            {
                SqlCommand cmd = new SqlCommand("Select email,gender,student from UserDetails where uName = '" + user + "'", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    lblEmail.Text = rdr.GetString(0);
                    lblGender.Text = rdr.GetString(1);
                    if (rdr.GetString(2) == "yes")//check the student or not
                    {
                        lblSudent.Text = "I am a Student";
                        btnLesson.Visible = true;
                        btnProject.Visible = false;
                        btnProjectMenu.Visible = false;
                        btnLessonMenu.Visible = true;
                        

                    }
                    else
                    {
                        lblSudent.Text = null;
                        btnLesson.Visible = false;
                        btnProject.Visible = true;
                        btnProjectMenu.Visible = true;
                        btnLessonMenu.Visible = false;
                        projectIstrue = true;

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There is an error!");
            }
            finally
            {
                con.Close();
            }

        }     


     

        private void taskFinish()
        {
            try
            {
                if (lblSudent.Text == "I am a Student")
                {
                    SqlCommand cmd1 = new SqlCommand("Delete from " + user + "Lesson where time = 0", con);
                    con.Open();
                    cmd1.ExecuteNonQuery();

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

        private void projectPanels()
        {
            try
            {
                //load first project panel
                SqlCommand cmd = new SqlCommand("Select projectName from " + user + "Project where pNo = 1", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();


                if (rdr.Read())
                {
                    
                    pnlP1.Visible = true;
                    lblP1.Text = rdr.GetString(0);

                    con.Close();

                    p1CmboLoad();

                   
                }
                else
                {
                    con.Close();
                }

                //load 2nd project panel

                SqlCommand cmd1 = new SqlCommand("Select projectName from " + user + "Project where pNo = 2", con);
                con.Open();
                SqlDataReader rdr1 = cmd1.ExecuteReader();

                if (rdr1.Read())
                {
                    pnlP2.Visible = true;
                    lblP2.Text = rdr1.GetString(0);

                    con.Close();

                    p2CmboLoad();
                }
                else
                {
                    con.Close();
                }

                //load 3rd project panel
                SqlCommand cmd2 = new SqlCommand("Select projectName from " + user + "Project where pNo = 3", con);
                con.Open();
                SqlDataReader rdr2 = cmd2.ExecuteReader();

                if (rdr2.Read())
                {
                    pnlP3.Visible = true;
                    lblP3.Text = rdr2.GetString(0);

                    con.Close();

                    p3CmboLoad();
                }
                else
                {
                    con.Close();
                }

                //load 4th project panel
                SqlCommand cmd3 = new SqlCommand("Select projectName from " + user + "Project where pNo = 4", con);
                con.Open();
                SqlDataReader rdr3 = cmd3.ExecuteReader();

                if (rdr3.Read())
                {
                    pnlP4.Visible = true;
                    lblP4.Text = rdr3.GetString(0);

                    con.Close();

                    p4CmboLoad();
                }
                else
                {
                    con.Close();
                }

                //load 5th project panel
                SqlCommand cmd4 = new SqlCommand("Select projectName from " + user + "Project where pNo = 5", con);
                con.Open();
                SqlDataReader rdr4 = cmd4.ExecuteReader();

                if (rdr4.Read())
                {
                    pnlP5.Visible = true;
                    lblP5.Text = rdr4.GetString(0);

                    con.Close();

                    p5CmboLoad();
                }
                else
                {
                    con.Close();
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

        //project 1 combo load
        private void p1CmboLoad()
        {
            try
            {


                cmboP1.Items.Clear();
                SqlCommand cmd = new SqlCommand("Select taskName from " + user + lblP1.Text, con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmboP1.Items.Add(rdr.GetString(0));
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

        //project 2 combo load
            private void p2CmboLoad()
            {
                try
                {


                    cmboP2.Items.Clear();
                    SqlCommand cmd = new SqlCommand("Select taskName from " + user + lblP2.Text, con);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        cmboP2.Items.Add(rdr.GetString(0));
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

        //project 3 combo load
        private void p3CmboLoad()
        {
            try
            {


                cmboP3.Items.Clear();
                SqlCommand cmd = new SqlCommand("Select taskName from " + user + lblP3.Text, con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmboP3.Items.Add(rdr.GetString(0));
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

        //project 4 combo load
        private void p4CmboLoad()
        {
            try
            {


                cmboP4.Items.Clear();
                SqlCommand cmd = new SqlCommand("Select taskName from " + user + lblP4.Text, con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmboP4.Items.Add(rdr.GetString(0));
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

        //project 5 combo load
        private void p5CmboLoad()
        {
            try
            {


                cmboP5.Items.Clear();
                SqlCommand cmd = new SqlCommand("Select taskName from " + user + lblP5.Text, con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmboP5.Items.Add(rdr.GetString(0));
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

        private void quickTaskLoad()
        {
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("Select taskName from " + user + "OtherTask", con);
                con.Open();
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                con.Close();

                datagridQuickTask.DataSource = tbl;
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

        private void remindComboData()
        {
            //add hours
            for (int i = 0; i <= 12; i++)
            {
                cmboHours.Items.Add(i.ToString());
            }

            //add mins
            for (int i = 10; i <= 59; i++)
            {

                cmboMin.Items.Add(i.ToString());
            }

            cmboAMPM.Items.Add("AM");
            cmboAMPM.Items.Add("PM");
        }

        //remind time cmbo load
        private void remindTimeCombo()
        {
            
            pnlGetRemind.BackColor = Color.FromArgb(7, 77, 146);
           

            //get the time,text  and date from database
            string date = DateTime.Now.ToString("MM/dd/yyyy");
                     
            
            try
            {
                SqlCommand cmd = new SqlCommand("Select time, text from " + user + "Remind where date = '" + date + "'", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                   
                    pnlGetRemind.Visible = true;
                    lblGetTime.Text = rdr.GetString(0);
                    txtRimindget.Text = rdr.GetString(1);

                    con.Close();

                }
                else
                {
                    pnlGetRemind.Visible = false;
                    con.Close();
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
        
        //loading the remind grid view
        private void remindGridLoad()
        {
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("Select date,time,text from " + user + "Remind", con);
                con.Open();
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                con.Close();


                dataGridReminder.DataSource = tbl;
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

        private void Form3_Load(object sender, EventArgs e)
        {
            
            pnlNavigation.Visible = false;
            pnlLesson.Visible = false ;
            pnlProject.Visible = false;
            pnlOtherTasks.Visible = false;
            pnlImportant.Visible = false;
            pnlReminder.Visible = false;
            //pnlProjectTasks.Visible = false;

            btnAddTasks.Visible = false;
            txtPname.Visible = false;

            pnlP1.Visible = false;
            pnlP2.Visible = false;

            pnlP3.Visible = false;
            pnlP4.Visible = false;
            pnlP5.Visible = false;

            lbl5Project.Visible = false;

            btnRemindDelete.Visible = false;//remind delete button not visible 

            pnlRemindDetails.Visible = false;//remind details panel hide


            timer1.Start();
            timeRemind.Start();


            if (projectIstrue == true)
            {
                projectPanels();
            }

            taskFinish();
            quickTaskLoad();

            remindTimeCombo();
            remindGridLoad();
            remindComboData();










            //---------------------------------------------------------------loadddddddddddddddddddd

        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            //panel hide
            pnlProject.Visible = false;
            pnlUserDetails.Visible = false;
            pnlLesson.Visible = false;
            pnlOtherTasks.Visible = true;
            pnlImportant.Visible = false;
            pnlReminder.Visible = false;



            pnlNavi.Height = btnTask.Height;
            pnlNavi.Top = btnTask.Top;
            pnlNavi.Left = btnTask.Left;
            btnTask.BackColor = Color.FromArgb(46,51,73);

            btnLesson.BackColor = Color.FromArgb(3, 32, 60);
            btnImportant.BackColor = Color.FromArgb(3, 32, 60);
            btnNote.BackColor = Color.FromArgb(3, 32, 60);
            btnRemind.BackColor = Color.FromArgb(3, 32, 60);
            btnProject.BackColor = Color.FromArgb(3, 32, 60);
        }

        private void btnLesson_Click(object sender, EventArgs e)
        {
            //panel hide
            pnlProject.Visible = false;
            pnlUserDetails.Visible = false;
            pnlOtherTasks.Visible = false;
            pnlLesson.Visible = true;
            pnlImportant.Visible = false;
            pnlReminder.Visible = false;
            //pnlProjectTasks.Visible = false;


            pnlNavi.Height = btnLesson.Height;
            pnlNavi.Top = btnLesson.Top;
            pnlNavi.Left = btnLesson.Left;
            btnLesson.BackColor = Color.FromArgb(46,51,73);

            btnTask.BackColor = Color.FromArgb(3, 32, 60);
            btnImportant.BackColor = Color.FromArgb(3, 32, 60);
            btnNote.BackColor = Color.FromArgb(3, 32, 60);
            btnRemind.BackColor = Color.FromArgb(3, 32, 60);
            try
            {

                //get the data

                SqlCommand cmd = new SqlCommand("Select time as TIME,description as DESCRIPTION,SubjectName as LESSON from " + user + "Lesson", con);
                con.Open();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);

                dataGridLesson.DataSource = tbl;

               





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

        private void btnRemind_Click(object sender, EventArgs e)
        {
            pnlNavi.Height = btnRemind.Height;
            pnlNavi.Top = btnRemind.Top;
            pnlNavi.Left = btnRemind.Left;
            btnRemind.BackColor = Color.FromArgb(46, 51, 73);

            btnTask.BackColor = Color.FromArgb(3, 32, 60);
            btnLesson.BackColor = Color.FromArgb(3, 32, 60);
            btnNote.BackColor = Color.FromArgb(3, 32, 60);
            btnImportant.BackColor = Color.FromArgb(3, 32, 60);
            btnProject.BackColor = Color.FromArgb(3, 32, 60);

            //panel hide
            pnlProject.Visible = false;
            pnlUserDetails.Visible = false;
            pnlLesson.Visible = false;
            pnlOtherTasks.Visible = false;
            pnlImportant.Visible = false;
            pnlReminder.Visible = true;





        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            pnlNavigation.Visible = false;
            pnlHalfNavi.Visible = true;

            if (pnlUserDetails.Visible == true)
            {
                pnlNavi2.Height = btnProf.Height;
                pnlNavi2.Top = btnProf.Top;
                pnlNavi2.Left = btnProf.Left;

                btnProf.BackColor = Color.FromArgb(46, 51, 73);
                btnSettings.BackColor = Color.FromArgb(3, 32, 60);
            }
            else
            {
                pnlNavi2.Visible = false;
                btnProf.BackColor = Color.FromArgb(3, 32, 60);
                btnSettings.BackColor = Color.FromArgb(3, 32, 60);

            }
           

            
            
        }

        private void btnMenu2_Click(object sender, EventArgs e)
        {
            pnlNavigation.Visible = true;
            pnlHalfNavi.Visible = false;

            if (pnlUserDetails.Visible == true)
            {
                pnlNavi.Height = pnlUser.Height;
                pnlNavi.Top = pnlUser.Top;
                pnlNavi.Left = pnlUser.Left;

                btnTask.BackColor = Color.FromArgb(3, 32, 60);
                btnLesson.BackColor = Color.FromArgb(3, 32, 60);
                btnNote.BackColor = Color.FromArgb(3, 32, 60);
                btnImportant.BackColor = Color.FromArgb(3, 32, 60);
                btnRemind.BackColor = Color.FromArgb(3, 32, 60);


            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult d;

            d = MessageBox.Show("Do you want to sign out ? ", "ToDo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                Form1 obj = new Form1();
                obj.Show();

                this.Close();
            }
           

        }

       

        private void pnlUser_Click(object sender, EventArgs e)
        {
            pnlNavi.Height = pnlUser.Height;
            pnlNavi.Top = pnlUser.Top;
            pnlNavi.Left = pnlUser.Left;
            

            btnTask.BackColor = Color.FromArgb(3, 32, 60);
            btnLesson.BackColor = Color.FromArgb(3, 32, 60);
            btnNote.BackColor = Color.FromArgb(3, 32, 60);
            btnImportant.BackColor = Color.FromArgb(3, 32, 60);
            btnRemind.BackColor = Color.FromArgb(3, 32, 60);
            btnProject.BackColor = Color.FromArgb(3, 32, 60);

            //show the panel details



            //pnl visiblity
            pnlUserDetails.Visible = true;
            pnlProject.Visible = false;
            pnlLesson.Visible = false;
            pnlOtherTasks.Visible = false;
            pnlImportant.Visible = false;
            pnlReminder.Visible = false;



        }

        private void btnProf_Click(object sender, EventArgs e)
        {
            pnlNavi2.Visible = true;
            pnlNavi2.Height = btnProf.Height;
            pnlNavi2.Top = btnProf.Top;
            pnlNavi2.Left = btnProf.Left;

            btnProf.BackColor = Color.FromArgb(46, 51, 73);
            btnSettings.BackColor = Color.FromArgb(3, 32, 60);

            pnlUserDetails.Visible = true;
            //pnlProjectTasks.Visible = false;

            //pnl visiblity
            pnlUserDetails.Visible = true;
            pnlProject.Visible = false;
            pnlLesson.Visible = false;
            pnlOtherTasks.Visible = false;
            pnlImportant.Visible = false;
            pnlReminder.Visible = false;


        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlNavi2.Visible = true;
            pnlNavi2.Height = btnSettings.Height;
            pnlNavi2.Top = btnSettings.Top;
            pnlNavi2.Left =btnSettings.Left;

            btnSettings.BackColor = Color.FromArgb(46, 51, 73);
            btnProf.BackColor = Color.FromArgb(3, 32, 60);
        }

        private void btnSaveNote_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd1 = new SaveFileDialog();
            if (sfd1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(sfd1.FileName, FileMode.CreateNew)) 
                using(StreamWriter sw = new StreamWriter(s)) 
                { 
                   sw.Write(txtTempBox.Text);
                }
              ;
            }
        }

        private void btnLessonAdd_Click(object sender, EventArgs e)
        {
            if (btnProject.Visible == true)
                btnType = "Project";
            else
                btnType = "Lesson";


            pName = lblTask;// name of the project
           
            this.Close();
            LessonAdd obj = new LessonAdd(user, btnType, pName);
            obj.Show();

           
        }

        private void dataGridLesson_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (btnProject.Visible == false)
            {
                btnType = "Lesson";
                try
                {
                    //click start button
                    string row = dataGridLesson.Rows[e.RowIndex].Cells["LESSON"].Value.ToString();
                    if (dataGridLesson.Columns[e.ColumnIndex].Name == "START")
                    {
                        Timer obj = new Timer(row, user, btnType, task);
                        obj.Show();
                        this.Hide();
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
                //-------------------------------------------------------------

                //click delete button

                string a = dataGridLesson.Rows[e.RowIndex].Cells["LESSON"].Value.ToString();

                if (dataGridLesson.Columns[e.ColumnIndex].Name == "DELETE")
                {
                    try
                    {
                        //delete row
                        SqlCommand cmd = new SqlCommand("Delete from " + user + "Lesson where SubjectName = '" + a + "'", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                    }
                    finally
                    {
                        con.Close();
                    }

                    try
                    {
                        string lbl1 = lblP1.Text;
                        string lbl2 = lblP2.Text;
                        string lbl3 = lblP3.Text;
                        string lbl4 = lblP4.Text;

                        //load table
                        SqlCommand cmd = new SqlCommand("Select time as TIME,description as DESCRIPTION, subjectName as LESSON from " + user + "Lesson", con);
                        con.Open();
                        SqlDataAdapter adp = new SqlDataAdapter(cmd);
                        DataTable tbl = new DataTable();
                        adp.Fill(tbl);
                       

                        dataGridLesson.DataSource = tbl;
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



            }



            //project tasks
            else
            {
                string bb = dataGridLesson.Rows[e.RowIndex].Cells["TASK"].Value.ToString();

                if (dataGridLesson.Columns[e.ColumnIndex].Name == "DELETE")
                {
                    
                    try
                    {
                        //delete row
                        SqlCommand cmd = new SqlCommand("Delete from " + user + task + " where taskName = '" + bb + "'", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                }
                    catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
                finally
                {
                    con.Close();
                }


                    try
                    {
                        //load table
                        SqlCommand cmd1 = new SqlCommand("Select time as TIME,description as DESCRIPTION, taskName as TASK from " + user + lblTask, con);
                        con.Open();
                        SqlDataAdapter adp = new SqlDataAdapter(cmd1);
                        DataTable tbl = new DataTable();
                        adp.Fill(tbl);
                        

                        dataGridLesson.DataSource = tbl;
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

                try
                {
                    btnType = "Project";

                    //click start button
                    
                    if (dataGridLesson.Columns[e.ColumnIndex].Name == "START")
                    {
                    string row1 = dataGridLesson.Rows[e.RowIndex].Cells["TASK"].Value.ToString();

                       
                        Timer obj = new Timer(row1, user, btnType, task);
                        obj.Show();
                        this.Hide();
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }




            }     
                          
                
            
        }

        private void dataGridLesson_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                e.CellStyle.SelectionBackColor = Color.FromArgb(249, 76, 86);
                e.CellStyle.SelectionForeColor = Color.White;
            }
            if (e.ColumnIndex == 0)
            {
                e.CellStyle.SelectionBackColor = Color.SteelBlue;
                e.CellStyle.SelectionForeColor = Color.White;
            }

        }

        private void btnProjectAdd_Click(object sender, EventArgs e)
        {
            
                

            if (pnlP1.Visible == true && pnlP2.Visible == true && pnlP3.Visible == true && pnlP4.Visible == true && pnlP5.Visible == true)
            {
                lbl5Project.Visible = true;
                txtPname.Visible = false;
            }
            else
            {

                txtPname.Visible = true;
                lbl5Project.Visible = false;
            }
                
            
           
        }

        private void btnProject_Click(object sender, EventArgs e)
        {
            pnlNavi.Height = btnProject.Height;
            pnlNavi.Top = btnProject.Top;
            pnlNavi.Left = btnProject.Left;
            btnProject.BackColor = Color.FromArgb(46, 51, 73);

            btnTask.BackColor = Color.FromArgb(3, 32, 60);
            btnLesson.BackColor = Color.FromArgb(3, 32, 60);
            btnNote.BackColor = Color.FromArgb(3, 32, 60);
            btnImportant.BackColor = Color.FromArgb(3, 32, 60);
            btnRemind.BackColor = Color.FromArgb(3, 32, 60);
           

            pnlProject.Visible = true;
            pnlUserDetails.Visible = false;
            pnlLesson.Visible = false;
            pnlOtherTasks.Visible = false;
            pnlImportant.Visible = false;
            pnlReminder.Visible = false;

            projectPanels();

        }

        private void txtPname_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPname.Text))
                btnAddTasks.Visible = false;
            else
                btnAddTasks.Visible = true;


            if (pnlP1.Visible == true && pnlP2.Visible == true && pnlP3.Visible == true && pnlP4.Visible == true && pnlP5.Visible == true)
            {
                txtPname.Visible = false;
            }
           

        }

        private void pnlProject_Leave(object sender, EventArgs e)
        {
            btnAddTasks.Visible = false;
            txtPname.Visible = false;
            txtPname.Text = null;
            lbl5Project.Visible = false;

            projectPanels();
        }

        //project validation
        private void Pvalid()
        {
            string pName = txtPname.Text;
            int i = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("Select projectName from " + user + "Project where projectName = '" + pName + "'"  , con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("There is a project called " + pName, "ToDo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    con.Close();
                    isPvalid = false;
                }
                else
                {
                    con.Close();

                    if (pnlP1.Visible == false && pnlP2.Visible == false && pnlP3.Visible == false && pnlP4.Visible == false && pnlP5.Visible == false)
                    {
                        i = 1;
                    }

                    else if (pnlP1.Visible == true && pnlP2.Visible == false && pnlP3.Visible == false && pnlP4.Visible == false && pnlP5.Visible == false)
                    {
                        i = 2;
                    }

                    else if (pnlP1.Visible == true && pnlP2.Visible == true && pnlP3.Visible == false && pnlP4.Visible == false && pnlP5.Visible == false)
                    {
                        i = 3;
                    }

                    else if (pnlP1.Visible == true && pnlP2.Visible == true && pnlP3.Visible == true && pnlP4.Visible == false && pnlP5.Visible == false)
                    {
                        i = 4;
                    }

                    else if (pnlP1.Visible == true && pnlP2.Visible == true && pnlP3.Visible == true && pnlP4.Visible == true && pnlP5.Visible == false)
                    {
                        i = 5;
                    }




                    string projectName = txtPname.Text;
                //insert projectName to database
                    SqlCommand cmd1 = new SqlCommand("Insert into " + user + "Project values (" + i + ",'" + projectName + "')", con);
                    con.Open();
                    cmd1.ExecuteNonQuery();
                    con.Close();

                //go to add the task for project
                btnType = "Project";
                pName = txtPname.Text;
                   
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

        private void createPtable()
        {
          
            string projectName = txtPname.Text;


            try
            {
                //create a project name table
                SqlCommand cmd = new SqlCommand("Create table " + user + projectName + "(taskNo int NOT NULL primary key Identity(1,1), taskName varchar(255), description text ,time int);", con);
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

        private void btnAddTasks_Click(object sender, EventArgs e)//-------------------------------
        {
            
            Pvalid();
            if (isPvalid == true)
            {
                createPtable();
                projectPanels();


                string pName = txtPname.Text;

                LessonAdd obj = new LessonAdd(user, btnType, pName);
                obj.Show();
                this.Close();
            }



            // SqlCommand cmd = new SqlCommand("Select projectName from " + user + "Project where projectName = '" + pName + "'" ,con );


            txtPname.Text = null;
            


            

        }

        private void txtPname_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (Char.IsWhiteSpace(ch))
            {
                e.Handled = true;
            }
        }

        private void chkP1_CheckedChanged(object sender, EventArgs e)
        {
            
                string lbl1 = lblP1.Text;
                string lbl2 = lblP2.Text;
                string lbl3 = lblP3.Text;
                string lbl4 = lblP4.Text;
                string lbl5 = lblP5.Text;

               
                    //delete 1st project
                    SqlCommand cmd = new SqlCommand("Delete from " + user + "Project where pNo = 1", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    //drop 1st project
                    SqlCommand cmd1 = new SqlCommand("Drop table " + user + lbl1, con);
                    con.Open();
                    cmd1.ExecuteNonQuery();
                    con.Close();

                    //update pNo to 1
                    SqlCommand cmd2 = new SqlCommand("Update " + user + "Project set pNo = 1 where pNo = 2 ", con);
                    con.Open();
                    cmd2.ExecuteNonQuery();
                    con.Close();

                    SqlCommand cmd3 = new SqlCommand("Update " + user + "Project set pNo = 2 where pNo = 3 ", con);
                    con.Open();
                    cmd3.ExecuteNonQuery();
                    con.Close();

                    SqlCommand cmd4 = new SqlCommand("Update " + user + "Project set pNo = 3 where pNo = 4 ", con);
                    con.Open();
                    cmd4.ExecuteNonQuery();
                    con.Close();

                    SqlCommand cmd5 = new SqlCommand("Update " + user + "Project set pNo = 4 where pNo = 5 ", con);
                    con.Open();
                    cmd5.ExecuteNonQuery();
                    con.Close();

                    pnlP1.Visible = false;
                    pnlP2.Visible = false;
                    pnlP3.Visible = false;
                    pnlP4.Visible = false;
                    pnlP5.Visible = false;


                    projectPanels();
                

            
            
           
                
           


        }

        private void chkP2_CheckedChanged(object sender, EventArgs e)
        {
          
                string lbl1 = lblP1.Text;
                string lbl2 = lblP2.Text;
                string lbl3 = lblP3.Text;
                string lbl4 = lblP4.Text;
                string lbl5 = lblP5.Text;

                //delete 2st project
                SqlCommand cmd = new SqlCommand("Delete from " + user + "Project where pNo = 2", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                SqlCommand cmd1 = new SqlCommand("Drop table " + user + lbl2, con);
                con.Open();
                cmd1.ExecuteNonQuery();
                con.Close();

                //update pNo to 2
                SqlCommand cmd2 = new SqlCommand("Update " + user + "Project set pNo = 2 where pNo = 3 ", con);
                con.Open();
                cmd2.ExecuteNonQuery();
                con.Close();

                SqlCommand cmd3 = new SqlCommand("Update " + user + "Project set pNo = 3 where pNo = 4 ", con);
                con.Open();
                cmd3.ExecuteNonQuery();
                con.Close();

                SqlCommand cmd4 = new SqlCommand("Update " + user + "Project set pNo = 4 where pNo = 5 ", con);
                con.Open();
                cmd4.ExecuteNonQuery();
                con.Close();


                pnlP1.Visible = true;
                pnlP2.Visible = false;
                pnlP3.Visible = false;
                pnlP4.Visible = false;
                pnlP5.Visible = false;

                projectPanels();

            
           
           
                
           


        }

       

      

        

        private void chkP4_CheckedChanged(object sender, EventArgs e)
        {
          
                string lbl1 = lblP1.Text;
                string lbl2 = lblP2.Text;
                string lbl3 = lblP3.Text;
                string lbl4 = lblP4.Text;
                string lbl5 = lblP5.Text;

                //delete 4th project
                SqlCommand cmd = new SqlCommand("Delete from " + user + "Project where pNo = 4", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                //drop 4th table
                SqlCommand cmd1 = new SqlCommand("Drop table " + user + lbl4, con);
                con.Open();
                cmd1.ExecuteNonQuery();
                con.Close();

                //update pNo to 4
                SqlCommand cmd2 = new SqlCommand("Update " + user + "Project set pNo = 4 where pNo = 5 ", con);
                con.Open();
                cmd2.ExecuteNonQuery();
                con.Close();

                pnlP1.Visible = true;
                pnlP2.Visible = true;
                pnlP3.Visible = true;
                pnlP4.Visible = false;
                pnlP5.Visible = false;

                projectPanels();
            
        }

        private void chkP5_CheckedChanged(object sender, EventArgs e)
        {
            
                string lbl1 = lblP1.Text;
                string lbl2 = lblP2.Text;
                string lbl3 = lblP3.Text;
                string lbl4 = lblP4.Text;
                string lbl5 = lblP5.Text;

                //drop 4nd table
                SqlCommand cmd1 = new SqlCommand("Drop table " + user + lbl5, con);
                con.Open();
                cmd1.ExecuteNonQuery();
                con.Close();

                //delete 5th project
                SqlCommand cmd = new SqlCommand("Delete from " + user + "Project where pNo = 5", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                pnlP1.Visible = true;
                pnlP2.Visible = true;
                pnlP3.Visible = true;
                pnlP4.Visible = true;
                pnlP5.Visible = false;

                projectPanels();
            
        }

        private void chkP3_CheckedChanged(object sender, EventArgs e)
        {
           
            
                string lbl1 = lblP1.Text;
                string lbl2 = lblP2.Text;
                string lbl3 = lblP3.Text;
                string lbl4 = lblP4.Text;
                string lbl5 = lblP5.Text;

                //delete 3rd project
                SqlCommand cmd = new SqlCommand("Delete from " + user + "Project where pNo = 3", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                //drop 3rd project
                SqlCommand cmd1 = new SqlCommand("Drop table " + user + lbl3, con);
                con.Open();
                cmd1.ExecuteNonQuery();
                con.Close();

                //update pNo to 2
                SqlCommand cmd2 = new SqlCommand("Update " + user + "Project set pNo = 3 where pNo = 4 ", con);
                con.Open();
                cmd2.ExecuteNonQuery();
                con.Close();

                SqlCommand cmd3 = new SqlCommand("Update " + user + "Project set pNo = 4 where pNo = 5 ", con);
                con.Open();
                cmd3.ExecuteNonQuery();
                con.Close();



                pnlP1.Visible = true;
                pnlP2.Visible = true;
                pnlP3.Visible = false;
                pnlP4.Visible = false;
                pnlP5.Visible = false;

                projectPanels();
            



        }

        private void lblP1_Click(object sender, EventArgs e)
        {
            
            pnlLesson.Visible = true;
            pnlProject.Visible = false;
            pnlUserDetails.Visible = false;
            task = lblP1.Text;

            lblTask = lblP1.Text;
      

            

            SqlCommand cmd = new SqlCommand("Select time as TIME,description as DESCRIPTION, taskName as TASK from " + user + lblTask , con);
            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            con.Close();

            dataGridLesson.DataSource = tbl;

            

        }

        //load the data to the important grid view fro important table
        private void importantGridLoad()
        {
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("Select noteName from " + user + "Important", con);
                con.Open();
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                con.Close();

                dataGridImportant.DataSource = tbl;
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

        private void btnImportant_Click(object sender, EventArgs e)
        {

            importantGridLoad();

            txtPsw.Text = null;

            pnlNavi.Height = btnImportant.Height;
            pnlNavi.Top = btnImportant.Top;
            pnlNavi.Left = btnImportant.Left;
            btnImportant.BackColor = Color.FromArgb(46, 51, 73);

            btnTask.BackColor = Color.FromArgb(3, 32, 60);
            btnLesson.BackColor = Color.FromArgb(3, 32, 60);
            btnNote.BackColor = Color.FromArgb(3, 32, 60);
            btnProject.BackColor = Color.FromArgb(3, 32, 60);
            btnRemind.BackColor = Color.FromArgb(3, 32, 60);


            pnlProject.Visible = false;
            pnlUserDetails.Visible = false;
            pnlLesson.Visible = false;
            pnlOtherTasks.Visible = false;
            pnlImportant.Visible = true;
            pnlPassword.Visible = true;
            pnlReminder.Visible = false;

            dataGridImportant.Visible = false;
            btnAddImportant.Visible = false;
            btnDelete.Visible = false;

        }

        private void btnNote_Click(object sender, EventArgs e)
        {
            Note obj = new Note(user);
            obj.Show();
            this.Close();
        }

        private void lblP2_Click(object sender, EventArgs e)
        {
            pnlLesson.Visible = true;
            pnlProject.Visible = false;
            pnlUserDetails.Visible = false;
            task = lblP2.Text;

            lblTask = lblP2.Text;




            SqlCommand cmd = new SqlCommand("Select time as TIME,description as DESCRIPTION, taskName as TASK from " + user + lblTask, con);
            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            con.Close();

            dataGridLesson.DataSource = tbl;
        }

        private void lblP3_Click(object sender, EventArgs e)
        {
            pnlLesson.Visible = true;
            pnlProject.Visible = false;
            pnlUserDetails.Visible = false;
            task = lblP3.Text;

            lblTask = lblP3.Text;




            SqlCommand cmd = new SqlCommand("Select time as TIME,description as DESCRIPTION, taskName as TASK from " + user + lblTask, con);
            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            con.Close();

            dataGridLesson.DataSource = tbl;
        }

        private void lblP4_Click(object sender, EventArgs e)
        {
            pnlLesson.Visible = true;
            pnlProject.Visible = false;
            pnlUserDetails.Visible = false;
            task = lblP4.Text;

            lblTask = lblP4.Text;




            SqlCommand cmd = new SqlCommand("Select time as TIME,description as DESCRIPTION, taskName as TASK from " + user + lblTask, con);
            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            con.Close();

            dataGridLesson.DataSource = tbl;
        }

        private void lblP5_Click(object sender, EventArgs e)
        {
            pnlLesson.Visible = true;
            pnlProject.Visible = false;
            pnlUserDetails.Visible = false;
            task = lblP5.Text;

            lblTask = lblP5.Text;




            SqlCommand cmd = new SqlCommand("Select time as TIME,description as DESCRIPTION, taskName as TASK from " + user + lblTask, con);
            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            con.Close();

            dataGridLesson.DataSource = tbl;
        }

        private void btnReminderMenu_Click(object sender, EventArgs e)
        {
            pnlNavi.Height = btnRemind.Height;
            pnlNavi.Top = btnRemind.Top;
            pnlNavi.Left = btnRemind.Left;
            btnRemind.BackColor = Color.FromArgb(46, 51, 73);

            btnTask.BackColor = Color.FromArgb(3, 32, 60);
            btnLesson.BackColor = Color.FromArgb(3, 32, 60);
            btnNote.BackColor = Color.FromArgb(3, 32, 60);
            btnImportant.BackColor = Color.FromArgb(3, 32, 60);
            btnProject.BackColor = Color.FromArgb(3, 32, 60);

            //panel hide
            pnlProject.Visible = false;
            pnlUserDetails.Visible = false;
            pnlLesson.Visible = false;
            pnlOtherTasks.Visible = false;
            pnlImportant.Visible = false;
            pnlReminder.Visible = true;
            pnlNavigation.Visible = true;
        }

        private void btnImportatntMenu_Click(object sender, EventArgs e)
        {
            importantGridLoad();

            txtPsw.Text = null;

            pnlNavi.Height = btnImportant.Height;
            pnlNavi.Top = btnImportant.Top;
            pnlNavi.Left = btnImportant.Left;
            btnImportant.BackColor = Color.FromArgb(46, 51, 73);

            btnTask.BackColor = Color.FromArgb(3, 32, 60);
            btnLesson.BackColor = Color.FromArgb(3, 32, 60);
            btnNote.BackColor = Color.FromArgb(3, 32, 60);
            btnProject.BackColor = Color.FromArgb(3, 32, 60);
            btnRemind.BackColor = Color.FromArgb(3, 32, 60);


            pnlProject.Visible = false;
            pnlUserDetails.Visible = false;
            pnlLesson.Visible = false;
            pnlOtherTasks.Visible = false;
            pnlImportant.Visible = true;
            pnlPassword.Visible = true;
            pnlNavigation.Visible = true;

            dataGridImportant.Visible = false;
            btnAddImportant.Visible = false;
            btnDelete.Visible = false;
        }

        private void btnTaskMenu_Click(object sender, EventArgs e)
        {
            pnlNavi.Height = btnTask.Height;
            pnlNavi.Top = btnTask.Top;
            pnlNavi.Left = btnTask.Left;
            btnTask.BackColor = Color.FromArgb(46, 51, 73);

            btnProject.BackColor = Color.FromArgb(3, 32, 60);
            btnLesson.BackColor = Color.FromArgb(3, 32, 60);
            btnNote.BackColor = Color.FromArgb(3, 32, 60);
            btnImportant.BackColor = Color.FromArgb(3, 32, 60);
            btnRemind.BackColor = Color.FromArgb(3, 32, 60);

            pnlProject.Visible = false;
            pnlUserDetails.Visible = false;
            pnlLesson.Visible = false;
            pnlOtherTasks.Visible = true;
            pnlNavigation.Visible = true;
        }

        private void btnNoteMenu_Click(object sender, EventArgs e)
        {
            Note obj = new Note(user);
            obj.Show();
            this.Close();
        }

        private void btnLessonMenu_Click(object sender, EventArgs e)
        {
            //panel hide
            pnlProject.Visible = false;
            pnlUserDetails.Visible = false;
            pnlOtherTask.Visible = false;
            pnlLesson.Visible = true;
            pnlNavigation.Visible = true;
            //pnlProjectTasks.Visible = false;


            pnlNavi.Height = btnLesson.Height;
            pnlNavi.Top = btnLesson.Top;
            pnlNavi.Left = btnLesson.Left;
            btnLesson.BackColor = Color.FromArgb(46, 51, 73);

            btnTask.BackColor = Color.FromArgb(3, 32, 60);
            btnImportant.BackColor = Color.FromArgb(3, 32, 60);
            btnNote.BackColor = Color.FromArgb(3, 32, 60);
            btnRemind.BackColor = Color.FromArgb(3, 32, 60);
            try
            {

                //get the data

                SqlCommand cmd = new SqlCommand("Select time as TIME,description as DESCRIPTION,SubjectName as LESSON from " + user + "Lesson", con);
                con.Open();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);

                dataGridLesson.DataSource = tbl;







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

        private void btnProjectMenu_Click(object sender, EventArgs e)
        {
            pnlNavi.Height = btnProject.Height;
            pnlNavi.Top = btnProject.Top;
            pnlNavi.Left = btnProject.Left;
            btnProject.BackColor = Color.FromArgb(46, 51, 73);

            btnTask.BackColor = Color.FromArgb(3, 32, 60);
            btnLesson.BackColor = Color.FromArgb(3, 32, 60);
            btnNote.BackColor = Color.FromArgb(3, 32, 60);
            btnImportant.BackColor = Color.FromArgb(3, 32, 60);
            btnRemind.BackColor = Color.FromArgb(3, 32, 60);

            pnlProject.Visible = true;
            pnlUserDetails.Visible = false;
            pnlLesson.Visible = false;
            pnlOtherTask.Visible = false;
            pnlNavigation.Visible = true;
        }

        private void btnPlayP1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cmboP1.Text))
            {
                MessageBox.Show("Please select a task", "ToDo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else

            {

                btnType = "Project";
                string row = cmboP1.Text;
                task = lblP1.Text;

                Timer obj = new Timer(row, user, btnType, task);
                obj.Show();
                this.Hide();
            }
        }

        private void btnPlayP2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cmboP2.Text))
            {
                MessageBox.Show("Please select a task", "ToDo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else

            {

                btnType = "Project";
                string row = cmboP2.Text;
                task = lblP2.Text;

                Timer obj = new Timer(row, user, btnType, task);
                obj.Show();
                this.Hide();
            }
        }

        private void btnPlayP3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cmboP3.Text))
            {
                MessageBox.Show("Please select a task", "ToDo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else

            {

                btnType = "Project";
                string row = cmboP3.Text;
                task = lblP3.Text;

                Timer obj = new Timer(row, user, btnType, task);
                obj.Show();
                this.Hide();
            }
        }

        private void btnPlayP4_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cmboP4.Text))
            {
                MessageBox.Show("Please select a task", "ToDo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else

            {

                btnType = "Project";
                string row = cmboP4.Text;
                task = lblP4.Text;

                Timer obj = new Timer(row, user, btnType, task);
                obj.Show();
                this.Hide();
            }
        }

        private void btnPlayP5_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cmboP5.Text))
            {
                MessageBox.Show("Please select a task", "ToDo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else

            {

                btnType = "Project";
                string row = cmboP5.Text;
                task = lblP5.Text;

                Timer obj = new Timer(row, user, btnType, task);
                obj.Show();
                this.Hide();
            }
        }

        private void txtQuickTask_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtQuickTask.Text))
            {
                btnQuickTaskAdd.Enabled = false;
            }
            else
            {
                btnQuickTaskAdd.Enabled = true;
            }
        }

        private void btnQuickTaskAdd_Click(object sender, EventArgs e)
        {
            string qTask = txtQuickTask.Text;
            txtQuickTask.Text = null;

            try
            {
                SqlCommand cmd1 = new SqlCommand("Select taskName from " + user + "OtherTask where taskName = '" + qTask + "'", con);
                con.Open();
                SqlDataReader rdr = cmd1.ExecuteReader();

                if (rdr.Read() == false)
                {
                    con.Close();

                    SqlCommand cmd = new SqlCommand("Insert into " + user + "OtherTask values ('" + qTask + "', 20)", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    SqlDataAdapter adp = new SqlDataAdapter("Select taskName from " + user + "OtherTask", con);
                    con.Open();
                    DataTable tbl = new DataTable();
                    adp.Fill(tbl);
                    con.Close();

                    datagridQuickTask.DataSource = tbl;
                }
                else
                {
                    MessageBox.Show("Already there is a task called " + qTask, "ToDo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        private void datagridQuickTask_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                
                e.CellStyle.ForeColor = Color.WhiteSmoke;
                e.CellStyle.SelectionBackColor = Color.FromArgb(249, 76, 86);
                e.CellStyle.SelectionForeColor = Color.White;
            }
            if (e.ColumnIndex == 0)
            {
                e.CellStyle.ForeColor = Color.WhiteSmoke;
                e.CellStyle.SelectionBackColor = Color.SteelBlue;
                e.CellStyle.SelectionForeColor = Color.White;
            }
        }

        private void datagridQuickTask_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (datagridQuickTask.Columns[e.ColumnIndex].Name == "Column3")
            {
                string a = datagridQuickTask.Rows[e.RowIndex].Cells["taskName"].Value.ToString();

                    try
                    {
                        //delete row
                        SqlCommand cmd = new SqlCommand("Delete from " + user + "OtherTask where taskName = '" + a + "'", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                    }
                    finally
                    {
                        con.Close();
                    }

                     quickTaskLoad();
            }


           try
                {
                    btnType = "QuickTask";

                    //click start button

                    if (datagridQuickTask.Columns[e.ColumnIndex].Name == "Column1")
                    {
                        string row1 = datagridQuickTask.Rows[e.RowIndex].Cells["taskName"].Value.ToString();


                        Timer obj = new Timer(row1, user, btnType, task);
                        obj.Show();
                        this.Hide();
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }

            }

        private void txtPsw_TextChanged(object sender, EventArgs e)
        {
            try
            {
                String psw = txtPsw.Text;

                SqlCommand cmd = new SqlCommand("Select password, uName from UserDetails where uName =  '" + user + "' OR email = '" + user + "'", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();



                if (rdr.Read() == true)
                {

                    if (psw == rdr.GetString(0))
                    {


                        pnlPassword.Visible = false;
                        dataGridImportant.Visible = true;
                        btnAddImportant.Visible = true;
                        

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

           
        }

        private void btnAddImportant_Click(object sender, EventArgs e)
        {
            Important obj = new Important(user,null,false);
            obj.Show();
            this.Close();
        }

        private void dataGridImportant_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Visible = true;

            

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d;

                d = MessageBox.Show("Do you want to remove this ?", "ToDO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (d == DialogResult.Yes)
                {
                    string send = dataGridImportant.CurrentRow.Cells["noteName"].Value.ToString();

                    SqlCommand cmd = new SqlCommand("Delete from " + user + "Important where noteName = '" + send + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    importantGridLoad();
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

            btnDelete.Visible = false;
        }

        private void dataGridImportant_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string row1 = dataGridImportant.Rows[e.RowIndex].Cells["noteName"].Value.ToString();

            Important obj = new Important(user, row1, true);
            obj.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void btnAlarmOk_Click(object sender, EventArgs e)
        {
            timeRemind.Start();
            selectedTime = cmboHours.Text + ":" + cmboMin.Text + " " + cmboAMPM.Text;
            string date = pickerDate.Text;
            string text = txtAlarmtxt.Text;
            try
            {
               
                SqlCommand cmd = new SqlCommand("Insert into " + user + "Remind values ('" + selectedTime + "','" + date + "','" + text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                txtAlarmtxt.Text = null;
                cmboHours.Text = "00";
                cmboMin.Text = "00";

                remindGridLoad();
                remindTimeCombo();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                con.Close();
            }

            Notify obj = new Notify("Remind");
            obj.Show();
        }

        private void lblRemindClose_Click(object sender, EventArgs e)
        {
            pnlGetRemind.Visible = false;
        }

        private void timeRemind_Tick(object sender, EventArgs e)
        {
            timeRemind.Start();

            time = DateTime.Now.ToShortTimeString();

            if (time == lblGetTime.Text)
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = @"D:\Icons\ring.wav";
                player.Play();

               

                timeRemind.Stop();
                try
                {
                    SqlCommand cmd = new SqlCommand("Delete from " + user + "Remind where time = '" + lblGetTime.Text + "' AND date = '" + DateTime.Now.ToString("MM/dd/yyyy") + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    pnlGetRemind.BackColor = Color.Red;

                    remindGridLoad();
                }
                catch(Exception ee)
                {

                    MessageBox.Show(ee.Message);
                }
                finally
                {

                    con.Close();
                }
            }


        }

        private void dataGridReminder_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            pnlRemindDetails.Visible = false;
            btnRemindDelete.Visible = true;
        }

        private void btnRemindDelete_Click(object sender, EventArgs e)
        {
            string time = dataGridReminder.CurrentRow.Cells["time"].Value.ToString();
            string date = dataGridReminder.CurrentRow.Cells["date"].Value.ToString();

            try
            {

                SqlCommand cmd = new SqlCommand("Delete from " + user + "Remind where time = '" + time + "' AND date = '" + date + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                remindGridLoad();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                con.Close();
            }

            btnRemindDelete.Visible = false;
        }

        private void dataGridReminder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pnlRemindDetails.Visible = true;

            DataGridViewRow row = this.dataGridReminder.Rows[e.RowIndex];
            txtRemindDetailsText.Text = row.Cells["text"].Value.ToString();
            lblDateRemindDetails.Text = row.Cells["date"].Value.ToString();
            lblTimeRemindDetails.Text = row.Cells["time"].Value.ToString();
        }

        private void dataGridReminder_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {

            pnlRemindDetails.Visible = false;
        }

        private void pnlReminder_MouseClick(object sender, MouseEventArgs e)
        {

            pnlRemindDetails.Visible = false;
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {

            pnlRemindDetails.Visible = false;
        }
    }
}
