namespace PRELIMsEXAM
{
    public partial class security_Check : Form
    {
        public security_Check()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void enter_sulod(object sender, EventArgs e)
        {
            
        }

        private void enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string password;

                password = passtbx.Text;

                if (password == "11414bautista")
                {
                    homePage homepage = new homePage();
                    homepage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Password Incorrect!");
                }
            }
            
        }
    }
}
