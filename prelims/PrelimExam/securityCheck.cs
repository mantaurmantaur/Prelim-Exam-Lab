using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrelimExam
{
    public partial class securityCheck : Form
    {
        public securityCheck()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            string password;

            password = passtbx.ToString();
            if(password == "123456")
            {
                home_page homepage = new home_page();
                homepage.Show();
            }
        }
    }
}
