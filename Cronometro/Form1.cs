using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cronometro
{
    public partial class cronometro : Form
    {
        int segundos;
        int minutos;
        bool pausa;
        public cronometro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            
            timer1.Start();
            segundos = 10;
            minutos = 0;
            button12.Enabled = true;
            pausa = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            label1.ForeColor = Color.Green;





        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            if (minutos >= 10 && segundos >= 10)
            {
                label1.Text = minutos.ToString() + ':' + segundos.ToString();
            }
            else
            {
                if (minutos >= 10 && segundos < 10)
                {
                    label1.Text = minutos.ToString() + ":0" + segundos.ToString();

                }
                else
                {
                    if (minutos < 10 && segundos >= 10)
                    {
                        label1.Text = '0' + minutos.ToString() + ':' + segundos.ToString();
                    }
                    else
                    {
                        label1.Text = '0' + minutos.ToString() + ":0" + segundos.ToString();
                    }
                }
            }


            if (segundos == 0&&minutos==0)
            {
                timer1.Stop();
                label1.ForeColor = Color.Red;
                button12.Enabled = false;
                pausa = false;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                

            }
            else
            {

                if (minutos >= 1)
                {

                    if (segundos == 0)
                    {

                        minutos += -1;
                        segundos = 59;
                    }
                    else
                    {
                        if (segundos <= 59)
                        {
                            segundos += -1;
                        }


                    }
                }
                else
                {
                    segundos += -1;
                }



                
                
                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            
            segundos = 15;
            minutos = 0;
            timer1.Start();
            
            button12.Enabled = true;
            pausa = false;
            button3.Enabled = false;
            button1.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            label1.ForeColor = Color.Green;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            segundos = 20;
            minutos = 0;
            timer1.Start();
            button12.Enabled = true;
            pausa = false;
            button2.Enabled = false;
            button1.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            label1.ForeColor = Color.Green;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            segundos = 30;
            minutos = 0;
            timer1.Start();
            button12.Enabled = true;
            pausa = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button1.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            label1.ForeColor = Color.Green;
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
            segundos = 50;
            minutos = 0;
            timer1.Start();
            button12.Enabled = true;
            pausa = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button1.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            label1.ForeColor = Color.Green;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            segundos = 0;
            minutos = 1;
            timer1.Start();
            button12.Enabled = true;
            pausa = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button1.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            label1.ForeColor = Color.Green;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            segundos = 0;
            minutos = 5;
            timer1.Start();
            button12.Enabled = true;
            pausa = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button1.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            label1.ForeColor = Color.Green;
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
            segundos = 0;
            minutos = 10;
            timer1.Start();
            button12.Enabled = true;
            pausa = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button1.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            label1.ForeColor = Color.Green;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            segundos = 0;
            minutos = 30;
            timer1.Start();
            button12.Enabled = true;
            pausa = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button1.Enabled = false;
            button10.Enabled = false;
            label1.ForeColor = Color.Green;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            segundos = 0;
            minutos = 60;
            timer1.Start();
            button12.Enabled = true;
            pausa = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button1.Enabled = false;
            label1.ForeColor = Color.Green;
        }

        private void button11_Click(object sender, EventArgs e)
        {


            timer1.Stop();
            label1.Text = "00:00";
            button12.Enabled = false;
            pausa = false;
            button12.Text = "PAUSA";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            label1.ForeColor = Color.Red;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!pausa)
            {
                timer1.Stop();
                if (minutos >= 10 && segundos >= 10)
                {
                    label1.Text = minutos.ToString() + ':' + segundos.ToString();
                   
                }
                else
                {
                    if (minutos >= 10 && segundos < 10)
                    {
                        label1.Text = minutos.ToString() + ":0" + segundos.ToString();

                    }
                    else
                    {
                        if (minutos < 10 && segundos >= 10)
                        {
                            label1.Text = '0' + minutos.ToString() + ':' + segundos.ToString();
                        }
                        else
                        {
                            label1.Text = '0' + minutos.ToString() + ":0" + segundos.ToString();
                        }
                    }
                }
                pausa = true;
                button12.Text = "REANUDAR";
                label1.ForeColor = Color.Blue;
            }
            else
            {
                timer1.Start();
                pausa = false;
                button12.Text = "PAUSA";
                label1.ForeColor = Color.Green;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
            timer1.Enabled = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {

                
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            } 

        }
    }
}
