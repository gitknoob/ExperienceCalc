using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExperienceCalc
{
    public partial class Form1 : Form
    {
        int[] aExpTable = new int[151];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Delerium tells you, "xp for level = xp from last level + level^2"

            int iXP = 0;
            aExpTable[20] = 0;

            for (int i = 21; i <= 150; i++)
            {
                iXP = iXP + (i * i);
                aExpTable[i] = iXP;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                label2.Text =
                    "Experience Required: " +
                    (aExpTable[Int32.Parse(textBox1.Text) + 1] - aExpTable[Int32.Parse(textBox1.Text)]).ToString() + ".";
            } catch { };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
                label5.Text =
                    "Experience Required: " +
                    (aExpTable[Int32.Parse(textBox3.Text)] - aExpTable[Int32.Parse(textBox2.Text)]).ToString() + ".";
            } catch { };
        }
    }
}
