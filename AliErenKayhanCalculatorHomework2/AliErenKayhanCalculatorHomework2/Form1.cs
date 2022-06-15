using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AliErenKayhanCalculatorHomework2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            String FirstValue;
            String SecondValue;
            FirstValue = textBox1.Text;
            SecondValue = textBox2.Text;
            string message;
            string message2;
            string message3;
            string title = "!!!!Warning!!!!!";
             try
                {
                     double firstdoubleValue = double.Parse(FirstValue);
                        try
                        {
                    double seconddoubleValue = double.Parse(SecondValue);
                    double result;
                    if (comboBox1.SelectedItem == "+")
                    {
                        result = firstdoubleValue + seconddoubleValue;
                        richTextBox1.Text = "The addition of " + firstdoubleValue + " and " + seconddoubleValue + " is = "+ result.ToString();
                    }
                    if (comboBox1.SelectedItem == "-")
                    {
                        result = firstdoubleValue - seconddoubleValue;
                        richTextBox1.Text = "The subtraction of " + firstdoubleValue + " and " + seconddoubleValue + " is = " + result.ToString();
                    }
                    if (comboBox1.SelectedItem == "x")
                    {
                        result = firstdoubleValue * seconddoubleValue;
                        richTextBox1.Text = "The multiplication of " + firstdoubleValue + " and " + seconddoubleValue + " is = " + result.ToString();
                    }
                    if (comboBox1.SelectedItem == "/")
                    {
                        result = firstdoubleValue / seconddoubleValue;
                        if (firstdoubleValue != 0 && seconddoubleValue == 0) // for the situation of number / 0
                        {
                            MessageBox.Show("The division of " + firstdoubleValue + " and " + seconddoubleValue + " is = Infinity\n" +
                                                   "Because you are trying to divide a number except 0 to 0.", title);
                            richTextBox1.Text = "The division of " + firstdoubleValue + " and " + seconddoubleValue + " is =  Infinity\n" +
                                                "Because you are trying to divide a number except 0 to 0.";
                            
                        }
                        if (firstdoubleValue == 0 && seconddoubleValue == 0) // for the situation of 0 / 0
                        {
                             MessageBox.Show("The division of " + firstdoubleValue + " and " + seconddoubleValue + " is = Error\n" +
                                                 "Warning!!!!You are trying to divide 0 to 0.", title);
                             richTextBox1.Text = "The division of " + firstdoubleValue + " and " + seconddoubleValue + " is =  Error\n" +
                                                  "Warning!!!! You are trying to divide 0 to 0.";
                        }
                        else
                        {
                            richTextBox1.Text = "The division of " + firstdoubleValue + " and " + seconddoubleValue + " is = " + result.ToString();

                        }
                    }


                }
                        catch (Exception ex)
                        {
                            richTextBox1.BackColor = Color.Red;
                            textBox2.BackColor = Color.Red;
                            message2 = "Wrong type data FOR NUMBER 2!! " +
                                         "\nPlease enter again.";
                            MessageBox.Show(message2, title);
                        }
               
                /* This code gives Error when the user doesn't select the operation.  
                 if (comboBox1.SelectedItem != "+" || comboBox1.SelectedItem != "-" ||
                    comboBox1.SelectedItem != "/" || comboBox1.SelectedItem != "x")
                {
                    message3 = "Select your operation, please.";
                    MessageBox.Show(message3, title);

                }
               */

            }
            catch (Exception ex)
                {
                    richTextBox1.BackColor = Color.Red;
                    textBox1.BackColor = Color.Red;
                    message = "Wrong type data FOR NUMBER 1!! " +
                              "\nPlease enter again.";
                    MessageBox.Show(message, title);
                }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.BackColor = Color.White;
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox1.Clear();
            textBox2.Clear();
            string message4;
            string title2 = "Reset";
            message4 = "Calculator is reset.";
            MessageBox.Show(message4, title2);
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = " ";
            textBox1.BackColor = Color.White;

        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = " ";
            textBox2.BackColor = Color.White;

        }

        private void richTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBox1.BackColor = Color.White;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
