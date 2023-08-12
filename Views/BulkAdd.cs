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
    public partial class BulkAdd : Form
    {
        public MainMenu RefToMain { get; set; }
        public User CurrentUser { get; set; }
        public LogIn RefToLogin { get; set; }

        public BulkAdd()
        {
            InitializeComponent();
        }

        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            if (comboBox1.SelectedIndex == 0)
            {
                var inhouses = await DatabaseService.GetInhouses();
                label3.Text = "Part ID";
                foreach (Inhouse inhouse in inhouses)
                {
                    comboBox2.Items.Add(inhouse.Name);
                }
            }
            if (comboBox1.SelectedIndex == 1)
            {
                var outsources = await DatabaseService.GetOutsources();
                label3.Text = "Part ID";
                foreach (Outsourced outsourced in outsources)
                {
                    comboBox2.Items.Add(outsourced.Name);
                }
            }
            if (comboBox1.SelectedIndex == 2)
            {
                var products = await DatabaseService.GetProducts();
                label3.Text = "Product ID";
                foreach (Product product in products)
                {
                    comboBox2.Items.Add(product.Name);
                }
            }
        }

        private async void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                var inhouses = await DatabaseService.GetInhouses();
                foreach (Inhouse inhouse in inhouses)
                {
                    if (comboBox2.Text == inhouse.PartId.ToString())
                    {
                        textBox1.Text = inhouse.Name;
                    }
                }
            }
            if (comboBox1.SelectedIndex == 1)
            {
                var outsources = await DatabaseService.GetOutsources();
                foreach (Outsourced outsourced in outsources)
                {
                    if (comboBox2.Text == outsourced.PartId.ToString())
                    {
                        textBox1.Text = outsourced.Name;
                    }
                }
            }
            if (comboBox1.SelectedIndex == 2)
            {
                var products = await DatabaseService.GetProducts();
                foreach (Product product in products)
                {
                    if (comboBox2.Text == product.ProductID.ToString())
                    {
                        textBox1.Text = product.Name;
                    }
                }
            }
        }

        private void BulkAdd_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Item Name", "Item Name");
            dataGridView1.Columns.Add("Quantity", "Quantity");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text) == true ||
               string.IsNullOrEmpty(comboBox2.Text) == true ||
               string.IsNullOrEmpty(numericUpDown1.Text) == true)
            {
                MessageBox.Show("All boxes must be filled");
            }
            else
                dataGridView1.Rows.Add(textBox1.Text, numericUpDown1.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            var inhouses = await DatabaseService.GetInhouses();
            var outsources = await DatabaseService.GetOutsources();
            var products = await DatabaseService.GetProducts();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                foreach (Inhouse inhouse in inhouses)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == inhouse.Name)
                    {
                        comboBox1.SelectedIndex = 0;
                        comboBox2.Text = inhouse.PartId.ToString();
                        textBox1.Text = inhouse.Name;
                        numericUpDown1.Value = Decimal.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                        dataGridView1.Rows.RemoveAt(i);
                    }
                }
                foreach (Outsourced outsourced in outsources)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == outsourced.Name)
                    {
                        comboBox1.SelectedIndex = 0;
                        comboBox2.Text = outsourced.PartId.ToString();
                        textBox1.Text = outsourced.Name;
                        numericUpDown1.Value = Decimal.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                        dataGridView1.Rows.RemoveAt(i);
                    }
                }
                foreach (Product product in products)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == product.Name)
                    {
                        comboBox1.SelectedIndex = 0;
                        comboBox2.Text = product.ProductID.ToString();
                        textBox1.Text = product.Name;
                        numericUpDown1.Value = Decimal.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                        dataGridView1.Rows.RemoveAt(i);
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RefToMain.Show();
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RefToLogin.Show();
            Close();
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            var inhouses = await DatabaseService.GetInhouses();
            var outsources = await DatabaseService.GetOutsources();
            var products = await DatabaseService.GetProducts();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                foreach (Inhouse inhouse in inhouses)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == inhouse.Name)
                    {
                        await DatabaseService.InhouseStockAdjust
                            (inhouse.PartId,
                             int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()));
                    }
                }
                foreach (Outsourced outsourced in outsources)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == outsourced.Name)
                    {
                        await DatabaseService.OutsourcedStockAdjust
                            (outsourced.PartId,
                             int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()));
                    }
                }
                foreach (Product product in products)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == product.Name)
                    {
                        await DatabaseService.ProductStockAdjust
                            (product.ProductID,
                             int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()));
                    }
                }

            }
        }
    }
}
