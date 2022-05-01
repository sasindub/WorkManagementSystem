using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo
{
    public partial class Notify : Form
    {
        string mType;
        public Notify(string mType)
        {
            InitializeComponent();
            this.mType = mType;

           
        }

        private void notifyLoad()
        {
            if (mType == "done")
            {
                picDone.Visible = true;
                picInterval.Visible = false;
                picWork.Visible = false;
                lblNotify.Text = "DONE";
            }
            else if (mType == "Interval")
            {
                this.BackColor = Color.FromArgb(52, 235, 103);
                picDone.Visible = false;
                picInterval.Visible = true;
                picWork.Visible = false;
                lblNotify.Text = "INTERVAL";
            }
            else if (mType == "Ready")
            {
                this.BackColor = Color.FromArgb(255, 77, 77);
                picDone.Visible = false;
                picInterval.Visible = false;
                picWork.Visible = true;
                lblNotify.Text = "Ready to work";
            }
            else if (mType == "Sent")
            {
                this.BackColor = Color.FromArgb(52, 235, 103);
                picDone.Visible = true;
                picInterval.Visible = false;
                picWork.Visible = false;
                lblNotify.Text = "Sent";
            }

            else if (mType == "Update")
            {
                this.BackColor = Color.FromArgb(255, 77, 77);
                picDone.Visible = true;
                picInterval.Visible = false;
                picWork.Visible = false;
                lblNotify.Text = "Updated";
            }

            else if (mType == "Email")
            {
                this.BackColor = Color.FromArgb(51, 50, 48);
                picDone.Visible = true;
                picInterval.Visible = false;
                picWork.Visible = false;
                lblNotify.AutoSize = true;
                lblNotify.Font = new Font("", 11, FontStyle.Bold);
                lblNotify.Text = "Verification code was sent";
            }

            else if (mType == "Remind")
            {
                
                picDone.Visible = true;
                picInterval.Visible = false;
                picWork.Visible = false;
                lblNotify.AutoSize = true;
                lblNotify.Font = new Font("", 11, FontStyle.Bold);
                lblNotify.Text = "Added to the reminder";
            }

        }


        private void Notify_Load(object sender, EventArgs e)
        {
            Top = 20;
            Left = Screen.PrimaryScreen.Bounds.Width - Width - 20;
            timerClose.Start();
            notifyLoad();

        }

        private void timerClose_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
