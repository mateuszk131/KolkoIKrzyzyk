using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KolkoIKrzyzyk
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            labelGracz1.Text = GUI.OpisElementowGUI.LabelGracz1;
            labelGracz2.Text = GUI.OpisElementowGUI.labelGracz2;
            labelTura.Text = GUI.OpisElementowGUI.labelTura;
            labelWynik1.Text = GUI.OpisElementowGUI.labelWynik1;
            labelWynik2.Text = GUI.OpisElementowGUI.labelWynik2;
            buttonReset.Text = GUI.OpisElementowGUI.ButtonReset;
            this.Text = "Kółko i krzyżyk";
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
            labelGracz1.ForeColor = Color.Red;
        }
        int tura, click1, click2, click3, click4, click5, click6, click7, click8, click9,player1hs,player2hs;
        public void Tura()
        {
            if(tura %2==0)
            {
                labelGracz2.ForeColor = Color.Red;
                labelGracz1.ForeColor = Color.Black;
            }
            else
            {
                labelGracz1.ForeColor = Color.Red;
                labelGracz2.ForeColor = Color.Black;

            }
            tura++;
            labelTura.Text = "Tura: " + tura;
            return;
        }
        public void Clear()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
            click1 = 0;
            click2 = 0;
            click3 = 0;
            click4 = 0;
            click5 = 0;
            click6 = 0;
            click7 = 0;
            click8 = 0;
            click9 = 0;
            tura = 0;
            labelTura.Text = "Tura: "+tura;
            labelGracz1.ForeColor = Color.Red;
            labelGracz2.ForeColor = Color.Black;
            labelWynik1.Text = "Wygrane: " + player1hs;
            labelWynik2.Text = "Wygrane: " + player2hs;
            return;
        }



        public void Check()
        {
            if (button1.Text != "" && button2.Text != "" && button3.Text != "")
            {
                if (button1.Text == button2.Text && button1.Text == button3.Text)
                {
                    button1.BackColor = Color.Green;
                    button2.BackColor = Color.Green;
                    button3.BackColor = Color.Green;
                    if (button1.Text == "O")
                    {
                        MessageBox.Show("Wygrywa gracz 1!");
                        player1hs++;
                        Clear();

                    }
                    else
                    {
                        MessageBox.Show("Wygrywa gracz 2!");
                        player2hs++;
                        Clear();
                    }
                }            
            }
            if (button4.Text != "" && button5.Text != "" && button6.Text != "")
            {
                if (button4.Text == button5.Text && button4.Text == button6.Text)
                {
                    button4.BackColor = Color.Green;
                    button5.BackColor = Color.Green;
                    button6.BackColor = Color.Green;
                    if (button4.Text == "O")
                    { 
                        MessageBox.Show("Wygrywa gracz 1!");
                        player1hs++;
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Wygrywa gracz 2!");
                        player2hs++;
                        Clear();
                    }
                }
            }
            if (button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                if (button7.Text == button8.Text && button7.Text == button9.Text)
                {
                    button7.BackColor = Color.Green;
                    button8.BackColor = Color.Green;
                    button9.BackColor = Color.Green;
                    if (button7.Text == "O")
                    {
                        MessageBox.Show("Wygrywa gracz 1!");
                        player1hs++;
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Wygrywa gracz 2!");
                        player2hs++;
                        Clear();
                    }
                }
            }
            if (button1.Text != "" && button4.Text != "" && button7.Text != "")
            {
                if (button1.Text == button4.Text && button1.Text == button7.Text)
                {
                    button1.BackColor = Color.Green;
                    button4.BackColor = Color.Green;
                    button7.BackColor = Color.Green;
                    if (button1.Text == "O")
                    {
                        MessageBox.Show("Wygrywa gracz 1!");
                        player1hs++;
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Wygrywa gracz 2!");
                        player2hs++;
                        Clear();
                    }
                }
            }
            if (button2.Text != "" && button5.Text != "" && button8.Text != "")
            {
                if (button2.Text == button5.Text && button2.Text == button8.Text)
                {
                    button2.BackColor = Color.Green;
                    button5.BackColor = Color.Green;
                    button8.BackColor = Color.Green;
                    if (button2.Text == "O")
                    {
                        MessageBox.Show("Wygrywa gracz 1!");
                        player1hs++;
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Wygrywa gracz 2!");
                        player2hs++;
                        Clear();
                    }
                }
            }
            if (button3.Text != "" && button6.Text != "" && button9.Text != "")
            {
                if (button3.Text == button6.Text && button3.Text == button9.Text)
                {
                    button3.BackColor = Color.Green;
                    button6.BackColor = Color.Green;
                    button9.BackColor = Color.Green;
                    if (button3.Text == "O")
                    {
                        MessageBox.Show("Wygrywa gracz 1!");
                        player1hs++;
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Wygrywa gracz 2!");
                        player2hs++;
                        Clear();
                    }
                }
            }
            if (button1.Text != "" && button5.Text != "" && button9.Text != "")
            {
                if (button1.Text == button5.Text && button1.Text == button9.Text)
                {
                    button1.BackColor = Color.Green;
                    button5.BackColor = Color.Green;
                    button9.BackColor = Color.Green;
                    if (button1.Text == "O")
                    {
                        MessageBox.Show("Wygrywa gracz 1!");
                        player1hs++;
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Wygrywa gracz 2!");
                        player2hs++;
                        Clear();
                    }
                }
            }
            if (button3.Text != "" && button5.Text != "" && button7.Text != "")
            {
                if (button3.Text == button5.Text && button3.Text == button7.Text)
                {
                    button3.BackColor = Color.Green;
                    button5.BackColor = Color.Green;
                    button7.BackColor = Color.Green;
                    if (button3.Text == "O")
                    {
                        MessageBox.Show("Wygrywa gracz 1!");
                        player1hs++;
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Wygrywa gracz 2!");
                        player2hs++;
                        Clear();
                    }
                }
            }
            if (tura >= 9)
            {
                MessageBox.Show("Remis!");
                Clear();

            }

        }
                    #region button_click
                    private void button1_Click(object sender, EventArgs e)
        {
            if (click1 == 0)
            {
                if (tura % 2 != 0)
                {
                    button1.Text = "X";
                }
                else
                {
                    button1.Text = "O";
                }
                click1++;
                Tura();
                Check();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (click2 == 0)
            {
                if (tura % 2 != 0)
                {
                    button2.Text = "X";
                }
                else
                {
                    button2.Text = "O";
                }
                click2++;
                Tura();
                Check();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (click3 == 0)
            {
                if (tura % 2 != 0)
                {
                    button3.Text = "X";
                }
                else
                {
                    button3.Text = "O";
                }
                click3++;
                Tura();
                Check();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (click4 == 0)
            {
                if (tura % 2 != 0)
                {
                    button4.Text = "X";
                }
                else
                {
                    button4.Text = "O";
                }
                click4++;
                Tura();
                Check();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (click5 == 0)
            {
                if (tura % 2 != 0)
                {
                    button5.Text = "X";
                }
                else
                {
                    button5.Text = "O";
                }
                click5++;
                Tura();
                Check();
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            {
                if (click6 == 0)
                {
                    if (tura % 2 != 0)
                    {
                        button6.Text = "X";
                    }
                    else
                    {
                        button6.Text = "O";
                    }
                    click6++;
                    Tura();
                    Check();
                }
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (click7 == 0)
            {
                if (tura % 2 != 0)
                {
                    button7.Text = "X";
                }
                else
                {
                    button7.Text = "O";
                }
                click7++;
                Tura();
                Check();
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (click8 == 0)
            {
                if (tura % 2 != 0)
                {
                    button8.Text = "X";
                }
                else
                {
                    button8.Text = "O";
                }
                click8++;
                Tura();
                Check();
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (click9 == 0)
            {
                if (tura % 2 != 0)
                {
                    button9.Text = "X";
                }
                else
                {
                    button9.Text = "O";
                }
                click9++;
                Tura();
                Check();
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            Clear();
        }
        #endregion
    }
}
