namespace Facial_Recognition_Attendance_System
{
    partial class UserSpace
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
            this.picCapture = new System.Windows.Forms.PictureBox();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.picDetected = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDetected)).BeginInit();
            this.SuspendLayout();
            // 
            // picCapture
            // 
            this.picCapture.Location = new System.Drawing.Point(12, 12);
            this.picCapture.Name = "picCapture";
            this.picCapture.Size = new System.Drawing.Size(552, 309);
            this.picCapture.TabIndex = 0;
            this.picCapture.TabStop = false;
            this.picCapture.Click += new System.EventHandler(this.picCapture_Click);
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.Location = new System.Drawing.Point(571, 12);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(218, 58);
            this.btnAdminLogin.TabIndex = 6;
            this.btnAdminLogin.Text = "Admin Login";
            this.btnAdminLogin.UseVisualStyleBackColor = true;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 58);
            this.button1.TabIndex = 7;
            this.button1.Text = "Time In Am";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(281, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 58);
            this.button2.TabIndex = 8;
            this.button2.Text = "Time Out Pm";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(281, 419);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(218, 58);
            this.button3.TabIndex = 10;
            this.button3.Text = "Time Out Pm";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(57, 419);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(218, 58);
            this.button4.TabIndex = 9;
            this.button4.Text = "Time In Pm";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // picDetected
            // 
            this.picDetected.Location = new System.Drawing.Point(572, 76);
            this.picDetected.Name = "picDetected";
            this.picDetected.Size = new System.Drawing.Size(217, 245);
            this.picDetected.TabIndex = 11;
            this.picDetected.TabStop = false;
            // 
            // UserSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.picDetected);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdminLogin);
            this.Controls.Add(this.picCapture);
            this.Name = "UserSpace";
            this.Text = "UserSpace";
            this.Load += new System.EventHandler(this.UserSpace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDetected)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCapture;
        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox picDetected;
    }
}