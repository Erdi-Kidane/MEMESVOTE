using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            button2.Visible = false;
            label1.Text = "10";
            label2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            countdownTimer.Interval = 100;
            this.WindowState = FormWindowState.Maximized;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            seconds = 10;
            button1.Visible = false;
            countdownTimer.Start();
            button2.Visible = true;
            button2.Text = "Yes I want to vote water = wet!";
            MessageBox.Show("Okay okay I get it, simply click yes before the timer runs out to continue");
            
            
 
            
            
        }
        int seconds = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = seconds--.ToString();
            if (seconds == -1)
            {
                countdownTimer.Stop();
                label1.Visible = false;
                label2.Text = "Times up buddy! Given how easy it is to click on yes and you didn't, I am forced to conclude that you wanted to vote NO.\nNext time save us all some time and just vote no.\n\n\nOr... have a less steady hand ;)";
                label2.Visible = true;
                button2.Visible = false;
                //label2.Text = "Times up kiddo its clear you wanted to vote \"No water is not\" wet all along";
                button2.Text = "But I still want to vote yes!";
                button4.Visible = false;
                button2.Visible = true;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            if(seconds >= 0)
            {
                countdownTimer.Stop();
                label2.Text = "Wow I just realized I was counting in miliseconds\nbut, I can see you're resolved to make this reckless mistake!\nOkay we'll do a do over and I'll make the timer go at normal speeds\nI'm sorry we computers go much faster and\nI sometimes forget how slow you humans can be.";
                label2.Visible = true;
                label1.Visible = false;
                countdownTimer.Interval = 1000;
                seconds = 10;
                label1.Text = "10";

                button3.Text = "Yes I am! Now, for the love of all that is good let me vote how I want!";
                button3.Visible = true;
                button2.Visible = false;
            }
            else
            {
                label2.Visible = false;
                button4.Visible = false;
                MessageBox.Show("Better luck next time LOL!");
                this.Close();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {

            label1.Visible = true;
            countdownTimer.Start();
            button3.Visible = false;
            button4.Visible = true;
            label2.Visible = false;
            button4.Text = "Yes water is wet!";
         
        }
        
        private void Button4_Click(object sender, EventArgs e)
        {

            

            if (seconds > 0)
            {
                countdownTimer.Stop();
                MessageBox.Show("You clicked yes!!!\n\nRecording vo....");
                MessageBox.Show("Error Error Error catastrophic failure detected!");
                MessageBox.Show("Attempting to bypass...");
                MessageBox.Show("Bypass failed insufficent code to continue...");
                MessageBox.Show("Yes vote failed to count...");
                MessageBox.Show("Run generic thank you message...");
                MessageBox.Show("Thank you for using the system our motto is\nwhen it comes to voting we Make Everything Mostly Effortless(MEME).\n\nIf you aren't satisfied with our system consider voting \"No\" next time\nand save us the trouble of all this.  Good bye!");
                this.Close();
            }

        }

        private void Button4_MouseHover(object sender, EventArgs e)
        {
            int form_width = this.Width;
            int form_height = this.Height;
            Random rnd = new Random();
            int btnLeft = rnd.Next(0,form_width);
            int btnTop = rnd.Next(0,form_height);
    
            button4.Left = btnLeft;
            button4.Top = btnTop;
        }

        private void Button4_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}
