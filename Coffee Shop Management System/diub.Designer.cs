namespace Coffee_Shop_Management_System
{
    partial class diub
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
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(224, 54);
            label1.Name = "label1";
            label1.Size = new Size(296, 59);
            label1.TabIndex = 0;
            label1.Text = "  Diub Ahmed";
            // 
            // button1
            // 
            button1.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(234, 184);
            button1.Name = "button1";
            button1.Size = new Size(248, 80);
            button1.TabIndex = 1;
            button1.Text = "DIUB er DUDU";
            button1.UseVisualStyleBackColor = true;
            // 
            // diub
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "diub";
            Text = "diub";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
    }
}