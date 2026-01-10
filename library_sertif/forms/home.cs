using library_sertif.forms;
using library_sertif.Forms;
using System;
using System.Windows.Forms;

public partial class home : Form
{
    private int _userId; }

   namespace library_sertif.forms
{
    public partial class home : Form
    {
        private int _userId;

        public home()
        {
            InitializeComponent(); 
            this.Text = "Home";
            _userId = 0;
        }

      
    
    private void btn_signin_home_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void btn_Signup_home_Click(object sender, EventArgs e)
        {
            new signup().Show();
            this.Hide();
        }
    }
}
