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
    public partial class Loading : Form
    {
      
        string user;
        BackgroundWorker worker = new BackgroundWorker();
        public Loading(string user)
        {
            InitializeComponent();

            this.user = user;
           
           
        }
        

        private void Loading_Load(object sender, EventArgs e)
        {
           

            this.timer1.Start();
            

           
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            this.progressBar1.Increment(1);
                       
            if (progressBar1.Value >= progressBar1.Maximum)
            {
                timer1.Stop();
                this.Close();
                Form3 obj = new Form3(user);
                obj.Show();
            }

        }
    }
}
