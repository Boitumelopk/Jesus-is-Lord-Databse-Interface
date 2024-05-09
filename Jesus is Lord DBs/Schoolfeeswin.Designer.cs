namespace Jesus_is_Lord_DBs
{
    partial class Schoolfeeswin
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textAccNum = new TextBox();
            textfeespaid = new TextBox();
            textTotalfeespaid = new TextBox();
            textReceiptNumber = new TextBox();
            findbtn1 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ADDbtn = new Button();
            DELBTN = new Button();
            updatebtn = new Button();
            showallbtn = new Button();
            dataGridView1 = new DataGridView();
            COUNTRECORDSBTN = new Button();
            BACKbtn = new Button();
            CLRBTN = new Button();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 69);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 1;
            label1.Text = "AccessionNum";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 168);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Fees Paid";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(680, 75);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 3;
            label3.Text = "Total Fees Paid ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(680, 151);
            label4.Name = "label4";
            label4.Size = new Size(125, 20);
            label4.TabIndex = 4;
            label4.Text = "Payment Method ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(692, 240);
            label5.Name = "label5";
            label5.Size = new Size(117, 20);
            label5.TabIndex = 5;
            label5.Text = "Receipt Number";
            // 
            // textAccNum
            // 
            textAccNum.Location = new Point(191, 72);
            textAccNum.Name = "textAccNum";
            textAccNum.Size = new Size(307, 27);
            textAccNum.TabIndex = 9;
            textAccNum.KeyPress += textAccNum_KeyPress;
            // 
            // textfeespaid
            // 
            textfeespaid.Location = new Point(191, 165);
            textfeespaid.Name = "textfeespaid";
            textfeespaid.Size = new Size(307, 27);
            textfeespaid.TabIndex = 10;
            textfeespaid.KeyPress += textfeespaid_KeyPress;
            // 
            // textTotalfeespaid
            // 
            textTotalfeespaid.Location = new Point(856, 72);
            textTotalfeespaid.Name = "textTotalfeespaid";
            textTotalfeespaid.Size = new Size(307, 27);
            textTotalfeespaid.TabIndex = 11;
            textTotalfeespaid.KeyPress += textTotalfeespaid_KeyPress;
            // 
            // textReceiptNumber
            // 
            textReceiptNumber.Location = new Point(856, 233);
            textReceiptNumber.Name = "textReceiptNumber";
            textReceiptNumber.Size = new Size(307, 27);
            textReceiptNumber.TabIndex = 13;
            // 
            // findbtn1
            // 
            findbtn1.Location = new Point(521, 69);
            findbtn1.Name = "findbtn1";
            findbtn1.Size = new Size(124, 33);
            findbtn1.TabIndex = 18;
            findbtn1.Text = "Find";
            findbtn1.UseVisualStyleBackColor = true;
            findbtn1.Click += findbtn1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(521, 168);
            button1.Name = "button1";
            button1.Size = new Size(124, 33);
            button1.TabIndex = 19;
            button1.Text = "Find";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1201, 69);
            button2.Name = "button2";
            button2.Size = new Size(124, 33);
            button2.TabIndex = 20;
            button2.Text = "Find";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1201, 151);
            button3.Name = "button3";
            button3.Size = new Size(124, 33);
            button3.TabIndex = 21;
            button3.Text = "Find";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1201, 234);
            button4.Name = "button4";
            button4.Size = new Size(124, 33);
            button4.TabIndex = 22;
            button4.Text = "Find";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // ADDbtn
            // 
            ADDbtn.Location = new Point(896, 326);
            ADDbtn.Name = "ADDbtn";
            ADDbtn.Size = new Size(124, 33);
            ADDbtn.TabIndex = 26;
            ADDbtn.Text = "ADD";
            ADDbtn.UseVisualStyleBackColor = true;
            ADDbtn.Click += ADDbtn_Click;
            // 
            // DELBTN
            // 
            DELBTN.Location = new Point(1050, 326);
            DELBTN.Name = "DELBTN";
            DELBTN.Size = new Size(124, 33);
            DELBTN.TabIndex = 27;
            DELBTN.Text = "DELETE";
            DELBTN.UseVisualStyleBackColor = true;
            DELBTN.Click += DELBTN_Click;
            // 
            // updatebtn
            // 
            updatebtn.Location = new Point(1201, 326);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(124, 33);
            updatebtn.TabIndex = 28;
            updatebtn.Text = "UPDATE";
            updatebtn.UseVisualStyleBackColor = true;
            updatebtn.Click += updatebtn_Click;
            // 
            // showallbtn
            // 
            showallbtn.Location = new Point(692, 326);
            showallbtn.Name = "showallbtn";
            showallbtn.Size = new Size(177, 33);
            showallbtn.TabIndex = 29;
            showallbtn.Text = "Show ALL Records";
            showallbtn.UseVisualStyleBackColor = true;
            showallbtn.Click += showallbtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(59, 365);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1272, 313);
            dataGridView1.TabIndex = 30;
            // 
            // COUNTRECORDSBTN
            // 
            COUNTRECORDSBTN.Location = new Point(910, 697);
            COUNTRECORDSBTN.Name = "COUNTRECORDSBTN";
            COUNTRECORDSBTN.Size = new Size(191, 33);
            COUNTRECORDSBTN.TabIndex = 31;
            COUNTRECORDSBTN.Text = "COUNT RECORDS";
            COUNTRECORDSBTN.UseVisualStyleBackColor = true;
            COUNTRECORDSBTN.Click += COUNTRECORDSBTN_Click;
            // 
            // BACKbtn
            // 
            BACKbtn.Location = new Point(1140, 697);
            BACKbtn.Name = "BACKbtn";
            BACKbtn.Size = new Size(191, 33);
            BACKbtn.TabIndex = 32;
            BACKbtn.Text = "BACK";
            BACKbtn.UseVisualStyleBackColor = true;
            BACKbtn.Click += BACKbtn_Click;
            // 
            // CLRBTN
            // 
            CLRBTN.Location = new Point(59, 315);
            CLRBTN.Name = "CLRBTN";
            CLRBTN.Size = new Size(177, 33);
            CLRBTN.TabIndex = 33;
            CLRBTN.Text = "CLEAR ALL TEXTBOXES";
            CLRBTN.UseVisualStyleBackColor = true;
            CLRBTN.Click += CLRBTN_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Cash", "Card" });
            comboBox1.Location = new Point(856, 157);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(307, 28);
            comboBox1.TabIndex = 34;
            // 
            // Schoolfeeswin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 753);
            Controls.Add(comboBox1);
            Controls.Add(CLRBTN);
            Controls.Add(BACKbtn);
            Controls.Add(COUNTRECORDSBTN);
            Controls.Add(dataGridView1);
            Controls.Add(showallbtn);
            Controls.Add(updatebtn);
            Controls.Add(DELBTN);
            Controls.Add(ADDbtn);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(findbtn1);
            Controls.Add(textReceiptNumber);
            Controls.Add(textTotalfeespaid);
            Controls.Add(textfeespaid);
            Controls.Add(textAccNum);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Schoolfeeswin";
            Text = "Schoolfeeswin";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textAccNum;
        private TextBox textfeespaid;
        private TextBox textTotalfeespaid;
        private TextBox textReceiptNumber;
        private Button findbtn1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button ADDbtn;
        private Button DELBTN;
        private Button updatebtn;
        private Button showallbtn;
        private DataGridView dataGridView1;
        private Button COUNTRECORDSBTN;
        private Button BACKbtn;
        private Button CLRBTN;
        private ComboBox comboBox1;
    }
}