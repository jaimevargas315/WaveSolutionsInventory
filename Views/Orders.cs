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
    public partial class Orders : Form
    {
        public MainMenu RefToMain { get; set; }
        public User CurrentUser { get; set; }
        public LogIn RefToLogIn { get; set; }

        public Orders()
        {
            InitializeComponent();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            var orders = DatabaseService.GetOrders(CurrentUser);
            dataGridView1.DataSource = orders;

            var current = DatabaseService.GetCurrentOrder(CurrentUser);
            dataGridView2.DataSource = current;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            CurrentUser.CurrentOrder = Int32.Parse(dataGridView1.SelectedCells[0].Value.ToString());
            await DatabaseService.UpdateUser(CurrentUser);
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

        private void button1_Click(object sender, EventArgs e)
        {
            // to do
        }
    }
}
