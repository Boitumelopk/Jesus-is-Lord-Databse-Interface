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
    public partial class studentswin : Form
    {
        string g;
        public studentswin()
        {
            InitializeComponent();
        }

        private void accnumfindbtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog= Jesus Is Lord Christian School;Integrated Security=True");
                string query = "SELECT * FROM JILCSStudents WHERE AccessionNum = @AccessionNum";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@AccessionNum", accnumtext.Text);
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
                string query = "SELECT * FROM JILCSStudents WHERE Name= @Name";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Name", stunametext.Text);
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
                string query = "SELECT * FROM JILCSStudents WHERE Surname = @Surname";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Surname", stusurnametext.Text);
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

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked == true)
                {
                    g = "Female";
                }
                else
                {
                    g = "Male";
                }
                SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog= Jesus Is Lord Christian School;Integrated Security=True");
                string query = "SELECT * FROM JILCSStudents WHERE Gender = @Gender";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Gender", g);
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

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog= Jesus Is Lord Christian School;Integrated Security=True");
                string query = "SELECT * FROM JILCSStudents WHERE Address = @Address";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Address", stuaddresstext.Text);
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

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog= Jesus Is Lord Christian School;Integrated Security=True");
                string query = "SELECT * FROM JILCSStudents WHERE Birthdate = @Birthdate";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Birthdate", stubirthdate.Value.Date.ToString("yyyy/MM/dd"));
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

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog= Jesus Is Lord Christian School;Integrated Security=True");
                string query = "SELECT * FROM JILCSStudents WHERE Cellphone = @Cellphone";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Cellphone", stucellphonetext.Text);
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

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog= Jesus Is Lord Christian School;Integrated Security=True");
                string query = "SELECT * FROM JILCSStudents WHERE DateRegistered = @DateRegistered";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@DateRegistered", sturegisterdate.Value.Date.ToString("yyyy/MM/dd"));
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

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog= Jesus Is Lord Christian School;Integrated Security=True");
                string query = "SELECT * FROM JILCSStudents WHERE Homelanguage = @HomeLanguage";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@HomeLanguage", stuhomelanguagetext.Text);
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

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog= Jesus Is Lord Christian School;Integrated Security=True");
                string query = "SELECT * FROM JILCSStudents WHERE Citizenship = @Citizenship";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Citizenship", stucitizenshiptext.Text);
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

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog= Jesus Is Lord Christian School;Integrated Security=True");
                string query = "SELECT * FROM JILCSStudents WHERE IDnum = @IDnum";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@IDnum", stuidnumtext.Text);
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

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog= Jesus Is Lord Christian School;Integrated Security=True");
                string query = "SELECT * FROM JILCSStudents WHERE CurrentGrade = @CurrentGrade";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@CurrentGrade", stucurrentgrcombobox.SelectedItem);
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

        private void button14_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                g = "Female";
            }
            else
            {
                g = "Male";
            }
            SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog=Jesus Is Lord Christian School;Integrated Security=True");
            conn.Open();
            string query = "INSERT into JILCSStudents (AccessionNum ,Name,Surname,Gender,Address,Birthdate,Cellphone,DateRegistered,HomeLanguage,Citizenship,IDnum,CurrentGrade) VALUES (@AccessionNum,@Name,@Surname,@Gender,@Address,@Birthdate,@Cellphone,@DateRegistered,@HomeLanguage,@Citizenship,@IDnum,@CurrentGrade)";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@AccessionNum", accnumtext.Text);
            command.Parameters.AddWithValue("@Name", stunametext.Text);
            command.Parameters.AddWithValue("@Surname", stusurnametext.Text);
            command.Parameters.AddWithValue("@Gender", g);
            command.Parameters.AddWithValue("@Address", stuaddresstext.Text);
            command.Parameters.AddWithValue("@Birthdate", stubirthdate.Value.Date.ToString("yyyy/MM/dd"));
            command.Parameters.AddWithValue("@Cellphone", stucellphonetext.Text);
            command.Parameters.AddWithValue("@DateRegistered", sturegisterdate.Value.Date.ToString("yyyy/MM/dd"));
            command.Parameters.AddWithValue("@HomeLanguage", stuhomelanguagetext.Text);
            command.Parameters.AddWithValue("@Citizenship", stucitizenshiptext.Text);
            command.Parameters.AddWithValue("@IDnum", stuidnumtext.Text);
            command.Parameters.AddWithValue("@CurrentGrade", stucurrentgrcombobox.SelectedItem);

            command.ExecuteNonQuery();
            MessageBox.Show("Successfully Added");
            conn.Close();



        }

        private void button15_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult myResult = MessageBox.Show("Are you sure you want to delete this record?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (myResult == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog= Jesus Is Lord Christian School;Integrated Security=True");
                    conn.Open();

                    SqlCommand del = new SqlCommand("DELETE FROM JILCSStudents WHERE  AccessionNum = @AccessionNum", conn);
                    del.Parameters.AddWithValue("@AccessionNum", accnumtext.Text);
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

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult myResult = MessageBox.Show("Are you sure you want to update this record?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (myResult == DialogResult.Yes)
                {
                    if (radioButton1.Checked == true)
                    {
                        g = "Female";
                    }
                    else
                    {
                        g = "Male";
                    }
                    SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog=Jesus Is Lord Christian School;Integrated Security=True");
                    conn.Open();
                    string query = "UPDATE JILCSStudents SET Name = @Name, Surname = @Surname, Gender = @Gender, Address = @Address,Birthdate = @Birthdate, Cellphone = @Cellphone,DateRegistered = @DateRegistered, HomeLanguage = @HomeLanguage, Citizenship = @Citizenship, IDnum = @IDnum, CurrentGrade = @CurrentGrade WHERE AccessionNum = @AccessionNum ";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@AccessionNum", accnumtext.Text);
                    command.Parameters.AddWithValue("@Name", stunametext.Text);
                    command.Parameters.AddWithValue("@Surname", stusurnametext.Text);
                    command.Parameters.AddWithValue("@Gender", g);
                    command.Parameters.AddWithValue("@Address", stuaddresstext.Text);
                    command.Parameters.AddWithValue("@Birthdate", stubirthdate.Value.Date.ToString("yyyy/MM/dd"));
                    command.Parameters.AddWithValue("@Cellphone", stucellphonetext.Text);
                    command.Parameters.AddWithValue("@DateRegistered", sturegisterdate.Value.Date.ToString("yyyy/MM/dd"));
                    command.Parameters.AddWithValue("@HomeLanguage", stuhomelanguagetext.Text);
                    command.Parameters.AddWithValue("@Citizenship", stucitizenshiptext.Text);
                    command.Parameters.AddWithValue("@IDnum", stuidnumtext.Text);
                    command.Parameters.AddWithValue("@CurrentGrade", stucurrentgrcombobox.SelectedItem);


                    command.ExecuteNonQuery();
                    MessageBox.Show("Successfully Updated");
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            finally { }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            ADDWIN aDDWIN = new ADDWIN();
            aDDWIN.Show();
            this.Hide();
        }
        private int CountRecords(DataGridView dataGridView)
        {
            return dataGridView.Rows.Count;
        }
        private void countbtn_Click(object sender, EventArgs e)
        {
            int count = CountRecords(dataGridView1) - 1;
            MessageBox.Show("Total records: " + count);
        }

        private void CLEARBTN_Click(object sender, EventArgs e)
        {
            accnumtext.Clear();
            stunametext.Clear();
            stusurnametext.Clear();
            stuaddresstext.Clear();
            stucellphonetext.Clear();
            stuhomelanguagetext.Clear();
            stucitizenshiptext.Clear();
            stuidnumtext.Clear();
        }

        private void showallbtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog= Jesus Is Lord Christian School;Integrated Security=True");
                string query = "SELECT * FROM JILCSStudents ";
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

        /*  private void accnumtext_KeyPress(object sender, KeyPressEventArgs e)
          {
              if (e.KeyChar == 13)
              {
                  if (accnumtext.Text == "")
                  {
                      MessageBox.Show("Blank Accession Number is not allowed", MessageBoxButtons.OK);
                  }
                  else
                  {
                      string AccessionNum;
                      AccessionNum = accnumtext.Text;

                  }
              }
          }*/

        private void stucellphonetext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void stuidnumtext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void stucurrentgrtext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void accnumtext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void stunametext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void stusurnametext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /*private void stugendertext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }*/

        private void stuhomelanguagetext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void stucitizenshiptext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void stubirthdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void stunametext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
