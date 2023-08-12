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
    public partial class BulkRemove : Form
    {
        public MainMenu RefToMain { get; set; }
        public User CurrentUser { get; set; }
        public LogIn RefToLogIn { get; set; }

        public BulkRemove()
        {
            InitializeComponent();
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

        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                var inhouse = await DatabaseService.GetInhouses();
                dataGridView1.DataSource = inhouse;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                var outsource = await DatabaseService.GetOutsources();
                dataGridView1.DataSource = outsource;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                var products = await DatabaseService.GetProducts();
                dataGridView1.DataSource = products;
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Text.Length > 0)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    if (comboBox1.SelectedIndex == 0)
                    {
                        for (int i = 0; i < dataGridView1.RowCount; i++)
                        {
                            await DatabaseService.InhouseStockAdjust(int.Parse(dataGridView1.SelectedCells[0].Value.ToString()),
                                                                    (int)-numericUpDown1.Value);
                        }
                    }
                    if (comboBox1.SelectedIndex == 1)
                    {
                        for (int i = 0; i < dataGridView1.RowCount; i++)
                        {
                            await DatabaseService.OutsourcedStockAdjust(int.Parse(dataGridView1.SelectedCells[0].Value.ToString()),
                                                                       (int)-numericUpDown1.Value);
                        }
                    }
                    if (comboBox1.SelectedIndex == 2)
                    {
                        await DatabaseService.ProductStockAdjust(int.Parse(dataGridView1.SelectedCells[0].Value.ToString()),
                                                                (int)-numericUpDown1.Value);
                    }
                }
            }
        }
    }
}
