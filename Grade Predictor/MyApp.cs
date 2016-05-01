using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grade_Predictor
{
    public partial class MyApp : Form
    {
        public MyApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button1.Visible = false;
            //button2.Visible = false;
            //button3.Visible = false;
            //label1.Visible = true;
            //textBox1.Visible = true;
            HideControl(new List<Control> { button2, button2 });
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void HideControl(List<Control> c)
        {
            foreach (var controle in c)
            {
                controle.Visible = false;
            }
        }
    }
}
