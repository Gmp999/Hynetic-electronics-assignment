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
            // label1
            // 
            this.resultlbl.AutoSize = true;
            this.resultlbl.Location = new System.Drawing.Point(205, 232);
            this.resultlbl.Name = "label1";
            this.resultlbl.Size = new System.Drawing.Size(0, 16);
            this.resultlbl.TabIndex = 3;
            // 
            // Winform2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 450);
            this.Controls.Add(this.resultlbl);
            this.Controls.Add(this.Submitbtn);
            this.Controls.Add(this.Namelbl);
            this.Controls.Add(this.nametxt);
            this.Name = "Winform2";
            this.Text = "Practice2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.Button Submitbtn;
        private System.Windows.Forms.Label resultlbl;
    }
}