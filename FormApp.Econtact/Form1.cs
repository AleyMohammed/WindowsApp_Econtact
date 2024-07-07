using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormApp.Econtact.EconClass;
using System.Configuration;

namespace FormApp.Econtact
{
    public partial class FormEcontact : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Downloads\AppVS\FormApp.Econtact\Database1.mdf;Integrated Security=True");
        public FormEcontact()
        {
            InitializeComponent();
        }
        contactClass C = new contactClass();
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Clear ()
        {
            textBoxfname.Text = "";
            textBoxlname.Text = "";
            textBoxConNo.Text = "";
            textboxaddresse.Text = "";
            combox.Text = "";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
           

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelfname_Click(object sender, EventArgs e)
        {

        }

        private void FormEcontact_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            C.FirstName = textBoxfname.Text;
            C.LastName = textBoxlname.Text;
            C.ContactNo = textBoxConNo.Text;
            C.Addresse= textboxaddresse.Text;
            C.Gender = combox.Text;

            bool Value = C.Insert(C);
            if(Value == true)
            {
                MessageBox.Show("Successfully");

                Clear();
            }
            else
            {
                MessageBox.Show("Error");
            }
            DataTable DB = C.Select();
            dataGridView1.DataSource = DB;

        }
         
        private void button4_Click(object sender, EventArgs e)
        {
            C.ContactID = Convert.ToInt32(textBoxContactid.Text);
            bool Value = C.Delete(C);

            if(Value == true)
            {
                MessageBox.Show("Successfully Deleted");

                DataTable DB = C.Select();
                dataGridView1.DataSource = DB;

                Clear();
            }
            else
            {

                MessageBox.Show("Error");
            }
                 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {

            C.ContactID = int.Parse(textBoxContactid.Text);

            C.FirstName = textBoxfname.Text;

            C.LastName = textBoxlname.Text;

            C.ContactNo = textBoxConNo.Text;

            C.Addresse = textboxaddresse.Text;

            C.Gender = combox.Text;

            // -------------------

            bool Value = C.Update(C);
            if (Value == true)
            {
                MessageBox.Show("Successfullu 'Update'");
                DataTable DB = C.Select();
                dataGridView1.DataSource = DB;

                Clear();
            }
            else {

                MessageBox.Show("Error");
            }



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable DB = C.Select();
            dataGridView1.DataSource = DB;

        }

        private void buttonMZ_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textboxaddresse_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rIndex = e.RowIndex;

            textBoxContactid.Text = dataGridView1.Rows[rIndex].Cells[0].Value.ToString();


            textBoxfname.Text = dataGridView1.Rows[rIndex].Cells[1].Value.ToString();


            textBoxlname.Text = dataGridView1.Rows[rIndex].Cells[2].Value.ToString();

            textBoxConNo.Text = dataGridView1.Rows[rIndex].Cells[3].Value.ToString();

            textboxaddresse.Text = dataGridView1.Rows[rIndex].Cells[4].Value.ToString();

            combox.Text = dataGridView1.Rows[rIndex].Cells[5].Value.ToString();






        }

        static string myServer = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBoxlname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
