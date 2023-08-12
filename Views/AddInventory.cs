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

namespace Capstone.Views
{
    public partial class AddInventory : Form
    {
        public Manager ReftoManager { get; set; }
        public User CurrentUser { get; set; }
        public LogIn RefToLogin { get; set; }

        public AddInventory()
        {
            InitializeComponent();
        }

        private async void AddInventory_Load(object sender, EventArgs e)
        {
            var products = await DatabaseService.GetProducts();
            foreach (Product product in products)
            {
                comboBox3.Items.Add(product.ProductID);
            }

        }

        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                comboBox2.Items.Clear();
                var inhouses = await DatabaseService.GetInhouses();
                foreach(Inhouse inhouse in inhouses)
                {
                    comboBox2.Items.Add(inhouse.PartId);
                }
            }
            if (comboBox1.SelectedIndex == 1)
            {
                comboBox2.Items.Clear();
                var outsources = await DatabaseService.GetOutsources();
                foreach (Outsourced outsourced in outsources)
                {
                    comboBox2.Items.Add(outsourced.PartId);
                }
            }

        }
    }
}
