namespace WindowsFormspractice
{
    partial class Winform2
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
            this.nametxt = new System.Windows.Forms.TextBox();
            this.Namelbl = new System.Windows.Forms.Label();
            this.Submitbtn = new System.Windows.Forms.Button();
            this.resultlbl = new System.Windows.Forms.Label();
            this.CountryExample = new System.Windows.Forms.ListBox();
            this.Languagecombo = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(169, 58);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(149, 22);
            this.nametxt.TabIndex = 0;
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelbl.Location = new System.Drawing.Point(36, 51);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(101, 29);
            this.Namelbl.TabIndex = 1;
            this.Namelbl.Text = "Name :";
            // 
            // Submitbtn
            // 
            this.Submitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submitbtn.Location = new System.Drawing.Point(158, 144);
            this.Submitbtn.Name = "Submitbtn";
            this.Submitbtn.Size = new System.Drawing.Size(133, 44);
            this.Submitbtn.TabIndex = 2;
            this.Submitbtn.Text = "Submit";
            this.Submitbtn.UseVisualStyleBackColor = true;
            this.Submitbtn.Click += new System.EventHandler(this.Submitbtn_Click);
            // 
            // resultlbl
            // 
            this.resultlbl.AutoSize = true;
            this.resultlbl.Location = new System.Drawing.Point(205, 232);
            this.resultlbl.Name = "resultlbl";
            this.resultlbl.Size = new System.Drawing.Size(0, 16);
            this.resultlbl.TabIndex = 3;
            // 
            // CountryExample
            // 
            this.CountryExample.FormattingEnabled = true;
            this.CountryExample.ItemHeight = 16;
            this.CountryExample.Items.AddRange(new object[] {
            "India",
            "Pakistan",
            "Dubai",
            "Turkey"});
            this.CountryExample.Location = new System.Drawing.Point(25, 318);
            this.CountryExample.Name = "CountryExample";
            this.CountryExample.Size = new System.Drawing.Size(147, 116);
            this.CountryExample.TabIndex = 4;
            // 
            // Languagecombo
            // 
            this.Languagecombo.FormattingEnabled = true;
            this.Languagecombo.Items.AddRange(new object[] {
            "Kannada",
            "Hindi ",
            "English",
            "Telgu",
            "Malyalam",
            "Tamil"});
            this.Languagecombo.Location = new System.Drawing.Point(316, 318);
            this.Languagecombo.Name = "Languagecombo";
            this.Languagecombo.Size = new System.Drawing.Size(134, 24);
            this.Languagecombo.TabIndex = 5;
            this.Languagecombo.Text = "Select your lang";
            this.Languagecombo.SelectedIndexChanged += new System.EventHandler(this.Languagecombo_SelectedIndexChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(231, 397);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(120, 20);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Radiobutton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(379, 397);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(105, 20);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "Checkbox1";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Winform2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 495);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.Languagecombo);
            this.Controls.Add(this.CountryExample);
            this.Controls.Add(this.resultlbl);
            this.Controls.Add(this.Submitbtn);
            this.Controls.Add(this.Namelbl);
            this.Controls.Add(this.nametxt);
            this.Name = "Winform2";
            this.Text = "Practice2";
            this.Load += new System.EventHandler(this.Winform2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.Button Submitbtn;
        private System.Windows.Forms.Label resultlbl;
        private System.Windows.Forms.ListBox CountryExample;
        private System.Windows.Forms.ComboBox Languagecombo;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}