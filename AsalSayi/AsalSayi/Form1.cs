using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsalSayi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 0; i <= 125074; i++)
            {
                int kontrol = 0;

                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        kontrol++;
                    }
                }
                if (kontrol == 2)
                {
                    listBox1.Items.Add(i);
                    label1.Text = listBox1.Items.Count.ToString() + " Tane asal sayı vardır.";
                }

            }
        }
    }
}
