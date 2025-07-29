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
    public partial class Winform2 : Form
    {
        public Winform2()
        {
            InitializeComponent();
        }

        private void Submitbtn_Click(object sender, EventArgs e)
        {
            resultlbl.Text = "Hello " + nametxt.Text;
        }
    }
}
