using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
 using System;
 using System.Drawing;
 using System.IO;
 using System.Linq;
 using System.Threading;
 using System.Threading.Tasks;

    



namespace Jesus_is_Lord_DBs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=Faith;Initial Catalog= Jesus Is Lord Christian School;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void usertype_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            String username, password;
         
            username = textusername.Text;
            password = textpassword.Text;

            try
            {
                string querry = " SELECT * FROM Login_new WHERE username ='" + textusername.Text + "' AND password = '" + textpassword.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    username = textusername.Text;
                    password = textpassword.Text;
                    //Page that needed to load next
                    ADDWIN addwin = new ADDWIN();
                    addwin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textusername.Clear();
                    textpassword.Clear();

                    //to focus username
                    textusername.Focus();
                }
            }
            catch
            {
                MessageBox.Show(" Error");
            }
            finally
            {
                conn.Close();
            }

            
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            textusername.Clear();
            textpassword.Clear();

            textusername.Focus();
        }
    }
}
