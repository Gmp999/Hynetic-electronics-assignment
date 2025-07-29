using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormspractice
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Click(object sender, EventArgs e)
        {
            //this.Close();
            //this.Activate();
            //this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            nametxt.Text = "Hi Goutham";
        }
    }
}
