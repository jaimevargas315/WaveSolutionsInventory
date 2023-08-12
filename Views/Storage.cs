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
    public partial class Storage : Form
    {
        public MainMenu RefToMain { get; set; }
        public User CurrentUser { get; set; }
        public LogIn RefToLogIn { get; set; }

        public Storage()
        {
            InitializeComponent();
        }

        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                var inhouses = await DatabaseService.GetInhouses();
                dataGridView1.DataSource = inhouses;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                var outsources = await DatabaseService.GetOutsources();
                dataGridView1.DataSource = outsources;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                var products = await DatabaseService.GetProducts();
                dataGridView1.DataSource = products;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void Storage_Load(object sender, EventArgs? e)
        {
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();

            dataGridView2.Rows.Clear();
            if (dataGridView2.Columns.Count == 0)
            {
                dataGridView2.Columns.Add("Item name", "Item name");
                dataGridView2.Columns.Add("Quantity", "Quantity");
            }

            var inhouses = await DatabaseService.GetInhouses();
            var outsources = await DatabaseService.GetOutsources();
            var products = await DatabaseService.GetProducts();

            foreach (Inhouse inhouse in inhouses)
            {
                for (int i = 0; i < comboBox3.Items.Count; i++)
                {
                    if (comboBox3.Items[i].ToString() == inhouse.StorageLocation)
                    { }
                    else
                        comboBox3.Items.Add(inhouse.StorageLocation);
                    comboBox2.Items.Add(inhouse.StorageLocation);

                }
            }
            foreach (Outsourced outsourced in outsources)
            {
                for (int i = 0; i < comboBox3.Items.Count; i++)
                {
                    if (comboBox3.Items[i].ToString() == outsourced.StorageLocation)
                    { }
                    else
                        comboBox3.Items.Add(outsourced.StorageLocation);
                    comboBox2.Items.Add(outsourced.StorageLocation);

                }
            }
            foreach (Product product in products)
            {
                for (int i = 0; i < comboBox3.Items.Count; i++)
                {
                    if (comboBox3.Items[i].ToString() == product.StorageLocation)
                    { }
                    else
                        comboBox3.Items.Add(product.StorageLocation);
                    comboBox2.Items.Add(product.StorageLocation);

                }
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                var inhouse = await DatabaseService.GetInhouse(Int32.Parse(dataGridView1.SelectedCells[0].Value.ToString()));
                inhouse.StorageLocation = comboBox3.Text;
                await DatabaseService.UpdateInhouse(inhouse);
            }
            if (comboBox2.SelectedIndex == 1)
            {
                var outsourced = await DatabaseService.GetOutsourced(Int32.Parse(dataGridView1.SelectedCells[0].Value.ToString()));
                outsourced.StorageLocation = comboBox3.Text;
                await DatabaseService.UpdateOutsourced(outsourced);
            }
            if (comboBox3.SelectedIndex == 2)
            {
                var product = await DatabaseService.GetProduct(Int32.Parse(dataGridView1.SelectedCells[0].Value.ToString()));
                product.StorageLocation = comboBox3.Text;
                await DatabaseService.UpdateProduct(product);
            }

            Storage_Load(this, null);
        }

        private async void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var inhouses = await DatabaseService.GetInhouses();
            var outsources = await DatabaseService.GetOutsources();
            var products = await DatabaseService.GetProducts();

            foreach (Inhouse inhouse in inhouses)
            {
                if (inhouse.StorageLocation == comboBox2.Text)
                {
                    dataGridView2.Rows.Add(inhouse.Name, inhouse.InStock);
                }
            }
            foreach (Outsourced outsourced in outsources)
            {
                if (outsourced.StorageLocation == comboBox2.Text)
                {
                    dataGridView2.Rows.Add(outsourced.Name, outsourced.InStock);
                }
            }
            foreach (Product product in products)
            {
                if (product.StorageLocation == comboBox2.Text)
                {
                    dataGridView2.Rows.Add(product.Name, product.InStock);
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
            RefToLogIn.Show();
            Close();
        }
    }
}
