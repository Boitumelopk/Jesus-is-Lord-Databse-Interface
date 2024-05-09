namespace Jesus_is_Lord_DBs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox2 = new PictureBox();
            loginbtn = new Button();
            textusername = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textpassword = new TextBox();
            welcome = new Label();
            clearbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ControlLight;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(47, 31);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(105, 78);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // loginbtn
            // 
            loginbtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginbtn.Location = new Point(318, 329);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(122, 46);
            loginbtn.TabIndex = 4;
            loginbtn.Text = "Login";
            loginbtn.UseVisualStyleBackColor = true;
            loginbtn.Click += loginbtn_Click;
            // 
            // textusername
            // 
            textusername.Location = new Point(283, 184);
            textusername.Name = "textusername";
            textusername.Size = new Size(208, 27);
            textusername.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(84, 173);
            label1.Name = "label1";
            label1.Size = new Size(142, 38);
            label1.TabIndex = 8;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(84, 253);
            label2.Name = "label2";
            label2.Size = new Size(132, 38);
            label2.TabIndex = 10;
            label2.Text = "Password";
            // 
            // textpassword
            // 
            textpassword.Location = new Point(283, 264);
            textpassword.Name = "textpassword";
            textpassword.Size = new Size(208, 27);
            textpassword.TabIndex = 9;
            // 
            // welcome
            // 
            welcome.Anchor = AnchorStyles.Top;
            welcome.AutoSize = true;
            welcome.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            welcome.Location = new Point(254, 43);
            welcome.Name = "welcome";
            welcome.Size = new Size(132, 38);
            welcome.TabIndex = 11;
            welcome.Text = "Welcome";
            // 
            // clearbtn
            // 
            clearbtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearbtn.Location = new Point(118, 329);
            clearbtn.Name = "clearbtn";
            clearbtn.Size = new Size(130, 46);
            clearbtn.TabIndex = 12;
            clearbtn.Text = "Clear";
            clearbtn.UseVisualStyleBackColor = true;
            clearbtn.Click += clearbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(593, 434);
            Controls.Add(clearbtn);
            Controls.Add(welcome);
            Controls.Add(label2);
            Controls.Add(textpassword);
            Controls.Add(label1);
            Controls.Add(textusername);
            Controls.Add(loginbtn);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form1";
            Text = "Jesus Is Lord Database";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button loginbtn;
        private TextBox textusername;
        private Label label1;
        private Label label2;
        private TextBox textpassword;
        private Label welcome;
        private Button clearbtn;
    }
}
