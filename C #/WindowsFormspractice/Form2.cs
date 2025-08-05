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
        //private TextBox txtbox = new TextBox();
        private Button btn = new Button();
        public Winform2()
        {
            InitializeComponent();
            //this.txtbox.BackColor = Color.White;
            //this.txtbox.Text = "Hi this is goutham";
            //this.txtbox.Size = new Size(100, 25);
            //this.txtbox.Location = new Point(90, 25);

            this.btn.BackColor = Color.White;
            this.btn.Text = "Click me";
            this.btn.Size = new Size(105, 25);
            this.btn.Location = new Point(95, 25);
            //Controls.Add(txtbox);
            Controls.Add(btn);
            this.btn.Click += new EventHandler(button_clk);



        }

        private void button_clk(object sender, EventArgs e)
        {
            Button FirstButton = sender as Button;
            MessageBox.Show("design time button clicked");
        }

        private void Submitbtn_Click(object sender, EventArgs e)
        {
            if (nametxt.Text != string.Empty)
            {
                string text = nametxt.Text;
                Boolean HasDigit = false;
                foreach (char letter in text)
                {
                    if (char.IsDigit(letter))
                    {
                        HasDigit = true;
                        break;
                    }
                }

                    //resultlbl.Text = "Hello with digit" + nametxt.Text ;

                if (!HasDigit)
                {
                    errorProvider1.SetError(nametxt, "There is no digit");
                }
                else
                {
                    errorProvider1.Clear();
                }

                  
            }
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

        private void resultbtn_Click(object sender, EventArgs e)
        {
            if (genderradibtn.Checked || chkbox.Checked)
            {
                genderresult.Text = genderradibtn.Text;
                //genderresult.Text = chkbox.Text;
            }
            else
            {
                genderresult.Text = "No buttons checked";
            }
        
    }

        private void chkbtn_Click(object sender, EventArgs e)
        {
            foreach (object item in checkedListBox1.CheckedItems)
            {
                chklistlbl.Text += item.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerlbl.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           var result = MessageBox.Show("Hello This is Goutham","Message Box",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Hand);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Yes siirrr");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dtpicker.Text = dateTimePicker1.Value.ToString("MM/dd/yyyy");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm formobj = new LoginForm();
            formobj.Show();
        }

        private void nametxt_Validating(object sender, CancelEventArgs e)
        {
            //if (nametxt.Text == string.Empty)
            //{
            //    MessageBox.Show("The text is not written");
            //}
        }
    }
}
