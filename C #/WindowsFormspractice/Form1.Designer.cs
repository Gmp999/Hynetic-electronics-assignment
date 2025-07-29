namespace WindowsFormspractice
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Namelbl = new System.Windows.Forms.Label();
            this.Addresslbl = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Registerbtn = new System.Windows.Forms.Button();
            this.Citylbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Gendergpb = new System.Windows.Forms.GroupBox();
            this.MaleRbtn = new System.Windows.Forms.RadioButton();
            this.FemaleRbtn = new System.Windows.Forms.RadioButton();
            this.Transportlbl = new System.Windows.Forms.Label();
            this.CarCbtn = new System.Windows.Forms.CheckBox();
            this.BusCbtn = new System.Windows.Forms.CheckBox();
            this.Gendergpb.SuspendLayout();
            this.SuspendLayout();
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Location = new System.Drawing.Point(56, 92);
            this.Namelbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(101, 29);
            this.Namelbl.TabIndex = 0;
            this.Namelbl.Text = "Name :";
            // 
            // Addresslbl
            // 
            this.Addresslbl.AutoSize = true;
            this.Addresslbl.Location = new System.Drawing.Point(56, 181);
            this.Addresslbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Addresslbl.Name = "Addresslbl";
            this.Addresslbl.Size = new System.Drawing.Size(137, 29);
            this.Addresslbl.TabIndex = 1;
            this.Addresslbl.Text = "Address : ";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(235, 89);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(209, 36);
            this.nametxt.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(235, 181);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(209, 83);
            this.textBox2.TabIndex = 3;
            // 
            // Registerbtn
            // 
            this.Registerbtn.Location = new System.Drawing.Point(311, 806);
            this.Registerbtn.Name = "Registerbtn";
            this.Registerbtn.Size = new System.Drawing.Size(133, 39);
            this.Registerbtn.TabIndex = 4;
            this.Registerbtn.Text = "Register";
            this.Registerbtn.UseVisualStyleBackColor = true;
            // 
            // Citylbl
            // 
            this.Citylbl.AutoSize = true;
            this.Citylbl.Location = new System.Drawing.Point(56, 311);
            this.Citylbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Citylbl.Name = "Citylbl";
            this.Citylbl.Size = new System.Drawing.Size(85, 29);
            this.Citylbl.TabIndex = 5;
            this.Citylbl.Text = "City : ";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft PhagsPa", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bengaluru",
            "Chennai",
            "Hyderabad",
            "Kochi"});
            this.comboBox1.Location = new System.Drawing.Point(235, 311);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "Select your city:";
            // 
            // Gendergpb
            // 
            this.Gendergpb.Controls.Add(this.FemaleRbtn);
            this.Gendergpb.Controls.Add(this.MaleRbtn);
            this.Gendergpb.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Gendergpb.Location = new System.Drawing.Point(61, 410);
            this.Gendergpb.Name = "Gendergpb";
            this.Gendergpb.Size = new System.Drawing.Size(478, 124);
            this.Gendergpb.TabIndex = 7;
            this.Gendergpb.TabStop = false;
            this.Gendergpb.Text = "Gender";
            // 
            // MaleRbtn
            // 
            this.MaleRbtn.AutoSize = true;
            this.MaleRbtn.Location = new System.Drawing.Point(47, 55);
            this.MaleRbtn.Name = "MaleRbtn";
            this.MaleRbtn.Size = new System.Drawing.Size(93, 33);
            this.MaleRbtn.TabIndex = 0;
            this.MaleRbtn.TabStop = true;
            this.MaleRbtn.Text = "Male";
            this.MaleRbtn.UseVisualStyleBackColor = true;
            // 
            // FemaleRbtn
            // 
            this.FemaleRbtn.AutoSize = true;
            this.FemaleRbtn.Location = new System.Drawing.Point(265, 55);
            this.FemaleRbtn.Name = "FemaleRbtn";
            this.FemaleRbtn.Size = new System.Drawing.Size(125, 33);
            this.FemaleRbtn.TabIndex = 1;
            this.FemaleRbtn.TabStop = true;
            this.FemaleRbtn.Text = "Female";
            this.FemaleRbtn.UseVisualStyleBackColor = true;
            // 
            // Transportlbl
            // 
            this.Transportlbl.AutoSize = true;
            this.Transportlbl.Location = new System.Drawing.Point(56, 608);
            this.Transportlbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Transportlbl.Name = "Transportlbl";
            this.Transportlbl.Size = new System.Drawing.Size(153, 29);
            this.Transportlbl.TabIndex = 8;
            this.Transportlbl.Text = "Transport : ";
            // 
            // CarCbtn
            // 
            this.CarCbtn.AutoSize = true;
            this.CarCbtn.Location = new System.Drawing.Point(235, 608);
            this.CarCbtn.Name = "CarCbtn";
            this.CarCbtn.Size = new System.Drawing.Size(78, 33);
            this.CarCbtn.TabIndex = 9;
            this.CarCbtn.Text = "Car";
            this.CarCbtn.UseVisualStyleBackColor = true;
            // 
            // BusCbtn
            // 
            this.BusCbtn.AutoSize = true;
            this.BusCbtn.Location = new System.Drawing.Point(358, 608);
            this.BusCbtn.Name = "BusCbtn";
            this.BusCbtn.Size = new System.Drawing.Size(82, 33);
            this.BusCbtn.TabIndex = 10;
            this.BusCbtn.Text = "Bus";
            this.BusCbtn.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(776, 897);
            this.Controls.Add(this.BusCbtn);
            this.Controls.Add(this.CarCbtn);
            this.Controls.Add(this.Transportlbl);
            this.Controls.Add(this.Gendergpb);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Citylbl);
            this.Controls.Add(this.Registerbtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.Addresslbl);
            this.Controls.Add(this.Namelbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Click += new System.EventHandler(this.LoginForm_Click);
            this.Gendergpb.ResumeLayout(false);
            this.Gendergpb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.Label Addresslbl;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Registerbtn;
        private System.Windows.Forms.Label Citylbl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox Gendergpb;
        private System.Windows.Forms.RadioButton FemaleRbtn;
        private System.Windows.Forms.RadioButton MaleRbtn;
        private System.Windows.Forms.Label Transportlbl;
        private System.Windows.Forms.CheckBox CarCbtn;
        private System.Windows.Forms.CheckBox BusCbtn;
    }
}

