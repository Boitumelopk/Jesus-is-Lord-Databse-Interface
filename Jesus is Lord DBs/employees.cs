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
using iText.Layout;
using iText.Kernel.Pdf;
using iText.Layout.Element;

namespace Jesus_is_Lord_DBs
{
    public partial class employeeswin : Form
    {
        string g;
        public employeeswin()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog= Jesus Is Lord Christian School;Integrated Security=True");
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog= Jesus Is Lord Christian School;Integrated Security=True");
                string query = "SELECT * FROM EmployeesJILCS WHERE TypeofEmployment = @TypeofEmployment";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@TypeofEmployment", typeofemploymentcomboBox2.SelectedItem);
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

        private void findbtn1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog= Jesus Is Lord Christian School;Integrated Security=True");
                string query = "SELECT * FROM EmployeesJILCS WHERE EmpId = @EmpId";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@EmpId", EmpIdtext.Text);
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

        private void Findbtn2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog= Jesus Is Lord Christian School;Integrated Security=True");
                string query = "SELECT * FROM EmployeesJILCS WHERE Name = @Name";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Name", empNametext.Text);
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

        private void Findbtn3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog= Jesus Is Lord Christian School;Integrated Security=True");
                string query = "SELECT * FROM EmployeesJILCS WHERE Surname = @Surname";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Surname", empSurnametext.Text);
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

        private void Findbtn4_Click(object sender, EventArgs e)
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
                string query = "SELECT * FROM EmployeesJILCS WHERE Gender = @Gender";
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

        private void Findbtn5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog= Jesus Is Lord Christian School;Integrated Security=True");
                string query = "SELECT * FROM EmployeesJILCS WHERE Cellphone = @Cellphone";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Cellphone", empcelltext.Text);
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
                string query = "SELECT * FROM EmployeesJILCS WHERE IDnumber = @IDnumber";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@IDnumber", empidnumtext.Text);
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

        private void Findbtn7_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog= Jesus Is Lord Christian School;Integrated Security=True");
                string query = "SELECT * FROM EmployeesJILCS WHERE Homelanguage = @HomeLanguage";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@HomeLanguage", emphomeLtext.Text);
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

        private void Findbtn9_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog= Jesus Is Lord Christian School;Integrated Security=True");
                string query = "SELECT * FROM EmployeesJILCS WHERE JobDescription= @JobDescription";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@JobDescription", jobdescomboBox2.SelectedItem);
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

        private void Findbtn10_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog= Jesus Is Lord Christian School;Integrated Security=True");
                string query = "SELECT * FROM EmployeesJILCS WHERE DateJoined= @DateJoined"; //QUERY
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@DateJoined", dateTimePicker1.Value.Date.ToString("yyyy/MM/dd"));
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

        private void empADDbtn_Click(object sender, EventArgs e)
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
            string query = "INSERT into EmployeesJILCS(EmpId,Name,Surname,Gender,Address,Cellphone,IDnumber,HomeLanguage,TypeofEmployment,JobDescription,DateJoined) VALUES (@EmpId,@Name,@Surname,@Gender,@Address,@Cellphone,@IDnumber,@HomeLanguage,@TypeofEmployment,@JobDescription,@DateJoined)";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@EmpId", EmpIdtext.Text);
            command.Parameters.AddWithValue("@Name", empNametext.Text);
            command.Parameters.AddWithValue("@Surname", empSurnametext.Text);
            command.Parameters.AddWithValue("@Gender", g);
            command.Parameters.AddWithValue("@Address", empaddrtext.Text);
            command.Parameters.AddWithValue("@Cellphone", empcelltext.Text);
            command.Parameters.AddWithValue("@IDnumber", empidnumtext.Text);
            command.Parameters.AddWithValue("@HomeLanguage", emphomeLtext.Text);
            command.Parameters.AddWithValue("@TypeofEmployment", typeofemploymentcomboBox2.SelectedItem);
            command.Parameters.AddWithValue("@JobDescription", jobdescomboBox2.SelectedItem);
            command.Parameters.AddWithValue("@DateJoined", dateTimePicker1.Value.Date.ToString("yyyy/MM/dd"));

            command.ExecuteNonQuery();
            MessageBox.Show("Successfully Added");
            conn.Close();


        }


        private void empdelbtn_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult myResult = MessageBox.Show("Are you sure you want to delete this record?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (myResult == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog= Jesus Is Lord Christian School;Integrated Security=True");
                    conn.Open();
                    SqlCommand del = new SqlCommand("DELETE FROM EmployeesJILCS WHERE  EmpId = @EmpId ", conn);
                    del.Parameters.AddWithValue("@EmpId", EmpIdtext.Text);
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

        private void empupdatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult myResult = MessageBox.Show("Are you sure you want to Update this record?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
                    string query = "UPDATE EmployeesJILCS SET EmpId = @EmpId,Name = @Name, Surname = @Surname, Gender = @Gender, Address = @Address, Cellphone = @Cellphone, IDnumber = @IDnumber, HomeLanguage = @HomeLanguage, TypeofEmployment = @TypeofEmployment, JobDescription = @JobDescription, DateJoined = @DateJoined WHERE EmpId = @EmpId";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@EmpId", EmpIdtext.Text);
                    command.Parameters.AddWithValue("@Name", empNametext.Text);
                    command.Parameters.AddWithValue("@Surname", empSurnametext.Text);
                    command.Parameters.AddWithValue("@Gender", g);
                    command.Parameters.AddWithValue("@Address", empaddrtext.Text);
                    command.Parameters.AddWithValue("@Cellphone", empcelltext.Text);
                    command.Parameters.AddWithValue("@IDnumber", empidnumtext.Text);
                    command.Parameters.AddWithValue("@HomeLanguage", emphomeLtext.Text);
                    command.Parameters.AddWithValue("@TypeofEmployment", typeofemploymentcomboBox2.SelectedItem);
                    command.Parameters.AddWithValue("@JobDescription", jobdescomboBox2.SelectedItem);
                    command.Parameters.AddWithValue("@DateJoined", dateTimePicker1.Value.Date.ToString("yyyy/MM/dd"));

                    command.ExecuteNonQuery();
                    MessageBox.Show("Successfully Updated");
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



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog= Jesus Is Lord Christian School;Integrated Security=True");
        }

        private void empaddrfindbtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog= Jesus Is Lord Christian School;Integrated Security=True");
                string query = "SELECT * FROM EmployeesJILCS WHERE Address = @Address";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Address", empaddrtext.Text);
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

        private void employeeswin_Load(object sender, EventArgs e)
        {

        }

        private void empbackbtn_Click(object sender, EventArgs e)
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
            EmpIdtext.Text = "";
            empNametext.Text = "";
            empSurnametext.Text = "";
            empaddrtext.Text = "";
            empcelltext.Text = "";
            empidnumtext.Text = "";
            emphomeLtext.Text = "";


        }

        private void showallbtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog= Jesus Is Lord Christian School;Integrated Security=True");
                string query = "SELECT * FROM EmployeesJILCS ";
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

        private void empNametext_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void empSurnametext_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void emphomeLtext_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void empidnumtext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void empcelltext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void empidnumtext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
