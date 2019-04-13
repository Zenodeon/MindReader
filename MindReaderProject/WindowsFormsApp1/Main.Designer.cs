namespace WindowsFormsApp1
{
    partial class MindReader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MindReader));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.ResultBtn = new System.Windows.Forms.Button();
            this.ListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ResultPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.AgainBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // ResultBtn
            // 
            this.ResultBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.ResultBtn.FlatAppearance.BorderSize = 0;
            this.ResultBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResultBtn.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultBtn.Location = new System.Drawing.Point(464, 543);
            this.ResultBtn.Name = "ResultBtn";
            this.ResultBtn.Size = new System.Drawing.Size(188, 54);
            this.ResultBtn.TabIndex = 0;
            this.ResultBtn.Text = "Ready? ";
            this.ResultBtn.UseVisualStyleBackColor = false;
            this.ResultBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListPanel
            // 
            this.ListPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.ListPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ListPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ListPanel.Font = new System.Drawing.Font("Montserrat Subrayada", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListPanel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ListPanel.Location = new System.Drawing.Point(90, 154);
            this.ListPanel.Name = "ListPanel";
            this.ListPanel.Size = new System.Drawing.Size(906, 376);
            this.ListPanel.TabIndex = 1;
            this.ListPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Doppio One", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mind Reader";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label2.Location = new System.Drawing.Point(93, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(423, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "1.  Think of  a  number with two Digits  ||  Eg. 49  ||  Eg2. 64";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label3.Location = new System.Drawing.Point(93, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(756, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "2.  Reduse the value of each digit  from the Main Number.  ||  Eg.  ( 49 - 4 - 9)" +
    " = 36  ||   Eg2. (64 - 6 - 4) = 54";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label4.Location = new System.Drawing.Point(93, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(472, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "3.  Now find the symbol from below according to the number u got.";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Location = new System.Drawing.Point(-7, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1121, 29);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(379, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(317, 68);
            this.panel3.TabIndex = 9;
            // 
            // ResultPanel
            // 
            this.ResultPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ResultPanel.BackColor = System.Drawing.Color.Black;
            this.ResultPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ResultPanel.Location = new System.Drawing.Point(342, 53);
            this.ResultPanel.Name = "ResultPanel";
            this.ResultPanel.Size = new System.Drawing.Size(220, 220);
            this.ResultPanel.TabIndex = 0;
            this.ResultPanel.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ResultPanel);
            this.panel1.Location = new System.Drawing.Point(90, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 376);
            this.panel1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(322, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 57);
            this.label5.TabIndex = 0;
            this.label5.Text = "Here It Is ;)";
            // 
            // AgainBtn
            // 
            this.AgainBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AgainBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.AgainBtn.FlatAppearance.BorderSize = 0;
            this.AgainBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgainBtn.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgainBtn.Location = new System.Drawing.Point(464, 543);
            this.AgainBtn.Name = "AgainBtn";
            this.AgainBtn.Size = new System.Drawing.Size(188, 54);
            this.AgainBtn.TabIndex = 11;
            this.AgainBtn.Text = "Again?";
            this.AgainBtn.UseVisualStyleBackColor = false;
            this.AgainBtn.Visible = false;
            this.AgainBtn.Click += new System.EventHandler(this.AgainBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label7.Location = new System.Drawing.Point(969, 581);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "By Zenodeon";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(21, 543);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 54);
            this.button1.TabIndex = 14;
            this.button1.Text = "GitHub";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Doppio One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(299, 26);
            this.label6.TabIndex = 1;
            this.label6.Text = "Want To Know How It Works?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Doppio One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(225, 26);
            this.label8.TabIndex = 2;
            this.label8.Text = "Vist My GitHub Page :)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label9.Font = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(797, 356);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "By Zenodeon";
            // 
            // MindReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1090, 610);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ListPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ResultBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AgainBtn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MindReader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mind Reader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button ResultBtn;
        private System.Windows.Forms.FlowLayoutPanel ListPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel ResultPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AgainBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}

