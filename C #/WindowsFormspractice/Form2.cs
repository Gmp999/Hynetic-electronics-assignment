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

        private void Winform2_Load(object sender, EventArgs e)
        {
            CountryExample.Items.Add("New Zeland");
            CountryExample.SelectionMode = SelectionMode.MultiSimple;
            CountryExample.SelectedIndex = 4;
            resultlbl.Text = CountryExample.SelectedItem.ToString();

        }

        private void Languagecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            resultlbl.Text = Languagecombo.SelectedItem.ToString();
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
