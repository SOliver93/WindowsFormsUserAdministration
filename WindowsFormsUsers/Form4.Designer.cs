namespace WindowsFormsUsers
{
    partial class AddUser
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
            this.lblText = new System.Windows.Forms.Label();
            this.lblNewID = new System.Windows.Forms.Label();
            this.lblNewUserName = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblNewFirstName = new System.Windows.Forms.Label();
            this.lblNewLastName = new System.Windows.Forms.Label();
            this.inptNewID = new System.Windows.Forms.TextBox();
            this.inptNewUserName = new System.Windows.Forms.TextBox();
            this.inptNewPassword = new System.Windows.Forms.TextBox();
            this.inptNewFirstName = new System.Windows.Forms.TextBox();
            this.inptNewLastName = new System.Windows.Forms.TextBox();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblText.Location = new System.Drawing.Point(62, 22);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(182, 20);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Dodajte novog korisnika.";
            // 
            // lblNewID
            // 
            this.lblNewID.AutoSize = true;
            this.lblNewID.Location = new System.Drawing.Point(44, 78);
            this.lblNewID.Name = "lblNewID";
            this.lblNewID.Size = new System.Drawing.Size(24, 13);
            this.lblNewID.TabIndex = 1;
            this.lblNewID.Text = "ID: ";
            // 
            // lblNewUserName
            // 
            this.lblNewUserName.AutoSize = true;
            this.lblNewUserName.Location = new System.Drawing.Point(44, 106);
            this.lblNewUserName.Name = "lblNewUserName";
            this.lblNewUserName.Size = new System.Drawing.Size(61, 13);
            this.lblNewUserName.TabIndex = 2;
            this.lblNewUserName.Text = "Username: ";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(44, 132);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(53, 13);
            this.lblNewPassword.TabIndex = 3;
            this.lblNewPassword.Text = "Password";
            // 
            // lblNewFirstName
            // 
            this.lblNewFirstName.AutoSize = true;
            this.lblNewFirstName.Location = new System.Drawing.Point(44, 158);
            this.lblNewFirstName.Name = "lblNewFirstName";
            this.lblNewFirstName.Size = new System.Drawing.Size(30, 13);
            this.lblNewFirstName.TabIndex = 4;
            this.lblNewFirstName.Text = "Ime: ";
            // 
            // lblNewLastName
            // 
            this.lblNewLastName.AutoSize = true;
            this.lblNewLastName.Location = new System.Drawing.Point(44, 184);
            this.lblNewLastName.Name = "lblNewLastName";
            this.lblNewLastName.Size = new System.Drawing.Size(50, 13);
            this.lblNewLastName.TabIndex = 5;
            this.lblNewLastName.Text = "Prezime: ";
            // 
            // inptNewID
            // 
            this.inptNewID.Location = new System.Drawing.Point(125, 75);
            this.inptNewID.Name = "inptNewID";
            this.inptNewID.Size = new System.Drawing.Size(119, 20);
            this.inptNewID.TabIndex = 6;
            // 
            // inptNewUserName
            // 
            this.inptNewUserName.Location = new System.Drawing.Point(125, 103);
            this.inptNewUserName.Name = "inptNewUserName";
            this.inptNewUserName.Size = new System.Drawing.Size(119, 20);
            this.inptNewUserName.TabIndex = 7;
            // 
            // inptNewPassword
            // 
            this.inptNewPassword.Location = new System.Drawing.Point(125, 129);
            this.inptNewPassword.Name = "inptNewPassword";
            this.inptNewPassword.Size = new System.Drawing.Size(119, 20);
            this.inptNewPassword.TabIndex = 8;
            // 
            // inptNewFirstName
            // 
            this.inptNewFirstName.Location = new System.Drawing.Point(125, 155);
            this.inptNewFirstName.Name = "inptNewFirstName";
            this.inptNewFirstName.Size = new System.Drawing.Size(119, 20);
            this.inptNewFirstName.TabIndex = 9;
            // 
            // inptNewLastName
            // 
            this.inptNewLastName.Location = new System.Drawing.Point(125, 181);
            this.inptNewLastName.Name = "inptNewLastName";
            this.inptNewLastName.Size = new System.Drawing.Size(119, 20);
            this.inptNewLastName.TabIndex = 10;
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Location = new System.Drawing.Point(125, 236);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(92, 35);
            this.btnAddNewUser.TabIndex = 11;
            this.btnAddNewUser.Text = "Spremi";
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 311);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.inptNewLastName);
            this.Controls.Add(this.inptNewFirstName);
            this.Controls.Add(this.inptNewPassword);
            this.Controls.Add(this.inptNewUserName);
            this.Controls.Add(this.inptNewID);
            this.Controls.Add(this.lblNewLastName);
            this.Controls.Add(this.lblNewFirstName);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblNewUserName);
            this.Controls.Add(this.lblNewID);
            this.Controls.Add(this.lblText);
            this.Name = "AddUser";
            this.Text = "Dodavanje korisnika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblNewID;
        private System.Windows.Forms.Label lblNewUserName;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblNewFirstName;
        private System.Windows.Forms.Label lblNewLastName;
        private System.Windows.Forms.TextBox inptNewID;
        private System.Windows.Forms.TextBox inptNewUserName;
        private System.Windows.Forms.TextBox inptNewPassword;
        private System.Windows.Forms.TextBox inptNewFirstName;
        private System.Windows.Forms.TextBox inptNewLastName;
        private System.Windows.Forms.Button btnAddNewUser;
    }
}