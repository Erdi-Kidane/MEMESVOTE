using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            button3.Visible = false;
            button4.Visible = false;
            checkedListBox1.Visible = false;
            checkedListBox1.CheckOnClick = true;
            button5.Visible = false;
            label1.Visible = false;
            button6.Visible = false;
            label3.Visible = false;
            //bool chk = false;
        }
        private bool chk = false;

        private void Button1_Click(object sender, EventArgs e)//yes button
        {

            MessageBox.Show("WARNING! You may have made a silly mistake, check your answer is vote again.");
            button1.Visible = false;
            button3.Visible = true;
            button2.Text = "No, you're right! I did make a silly mistake.";
        }

        private void Button2_Click(object sender, EventArgs e)//No button
        {
            MessageBox.Show("You picked water is not wet your answer has been unbiasedly recorded, thank you for using our Make Everything Mostly Effortless System (MEMES)");
            this.Close();


        }

        private void Button3_Click(object sender, EventArgs e)//yes 2 button
        {
            
            //button1.
            MessageBox.Show("OKay... but have you considered the fact that: \n\nWetness is the ability of a liquid to adhere to the surface of a solid, so when we say that something is wet, we mean that the liquid is sticking to the surface of a material.\n\nThus liquid water is not itself wet, but can make other solid materials wet.");

            button3.Visible = false;
            button4.Visible = true;
            button4.Text = "Yes, even though those are compelling facts I think water is wet";
            //button3.Location = new Point(40, 40);

        }
        private void Button4_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            
            MessageBox.Show("Please check ALL to confirm your intent to vote \"YES\".  Otherwise vote \"NO\"");
            label3.Visible = true;
             button4.Visible = false;
             checkedListBox1.Visible = true;
             button2.Visible = true;

            
        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(checkedListBox1.CheckedItems.Count == checkedListBox1.Items.Count)
            {
                //checkedListBox1.Visible = false;
                //button4.Visible = true;
                //button2.Visible = true;
                //button4.Text = "I agree to all these terms";
                chk = true;
                
                MessageBox.Show("Not too late to say vote no!");
                label3.Visible = false;
                button5.Text = "I agree with all the above";
                button5.Visible = true;
                button2.Visible = true;
                
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            
            button5.Visible = false;
            checkedListBox1.Visible = false;
            label1.Visible = true;
            button6.Visible = true;
            button6.Text = "Just let me vote yes dang it!";

        }

        private void Label1_Click(object sender, EventArgs e)
        {
            
        }
        
        private void Button6_Click(object sender, EventArgs e)
        {
            
            button2.Visible = false;
            //go to form 2
            MessageBox.Show("Alright fine... FINE! I get it you want to vote yes water is wet! Just click the yes button and we'll be done!");
            Form2 f2 = new Form2();

            f2.ShowDialog();
            button6.Text = "Yes it is! I want to try again!";
            label1.Text = "Want some more or have you finally seen the light? Is water wet?";
            button2.Text = "No, the right answer was always no...";
            button2.Visible = true;
        }



    }
}
//MEME
//Majority Effectively meticulously Errorlessly