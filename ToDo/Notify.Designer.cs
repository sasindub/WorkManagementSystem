
namespace ToDo
{
    partial class Notify
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notify));
            this.lblNotify = new System.Windows.Forms.Label();
            this.timerClose = new System.Windows.Forms.Timer(this.components);
            this.picDone = new System.Windows.Forms.PictureBox();
            this.picInterval = new System.Windows.Forms.PictureBox();
            this.lblClose = new System.Windows.Forms.Label();
            this.picWork = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWork)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNotify
            // 
            this.lblNotify.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNotify.ForeColor = System.Drawing.Color.White;
            this.lblNotify.Location = new System.Drawing.Point(110, 37);
            this.lblNotify.Name = "lblNotify";
            this.lblNotify.Size = new System.Drawing.Size(240, 32);
            this.lblNotify.TabIndex = 0;
            this.lblNotify.Text = "notify";
            this.lblNotify.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerClose
            // 
            this.timerClose.Interval = 10500;
            this.timerClose.Tick += new System.EventHandler(this.timerClose_Tick);
            // 
            // picDone
            // 
            this.picDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picDone.Image = ((System.Drawing.Image)(resources.GetObject("picDone.Image")));
            this.picDone.Location = new System.Drawing.Point(70, 37);
            this.picDone.Name = "picDone";
            this.picDone.Size = new System.Drawing.Size(34, 32);
            this.picDone.TabIndex = 1;
            this.picDone.TabStop = false;
            // 
            // picInterval
            // 
            this.picInterval.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picInterval.Image = ((System.Drawing.Image)(resources.GetObject("picInterval.Image")));
            this.picInterval.Location = new System.Drawing.Point(70, 37);
            this.picInterval.Name = "picInterval";
            this.picInterval.Size = new System.Drawing.Size(34, 32);
            this.picInterval.TabIndex = 2;
            this.picInterval.TabStop = false;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClose.Location = new System.Drawing.Point(332, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(18, 18);
            this.lblClose.TabIndex = 3;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // picWork
            // 
            this.picWork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWork.Image = ((System.Drawing.Image)(resources.GetObject("picWork.Image")));
            this.picWork.Location = new System.Drawing.Point(70, 37);
            this.picWork.Name = "picWork";
            this.picWork.Size = new System.Drawing.Size(34, 32);
            this.picWork.TabIndex = 4;
            this.picWork.TabStop = false;
            // 
            // Notify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(362, 104);
            this.ControlBox = false;
            this.Controls.Add(this.picWork);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.picInterval);
            this.Controls.Add(this.picDone);
            this.Controls.Add(this.lblNotify);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notify";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Notify";
            this.Load += new System.EventHandler(this.Notify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWork)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNotify;
        private System.Windows.Forms.Timer timerClose;
        private System.Windows.Forms.PictureBox picDone;
        private System.Windows.Forms.PictureBox picInterval;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.PictureBox picWork;
    }
}