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

namespace ToDo
{
    public partial class Important : Form
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
        string row;
        bool cellClick;
        public Important(string user, string row, bool cellClick)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            this.user = user;
            this.row = row;
            this.cellClick = cellClick;
            
        }

        private void loadData()
        {
            try
            {
                txtNote.Enabled = false;
                txtTitle.Visible = false;
                lblTitle.Visible = true;
                btnUpdate.Visible = true;
                btnUpdate.Enabled = false;

                SqlCommand cmd = new SqlCommand("Select noteName, impNote from " + user + "Important where noteName = '" + row + "'", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    txtNote.Text = rdr.GetString(1);
                    lblTitle.Text = rdr.GetString(0);
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

        private void Important_Load(object sender, EventArgs e)
        {
            lblEnterTitle.Visible = false;
            lblTitle.Visible = false;
            btnUpdate.Visible = false;

            if (cellClick == true)

            {
                loadData();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form3 obj = new Form3(user);
            obj.Show();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTitle.Text))
            {
                lblEnterTitle.Visible = true;
            }
            else
            {
                string title = txtTitle.Text;
                string note = txtNote.Text;

                SqlCommand cmd1 = new SqlCommand("Select noteName from " + user + "Important where noteName = '" + title + "'", con);
                con.Open();
                SqlDataReader rdr = cmd1.ExecuteReader();

                if (rdr.Read())
                {
                    lblEnterTitle.Text = "Please try another title";
                    con.Close();
                }

                else
                {


                    con.Close();

                    SqlCommand cmd = new SqlCommand("Insert into " + user + "Important values ('" + title + "','" + note + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    Form3 obj = new Form3(user);
                    obj.Show();
                    this.Close();
                }




            }
        }

        private void txtNote_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtNote.Enabled = true;
        }

        private void txtNote_TextChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            txtNote.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Update " + user + "Important set impNote = '" + txtNote.Text + "' where noteName = '" + lblTitle.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();

                Notify obj1 = new Notify("Update");
                obj1.Show();

                Form3 obj = new Form3(user);
                obj.Show();
                this.Close();

               




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
}
