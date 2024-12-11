using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Compile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Copy textbox1 into comp string
                string comp = textBox1.Text;
                //set content of textbox1 to array of Character type
                char[] CHCompile = new char[textBox1.TextLength];
                //counter of For cycle
                int i = 0;
                //this 'for' set string into array(this 'for' can not use)
                for (; i < textBox1.Text.Length; i++)
                {
                    //fill array with string
                    CHCompile[i] = Convert.ToChar(textBox1.Text.Substring(i, 1));
                }
                //recognize type of input string
                string type = "";
                //recognize string until character space
                type = textBox1.Text.Substring(0, textBox1.Text.IndexOf(' '));

                // MessageBox.Show(type);
                //show len of string type
                int count = type.Length;
                //MessageBox.Show(count + "");
                //a character for recognize character space
                char CheckSpace = ' ';
                //initialize variable
                string check2 = "";
                //a character after type
                int n = count + 1;
                //this variable checking space charachter
                CheckSpace = Convert.ToChar(textBox1.Text.Substring(count, 1));
                //variable name
                check2 = textBox1.Text.Substring(n, textBox1.TextLength - n);
                //checking equal of statement
                if (!textBox1.Text.Contains('='))
                {
                    
                    //compile ; char in end of statement
                    if (textBox1.Text.Substring(textBox1.TextLength - 1, 1) != ";")
                    {
                        MessageBox.Show("Enter End Of Statement (;)","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    else
                    {
                        //checking type of variable
                        if (type == "string" || type == "int")//|| type == "float")
                        {
                            //check space
                            if (CheckSpace != ' ')
                            {
                                MessageBox.Show("this string is not correctly" + '\n' + "because this variable is not contain A Type !");
                            }
                            //check space
                            else if (CheckSpace == ' ')
                            {
                                //check first char in value of variable
                                char ChrChecked = Convert.ToChar(check2.Substring(0, 1));
                                //ckeching first char in value
                                if (ChrChecked == '0' || ChrChecked == '1' || ChrChecked == '2' || ChrChecked == '3' || ChrChecked == '4' || ChrChecked == '5' || ChrChecked == '6' || ChrChecked == '7' || ChrChecked == '8' || ChrChecked == '9')
                                {
                                    MessageBox.Show("this variable is not correct  because This  variable Started With Number ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                //ckeching first char in value
                                else if (ChrChecked == '#' || ChrChecked == '@' || ChrChecked == '!' || ChrChecked == '~' || ChrChecked == '$' || ChrChecked == '%' || ChrChecked == '^' || ChrChecked == '&' || ChrChecked == '*' || ChrChecked == ';' || ChrChecked == '\'' || ChrChecked == '\"' || ChrChecked == '}' || ChrChecked == '{' || ChrChecked == ']' || ChrChecked == '[' || ChrChecked == '+' || ChrChecked == '\'')
                                {
                                    MessageBox.Show("This Variable Is Not Acsept" + '\n' + "Please Not Enter ~ ! @ # $ % ^ & * Charachter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                //ckeching first char in value
                                else if (check2.Contains(' '))
                                {
                                    MessageBox.Show("this Variable Is Contain Space Character Please Delete it", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                }
                                    //checking ) and (
                                else if (check2.Contains('(') && !check2.Contains(')'))
                                {
                                    MessageBox.Show("please Close The Prantes");
                                }
                                //checking ) and (
                                else if (check2.Contains(')') && !check2.Contains('('))
                                {
                                    MessageBox.Show("please Open The Prantes");
                                }
                                else
                                {
                                    MessageBox.Show("This Variable Acsept", "Accept", MessageBoxButtons.OK, MessageBoxIcon.Question);
                                }

                            }
                        }

                    }
                }
                //-----------------------------------------------------------------------------------
                else if (textBox1.Text.Contains("=") && type == "string")
                {
                    if (textBox1.Text.Substring(textBox1.TextLength - 1, 1) != ";")
                    {
                        MessageBox.Show("enter End Of Statement (;)","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    else
                    {
                        int indexEqual = textBox1.Text.IndexOf('=');
                        CheckSpace = Convert.ToChar(textBox1.Text.Substring(count, 1));
                        if (CheckSpace != ' ')
                        {
                            MessageBox.Show("this string is not correctly" + '\n' + "because this variable is not contain A Type !", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (CheckSpace == ' ')
                        {

                            //MessageBox.Show("Ch2" + check2);
                            char ChrChecked = Convert.ToChar(check2.Substring(0, 1));
                            if (ChrChecked == '0' || ChrChecked == '1' || ChrChecked == '2' || ChrChecked == '3' || ChrChecked == '4' || ChrChecked == '5' || ChrChecked == '6' || ChrChecked == '7' || ChrChecked == '8' || ChrChecked == '9')
                            {
                                MessageBox.Show("this variable is not correct  because This  variable Started With Number ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (ChrChecked == '#' || ChrChecked == '@' || ChrChecked == '!' || ChrChecked == '~' || ChrChecked == '$' || ChrChecked == '%' || ChrChecked == '^' || ChrChecked == '&' || ChrChecked == '*' || ChrChecked == ';' || ChrChecked == '\'' || ChrChecked == '\"' || ChrChecked == '}' || ChrChecked == '{' || ChrChecked == ']' || ChrChecked == '[' || ChrChecked == '+' || ChrChecked == '\'')
                            {
                                MessageBox.Show("This Variable Is Not Acsept" + '\n' + "Please Not Enter ~ ! @ # $ % ^ & * Charachter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (check2.Contains(' '))
                            {
                                MessageBox.Show("this Variable Is Contain Space Character Please Delete it", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else if (check2.Contains('(') && !check2.Contains(')'))
                            {
                                MessageBox.Show("please Close The Prantes", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (check2.Contains(')') && !check2.Contains('('))
                            {
                                MessageBox.Show("please Open The Prantes", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        //else
                        //{
                        check2 = textBox1.Text.Substring(n, textBox1.TextLength - n - indexEqual);

                        //else
                        //{

                        ++indexEqual;
                        string strAfterEqual = textBox1.Text.Substring(indexEqual, (textBox1.TextLength - indexEqual) - 1);
                        //MessageBox.Show("After = is    " + strAfterEqual);
                        //if (strAfterEqual.Substring(0, 1) == "\"" && strAfterEqual.Substring(textBox1.TextLength - 2, 1) == "\"")
                        //MessageBox.Show(textBox1.Text.Substring(textBox1.TextLength - 2, 1).ToString());
                        //MessageBox.Show(strAfterEqual.Substring(0, 1).ToString());
                        if (textBox1.Text.Substring(textBox1.TextLength - 2, 1) == "\"" && strAfterEqual.Substring(0, 1) == "\"")
                        {
                            MessageBox.Show("this variable is Correct");
                        }
                        else if (textBox1.Text.Substring(textBox1.TextLength - 2, 1) != "\"" && strAfterEqual.Substring(0, 1) != "\"")
                        {
                            MessageBox.Show("this variable is not Correct", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        //}
                        //}
                    }
                }
                //----------------------------------------------------------
                else if (textBox1.Text.Contains("=") && type == "int")
                {
                    int indexEqual2 = textBox1.Text.IndexOf('=');
                    ++indexEqual2;
                    string numberAfterEqual = textBox1.Text.Substring(indexEqual2, (textBox1.TextLength - indexEqual2) - 1);
                    if (textBox1.Text.Substring(textBox1.TextLength - 1, 1) != ";")
                    {
                        MessageBox.Show("enter End Of Statement (;)", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (textBox1.Text.Substring(textBox1.TextLength - 1, 1) == ";")
                    {
                        int indexEqual = textBox1.Text.IndexOf('=');
                        CheckSpace = Convert.ToChar(textBox1.Text.Substring(count, 1));
                        if (CheckSpace != ' ')
                        {
                            MessageBox.Show("this string is not correctly" + '\n' + "because this variable is not contain A Type !", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (CheckSpace == ' ')
                        {

                            //MessageBox.Show("Ch2" + check2);
                            char ChrChecked = Convert.ToChar(check2.Substring(0, 1));
                            if (ChrChecked == '0' || ChrChecked == '1' || ChrChecked == '2' || ChrChecked == '3' || ChrChecked == '4' || ChrChecked == '5' || ChrChecked == '6' || ChrChecked == '7' || ChrChecked == '8' || ChrChecked == '9')
                            {
                                MessageBox.Show("this variable is not correct  because This  variable Started With Number ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (ChrChecked == '#' || ChrChecked == '@' || ChrChecked == '!' || ChrChecked == '~' || ChrChecked == '$' || ChrChecked == '%' || ChrChecked == '^' || ChrChecked == '&' || ChrChecked == '*' || ChrChecked == ';' || ChrChecked == '\'' || ChrChecked == '\"' || ChrChecked == '}' || ChrChecked == '{' || ChrChecked == ']' || ChrChecked == '[' || ChrChecked == '+' || ChrChecked == '\'')
                            {
                                MessageBox.Show("This Variable Is Not Acsept" + '\n' + "Please Not Enter ~ ! @ # $ % ^ & * Charachter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (check2.Contains(' '))
                            {
                                MessageBox.Show("this Variable Is Contain Space Character Please Delete it", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else if (check2.Contains('(') && !check2.Contains(')'))
                            {
                                MessageBox.Show("please Close The Prantes", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (check2.Contains(')') && !check2.Contains('('))
                            {
                                MessageBox.Show("please Open The Prantes", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            //else
                            //{
                            else if(textBox1.Text.Contains("\""))
                                {
                                    MessageBox.Show("The Type Of <<int>> not Suported String Type", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            else if (numberAfterEqual.Length > 5 || Convert.ToDouble(numberAfterEqual) > 32678)
                                {
                                    MessageBox.Show("(Type int Suport To -32768-+32767)", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            else //if (numberAfterEqual.Length < 5)
                            {
                                //MessageBox.Show(numberAfterEqual);
                                for (int j = 0; j < numberAfterEqual.Length; j++)
                                {
                                    string chechingType = (numberAfterEqual.Substring(j, 1)).ToString();
                                    if (chechingType != "0" && chechingType != "1" && chechingType != "2" && chechingType != "3" && chechingType != "4" && chechingType != "5" && chechingType != "6" && chechingType != "7" && chechingType != "8" && chechingType != "9")
                                    {
                                        MessageBox.Show("The Type Of <<int>> not Suported String Type", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        break;
                                    }
                                }
                                MessageBox.Show("this variable is correct", "Happy", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            }
                            //else
                            //{
                            //    MessageBox.Show("this variable is correct", "Happy", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            //}
                            
                            
                        }
                    }
                }
                else
                {
                    MessageBox.Show("This Format Of Variable Is Not Acseptable", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception r)
            {
                MessageBox.Show(r.Message, "Exception");
            }
                }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }

     
}
