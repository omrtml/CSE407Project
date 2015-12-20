namespace LibraryProject
{
    partial class LoginScreen
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usernametext = new System.Windows.Forms.TextBox();
            this.passwordtext = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.btn_registration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(94, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(94, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            // 
            // usernametext
            // 
            this.usernametext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usernametext.Location = new System.Drawing.Point(198, 76);
            this.usernametext.Margin = new System.Windows.Forms.Padding(6);
            this.usernametext.Name = "usernametext";
            this.usernametext.Size = new System.Drawing.Size(151, 30);
            this.usernametext.TabIndex = 2;
            // 
            // passwordtext
            // 
            this.passwordtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordtext.Location = new System.Drawing.Point(198, 115);
            this.passwordtext.Name = "passwordtext";
            this.passwordtext.PasswordChar = '*';
            this.passwordtext.Size = new System.Drawing.Size(151, 30);
            this.passwordtext.TabIndex = 3;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(139, 176);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 4;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(253, 176);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 5;
            this.exit.Text = "Exit";
            this.exit.Click += new System.EventHandler(this.exit_Click_1);
            // 
            // btn_registration
            // 
            this.btn_registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_registration.Location = new System.Drawing.Point(348, 12);
            this.btn_registration.Name = "btn_registration";
            this.btn_registration.Size = new System.Drawing.Size(122, 30);
            this.btn_registration.TabIndex = 10;
            this.btn_registration.Text = "Registration";
            this.btn_registration.UseVisualStyleBackColor = true;
            this.btn_registration.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 254);
            this.Controls.Add(this.btn_registration);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.login);
            this.Controls.Add(this.passwordtext);
            this.Controls.Add(this.usernametext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "LoginScreen";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

  
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usernametext;
        private System.Windows.Forms.TextBox passwordtext;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button btn_registration;
    }
}