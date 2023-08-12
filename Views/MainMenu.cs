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
    public partial class MainMenu : Form
    {
        public LogIn RefToLogIn { get; set; }
        public User CurrentUser { get; set; }

        public BulkAdd BulkAdd { get; set; }
        public Storage Storage { get; set; }
        public Orders Orders { get; set; }
        public BulkRemove BulkRemove { get; set; }
        public Search Search { get; set; }
        public Manager Manager { get; set; }

        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BulkAdd = new BulkAdd();
            BulkAdd.RefToMain = this;
            BulkAdd.CurrentUser = CurrentUser;
            BulkAdd.RefToLogin = RefToLogIn;
            BulkAdd.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Storage = new Storage();
            Storage.RefToMain = this;
            Storage.CurrentUser = CurrentUser;
            Storage.RefToLogIn = RefToLogIn;
            Storage.Show();
            Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Orders = new Orders();
            Orders.RefToMain = this;
            Orders.CurrentUser = CurrentUser;
            Orders.RefToLogIn = RefToLogIn;
            Orders.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BulkRemove = new BulkRemove();
            BulkRemove.RefToMain = this;
            BulkRemove.CurrentUser = CurrentUser;
            BulkRemove.RefToLogIn = RefToLogIn;
            BulkRemove.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Search = new Search();
            Search.RefToMain = this;
            Search.CurrentUser = CurrentUser;
            Search.RefToLogIn = RefToLogIn;
            Search.Show();
            Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Manager = new Manager();
            Manager.RefToMain = this;
            Manager.CurrentUser = CurrentUser;
            Manager.RefToLogIn = RefToLogIn;
            Manager.Show();
            Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RefToLogIn.Show();
            Close();
        }
    }
}
