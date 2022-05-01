
namespace ToDo
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblDone = new System.Windows.Forms.Label();
            this.picDone = new System.Windows.Forms.PictureBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.erroUser = new System.Windows.Forms.ErrorProvider(this.components);
            this.erroEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorGender = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtUserS = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPswS = new System.Windows.Forms.TextBox();
            this.txtRePswS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblVerify = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.chkStu = new System.Windows.Forms.CheckBox();
            this.lbltick = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.lbl8Char = new System.Windows.Forms.Label();
            this.lblUppercase = new System.Windows.Forms.Label();
            this.pic8CharDone = new System.Windows.Forms.PictureBox();
            this.picUpperDone = new System.Windows.Forms.PictureBox();
            this.pic8CharError = new System.Windows.Forms.PictureBox();
            this.picUpperError = new System.Windows.Forms.PictureBox();
            this.lblPswR = new System.Windows.Forms.Label();
            this.lblUserAvailable = new System.Windows.Forms.Label();
            this.lblEmailAvailble = new System.Windows.Forms.Label();
            this.btnResend = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picErrorDigit = new System.Windows.Forms.PictureBox();
            this.picDigitDone = new System.Windows.Forms.PictureBox();
            this.lblDigits = new System.Windows.Forms.Label();
            this.picEyeOpenP = new System.Windows.Forms.PictureBox();
            this.picEyeHide = new System.Windows.Forms.PictureBox();
            this.lblWait = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorGender)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic8CharDone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpperDone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic8CharError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpperError)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorDigit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDigitDone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeOpenP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Raleway", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(484, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 52);
            this.label1.TabIndex = 7;
            this.label1.Text = "SIGN IN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(454, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 52);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1023, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 34);
            this.btnClose.TabIndex = 21;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(15, 525);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 34);
            this.btnBack.TabIndex = 27;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lblDone
            // 
            this.lblDone.AutoSize = true;
            this.lblDone.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.lblDone.Location = new System.Drawing.Point(986, 447);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(46, 20);
            this.lblDone.TabIndex = 34;
            this.lblDone.Text = "Done";
            // 
            // picDone
            // 
            this.picDone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picDone.BackgroundImage")));
            this.picDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picDone.Location = new System.Drawing.Point(963, 447);
            this.picDone.Name = "picDone";
            this.picDone.Size = new System.Drawing.Size(23, 20);
            this.picDone.TabIndex = 35;
            this.picDone.TabStop = false;
            this.picDone.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.btnDone.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Image = ((System.Drawing.Image)(resources.GetObject("btnDone.Image")));
            this.btnDone.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDone.Location = new System.Drawing.Point(963, 525);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(100, 34);
            this.btnDone.TabIndex = 36;
            this.btnDone.Text = "Done";
            this.btnDone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            this.btnDone.MouseLeave += new System.EventHandler(this.btnDone_MouseLeave);
            this.btnDone.MouseHover += new System.EventHandler(this.btnDone_MouseHover);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // erroUser
            // 
            this.erroUser.ContainerControl = this;
            // 
            // erroEmail
            // 
            this.erroEmail.ContainerControl = this;
            // 
            // errorGender
            // 
            this.errorGender.ContainerControl = this;
            // 
            // txtUserS
            // 
            this.txtUserS.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtUserS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserS.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtUserS.Location = new System.Drawing.Point(183, 91);
            this.txtUserS.Name = "txtUserS";
            this.txtUserS.PlaceholderText = "ex :- Jhone";
            this.txtUserS.Size = new System.Drawing.Size(316, 27);
            this.txtUserS.TabIndex = 16;
            this.txtUserS.TextChanged += new System.EventHandler(this.txtUserS_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(183, 217);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "example@gmail.com";
            this.txtEmail.Size = new System.Drawing.Size(316, 27);
            this.txtEmail.TabIndex = 17;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtPswS
            // 
            this.txtPswS.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtPswS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPswS.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPswS.Location = new System.Drawing.Point(705, 91);
            this.txtPswS.Name = "txtPswS";
            this.txtPswS.PlaceholderText = "at least 8 characters";
            this.txtPswS.Size = new System.Drawing.Size(316, 27);
            this.txtPswS.TabIndex = 18;
            this.txtPswS.UseSystemPasswordChar = true;
            this.txtPswS.TextChanged += new System.EventHandler(this.txtPswS_TextChanged);
            this.txtPswS.MouseLeave += new System.EventHandler(this.txtPswS_MouseLeave);
            this.txtPswS.MouseHover += new System.EventHandler(this.txtPswS_MouseHover);
            this.txtPswS.Validating += new System.ComponentModel.CancelEventHandler(this.txtPswS_Validating);
            // 
            // txtRePswS
            // 
            this.txtRePswS.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtRePswS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRePswS.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtRePswS.Location = new System.Drawing.Point(705, 217);
            this.txtRePswS.Name = "txtRePswS";
            this.txtRePswS.PlaceholderText = "Re-Enter the password";
            this.txtRePswS.Size = new System.Drawing.Size(316, 27);
            this.txtRePswS.TabIndex = 19;
            this.txtRePswS.UseSystemPasswordChar = true;
            this.txtRePswS.TextChanged += new System.EventHandler(this.txtRePswS_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.label2.Location = new System.Drawing.Point(47, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.label3.Location = new System.Drawing.Point(47, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.label4.Location = new System.Drawing.Point(545, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "Password";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.label5.Location = new System.Drawing.Point(545, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "Re - Password";
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(163)))), ((int)(((byte)(250)))));
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCode.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCode.Location = new System.Drawing.Point(545, 337);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.PlaceholderText = "verify e-mail";
            this.txtCode.Size = new System.Drawing.Size(126, 33);
            this.txtCode.TabIndex = 25;
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            this.txtCode.MouseLeave += new System.EventHandler(this.txtCode_MouseLeave);
            this.txtCode.MouseHover += new System.EventHandler(this.txtCode_MouseHover);
            // 
            // lblVerify
            // 
            this.lblVerify.AutoSize = true;
            this.lblVerify.BackColor = System.Drawing.Color.Transparent;
            this.lblVerify.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVerify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.lblVerify.Location = new System.Drawing.Point(372, 337);
            this.lblVerify.Name = "lblVerify";
            this.lblVerify.Size = new System.Drawing.Size(167, 24);
            this.lblVerify.TabIndex = 26;
            this.lblVerify.Text = "verification code";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblGender);
            this.groupBox1.Controls.Add(this.rdoMale);
            this.groupBox1.Controls.Add(this.rdoFemale);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.groupBox1.Location = new System.Drawing.Point(743, 313);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 128);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.lblGender.Location = new System.Drawing.Point(100, 56);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(0, 24);
            this.lblGender.TabIndex = 37;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoMale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.rdoMale.Location = new System.Drawing.Point(100, 71);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(79, 32);
            this.rdoMale.TabIndex = 30;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            this.rdoMale.CheckedChanged += new System.EventHandler(this.rdoMale_CheckedChanged);
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoFemale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.rdoFemale.Location = new System.Drawing.Point(100, 33);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(103, 32);
            this.rdoFemale.TabIndex = 29;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            this.rdoFemale.CheckedChanged += new System.EventHandler(this.rdoFemale_CheckedChanged);
            // 
            // chkStu
            // 
            this.chkStu.AutoSize = true;
            this.chkStu.BackColor = System.Drawing.Color.Transparent;
            this.chkStu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkStu.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.chkStu.Font = new System.Drawing.Font("Raleway SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkStu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(122)))), ((int)(((byte)(0)))));
            this.chkStu.Location = new System.Drawing.Point(47, 337);
            this.chkStu.Margin = new System.Windows.Forms.Padding(5);
            this.chkStu.Name = "chkStu";
            this.chkStu.Size = new System.Drawing.Size(172, 36);
            this.chkStu.TabIndex = 32;
            this.chkStu.Text = "I am student";
            this.chkStu.UseVisualStyleBackColor = false;
            this.chkStu.MouseLeave += new System.EventHandler(this.chkStu_MouseLeave);
            this.chkStu.MouseHover += new System.EventHandler(this.chkStu_MouseHover);
            // 
            // lbltick
            // 
            this.lbltick.BackColor = System.Drawing.Color.Transparent;
            this.lbltick.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbltick.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbltick.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbltick.Location = new System.Drawing.Point(47, 382);
            this.lbltick.Name = "lbltick";
            this.lbltick.Size = new System.Drawing.Size(223, 30);
            this.lbltick.TabIndex = 33;
            this.lbltick.Text = "Tick if you are a student";
            this.lbltick.Click += new System.EventHandler(this.lblSignShow_Click);
            // 
            // lblStudent
            // 
            this.lblStudent.BackColor = System.Drawing.Color.Transparent;
            this.lblStudent.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(122)))), ((int)(((byte)(0)))));
            this.lblStudent.Location = new System.Drawing.Point(47, 343);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(172, 24);
            this.lblStudent.TabIndex = 37;
            // 
            // lbl8Char
            // 
            this.lbl8Char.AutoSize = true;
            this.lbl8Char.BackColor = System.Drawing.Color.Transparent;
            this.lbl8Char.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.lbl8Char.Location = new System.Drawing.Point(729, 127);
            this.lbl8Char.Name = "lbl8Char";
            this.lbl8Char.Size = new System.Drawing.Size(140, 20);
            this.lbl8Char.TabIndex = 38;
            this.lbl8Char.Text = "at least 8 characters";
            // 
            // lblUppercase
            // 
            this.lblUppercase.AutoSize = true;
            this.lblUppercase.BackColor = System.Drawing.Color.Transparent;
            this.lblUppercase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.lblUppercase.Location = new System.Drawing.Point(729, 167);
            this.lblUppercase.Name = "lblUppercase";
            this.lblUppercase.Size = new System.Drawing.Size(87, 20);
            this.lblUppercase.TabIndex = 39;
            this.lblUppercase.Text = "upper cases";
            // 
            // pic8CharDone
            // 
            this.pic8CharDone.BackColor = System.Drawing.Color.Transparent;
            this.pic8CharDone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic8CharDone.BackgroundImage")));
            this.pic8CharDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic8CharDone.Location = new System.Drawing.Point(705, 130);
            this.pic8CharDone.Name = "pic8CharDone";
            this.pic8CharDone.Size = new System.Drawing.Size(29, 17);
            this.pic8CharDone.TabIndex = 40;
            this.pic8CharDone.TabStop = false;
            // 
            // picUpperDone
            // 
            this.picUpperDone.BackColor = System.Drawing.Color.Transparent;
            this.picUpperDone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picUpperDone.BackgroundImage")));
            this.picUpperDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picUpperDone.Location = new System.Drawing.Point(705, 170);
            this.picUpperDone.Name = "picUpperDone";
            this.picUpperDone.Size = new System.Drawing.Size(29, 17);
            this.picUpperDone.TabIndex = 41;
            this.picUpperDone.TabStop = false;
            // 
            // pic8CharError
            // 
            this.pic8CharError.BackColor = System.Drawing.Color.Transparent;
            this.pic8CharError.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic8CharError.BackgroundImage")));
            this.pic8CharError.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic8CharError.Location = new System.Drawing.Point(705, 130);
            this.pic8CharError.Name = "pic8CharError";
            this.pic8CharError.Size = new System.Drawing.Size(29, 17);
            this.pic8CharError.TabIndex = 42;
            this.pic8CharError.TabStop = false;
            // 
            // picUpperError
            // 
            this.picUpperError.BackColor = System.Drawing.Color.Transparent;
            this.picUpperError.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picUpperError.BackgroundImage")));
            this.picUpperError.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picUpperError.Location = new System.Drawing.Point(705, 170);
            this.picUpperError.Name = "picUpperError";
            this.picUpperError.Size = new System.Drawing.Size(29, 17);
            this.picUpperError.TabIndex = 43;
            this.picUpperError.TabStop = false;
            // 
            // lblPswR
            // 
            this.lblPswR.AutoSize = true;
            this.lblPswR.BackColor = System.Drawing.Color.Transparent;
            this.lblPswR.ForeColor = System.Drawing.Color.Salmon;
            this.lblPswR.Location = new System.Drawing.Point(705, 253);
            this.lblPswR.Name = "lblPswR";
            this.lblPswR.Size = new System.Drawing.Size(176, 20);
            this.lblPswR.TabIndex = 44;
            this.lblPswR.Text = "Password is not matching";
            // 
            // lblUserAvailable
            // 
            this.lblUserAvailable.AutoSize = true;
            this.lblUserAvailable.BackColor = System.Drawing.Color.Transparent;
            this.lblUserAvailable.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblUserAvailable.Location = new System.Drawing.Point(183, 127);
            this.lblUserAvailable.Name = "lblUserAvailable";
            this.lblUserAvailable.Size = new System.Drawing.Size(63, 20);
            this.lblUserAvailable.TabIndex = 45;
            this.lblUserAvailable.Text = "Availble";
            this.lblUserAvailable.Click += new System.EventHandler(this.lblUserAvailable_Click);
            // 
            // lblEmailAvailble
            // 
            this.lblEmailAvailble.AutoSize = true;
            this.lblEmailAvailble.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailAvailble.ForeColor = System.Drawing.Color.Salmon;
            this.lblEmailAvailble.Location = new System.Drawing.Point(183, 253);
            this.lblEmailAvailble.Name = "lblEmailAvailble";
            this.lblEmailAvailble.Size = new System.Drawing.Size(196, 20);
            this.lblEmailAvailble.TabIndex = 46;
            this.lblEmailAvailble.Text = "This e-mail already has used";
            // 
            // btnResend
            // 
            this.btnResend.BackColor = System.Drawing.Color.Transparent;
            this.btnResend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResend.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnResend.FlatAppearance.BorderSize = 0;
            this.btnResend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResend.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResend.ForeColor = System.Drawing.Color.Gray;
            this.btnResend.Image = ((System.Drawing.Image)(resources.GetObject("btnResend.Image")));
            this.btnResend.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResend.Location = new System.Drawing.Point(562, 376);
            this.btnResend.Name = "btnResend";
            this.btnResend.Size = new System.Drawing.Size(109, 34);
            this.btnResend.TabIndex = 47;
            this.btnResend.Text = "Re-Send";
            this.btnResend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResend.UseVisualStyleBackColor = false;
            this.btnResend.Click += new System.EventHandler(this.btnResend_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Black;
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(372, 376);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 20);
            this.lblEmail.TabIndex = 48;
            this.lblEmail.Text = "email";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.picErrorDigit);
            this.panel1.Controls.Add(this.picDigitDone);
            this.panel1.Controls.Add(this.lblDigits);
            this.panel1.Controls.Add(this.picEyeOpenP);
            this.panel1.Controls.Add(this.picEyeHide);
            this.panel1.Controls.Add(this.lblWait);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.btnResend);
            this.panel1.Controls.Add(this.picDone);
            this.panel1.Controls.Add(this.btnDone);
            this.panel1.Controls.Add(this.lblDone);
            this.panel1.Controls.Add(this.lblEmailAvailble);
            this.panel1.Controls.Add(this.lblUserAvailable);
            this.panel1.Controls.Add(this.lblPswR);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.picUpperError);
            this.panel1.Controls.Add(this.pic8CharError);
            this.panel1.Controls.Add(this.picUpperDone);
            this.panel1.Controls.Add(this.pic8CharDone);
            this.panel1.Controls.Add(this.lblUppercase);
            this.panel1.Controls.Add(this.lbl8Char);
            this.panel1.Controls.Add(this.lblStudent);
            this.panel1.Controls.Add(this.lbltick);
            this.panel1.Controls.Add(this.chkStu);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.lblVerify);
            this.panel1.Controls.Add(this.txtCode);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtRePswS);
            this.panel1.Controls.Add(this.txtPswS);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtUserS);
            this.panel1.Location = new System.Drawing.Point(-5, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 662);
            this.panel1.TabIndex = 49;
            // 
            // picErrorDigit
            // 
            this.picErrorDigit.BackColor = System.Drawing.Color.Transparent;
            this.picErrorDigit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picErrorDigit.BackgroundImage")));
            this.picErrorDigit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picErrorDigit.Location = new System.Drawing.Point(705, 150);
            this.picErrorDigit.Name = "picErrorDigit";
            this.picErrorDigit.Size = new System.Drawing.Size(29, 17);
            this.picErrorDigit.TabIndex = 54;
            this.picErrorDigit.TabStop = false;
            // 
            // picDigitDone
            // 
            this.picDigitDone.BackColor = System.Drawing.Color.Transparent;
            this.picDigitDone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picDigitDone.BackgroundImage")));
            this.picDigitDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picDigitDone.Location = new System.Drawing.Point(705, 150);
            this.picDigitDone.Name = "picDigitDone";
            this.picDigitDone.Size = new System.Drawing.Size(29, 17);
            this.picDigitDone.TabIndex = 53;
            this.picDigitDone.TabStop = false;
            // 
            // lblDigits
            // 
            this.lblDigits.AutoSize = true;
            this.lblDigits.BackColor = System.Drawing.Color.Transparent;
            this.lblDigits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.lblDigits.Location = new System.Drawing.Point(729, 147);
            this.lblDigits.Name = "lblDigits";
            this.lblDigits.Size = new System.Drawing.Size(104, 20);
            this.lblDigits.TabIndex = 52;
            this.lblDigits.Text = "at least 1 digit";
            // 
            // picEyeOpenP
            // 
            this.picEyeOpenP.BackColor = System.Drawing.Color.PaleTurquoise;
            this.picEyeOpenP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picEyeOpenP.BackgroundImage")));
            this.picEyeOpenP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picEyeOpenP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEyeOpenP.InitialImage = ((System.Drawing.Image)(resources.GetObject("picEyeOpenP.InitialImage")));
            this.picEyeOpenP.Location = new System.Drawing.Point(978, 91);
            this.picEyeOpenP.Name = "picEyeOpenP";
            this.picEyeOpenP.Size = new System.Drawing.Size(43, 24);
            this.picEyeOpenP.TabIndex = 51;
            this.picEyeOpenP.TabStop = false;
            this.picEyeOpenP.Click += new System.EventHandler(this.picEyeOpenP_Click);
            // 
            // picEyeHide
            // 
            this.picEyeHide.BackColor = System.Drawing.Color.PaleTurquoise;
            this.picEyeHide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picEyeHide.BackgroundImage")));
            this.picEyeHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picEyeHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEyeHide.InitialImage = ((System.Drawing.Image)(resources.GetObject("picEyeHide.InitialImage")));
            this.picEyeHide.Location = new System.Drawing.Point(978, 91);
            this.picEyeHide.Name = "picEyeHide";
            this.picEyeHide.Size = new System.Drawing.Size(43, 24);
            this.picEyeHide.TabIndex = 50;
            this.picEyeHide.TabStop = false;
            this.picEyeHide.Click += new System.EventHandler(this.picEyeHide_Click_1);
            // 
            // lblWait
            // 
            this.lblWait.AutoSize = true;
            this.lblWait.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.lblWait.Location = new System.Drawing.Point(511, 361);
            this.lblWait.Name = "lblWait";
            this.lblWait.Size = new System.Drawing.Size(93, 20);
            this.lblWait.TabIndex = 49;
            this.lblWait.Text = "please wait...";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(12, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(77, 34);
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1072, 635);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.Form2_Activated);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorGender)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic8CharDone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpperDone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic8CharError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpperError)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorDigit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDigitDone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeOpenP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblDone;
        private System.Windows.Forms.PictureBox picDone;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider erroUser;
        private System.Windows.Forms.ErrorProvider erroEmail;
        private System.Windows.Forms.ErrorProvider errorGender;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnResend;
        private System.Windows.Forms.Label lblEmailAvailble;
        private System.Windows.Forms.Label lblUserAvailable;
        private System.Windows.Forms.Label lblPswR;
        private System.Windows.Forms.PictureBox picUpperError;
        private System.Windows.Forms.PictureBox pic8CharError;
        private System.Windows.Forms.PictureBox picUpperDone;
        private System.Windows.Forms.PictureBox pic8CharDone;
        private System.Windows.Forms.Label lblUppercase;
        private System.Windows.Forms.Label lbl8Char;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label lbltick;
        private System.Windows.Forms.CheckBox chkStu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.Label lblVerify;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRePswS;
        private System.Windows.Forms.TextBox txtPswS;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUserS;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblWait;
        private System.Windows.Forms.PictureBox picEyeHide;
        private System.Windows.Forms.PictureBox picEyeOpenP;
        private System.Windows.Forms.PictureBox picErrorDigit;
        private System.Windows.Forms.PictureBox picDigitDone;
        private System.Windows.Forms.Label lblDigits;
    }
}