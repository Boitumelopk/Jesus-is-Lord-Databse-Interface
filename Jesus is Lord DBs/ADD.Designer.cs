namespace Jesus_is_Lord_DBs
{
    partial class ADDWIN
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
            empbtn = new Button();
            NettPayListbtn = new Button();
            Studentsbtn = new Button();
            schoolfeesbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 81);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 0;
            label1.Text = "Choose Table: ";
            // 
            // empbtn
            // 
            empbtn.Location = new Point(47, 159);
            empbtn.Name = "empbtn";
            empbtn.Size = new Size(119, 39);
            empbtn.TabIndex = 1;
            empbtn.Text = "Employees";
            empbtn.UseVisualStyleBackColor = true;
            empbtn.Click += empbtn_Click;
            // 
            // NettPayListbtn
            // 
            NettPayListbtn.Location = new Point(241, 159);
            NettPayListbtn.Name = "NettPayListbtn";
            NettPayListbtn.Size = new Size(119, 39);
            NettPayListbtn.TabIndex = 2;
            NettPayListbtn.Text = "NettPayList";
            NettPayListbtn.UseVisualStyleBackColor = true;
            NettPayListbtn.Click += NettPayListbtn_Click;
            // 
            // Studentsbtn
            // 
            Studentsbtn.Location = new Point(428, 159);
            Studentsbtn.Name = "Studentsbtn";
            Studentsbtn.Size = new Size(119, 39);
            Studentsbtn.TabIndex = 3;
            Studentsbtn.Text = "Students";
            Studentsbtn.UseVisualStyleBackColor = true;
            Studentsbtn.Click += Studentsbtn_Click;
            // 
            // schoolfeesbtn
            // 
            schoolfeesbtn.Location = new Point(611, 159);
            schoolfeesbtn.Name = "schoolfeesbtn";
            schoolfeesbtn.Size = new Size(119, 39);
            schoolfeesbtn.TabIndex = 4;
            schoolfeesbtn.Text = "School Fees";
            schoolfeesbtn.UseVisualStyleBackColor = true;
            schoolfeesbtn.Click += schoolfeesbtn_Click;
            // 
            // ADDWIN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 269);
            Controls.Add(schoolfeesbtn);
            Controls.Add(Studentsbtn);
            Controls.Add(NettPayListbtn);
            Controls.Add(empbtn);
            Controls.Add(label1);
            Name = "ADDWIN";
            Text = "ADD";
            Load += ADD_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button empbtn;
        private Button NettPayListbtn;
        private Button Studentsbtn;
        private Button schoolfeesbtn;
    }
}