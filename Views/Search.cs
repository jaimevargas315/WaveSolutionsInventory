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
using Capstone.Service;

namespace Capstone
{
    public partial class Search : Form
    {
        public MainMenu RefToMain { get; set; }
        public User CurrentUser { get; set; }
        public LogIn RefToLogIn { get; set; }


        public Search()
        {
            InitializeComponent();
        }

        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                var inhouses = await DatabaseService.GetInhouses();
                dataGridView1.DataSource = inhouses;

                numericUpDown3.Visible = true;
                label7.Visible = true;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                var outsources = await DatabaseService.GetOutsources();
                dataGridView1.DataSource = outsources;
                numericUpDown3.Visible = true;
                label7.Visible = true;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                var products = await DatabaseService.GetProducts();
                dataGridView1.DataSource = products;
                numericUpDown3.Visible = false;
                label7.Visible = false;
            }
        }

        private void Search_Load(object sender, EventArgs e)
        {
            numericUpDown1.Controls[0].Visible = false;
            numericUpDown2.Controls[0].Visible = false;
            numericUpDown3.Controls[0].Visible = false;
            numericUpDown4.Controls[0].Visible = false;
            numericUpDown5.Controls[0].Visible = false;
            numericUpDown6.Controls[0].Visible = false;

        }
        private async void Inventory_Search()
        {
            var inhouses = await DatabaseService.GetInhouses();
            var outsources = await DatabaseService.GetOutsources();
            var products = await DatabaseService.GetProducts();
            if (comboBox1.SelectedIndex == 0)
            {
                foreach (Inhouse inhouse in inhouses)
                {
                    if (inhouse.PartId != (int)numericUpDown1.Value)
                    {
                        inhouses.Remove(inhouse);
                        continue;
                    }
                    if (inhouse.ProductID != (int)numericUpDown2.Value)
                    {
                        inhouses.Remove(inhouse);
                        continue;
                    }
                    if (inhouse.Name != textBox1.Text)
                    {
                        inhouses.Remove(inhouse);
                        continue;
                    }
                    if(inhouse.MachineID != (int)numericUpDown3.Value)
                    {
                        inhouses.Remove(inhouse);
                        continue;
                    }
                    if(inhouse.Price != numericUpDown4.Value)
                    {
                        inhouses.Remove(inhouse);
                        continue;
                    }
                    if(inhouse.CompanyName != textBox2.Text)
                    {
                        inhouses.Remove(inhouse);
                        continue;
                    }
                }
                dataGridView1.DataSource = inhouses;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                foreach (Outsourced outsourced in outsources)
                {
                    if (outsourced.PartId != (int)numericUpDown1.Value)
                    {
                        outsources.Remove(outsourced);
                        continue;
                    }
                    if (outsourced.ProductID != (int)numericUpDown2.Value)
                    {
                        outsources.Remove(outsourced);
                        continue;
                    }
                    if (outsourced.Name != textBox1.Text)
                    {
                        outsources.Remove(outsourced);
                        continue;
                    }
                    if (outsourced.MachineID != (int)numericUpDown3.Value)
                    {
                        outsources.Remove(outsourced);
                        continue;
                    }
                    if (outsourced.Price != numericUpDown4.Value)
                    {
                        outsources.Remove(outsourced);
                        continue;
                    }
                    if (outsourced.CompanyName != textBox2.Text)
                    {
                        outsources.Remove(outsourced);
                        continue;
                    }
                }
                dataGridView1.DataSource = outsources;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                foreach (Product product in products)
                {
                    if (product.ProductID != (int)numericUpDown2.Value)
                    {
                        products.Remove(product);
                        continue;
                    }
                    if (product.Name != textBox1.Text)
                    {
                        products.Remove(product);
                        continue;
                    }
                    if (product.Price != numericUpDown4.Value)
                    {
                        products.Remove(product);
                        continue;
                    }
                    if (product.CompanyName != textBox2.Text)
                    {
                        products.Remove(product);
                        continue;
                    }
                }
                dataGridView1.DataSource = products;
            }
        }
        private async void Order_Search()
        {
            var orders = await DatabaseService.GetOrders();
            foreach(Order order in orders)
            {
                if(order.OrderId != (int)numericUpDown5.Value)
                {
                    orders.Remove(order);
                    continue;
                }
                if (order.UserID != (int)numericUpDown6.Value)
                {
                    orders.Remove(order);
                    continue;
                }
                if (order.Complete.ToString() != comboBox2.Text)
                {
                    orders.Remove(order);
                    continue;
                }
                if(order.Parts.Contains(textBox3.Text)==false)
                {
                    orders.Remove(order);
                    continue;
                }
                if (order.Products.Contains(textBox4.Text) == false)
                {
                    orders.Remove(order);
                    continue;
                }
            }
            dataGridView2.DataSource= orders;
        }

        #region call search
        private void numericUpDown1_TextChanged(object? sender, EventArgs e)
        {
            Inventory_Search();
        }

        private void numericUpDown2_TextChanged(object? sender, EventArgs e)
        {
            Inventory_Search();
        }

        private void numericUpDown3_TextChanged(object? sender, EventArgs e)
        {
            Inventory_Search();
        }

        private void numericUpDown4_TextChanged(object? sender, EventArgs e)
        {
            Inventory_Search();
        }

        private void numericUpDown5_TextChanged(object? sender, EventArgs e)
        {
            Order_Search();
        }

        private void numericUpDown6_TextChanged(object? sender, EventArgs e)
        {
            Order_Search();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Inventory_Search();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Inventory_Search();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Inventory_Search();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            Inventory_Search();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            Inventory_Search();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Inventory_Search();
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            Order_Search();
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            Order_Search();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Order_Search();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Order_Search();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Order_Search();
        }
        #endregion
    }
}
