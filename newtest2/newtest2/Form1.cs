using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace newtest2
{
    public partial class Form1 : Form
    {
        Graphics g;
        Color lineColor = Color.Red;
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            g.Clear(BackColor);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fileOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void colorOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            colorDialog1.ShowDialog();
            menuStrip1.BackColor = colorDialog1.Color;
            lineColor = colorDialog1.Color;
            g.DrawLine(new Pen(lineColor), button1.Location.X + button1.Width / 2, button1.Location.Y + button1.Height, button2.Location.X + button2.Width / 2, button2.Location.Y);
        }

        private void disappearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            menuStrip1.Visible = true;
        }

        private void backgroundStartupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Process.Start();
        }

        private void drawLinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //between button1 and 2
            g.DrawLine(new Pen(lineColor), button1.Location.X + button1.Width / 2, button1.Location.Y + button1.Height, button2.Location.X + button2.Width / 2, button2.Location.Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
