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
using System.IO;
using System.Runtime.InteropServices;

namespace ToDo
{
   
    public partial class Note : Form
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
        string user;
      
        public Note(string user)
        {
            
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            this.user = user;
        }


        private void btnProject_Click(object sender, EventArgs e)
        {
            pnlInbox.Visible = false;
            lstFriends.Visible = false;
            btnDownload.Visible = false;

            datagridInbox.Visible = true;
            txtMessage.Visible = false;
            btnDelete.Visible = false;
            lblSenderName.Visible = false;
            btnBackToInbox.Visible = false;
            cmboFontSize.Visible = false;
            lblFrom.Visible = false;

            pnlInbox.Visible = false;
            pnlNavi.Height = btnNoteSend.Height;
            pnlNavi.Top = btnNoteSend.Top;
            pnlNavi.Left = btnNoteSend.Left;

            btnNoteSend.BackColor = Color.FromArgb(46, 51, 73);

            btnNoteInbox.BackColor = Color.FromArgb(3, 32, 60);
        }


        //load the note details to inbox
        private void gridLoad()
        {
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("Select senderName, note, time from " + user + "Note", con);
                con.Open();
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                con.Close();

                datagridInbox.DataSource = tbl;
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
        private void Note_Load(object sender, EventArgs e)
        {

           
            pnlInbox.Visible = false;
            pnlNavi.Height = btnNoteSend.Height;
            pnlNavi.Top = btnNoteSend.Top;
            pnlNavi.Left = btnNoteSend.Left;

            btnNoteSend.BackColor = Color.FromArgb(46, 51, 73);

           

            lstFriends.Visible = false;
            txtMessage.Visible = false;
            lblSenderName.Visible = false;
            btnBackToInbox.Visible = false;
            cmboFontSize.Visible = false;
            lblFrom.Visible = false;
            btnDelete.Visible = false;

            btnDownload.Visible = false;

            gridLoad();//load the note details
       

            
        }

        private void txtFriendSearch_TextChanged(object sender, EventArgs e)
        {

            try
            {
                lstFriends.Items.Clear();

                string search = txtFriendSearch.Text;
                if (String.IsNullOrEmpty(txtFriendSearch.Text))
                {
                    lstFriends.Visible = false;
                }
                else
                {
                    lstFriends.Visible = true;
                    //search users
                    SqlCommand cmd = new SqlCommand("Select uName from UserDetails where uName like '" + search + "%'", con);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                                       
                  
                    while (rdr.Read())
                    {
                        if (rdr.GetString(0) == user)
                        {
                            continue;
                        }
                         lstFriends.ForeColor = Color.FromArgb(3, 32, 60);
                         lstFriends.Items.Add(rdr.GetString(0));//get user names to list box
                           
                    }

                    con.Close();

                    //if the user is not in the database
                    SqlCommand cmd1 = new SqlCommand("Select uName from UserDetails where uName like '" + search + "%'", con);
                    con.Open();
                    SqlDataReader rdr1 = cmd.ExecuteReader();


                    if (rdr1.Read() == false)
                    {
                        lstFriends.Visible = false;
           

                    }
                   
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

        private void lstFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            

            try
            {
                lstFriends.Visible = false;
                txtFriendSearch.Text = lstFriends.SelectedItem.ToString();
                lstFriends.Visible = false;


            }
            
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Form3 obj = new Form3(user);
            obj.Show();
            this.Close();

        }

        private void txtNote_MouseClick(object sender, MouseEventArgs e)
        {
            lstFriends.Visible = false;
        }

        private void Note_MouseClick(object sender, MouseEventArgs e)
        {
            lstFriends.Visible = false;
        }

        private void btnSeachFriends_Click(object sender, EventArgs e)
        {
            lstFriends.Items.Clear();

            if (String.IsNullOrEmpty(txtFriendSearch.Text))
            {

                lstFriends.Visible = true;
                lstFriends.ForeColor = Color.Red;
                lstFriends.Items.Add("can not find the user.");
            }
            else
            {
                try
                {
                    

                    string search = txtFriendSearch.Text;

                    lstFriends.Visible = true;
                    //search users
                    SqlCommand cmd = new SqlCommand("Select uName from UserDetails where uName like '" + search + "%'", con);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        if (rdr.GetString(0) == user)
                        {
                            continue;
                        }

                        lstFriends.ForeColor = Color.FromArgb(3, 32, 60);
                        lstFriends.Items.Add(rdr.GetString(0));//get user names to list box



                    }

                    con.Close();

                    //if the user is not in the database

                    SqlCommand cmd1 = new SqlCommand("Select uName from UserDetails where uName like '" + search + "%'", con);
                    con.Open();
                    SqlDataReader rdr1 = cmd.ExecuteReader();


                    if (rdr1.Read() == false)
                    {
                        lstFriends.ForeColor = Color.Red;
                        lstFriends.Items.Add("can not find the user.");
                   

                    }
                    

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
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            lstFriends.Items.Clear();

                string text = txtNote.Text;
                

                string search = txtFriendSearch.Text;
                string time = DateTime.Now.ToLongTimeString();



            try
            {
                //insert note to ther reciever's note table (send the note)
                SqlCommand cmd = new SqlCommand("Insert into " + search + "Note values ('" + user + "','" + text + "','" + time + "')" , con);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    txtFriendSearch.Text = null;
                    txtNote.Text = null;

                    Notify obj = new Notify("Sent");
                    obj.Show();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                lstFriends.Visible = true;
                lstFriends.ForeColor = Color.Red;
                lstFriends.Items.Add("can not find the user.");
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

        private void btnNoteInbox_Click(object sender, EventArgs e)
        {
             pnlNavi.Height = btnNoteInbox.Height ;
             pnlNavi.Top = btnNoteInbox.Top ;
             pnlNavi.Left = btnNoteInbox.Left;

            pnlInbox.Visible = true;

            btnNoteInbox.BackColor = Color.FromArgb(46, 51, 73);

            btnNoteSend.BackColor = Color.FromArgb(3, 32, 60);

            gridLoad();//load the note details


        }

        private void datagridInbox_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                // e.CellStyle.ForeColor = Color.FromArgb(46, 51, 73);
                e.CellStyle.ForeColor = Color.FromArgb(69,75,102);

                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                e.CellStyle.SelectionBackColor = Color.Azure;
                e.CellStyle.SelectionForeColor = Color.FromArgb(3,32,60);

            }
            if (e.ColumnIndex == 1)
            {

                e.CellStyle.SelectionBackColor = Color.FromArgb(46, 51, 73);
                e.CellStyle.SelectionForeColor = Color.White;
                e.CellStyle.ForeColor = Color.FromArgb(69, 75, 102);
            }
            if (e.ColumnIndex == 2)
            {
                e.CellStyle.SelectionBackColor = Color.FromArgb(46, 51, 73);
                e.CellStyle.SelectionForeColor = Color.White;
                e.CellStyle.ForeColor = Color.FromArgb(69, 75, 102);
            
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string send = datagridInbox.CurrentRow.Cells["SenderName"].Value.ToString();
            string time = datagridInbox.CurrentRow.Cells["time"].Value.ToString();
            try
            {
                SqlCommand cmd = new SqlCommand("Delete from " + user + "Note where senderName = '" + send + "' AND time = '" + time + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

            ////int rowIndex = datagridInbox.CurrentCell.RowIndex;
            //datagridInbox.Rows.RemoveAt(rowIndex);

            gridLoad();
            btnDelete.Visible = false;
        }

        private void btnBackToInbox_Click(object sender, EventArgs e)
        {
            datagridInbox.Visible = true;
            txtMessage.Visible = false;
            btnDelete.Visible = true;
            lblSenderName.Visible = false;
            btnBackToInbox.Visible = false;
            cmboFontSize.Visible = false;
            lblFrom.Visible = false;
            btnDownload.Visible = false;
        }

        

        private void datagridInbox_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Visible = true;

        }

        private void cmboFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMessage.Font = new Font(txtMessage.Font.FontFamily, float.Parse(cmboFontSize.SelectedItem.ToString()));
        }

        private void btnReply_Click(object sender, EventArgs e)
        {

            if (lblFrom.Text == "sender")
                txtFriendSearch.Text = null; 
            
            else
                txtFriendSearch.Text = lblSenderName.Text;

            pnlInbox.Visible = false;
            lstFriends.Visible = false;

            datagridInbox.Visible = true;
            txtMessage.Visible = false;
            btnDelete.Visible = false;
            lblSenderName.Visible = false;
            btnBackToInbox.Visible = false;
            cmboFontSize.Visible = false;
            lblFrom.Visible = false;
            btnDownload.Visible = false;

            pnlNavi.Height = btnNoteSend.Height;
            pnlNavi.Top = btnNoteSend.Top;
            pnlNavi.Left = btnNoteSend.Left;

            btnNoteSend.BackColor = Color.FromArgb(46, 51, 73);

            btnNoteInbox.BackColor = Color.FromArgb(3, 32, 60);

            

        }

        private void datagridInbox_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            datagridInbox.Visible = false;
            txtMessage.Visible = true;
            btnDelete.Visible = false;
            lblSenderName.Visible = true;
            btnBackToInbox.Visible = true;
            cmboFontSize.Visible = true;
            lblFrom.Visible = true;
            btnDownload.Visible = true; 


            DataGridViewRow row = this.datagridInbox.Rows[e.RowIndex];
            txtMessage.Text = row.Cells["note"].Value.ToString();
            lblSenderName.Text = row.Cells["senderName"].Value.ToString();
        }

        private void cmbSizeSend_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNote.Font = new Font(txtNote.Font.FontFamily, float.Parse(cmbSizeSend.SelectedItem.ToString()));
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd1 = new SaveFileDialog();
            if (sfd1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(sfd1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(txtMessage.Text);
                }
              ;
            }
        }
    }
}
