using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace current_caculator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double U=double.Parse(txtVoltage.Text);
            double R1=double.Parse(txtR1.Text);
            double R2=double.Parse(txtR2.Text);
            double R3=double.Parse(txtR3.Text);
            double R4=double.Parse(txtR4.Text);

           if(txtR1.Text==""||txtR2.Text==""||txtR3.Text==""||txtR4.Text==""||txtVoltage.Text=="")
                {MessageBox.Show("请输入数据");
                return;
                }

           if(U>0 && R1>0 && R2>0 && R3>0 && R4>0)
                {if(radioButton1.Checked)
                    MessageBox.Show
                        ($"Current:{caculate.current1(U,R1,R2,R3,R4)}A \nPower:{caculate.power1(U,R1,R2,R3,R4)}W");
                else
                    MessageBox.Show
                        ($"Current:{caculate.current2(U,R1,R2,R3,R4)}A \nPower:{caculate.power1(U,R1,R2,R3,R4)}W");
                }

           else
               {
                MessageBox.Show("Error");
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtVoltage.Text = "";
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            txtR1.Text = "";
            txtR2.Text = "";
            txtR3.Text = "";
            txtR4.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtVoltage.Text))
            {

            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtVoltage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != (char)('.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)('.') && ((TextBox)sender).Text.IndexOf('.') != -1)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)('.') && ((TextBox)sender).Text == "")
            {
                e.Handled = true;
            }

            if (e.KeyChar != (char)('.') && ((TextBox)sender).Text == "0")
            {
                e.Handled = true;
            }
        }
        private void txtR1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != (char)('.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)('.') && ((TextBox)sender).Text.IndexOf('.') != -1)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)('.') && ((TextBox)sender).Text == "")
            {
                e.Handled = true;
            }

            if (e.KeyChar != (char)('.') && ((TextBox)sender).Text == "0")
            {
                e.Handled = true;
            }
        }
        private void txtR2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != (char)('.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)('.') && ((TextBox)sender).Text.IndexOf('.') != -1)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)('.') && ((TextBox)sender).Text == "")
            {
                e.Handled = true;
            }

            if (e.KeyChar != (char)('.') && ((TextBox)sender).Text == "0")
            {
                e.Handled = true;
            }
        }
        private void txtR3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != (char)('.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)('.') && ((TextBox)sender).Text.IndexOf('.') != -1)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)('.') && ((TextBox)sender).Text == "")
            {
                e.Handled = true;
            }

            if (e.KeyChar != (char)('.') && ((TextBox)sender).Text == "0")
            {
                e.Handled = true;
            }
        }
        private void txtR4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != (char)('.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)('.') && ((TextBox)sender).Text.IndexOf('.') != -1)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)('.') && ((TextBox)sender).Text == "")
            {
                e.Handled = true;
            }

            if (e.KeyChar != (char)('.') && ((TextBox)sender).Text == "0")
            {
                e.Handled = true;
            }
        }
    }
}
