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
using Capstone.Views;

namespace Capstone
{
    public partial class Manager : Form
    {
        public MainMenu RefToMain { get; set; }
        public User CurrentUser { get; set; }
        public LogIn RefToLogIn { get; set; }


        public Manager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditUsers editUsers = new EditUsers();
            editUsers.RefToManager = this;
            editUsers.CurrentUser = CurrentUser;
            editUsers.RefToLogin = RefToLogIn;
            Hide();
            editUsers.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditOrders editOrders = new EditOrders();
            editOrders.ReftoManager = this;
            editOrders.CurrentUser = CurrentUser;
            editOrders.RefToLogin = RefToLogIn;
            Hide();
            editOrders.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EditInventory editInventory = new EditInventory();
            editInventory.ReftoManager = this;
            editInventory.CurrentUser = CurrentUser;
            editInventory.RefToLogin = RefToLogIn;
            Hide();
            editInventory.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.ReftoManager = this;
            addUser.CurrentUser = CurrentUser;
            addUser.RefToLogin = RefToLogIn;
            Hide();
            addUser.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddOrder addOrder = new AddOrder();
            addOrder.ReftoManager = this;
            addOrder.CurrentUser = CurrentUser;
            addOrder.RefToLogin = RefToLogIn;
            Hide();
            addOrder.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddInventory addInventory = new AddInventory();
            addInventory.ReftoManager = this;
            addInventory.CurrentUser = CurrentUser;
            addInventory.RefToLogin = RefToLogIn;
            Hide();
            addInventory.Show();
        }
    }
}
