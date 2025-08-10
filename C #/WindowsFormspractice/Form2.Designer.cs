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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Timer timer1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Winform2));
            this.nametxt = new System.Windows.Forms.TextBox();
            this.Namelbl = new System.Windows.Forms.Label();
            this.Submitbtn = new System.Windows.Forms.Button();
            this.resultlbl = new System.Windows.Forms.Label();
            this.CountryExample = new System.Windows.Forms.ListBox();
            this.Languagecombo = new System.Windows.Forms.ComboBox();
            this.genderradibtn = new System.Windows.Forms.RadioButton();
            this.chkbox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resultbtn = new System.Windows.Forms.Button();
            this.genderresult = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.chkbtn = new System.Windows.Forms.Button();
            this.chklistlbl = new System.Windows.Forms.Label();
            this.timerlbl = new System.Windows.Forms.Label();
            this.tabCtrl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dtpicker = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.designerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solutionExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeSnippetManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.tabCtrl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(169, 58);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(149, 22);
            this.nametxt.TabIndex = 0;
            this.nametxt.Validating += new System.ComponentModel.CancelEventHandler(this.nametxt_Validating);
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
            this.Submitbtn.Location = new System.Drawing.Point(120, 144);
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
            this.CountryExample.Location = new System.Drawing.Point(12, 304);
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
            this.Languagecombo.Location = new System.Drawing.Point(396, 56);
            this.Languagecombo.Name = "Languagecombo";
            this.Languagecombo.Size = new System.Drawing.Size(134, 24);
            this.Languagecombo.TabIndex = 5;
            this.Languagecombo.Text = "Select your lang";
            this.Languagecombo.SelectedIndexChanged += new System.EventHandler(this.Languagecombo_SelectedIndexChanged);
            // 
            // genderradibtn
            // 
            this.genderradibtn.AutoSize = true;
            this.genderradibtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderradibtn.Location = new System.Drawing.Point(6, 43);
            this.genderradibtn.Name = "genderradibtn";
            this.genderradibtn.Size = new System.Drawing.Size(79, 20);
            this.genderradibtn.TabIndex = 6;
            this.genderradibtn.TabStop = true;
            this.genderradibtn.Text = "Gender";
            this.genderradibtn.UseVisualStyleBackColor = true;
            // 
            // chkbox
            // 
            this.chkbox.AutoSize = true;
            this.chkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbox.Location = new System.Drawing.Point(219, 44);
            this.chkbox.Name = "chkbox";
            this.chkbox.Size = new System.Drawing.Size(77, 20);
            this.chkbox.TabIndex = 8;
            this.chkbox.Text = "Saving";
            this.chkbox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.resultbtn);
            this.groupBox1.Controls.Add(this.genderresult);
            this.groupBox1.Controls.Add(this.genderradibtn);
            this.groupBox1.Controls.Add(this.chkbox);
            this.groupBox1.Location = new System.Drawing.Point(220, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 165);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Radio and Checkbox";
            // 
            // resultbtn
            // 
            this.resultbtn.Location = new System.Drawing.Point(119, 84);
            this.resultbtn.Name = "resultbtn";
            this.resultbtn.Size = new System.Drawing.Size(75, 23);
            this.resultbtn.TabIndex = 10;
            this.resultbtn.Text = "clickme";
            this.resultbtn.UseVisualStyleBackColor = true;
            this.resultbtn.Click += new System.EventHandler(this.resultbtn_Click);
            // 
            // genderresult
            // 
            this.genderresult.AutoSize = true;
            this.genderresult.Location = new System.Drawing.Point(23, 127);
            this.genderresult.Name = "genderresult";
            this.genderresult.Size = new System.Drawing.Size(0, 16);
            this.genderresult.TabIndex = 9;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "First",
            "Second",
            "Third",
            "Fourth"});
            this.checkedListBox1.Location = new System.Drawing.Point(609, 304);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(201, 89);
            this.checkedListBox1.TabIndex = 10;
            // 
            // chkbtn
            // 
            this.chkbtn.Location = new System.Drawing.Point(677, 414);
            this.chkbtn.Name = "chkbtn";
            this.chkbtn.Size = new System.Drawing.Size(75, 23);
            this.chkbtn.TabIndex = 11;
            this.chkbtn.Text = "Cheklist";
            this.chkbtn.UseVisualStyleBackColor = true;
            this.chkbtn.Click += new System.EventHandler(this.chkbtn_Click);
            // 
            // chklistlbl
            // 
            this.chklistlbl.AutoSize = true;
            this.chklistlbl.Location = new System.Drawing.Point(674, 458);
            this.chklistlbl.Name = "chklistlbl";
            this.chklistlbl.Size = new System.Drawing.Size(0, 16);
            this.chklistlbl.TabIndex = 12;
            // 
            // timerlbl
            // 
            this.timerlbl.AutoSize = true;
            this.timerlbl.Location = new System.Drawing.Point(21, 443);
            this.timerlbl.Name = "timerlbl";
            this.timerlbl.Size = new System.Drawing.Size(0, 16);
            this.timerlbl.TabIndex = 13;
            // 
            // tabCtrl1
            // 
            this.tabCtrl1.Controls.Add(this.tabPage1);
            this.tabCtrl1.Controls.Add(this.tabPage2);
            this.tabCtrl1.Location = new System.Drawing.Point(620, 42);
            this.tabCtrl1.Name = "tabCtrl1";
            this.tabCtrl1.SelectedIndex = 0;
            this.tabCtrl1.Size = new System.Drawing.Size(253, 231);
            this.tabCtrl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(245, 202);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "My profile";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: Goutham M P";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(245, 202);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Technical Skills";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "c#,python,javascript";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(403, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(944, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 36);
            this.button1.TabIndex = 16;
            this.button1.Text = "Msgboxbutton";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(892, 144);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 17;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtpicker
            // 
            this.dtpicker.AutoSize = true;
            this.dtpicker.Location = new System.Drawing.Point(926, 183);
            this.dtpicker.Name = "dtpicker";
            this.dtpicker.Size = new System.Drawing.Size(0, 16);
            this.dtpicker.TabIndex = 18;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(941, 304);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(76, 16);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Form1open";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1138, 28);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.addToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codeToolStripMenuItem,
            this.designerToolStripMenuItem,
            this.solutionExplorerToolStripMenuItem,
            this.propertiesToolStripMenuItem});
            this.viewToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gotoToolStripMenuItem,
            this.findToolStripMenuItem,
            this.undoToolStripMenuItem});
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getToolsToolStripMenuItem,
            this.connectToDatabaseToolStripMenuItem,
            this.connectToServerToolStripMenuItem,
            this.codeSnippetManagerToolStripMenuItem});
            this.toolsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // codeToolStripMenuItem
            // 
            this.codeToolStripMenuItem.Name = "codeToolStripMenuItem";
            this.codeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.codeToolStripMenuItem.Text = "Code";
            this.codeToolStripMenuItem.Click += new System.EventHandler(this.codeToolStripMenuItem_Click);
            // 
            // designerToolStripMenuItem
            // 
            this.designerToolStripMenuItem.Name = "designerToolStripMenuItem";
            this.designerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.designerToolStripMenuItem.Text = "Designer";
            // 
            // solutionExplorerToolStripMenuItem
            // 
            this.solutionExplorerToolStripMenuItem.Name = "solutionExplorerToolStripMenuItem";
            this.solutionExplorerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.solutionExplorerToolStripMenuItem.Text = "Solution Explorer";
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.propertiesToolStripMenuItem.Text = "Properties";
            // 
            // gotoToolStripMenuItem
            // 
            this.gotoToolStripMenuItem.Name = "gotoToolStripMenuItem";
            this.gotoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.gotoToolStripMenuItem.Text = "Goto";
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.findToolStripMenuItem.Text = "Find";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // getToolsToolStripMenuItem
            // 
            this.getToolsToolStripMenuItem.Name = "getToolsToolStripMenuItem";
            this.getToolsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.getToolsToolStripMenuItem.Text = "Get tools";
            // 
            // connectToDatabaseToolStripMenuItem
            // 
            this.connectToDatabaseToolStripMenuItem.Name = "connectToDatabaseToolStripMenuItem";
            this.connectToDatabaseToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.connectToDatabaseToolStripMenuItem.Text = "Connect to database";
            // 
            // connectToServerToolStripMenuItem
            // 
            this.connectToServerToolStripMenuItem.Name = "connectToServerToolStripMenuItem";
            this.connectToServerToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.connectToServerToolStripMenuItem.Text = "Connect to server";
            // 
            // codeSnippetManagerToolStripMenuItem
            // 
            this.codeSnippetManagerToolStripMenuItem.Name = "codeSnippetManagerToolStripMenuItem";
            this.codeSnippetManagerToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.codeSnippetManagerToolStripMenuItem.Text = "Code snippet manager";
            // 
            // Winform2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 495);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.dtpicker);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabCtrl1);
            this.Controls.Add(this.timerlbl);
            this.Controls.Add(this.chklistlbl);
            this.Controls.Add(this.chkbtn);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Languagecombo);
            this.Controls.Add(this.CountryExample);
            this.Controls.Add(this.resultlbl);
            this.Controls.Add(this.Submitbtn);
            this.Controls.Add(this.Namelbl);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Winform2";
            this.Text = "Practice2";
            this.Load += new System.EventHandler(this.Winform2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabCtrl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.RadioButton genderradibtn;
        private System.Windows.Forms.CheckBox chkbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label genderresult;
        private System.Windows.Forms.Button resultbtn;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button chkbtn;
        private System.Windows.Forms.Label chklistlbl;
        private System.Windows.Forms.Label timerlbl;
        private System.Windows.Forms.TabControl tabCtrl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label dtpicker;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem designerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solutionExplorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gotoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codeSnippetManagerToolStripMenuItem;
    }
}