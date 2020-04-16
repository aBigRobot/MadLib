using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MadLib
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.ActiveControl = textBox1;
            textBox1.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string box1 = textBox1.Text;
            string box2 = textBox2.Text;
            string box3 = textBox3.Text;
            string box4 = textBox4.Text;
            string box5 = textBox5.Text;
            string box6 = textBox6.Text;
            string box7 = textBox7.Text;
            string box8 = textBox8.Text;
            string box9 = textBox9.Text;
            string box10 = textBox10.Text;
            string box11 = textBox11.Text;
            string box12 = textBox12.Text;
            string box13 = textBox13.Text;
            string box14 = textBox14.Text;
            string box15 = textBox15.Text;
            string box16 = textBox16.Text;
            string box17 = textBox17.Text;
            string box18 = textBox18.Text;
            string box19 = textBox19.Text;
            string box20 = textBox20.Text;


            MessageBox.Show("GOOD JOB! Enjoy the story below: \n" +
                            "If you go to some " + box1 + " place like Yellowstone " +
                            "National " + box2 + " Park, you must know how to deal with the " +
                            "wild animals such as bears, wolves, and " + box3 + ". " +
                            "The most important of these is the bear. There are three kinds of bears, " +
                            "the grizzly bear, the " + box4 + " bear, and the " + box5 + " bear. Bears spend most of their time " + 
                            box6 + " or " + box7 + ". They look very " + box8 + ", but " +
                            "if you make them " + box9 + ", they might bite your " + box10 + "! Bears will come up " +
                            "to your car and beg for " + box11 + ". They will stand on their hind legs and clap their " +
                            box12 + " together and pretend to be " + box13 + ". But do NOT get out of your " + box14 + 
                            " or offer the bears " + box15 + " or " + box16 + ". This same advice applies to other wild " + 
                            "creatures such as " + box17 + " and " + box18 + ". Remember all these rules and you will spend " +
                            "your vacation " + box19 + " and not get eaten by a/an " + box20 + ".");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void textBox20_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
