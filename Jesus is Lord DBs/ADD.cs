using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jesus_is_Lord_DBs
{
    public partial class ADDWIN : Form
    {

        public ADDWIN()
        {
            InitializeComponent();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ADD_Load(object sender, EventArgs e)
        {

        }

        private void empbtn_Click(object sender, EventArgs e)
        {
            employeeswin employees = new employeeswin();
            employees.Show();
            this.Hide();
        }
        private void NettPayListbtn_Click(object sender, EventArgs e)
        {
            NettPayListWIN netpay = new NettPayListWIN();
            netpay.Show();
            this.Hide();
        }


        private void Studentsbtn_Click(object sender, EventArgs e)
        {
            studentswin students = new studentswin();
            students.Show();
            this.Hide();
        }

        private void schoolfeesbtn_Click(object sender, EventArgs e)
        {
            Schoolfeeswin schoolfees = new Schoolfeeswin();
            schoolfees.Show();
            this.Hide();
        }
    }
}
