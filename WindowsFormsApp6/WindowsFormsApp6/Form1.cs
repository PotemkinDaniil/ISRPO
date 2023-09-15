using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Сработала левая кнопка";
            label1.ForeColor = Color.DarkBlue;
            label1.TextAlign = ContentAlignment.MiddleLeft;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Сработала правая кнопка";
            label1.ForeColor = Color.DarkRed;
            label1.TextAlign = ContentAlignment.MiddleRight;
        }
    }
}
