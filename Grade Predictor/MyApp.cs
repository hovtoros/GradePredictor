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
            HideControl(new List<Control> { freshman_button, sophomore_button, junior_button, senior_button, core_button, foundamental_button, elective_button });
        }

        private void HideControl(List<Control> c) // function to hide a container
        {
            foreach (var control in c)
            {
                control.Visible = false;
            }
        }

        private void ShowControl(List<Control> c) // function to show a container
        {
            foreach (var control in c)
            {
                control.Visible = true;
            }
        }

        private void CS_button_Click(object sender, EventArgs e)
        {
            HideControl(new List<Control> { CS_button, BUS_button, EC_button });
            ShowControl(new List<Control> { freshman_button, sophomore_button, junior_button, senior_button});
        }

        private void BUS_button_Click(object sender, EventArgs e)
        {
            HideControl(new List<Control> { CS_button, BUS_button, EC_button });
            ShowControl(new List<Control> { freshman_button, sophomore_button, junior_button, senior_button });
        }

        private void EC_button_Click(object sender, EventArgs e)
        {
            HideControl(new List<Control> { CS_button, BUS_button, EC_button });
            ShowControl(new List<Control> { freshman_button, sophomore_button, junior_button, senior_button });
        }

        private void core_button_Click(object sender, EventArgs e)
        {

        }

        private void freshman_button_Click(object sender, EventArgs e)
        {
            var myForm = new CS_Form();
            myForm.ShowDialog();
        }
    }
}
