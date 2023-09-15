using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
       

    {
        int n = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (n % 2 == 0)
            {
                label1.ForeColor = Color.Yellow;
                button1.BackColor = Color.Red;
                n++;
            }
            else if (n % 2 != 0)
            {
                label1.ForeColor = Color.Pink;
                button1.BackColor = Color.DarkBlue;
                n++;
            }
            label1.Top += 5;
            label1.Text = "Нажмите на кнопочку " + n;
            


        }
    }
}
