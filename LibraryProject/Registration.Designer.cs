namespace LibraryProject
{
    partial class Registration
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_PasswordConfirm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_PriKey = new System.Windows.Forms.TextBox();
            this.btn_Register = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lblwarning = new System.Windows.Forms.Label();
            this.lblconfirm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(135, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(139, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(19, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password Comfirmation:";
            // 
            // txt_Username
            // 
            this.txt_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Username.Location = new System.Drawing.Point(249, 36);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(181, 30);
            this.txt_Username.TabIndex = 3;
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Password.Location = new System.Drawing.Point(249, 83);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(181, 30);
            this.txt_Password.TabIndex = 4;
            this.txt_Password.Tag = "";
            this.txt_Password.TextChanged += new System.EventHandler(this.txt_Password_TextChanged);
            // 
            // txt_PasswordConfirm
            // 
            this.txt_PasswordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_PasswordConfirm.Location = new System.Drawing.Point(249, 147);
            this.txt_PasswordConfirm.Name = "txt_PasswordConfirm";
            this.txt_PasswordConfirm.PasswordChar = '*';
            this.txt_PasswordConfirm.Size = new System.Drawing.Size(181, 30);
            this.txt_PasswordConfirm.TabIndex = 5;
            this.txt_PasswordConfirm.Tag = "";
            this.txt_PasswordConfirm.TextChanged += new System.EventHandler(this.txt_PasswordConfirm_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(111, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Privilage Key:";
            // 
            // txt_PriKey
            // 
            this.txt_PriKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_PriKey.Location = new System.Drawing.Point(249, 207);
            this.txt_PriKey.Name = "txt_PriKey";
            this.txt_PriKey.PasswordChar = '*';
            this.txt_PriKey.Size = new System.Drawing.Size(181, 30);
            this.txt_PriKey.TabIndex = 7;
            // 
            // btn_Register
            // 
            this.btn_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Register.Location = new System.Drawing.Point(46, 267);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(122, 47);
            this.btn_Register.TabIndex = 8;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Exit.Location = new System.Drawing.Point(390, 267);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(122, 47);
            this.btn_Exit.TabIndex = 9;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lblwarning
            // 
            this.lblwarning.AutoSize = true;
            this.lblwarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblwarning.ForeColor = System.Drawing.Color.Red;
            this.lblwarning.Location = new System.Drawing.Point(21, 116);
            this.lblwarning.Name = "lblwarning";
            this.lblwarning.Size = new System.Drawing.Size(611, 26);
            this.lblwarning.TabIndex = 10;
            this.lblwarning.Text = "The password you have entered is not valid according to password policy\r\nPlease u" +
    "se Upper Case - Lower Case - Numeric - Non-Alpha Numeric characters with minumum" +
    " lenght of 8.";
            this.lblwarning.Visible = false;
            // 
            // lblconfirm
            // 
            this.lblconfirm.AutoSize = true;
            this.lblconfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblconfirm.ForeColor = System.Drawing.Color.Red;
            this.lblconfirm.Location = new System.Drawing.Point(148, 180);
            this.lblconfirm.Name = "lblconfirm";
            this.lblconfirm.Size = new System.Drawing.Size(364, 13);
            this.lblconfirm.TabIndex = 11;
            this.lblconfirm.Text = "Password and Confirmation does not match. Please type again.";
            this.lblconfirm.Visible = false;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 376);
            this.Controls.Add(this.lblconfirm);
            this.Controls.Add(this.lblwarning);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.txt_PriKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_PasswordConfirm);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registration";
            this.Text = "Registration Screen";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_PasswordConfirm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_PriKey;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lblwarning;
        private System.Windows.Forms.Label lblconfirm;
    }
}