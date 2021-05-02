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
        int tempindex = 0;
        int pos = -1;
        int flagfound = 0;
        public Form1()
        {
            InitializeComponent();
            this.Text = "MSA";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string paragraph = richTextBox1.Text;

            string word = textBox1.Text;
            for (int i = 0; i < paragraph.Length; i++)
            {
                tempindex = i;
                for (int j = 0; j < word.Length; j++)
                {
                    if (paragraph[tempindex] == word[j])
                    {
                        if (j == 0)
                        {
                            pos = tempindex;
                        }
                        tempindex++;

                        if (j == (word.Length - 2))
                        {
                            flagfound = 1;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                if (flagfound == 1)
                {
                    break;
                }
            }

                if (flagfound == 1)
                {
                    richTextBox1.SelectionStart = pos;
                    richTextBox1.SelectionLength = word.Length;
                    richTextBox1.SelectionBackColor = Color.Red;

                }
                else
                {
                    MessageBox.Show("No match found");
                }
            }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    }


