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
    public partial class NettPayListWIN : Form
    {
        public NettPayListWIN()
        {
            InitializeComponent();
        }

        private void findbtn1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog= Jesus Is Lord Christian School;Integrated Security=True");
                string query = "SELECT * FROM JILCSNettPayList WHERE EmpId= @EmpId";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@EmpId", textEMPID.Text);
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

        private void findbtn2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog= Jesus Is Lord Christian School;Integrated Security=True");
                string query = "SELECT * FROM JILCSNettPayList WHERE Name = @Name";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Name", textNAME.Text);
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

        private void finndbtn3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog= Jesus Is Lord Christian School;Integrated Security=True");
                string query = "SELECT * FROM JILCSNettPayList WHERE Surname= @Surname";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Surname", textSURNAME.Text);
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

        private void findbtn4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog= Jesus Is Lord Christian School;Integrated Security=True");
                string query = "SELECT * FROM JILCSNettPayList WHERE PayMethod= @PayMethod";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@PayMethod", comboBox1.SelectedItem);
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

        private void findbtn5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog= Jesus Is Lord Christian School;Integrated Security=True");
                string query = "SELECT * FROM JILCSNettPayList WHERE BankName = @BankName";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@BankName", textBANKNAME.Text);
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

        private void Findbtn6_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog= Jesus Is Lord Christian School;Integrated Security=True");
                string query = "SELECT * FROM JILCSNettPayList WHERE AccountNumber= @AccountNumber";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@AccountNumber", textACCNUMBER.Text);
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

        private void findbtn7_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog= Jesus Is Lord Christian School;Integrated Security=True");
                string query = "SELECT * FROM JILCSNettPayList WHERE BranchCode = @BranchCode";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@BranchCode", textBRANCHCODE.Text);
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

        private void findbtn8_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog= Jesus Is Lord Christian School;Integrated Security=True");
                string query = "SELECT * FROM JILCSNettPayList WHERE NettPay = @NettPay";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@NettPay", textNETPAY.Text);
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


        private void UPDATEBTN_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult myResult = MessageBox.Show("Are you sure you want to Update this record?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (myResult == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog=Jesus Is Lord Christian School;Integrated Security=True");
                    conn.Open();
                    string query = "UPDATE JILCSNettPayList SET Name = @Name, Surname = @Surname, PayMethod = @PayMethod, BankName= @BankName, AccountNumber = @AccountNumber, BranchCode = @BranchCode, NettPay = @NettPay WHERE EmpId = @EmpId";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@EmpId", textEMPID.Text);
                    command.Parameters.AddWithValue("@Name", textNAME.Text);
                    command.Parameters.AddWithValue("@Surname", textSURNAME.Text);
                    command.Parameters.AddWithValue("@PayMethod", comboBox1.SelectedItem);
                    command.Parameters.AddWithValue("@BankName", textBANKNAME.Text);
                    command.Parameters.AddWithValue("@AccountNumber", textACCNUMBER.Text);
                    command.Parameters.AddWithValue("@BranchCode", textBRANCHCODE.Text);
                    command.Parameters.AddWithValue("@NettPay", textNETPAY.Text);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Successfully Added");
                    conn.Close(); }

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            finally
            {

            }
        }

        private void ADDbtn_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog=Jesus Is Lord Christian School;Integrated Security=True");
            conn.Open();
            string query = "INSERT into JILCSNettPayList (EmpId,Name,Surname,PayMethod,BankName,AccountNumber,BranchCode,NettPay) VALUES (@EmpId,@Name,@Surname,@PayMethod,@BankName,@AccountNumber,@BranchCode,@NettPay)";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@EmpId", textEMPID.Text);
            command.Parameters.AddWithValue("@Name", textNAME.Text);
            command.Parameters.AddWithValue("@Surname", textSURNAME.Text);
            command.Parameters.AddWithValue("@PayMethod", comboBox1.SelectedItem);
            command.Parameters.AddWithValue("@BankName", textBANKNAME.Text);
            command.Parameters.AddWithValue("@AccountNumber", textACCNUMBER.Text);
            command.Parameters.AddWithValue("@BranchCode", textBRANCHCODE.Text);
            command.Parameters.AddWithValue("@NettPay", textNETPAY.Text);

            command.ExecuteNonQuery();
            MessageBox.Show("Successfully Added");
            conn.Close();
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            try
            {
                    DialogResult myResult = MessageBox.Show("Are you sure you want to delete this record?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (myResult == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog= Jesus Is Lord Christian School;Integrated Security=True");
                    conn.Open();
                    SqlCommand del = new SqlCommand("DELETE FROM JILCSNettPayList WHERE  EmpId = @EmpId ", conn);
                    del.Parameters.AddWithValue("@EmpId", textEMPID.Text);
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

        private void CLEARBTN_Click(object sender, EventArgs e)
        {
            textEMPID.Clear();
            textNAME.Clear();
            textSURNAME.Clear();
            textBANKNAME.Clear();
            textACCNUMBER.Clear();
            textBRANCHCODE.Clear();
            textNETPAY.Clear();
        }

        private void BACKBTN_Click(object sender, EventArgs e)
        {
            ADDWIN aDDWIN = new ADDWIN();
            aDDWIN.Show();
            this.Hide();
        }
        private int CountRecords(DataGridView dataGridView)
        {
            return dataGridView.Rows.Count;
        }

        private void COUNTRECORDSBTN_Click(object sender, EventArgs e)
        {
            int count = CountRecords(dataGridView1) - 1;
            MessageBox.Show("Total records: " + count);
        }

        private void showallbtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog= Jesus Is Lord Christian School;Integrated Security=True");
                string query = "SELECT * FROM JILCSNettPayList ";
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

        private void textACCNUMBER_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void textNAME_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textSURNAME_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBANKNAME_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBRANCHCODE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textNETPAY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
