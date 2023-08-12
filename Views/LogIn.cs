using Capstone.Objects;
using Capstone.Service;

namespace Capstone
{
    public partial class LogIn : Form
    {
        public User CurrentUser { get; set; }
        public MainMenu MainMenu { get; set; }

        public LogIn()
        {
            InitializeComponent();
        }

        private async void button8_Click(object sender, EventArgs e)
        {/*
            var users = await DatabaseService.GetUsers();
            bool found = false;
            foreach (User user in users)
            {
                if(user.UserID.ToString() == textBox1.Text &&
                    user.Password == textBox2.Text)
                {
                    found = true;
                    CurrentUser = user; */
                    MainMenu = new MainMenu();
                    MainMenu.Show();
                    MainMenu.RefToLogIn = this;
                    MainMenu.CurrentUser = CurrentUser;
                    Hide(); /*
                }
            }
            if (!found) 
            {
                MessageBox.Show("User ID and password combination not recognized");
            } */
        }
    }
}