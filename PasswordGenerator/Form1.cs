using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generatebutton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            char[] input = charsinput.Text.ToCharArray();
            char[] chars = input.GroupBy(n => n).Where(g => g.Count() >= 1).Select(g => g.Key).ToArray();

            int numberOfchars = numberofchars.Value;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < numberOfchars; i++)
            {
                sb.Append(chars[random.Next(chars.Length)]);
            }

            result.Text = sb.ToString();

            ulong numberofcombinations = (ulong)Math.Pow(chars.Length, numberOfchars);

            ulong timeofbrutforse = (ulong)(numberofcombinations /(6*4* Math.Pow(10,9)));

            textBox1.Text = numberofcombinations.ToString();
            textBox2.Text = timeofbrutforse.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
