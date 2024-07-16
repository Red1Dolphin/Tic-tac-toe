using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_tac_toe
{
    public partial class Game : Form
    {
        

        Thread th;
        private void openNewWIN()
        {
            Application.Run(new WIN());
        }
        private void openNewLOSE()
        {
            Application.Run(new LOSE());
        }
        private void openNewDRAW()
        {
            Application.Run(new DRAW());
        }
        public void WIN()
        {
            if(
                button1.Text == "X" && button2.Text == "X" &&  button3.Text == "X"||
                button4.Text == "X" && button5.Text == "X" && button6.Text == "X" ||
                button7.Text == "X" && button8.Text == "X" && button9.Text == "X" ||
                button1.Text == "X" && button4.Text == "X" && button7.Text == "X" ||
                button2.Text == "X" && button5.Text == "X" && button8.Text == "X" ||
                button3.Text == "X" && button6.Text == "X" && button9.Text == "X" ||
                button1.Text == "X" && button5.Text == "X" && button9.Text == "X" ||
                button3.Text == "X" && button5.Text == "X" && button7.Text == "X"     
                )             
            {
                th = new Thread(openNewWIN);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                this.Close();
            }
            else if 
                (
                button1.Text == "O" && button2.Text == "O" && button3.Text == "O" ||
                button4.Text == "O" && button5.Text == "O" && button6.Text == "O" ||
                button7.Text == "O" && button8.Text == "O" && button9.Text == "O" ||
                button1.Text == "O" && button4.Text == "O" && button7.Text == "O" ||
                button2.Text == "O" && button5.Text == "O" && button8.Text == "O" ||
                button3.Text == "O" && button6.Text == "O" && button9.Text == "O" ||
                button1.Text == "O" && button5.Text == "O" && button9.Text == "O" ||
                button3.Text == "O" && button5.Text == "O" && button7.Text == "O"
                )
            {
                th = new Thread(openNewLOSE);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                this.Close();
            }
            else
            {
                if(
                    button1.Text != "" &&
                    button2.Text != "" &&
                    button3.Text != "" &&
                    button4.Text != "" &&
                    button5.Text != "" &&
                    button6.Text != "" &&
                    button7.Text != "" &&
                    button8.Text != "" &&
                    button9.Text != ""                    
                    )
                {
                    th = new Thread(openNewDRAW);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                    this.Close();
                }
            }
        }
        
        public void Computer() 
        {   
            Random rand = new Random();
            
            bool turn = false;
            while(!turn)
            {
                if(button1.Text == "X" && button2.Text == "X" && button3.Text == "") 
                {
                    button3.Text = "O";
                    turn = true;
                }
                else if (button1.Text == "" && button2.Text == "X" && button3.Text == "X")
                {
                    button1.Text = "O";
                    turn = true;
                }
                else if (button4.Text == "" && button5.Text == "X" && button6.Text == "X")
                {
                    button4.Text = "O";
                    turn = true;
                }
                else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "")
                {
                    button6.Text = "O";
                    turn = true;
                }
                else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "")
                {
                    button9.Text = "O";
                    turn = true;
                }
                else if (button7.Text == "" && button8.Text == "X" && button9.Text == "X")
                {
                    button7.Text = "O";
                    turn = true;
                }
                else if (button1.Text == "" && button4.Text == "X" && button7.Text == "X")
                {
                    button1.Text = "O";
                    turn = true;
                }
                else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "")
                {
                    button7.Text = "O";
                    turn = true;
                }
                else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "")
                {
                    button8.Text = "O";
                    turn = true;
                }
                else if (button2.Text == "" && button5.Text == "X" && button8.Text == "X")
                {
                    button2.Text = "O";
                    turn = true;
                }
                else if (button3.Text == "" && button6.Text == "X" && button9.Text == "X")
                {
                    button3.Text = "O";
                    turn = true;
                }
                else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "")
                {
                    button9.Text = "O";
                    turn = true;
                }
                else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "")
                {
                    button9.Text = "O";
                    turn = true;
                }
                else if (button1.Text == "" && button5.Text == "X" && button9.Text == "X")
                {
                    button1.Text = "O";
                    turn = true;
                }
                else if (button3.Text == "" && button5.Text == "X" && button7.Text == "X")
                {
                    button3.Text = "O";
                    turn = true;
                }
                else if (button3.Text == "X" && button5.Text == "X" && button7.Text == "")
                {
                    button7.Text = "O";
                    turn = true;
                }
                else
                {
                    switch (rand.Next(1, 10))
                    {
                        case 1:
                            if (button1.Text == "")
                            {
                                button1.Text = "O";
                                turn = true;
                            }
                            break;
                        case 2:
                            if (button2.Text == "")
                            {
                                button2.Text = "O";
                                turn = true;
                            }
                            break;
                        case 3:
                            if (button3.Text == "")
                            {
                                button3.Text = "O";
                                turn = true;
                            }
                            break;
                        case 4:
                            if (button4.Text == "")
                            {
                                button4.Text = "O";
                                turn = true;
                            }
                            break;
                        case 5:
                            if (button5.Text == "")
                            {
                                button5.Text = "O";
                                turn = true;
                            }
                            break;
                        case 6:
                            if (button6.Text == "")
                            {
                                button6.Text = "O";
                                turn = true;
                            }
                            break;
                        case 7:
                            if (button7.Text == "")
                            {
                                button7.Text = "O";
                                turn = true;
                            }
                            break;
                        case 8:
                            if (button8.Text == "")
                            {
                                button8.Text = "O";
                                turn = true;
                            }
                            break;
                        case 9:
                            if (button9.Text == "")
                            {
                                button9.Text = "O";
                                turn = true;
                            }
                            break;
                    }
                }            
            } 
        }

        public Game()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                button1.Text = "X";
                WIN();
                Computer();
                WIN();
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                button2.Text = "X";
                WIN();
                Computer();
                WIN();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "")
            {
                button3.Text = "X";
                WIN();
                Computer();
                WIN();
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "")
            {
                button4.Text = "X";
                WIN();
                Computer();
                WIN();
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "")
            {
                button5.Text = "X";
                WIN();
                Computer();
                WIN();
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "")
            {
                button6.Text = "X";
                WIN();
                Computer();
                WIN();
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "")
            {
                button7.Text = "X";
                WIN();
                Computer();
                WIN();
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "")
            {
                button8.Text = "X";
                WIN();
                Computer();
                WIN();
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "")
            {
                button9.Text = "X";
                WIN();
                Computer();
                WIN();
            }
            
        }

    }
}
