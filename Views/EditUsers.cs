using Capstone.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capstone.Objects;

namespace Capstone
{
    public partial class EditUsers : Form
    {
        public Manager RefToManager { get; set; }
        public LogIn RefToLogin { get; set; }
        public User CurrentUser { get; set; }
        public EditUsers()
        {
            InitializeComponent();
        }

        private async void EditUsers_Load(object sender, EventArgs e)
        {
            var users = await DatabaseService.GetUsers();
            dataGridView1.DataSource = users;

            comboBox2.Items.Clear();
            foreach (User user in users)
            {
                comboBox2.Items.Add(user.UserID);
            }
        }

        private async void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            var users = await DatabaseService.GetUsers();
            foreach (User user in users)
            {
                if (comboBox2.Text == user.UserID.ToString())
                {
                    textBox1.Text = user.FirstName;
                    textBox2.Text = user.LastName;
                    textBox3.Text = user.Password;
                    dateTimePicker1.Value = user.CreationDate;
                    if (user.IsManager)
                        comboBox1.SelectedIndex = 0;
                }
            }
        }
        private async void numericUpDown1_TextChanged(object sender, EventArgs e)
        {
            var users = await DatabaseService.GetUsers();
            foreach (User user in users)
            {
                if (comboBox2.Text == user.UserID.ToString())
                {
                    textBox1.Text = user.FirstName;
                    textBox2.Text = user.LastName;
                    textBox3.Text = user.Password;
                    dateTimePicker1.Value = user.CreationDate;
                    if (user.IsManager)
                        comboBox1.SelectedIndex = 0;
                }
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox2.Text) == true ||
                string.IsNullOrEmpty(textBox1.Text) == true ||
                string.IsNullOrEmpty(textBox2.Text) == true ||
                string.IsNullOrEmpty(textBox3.Text) == true ||
                string.IsNullOrEmpty(comboBox1.Text) == true)
            {
                MessageBox.Show("Must fill all fields");
            }
            else
            {
                bool manager = false;
                if (comboBox1.SelectedIndex == 0)
                    manager = true;
                await DatabaseService.UpdateUser(int.Parse(comboBox2.Text),
                                                 textBox1.Text,
                                                 textBox2.Text,
                                                 textBox3.Text,
                                                 dateTimePicker1.Value,
                                                 manager);
                EditUsers_Load(this, null);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                await DatabaseService.RemoveUser(int.Parse(dataGridView1.SelectedCells[0].Value.ToString()));
                EditUsers_Load(this, null);
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                comboBox2.Text = dataGridView1.SelectedCells[0].Value.ToString();
                textBox1.Text = dataGridView1.SelectedCells[1].Value.ToString();
                textBox2.Text = dataGridView1.SelectedCells[2].Value.ToString();
                textBox3.Text = dataGridView1.SelectedCells[3].Value.ToString();
                dateTimePicker1.Value = DateTime.Parse(dataGridView1.SelectedCells[5].Value.ToString());
                comboBox1.Text = dataGridView1.SelectedCells[6].Value.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
