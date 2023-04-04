using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Tema1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Patern string
            string pattern = textBox1.Text;

            // String in wich pattern is being found
            string Text = textBox2.Text;

            // Print amonth of times pattern has been found and a massage for when its not found
            Match m = Regex.Match(Text, pattern, RegexOptions.IgnoreCase);

            if (m.Success)
            {
                Answer.Items.Add("Pattern  " + m.Value + "has been found at position " + m.Index);
            }

            else
            {
                Answer.Items.Add("Pattern hasn't been found");
            }

        }
        
    }
}
