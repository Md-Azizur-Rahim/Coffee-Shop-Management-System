namespace Coffee_Shop_Management_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_user_Id = new Label();
            lbl_user_pass = new Label();
            txt_user_email = new TextBox();
            txt_user_password = new TextBox();
            btn_logIn = new Button();
            SuspendLayout();
            // 
            // lbl_user_Id
            // 
            lbl_user_Id.AutoSize = true;
            lbl_user_Id.Font = new Font("Calibri", 16.3018875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_user_Id.Location = new Point(120, 111);
            lbl_user_Id.Name = "lbl_user_Id";
            lbl_user_Id.Size = new Size(137, 31);
            lbl_user_Id.TabIndex = 0;
            lbl_user_Id.Text = "User Email :";
            // 
            // lbl_user_pass
            // 
            lbl_user_pass.AutoSize = true;
            lbl_user_pass.Font = new Font("Calibri", 16.3018875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_user_pass.Location = new Point(120, 173);
            lbl_user_pass.Name = "lbl_user_pass";
            lbl_user_pass.Size = new Size(126, 31);
            lbl_user_pass.TabIndex = 1;
            lbl_user_pass.Text = "Password :";
            // 
            // txt_user_email
            // 
            txt_user_email.Font = new Font("Calibri", 16.3018875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_user_email.Location = new Point(263, 111);
            txt_user_email.Name = "txt_user_email";
            txt_user_email.Size = new Size(407, 37);
            txt_user_email.TabIndex = 2;
            // 
            // txt_user_password
            // 
            txt_user_password.Font = new Font("Calibri", 16.3018875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_user_password.Location = new Point(263, 173);
            txt_user_password.Name = "txt_user_password";
            txt_user_password.Size = new Size(407, 37);
            txt_user_password.TabIndex = 3;
            txt_user_password.UseSystemPasswordChar = true;
            // 
            // btn_logIn
            // 
            btn_logIn.BackColor = Color.White;
            btn_logIn.Cursor = Cursors.Hand;
            btn_logIn.Font = new Font("Calibri", 16.3018875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_logIn.Location = new Point(324, 287);
            btn_logIn.Name = "btn_logIn";
            btn_logIn.RightToLeft = RightToLeft.No;
            btn_logIn.Size = new Size(146, 52);
            btn_logIn.TabIndex = 4;
            btn_logIn.Text = "Log In";
            btn_logIn.UseVisualStyleBackColor = false;
            btn_logIn.Click += btn_logIn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(btn_logIn);
            Controls.Add(txt_user_password);
            Controls.Add(txt_user_email);
            Controls.Add(lbl_user_pass);
            Controls.Add(lbl_user_Id);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_user_Id;
        private Label lbl_user_pass;
        private TextBox txt_user_email;
        private TextBox txt_user_password;
        private Button btn_logIn;
    }
}
