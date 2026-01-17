namespace WinFormsApp1
{
    partial class LoginRegister
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
            lbluser = new Label();
            lblpass = new Label();
            txtbxuser = new TextBox();
            txtbxpass = new TextBox();
            btnLogin = new Button();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // lbluser
            // 
            lbluser.AutoSize = true;
            lbluser.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbluser.ForeColor = Color.SaddleBrown;
            lbluser.Location = new Point(99, 113);
            lbluser.Name = "lbluser";
            lbluser.Size = new Size(83, 21);
            lbluser.TabIndex = 0;
            lbluser.Text = "Username";
            // 
            // lblpass
            // 
            lblpass.AutoSize = true;
            lblpass.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblpass.ForeColor = Color.SaddleBrown;
            lblpass.Location = new Point(99, 184);
            lblpass.Name = "lblpass";
            lblpass.Size = new Size(79, 21);
            lblpass.TabIndex = 1;
            lblpass.Text = "Password";
            // 
            // txtbxuser
            // 
            txtbxuser.BackColor = Color.Bisque;
            txtbxuser.Location = new Point(62, 137);
            txtbxuser.Name = "txtbxuser";
            txtbxuser.Size = new Size(147, 23);
            txtbxuser.TabIndex = 2;
            // 
            // txtbxpass
            // 
            txtbxpass.BackColor = Color.Bisque;
            txtbxpass.Location = new Point(62, 208);
            txtbxpass.Name = "txtbxpass";
            txtbxpass.Size = new Size(147, 23);
            txtbxpass.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SaddleBrown;
            btnLogin.ForeColor = Color.Bisque;
            btnLogin.Location = new Point(92, 258);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(90, 27);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Broadway", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.SaddleBrown;
            lblTitle.Location = new Point(92, 47);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(103, 31);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "LOGIN";
            // 
            // LoginRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(271, 355);
            Controls.Add(lblTitle);
            Controls.Add(btnLogin);
            Controls.Add(txtbxpass);
            Controls.Add(txtbxuser);
            Controls.Add(lblpass);
            Controls.Add(lbluser);
            Name = "LoginRegister";
            Text = "LoginRegister";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbluser;
        private Label lblpass;
        private TextBox txtbxuser;
        private TextBox txtbxpass;
        private Button btnLogin;
        private Label lblTitle;
    }
}