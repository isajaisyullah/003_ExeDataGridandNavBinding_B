using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeDataGridandNavBinding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtUser.Text=="isa" && txtPassword.Text=="" && validation1.Checked)
            {
                new Form2().Show();
                this.Hide();
            }
            else if (txtUser.Text == "isajaisyullah" && txtPassword.Text == "passwordISA" && !validation1.Checked)
            {
                MessageBox.Show("Accept Term & Condition to continue!");
            }
            else
            {
                MessageBox.Show("The Username or Password incorrect!");
                txtUser.Clear();
                txtPassword.Clear();
                txtUser.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
