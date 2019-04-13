using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;



namespace WindowsFormsApp1
{

    public partial class MindReader : Form
    {
        //Array Of All The Symbols 
        public static string[] Sym = new string[] { "◐", "◑", "◒", "◓", "◔", "◕", "◖", "◗" };
        Random RC = new Random();
        public static int NC; //For Displaying Symbols On Number Divisble By 9
        int RCN; //Random Number

        public MindReader()
        {
            InitializeComponent();

            Create_Info(); //Assign Random Symbols To All Numbers 
                           //But Assigns Number Divible By 9 A Specfic Symbols   
        }
        public void Create_Info()
        {
            ListPanel.Controls.Clear();

            NC = RC.Next(0, 7); //Random Specfic Symbol For Number Divisble By 9

            for (int i = 1; i <= 99; i++)   //Assign Symbols For All Numbers
            {
                Label NumL = new Label();
                NumL.Name = i + ToString();
                NumL.Font = new Font("Cambria", 15);
                NumL.ForeColor = Color.FromArgb(0,0,0);
                NumL.AutoSize = true;
                NumL.Margin = new Padding(0, 5, 25, 5);

                if (i % 9 == 0)  //Checking If The Number Is Divisble By 9 And 
                                 //Gives The Random Specfic Symbol
                {
                    NumL.Text = i + " -> " + Sym[NC];
                }
                else             //Else Gives A Random Symbol
                {
                    RCN = RC.Next(0, 7);
                    NumL.Text = i + " -> " + Sym[RCN];
                }

                ListPanel.Controls.Add(NumL);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListPanel.Hide();
            ResultBtn.Hide();

            AgainBtn.Show();

            ResultPanel.Controls.Clear();

            Label ResuL = new Label();
            ResuL.Name = 1 + ToString();
            ResuL.Font = new Font("Cambria", 130);
            ResuL.ForeColor = Color.FromArgb(178, 8, 55);
            ResuL.AutoSize = true;
            ResuL.Text = MindReader.Sym[MindReader.NC];

            ResultPanel.Controls.Add(ResuL);

        }

        private void AgainBtn_Click(object sender, EventArgs e)
        {
            Create_Info();

            ResultBtn.Show();
            ListPanel.Show();

            AgainBtn.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Zenodeon");         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
     
        }
    
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
