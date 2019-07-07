namespace Student_Portal
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.logInPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.logInMenu = new System.Windows.Forms.Button();
            this.resultMenu = new System.Windows.Forms.Button();
            this.signUpMenu = new System.Windows.Forms.Button();
            this.spImage = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.teacherRadioButton = new System.Windows.Forms.RadioButton();
            this.studentRadioButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logInPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // logInPictureBox
            // 
            this.logInPictureBox.BackColor = System.Drawing.Color.DimGray;
            this.logInPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logInPictureBox.Image")));
            this.logInPictureBox.Location = new System.Drawing.Point(491, 88);
            this.logInPictureBox.Name = "logInPictureBox";
            this.logInPictureBox.Size = new System.Drawing.Size(365, 599);
            this.logInPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logInPictureBox.TabIndex = 0;
            this.logInPictureBox.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1338, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // logInMenu
            // 
            this.logInMenu.BackColor = System.Drawing.Color.SlateBlue;
            this.logInMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInMenu.Location = new System.Drawing.Point(27, 29);
            this.logInMenu.Name = "logInMenu";
            this.logInMenu.Size = new System.Drawing.Size(103, 48);
            this.logInMenu.TabIndex = 2;
            this.logInMenu.Text = "Log In";
            this.logInMenu.UseVisualStyleBackColor = false;
            // 
            // resultMenu
            // 
            this.resultMenu.BackColor = System.Drawing.Color.SlateBlue;
            this.resultMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultMenu.Location = new System.Drawing.Point(146, 29);
            this.resultMenu.Name = "resultMenu";
            this.resultMenu.Size = new System.Drawing.Size(103, 48);
            this.resultMenu.TabIndex = 3;
            this.resultMenu.Text = "Result";
            this.resultMenu.UseVisualStyleBackColor = false;
            this.resultMenu.Click += new System.EventHandler(this.resultMenu_Click);
            // 
            // signUpMenu
            // 
            this.signUpMenu.BackColor = System.Drawing.Color.SlateBlue;
            this.signUpMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpMenu.Location = new System.Drawing.Point(264, 29);
            this.signUpMenu.Name = "signUpMenu";
            this.signUpMenu.Size = new System.Drawing.Size(103, 48);
            this.signUpMenu.TabIndex = 4;
            this.signUpMenu.Text = "Sign Up";
            this.signUpMenu.UseVisualStyleBackColor = false;
            this.signUpMenu.Click += new System.EventHandler(this.signUpMenu_Click);
            // 
            // spImage
            // 
            this.spImage.AutoSize = true;
            this.spImage.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.spImage.Font = new System.Drawing.Font("Arial Narrow", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spImage.Location = new System.Drawing.Point(560, 147);
            this.spImage.Name = "spImage";
            this.spImage.Size = new System.Drawing.Size(226, 46);
            this.spImage.TabIndex = 6;
            this.spImage.Text = "Student Portal";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.BackColor = System.Drawing.Color.Transparent;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(515, 272);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(110, 25);
            this.userName.TabIndex = 7;
            this.userName.Text = "User Name";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.userNameTextBox.Location = new System.Drawing.Point(515, 305);
            this.userNameTextBox.Multiline = true;
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(321, 37);
            this.userNameTextBox.TabIndex = 9;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.passwordTextBox.Location = new System.Drawing.Point(516, 389);
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(321, 37);
            this.passwordTextBox.TabIndex = 11;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(517, 358);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(98, 25);
            this.password.TabIndex = 10;
            this.password.Text = "Password";
            // 
            // teacherRadioButton
            // 
            this.teacherRadioButton.AutoSize = true;
            this.teacherRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherRadioButton.Location = new System.Drawing.Point(568, 440);
            this.teacherRadioButton.Name = "teacherRadioButton";
            this.teacherRadioButton.Size = new System.Drawing.Size(103, 29);
            this.teacherRadioButton.TabIndex = 13;
            this.teacherRadioButton.TabStop = true;
            this.teacherRadioButton.Text = "Teacher";
            this.teacherRadioButton.UseVisualStyleBackColor = true;
            // 
            // studentRadioButton
            // 
            this.studentRadioButton.AutoSize = true;
            this.studentRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentRadioButton.Location = new System.Drawing.Point(688, 440);
            this.studentRadioButton.Name = "studentRadioButton";
            this.studentRadioButton.Size = new System.Drawing.Size(98, 29);
            this.studentRadioButton.TabIndex = 14;
            this.studentRadioButton.TabStop = true;
            this.studentRadioButton.Text = "Student";
            this.studentRadioButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(384, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 48);
            this.button1.TabIndex = 15;
            this.button1.Text = "Administration";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Silver;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.Maroon;
            this.save.Location = new System.Drawing.Point(714, 516);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(128, 43);
            this.save.TabIndex = 16;
            this.save.Text = "Log In";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1354, 731);
            this.Controls.Add(this.save);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.studentRadioButton);
            this.Controls.Add(this.teacherRadioButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.spImage);
            this.Controls.Add(this.signUpMenu);
            this.Controls.Add(this.resultMenu);
            this.Controls.Add(this.logInMenu);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.logInPictureBox);
            this.Name = "LogIn";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log in page";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LogIn_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logInPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logInPictureBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button logInMenu;
        private System.Windows.Forms.Button resultMenu;
        private System.Windows.Forms.Button signUpMenu;
        private System.Windows.Forms.Label spImage;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.RadioButton teacherRadioButton;
        private System.Windows.Forms.RadioButton studentRadioButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button save;

    }
}

