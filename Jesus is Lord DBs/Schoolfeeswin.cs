using iText.StyledXmlParser.Jsoup.Nodes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace Jesus_is_Lord_DBs
{
    public partial class Schoolfeeswin : Form
    {
        public Schoolfeeswin()
        {
            InitializeComponent();
        }

        private void findbtn1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog= Jesus Is Lord Christian School;Integrated Security=True");
                string query = "SELECT * FROM SchoolFees WHERE AccessionNum = @AccessionNum";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@AccessionNum", textAccNum.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog= Jesus Is Lord Christian School;Integrated Security=True");
                string query = "SELECT * FROM SchoolFees WHERE FeesPaid = @FeesPaid";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@FeesPaid", textfeespaid.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog= Jesus Is Lord Christian School;Integrated Security=True");
                string query = "SELECT * FROM SchoolFees WHERE TotalFees = @TotalFees";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@TotalFees", textTotalfeespaid.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog= Jesus Is Lord Christian School;Integrated Security=True");
                string query = "SELECT * FROM SchoolFees WHERE PaymentMethod = @PaymentMethod";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@PaymentMethod", comboBox1.SelectedItem);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog= Jesus Is Lord Christian School;Integrated Security=True");
                string query = "SELECT * FROM SchoolFees WHERE ReceiptNumber = @ReceiptNumber";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@ReceiptNumber", textReceiptNumber.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showallbtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog= Jesus Is Lord Christian School;Integrated Security=True");
                string query = "SELECT * FROM SchoolFees ";
                SqlCommand command = new SqlCommand(query, conn);
                ;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ADDbtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog=Jesus Is Lord Christian School;Integrated Security=True");
            conn.Open();
            string query = "INSERT into SchoolFees (AccessionNum,FeesPaid,TotalFees,PaymentMethod,ReceiptNumber) VALUES (@AccessionNum,@FeesPaid,@TotalFees,@PaymentMethod,@ReceiptNumber)";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@AccessionNum", textAccNum.Text);
            command.Parameters.AddWithValue("@FeesPaid", textfeespaid.Text);
            command.Parameters.AddWithValue("@TotalFees", textTotalfeespaid.Text);
            command.Parameters.AddWithValue("@PaymentMethod", comboBox1.SelectedItem);
            command.Parameters.AddWithValue("@ReceiptNumber", textReceiptNumber.Text);

            command.ExecuteNonQuery();
            MessageBox.Show("Successfully Added");
            conn.Close();
        }

        private void DELBTN_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult myResult = MessageBox.Show("Are you sure you want to delete this record?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (myResult == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog= Jesus Is Lord Christian School;Integrated Security=True");
                    conn.Open();
                    SqlCommand del = new SqlCommand("DELETE FROM SchoolFees WHERE  AccessionNum = @AccessionNum ", conn);
                    del.Parameters.AddWithValue("@AccessionNum", textAccNum.Text);
                    del.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Succesfully deleted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            finally
            {

            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult myResult = MessageBox.Show("Are you sure you want to Update this record?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (myResult == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog=Jesus Is Lord Christian School;Integrated Security=True");
                    conn.Open();
                    string query = "UPDATE SchoolFees SET FeesPaid = @FeesPaid, TotalFees = @TotalFees, PaymentMethod = @PaymentMethod, ReceiptNumber = @ReceiptNumber WHERE AccessionNum = @AccessionNum";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@AccessionNum", textAccNum.Text);
                    command.Parameters.AddWithValue("@FeesPaid", textfeespaid.Text);
                    command.Parameters.AddWithValue("@TotalFees", textTotalfeespaid.Text);
                    command.Parameters.AddWithValue("@PaymentMethod", comboBox1.SelectedItem);
                    command.Parameters.AddWithValue("@ReceiptNumber", textReceiptNumber.Text);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Successfully Added");
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            finally
            {

            }
        }

        private void BACKbtn_Click(object sender, EventArgs e)
        {
            ADDWIN aDDWIN = new ADDWIN();
            aDDWIN.Show();
            this.Hide();
        }

        private void COUNTRECORDSBTN_Click(object sender, EventArgs e)
        { // Assuming you have a DataGridView named dataGridView1
            int recordCount = dataGridView1.RowCount - 1;

            // Now you can use recordCount as needed

            //int count = CountRecords (dataGridView1) - 1;
            MessageBox.Show("Total records: " + recordCount);
        }

        private void CLRBTN_Click(object sender, EventArgs e)
        {
            textAccNum.Clear();
            textfeespaid.Clear();
            textTotalfeespaid.Clear();
            textReceiptNumber.Clear();

        }

        private void textAccNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /* private void textfeespaid_TextChanged(object sender, EventArgs e)
         {
             decimal price;
             if (
                 decimal.TryParse(textfeespaid.Text, out price))
             { textfeespaid.Text = string.Format("{0;C}", price); }
             else
             {
                 textfeespaid.Text = string.Empty;
             }
         }*/

        private void textfeespaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void textTotalfeespaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        /*  private void textfeespaid_Leave(object sender, EventArgs e)
          {
              decimal price;
              if(decimal.TryParse(textfeespaid.Text,out price))
              {
                  textfeespaid.Text = string.Format("{0:C}",price);
              }
          }*/
    }
}
