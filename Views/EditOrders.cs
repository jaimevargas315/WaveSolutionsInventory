using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capstone.Objects;
using Capstone.Service;

namespace Capstone
{
    public partial class EditOrders : Form
    {
        public Manager ReftoManager { get; set; }
        public User CurrentUser { get; set; }
        public LogIn RefToLogin { get; set; }
        public EditOrders()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void EditOrders_Load(object sender, EventArgs e)
        {
            var orders = await DatabaseService.GetOrders();
            var users = await DatabaseService.GetUsers();
            dataGridView1.DataSource = orders;

            comboBox1.Items.Clear();
            foreach (Order order in orders)
            {
                comboBox1.Items.Add(order.OrderId);
            }

            comboBox2.Items.Clear();
            foreach (User user in users)
            {
                comboBox2.Items.Add(user.UserID);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text) == true ||
               string.IsNullOrEmpty(comboBox2.Text) == true ||
               string.IsNullOrEmpty(comboBox3.Text) == true ||
               string.IsNullOrEmpty(textBox1.Text) == true ||
               string.IsNullOrEmpty(textBox2.Text) == true ||
               string.IsNullOrEmpty(textBox3.Text) == true ||
               string.IsNullOrEmpty(textBox4.Text) == true)
            {
                MessageBox.Show("All fields must be filled");
            }
            else
            {
                var orders = await DatabaseService.GetOrders();
                foreach (Order order in orders)
                {
                    if (order.OrderId == int.Parse(comboBox1.Text))
                    {
                        order.UserID = int.Parse(comboBox2.Text);
                        order.CreationTime = dateTimePicker1.Value;
                        order.Complete = bool.Parse(comboBox3.Text);
                        order.CompletionTime = dateTimePicker2.Value;
                        order.Parts = textBox1.Text;
                        order.Products = textBox2.Text;
                        order.MissingParts = textBox3.Text;
                        order.MissingProducts = textBox4.Text;

                        await DatabaseService.UpdateOrder(order);
                        EditOrders_Load(this, null);
                    }
                }
            }
        }

        private async void comboBox1_TextChanged(object sender, EventArgs e)
        {
            var orders = await DatabaseService.GetOrders();
            foreach (Order order in orders)
            {
                if (order.OrderId == int.Parse(comboBox1.Text))
                {
                    comboBox2.Text = order.UserID.ToString();
                    dateTimePicker1.Value = order.CreationTime;
                    comboBox3.Text = order.Complete.ToString();
                    dateTimePicker2.Value = order.CompletionTime;
                    textBox1.Text = order.Parts;
                    textBox2.Text = order.Products;
                    textBox3.Text = order.MissingParts;
                    textBox4.Text = order.MissingProducts;

                }
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Delete order", "Are you sure you want to delete the selected order?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    await DatabaseService.RemoveOrder(int.Parse(dataGridView1.SelectedCells[0].Value.ToString()));
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                comboBox1.Text = dataGridView1.SelectedCells[0].Value.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReftoManager.Show();
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RefToLogin.Show();
            Close();
        }
    }
}

