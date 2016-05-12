using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Grade_Predictor.Models;

namespace Grade_Predictor
{
    public partial class MyApp : Form
    {
        Student _student = new Student();

        public MyApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Helpers.HideControl(new List<Control> { core_button, foundamental_button, elective_button, next, back });
        }


        private void CS_button_Click(object sender, EventArgs e)
        {
            _student.Department = "CS";
            CS_button.BackColor = Color.Salmon;
            Helpers.HideControl(new List<Control> { BUS_button, EC_button });
            Helpers.ShowControl(new List<Control> { core_button, foundamental_button, elective_button });
        }

        private void BUS_button_Click(object sender, EventArgs e)
        {
            _student.Department = "BUS";
            BUS_button.BackColor = Color.Salmon;
            Helpers.HideControl(new List<Control> { CS_button, EC_button });
            Helpers.ShowControl(new List<Control> { core_button, foundamental_button, elective_button });
        }

        private void EC_button_Click(object sender, EventArgs e)
        {
            _student.Department = "EC";
            EC_button.BackColor = Color.Salmon;
            Helpers.HideControl(new List<Control> { CS_button, BUS_button });
            Helpers.ShowControl(new List<Control> { core_button, foundamental_button, elective_button });
        }

        private void core_button_Click(object sender, EventArgs e)
        {
            //_student._Course.Type = "Core";
            core_button.BackColor = Color.SandyBrown;
            Helpers.HideControl(new List<Control> { foundamental_button, elective_button });
            Helpers.ShowControl(new List<Control> { core_button, next, back });
        }

        private void foundamental_button_Click(object sender, EventArgs e)
        {
            //_student._Course.Type = "Foundamental";
            foundamental_button.BackColor = Color.SandyBrown;
            Helpers.HideControl(new List<Control> { core_button, elective_button });
            Helpers.ShowControl(new List<Control> { foundamental_button, next, back });
        }

        private void elective_button_Click(object sender, EventArgs e)
        {
            //_student._Course.Type = "Elective";
            elective_button.BackColor = Color.SandyBrown;
            Helpers.HideControl(new List<Control> { foundamental_button, core_button });
            Helpers.ShowControl(new List<Control> { elective_button, next, back });
        }

        private void next_Click(object sender, EventArgs e)
        {
            var myForm = new CS_Form();
            myForm.ShowDialog();
            //var myForm = new CS_Form(_student);
            //myForm.ShowDialog();
        }

        private void back_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ExecutablePath);
            this.Close();
        }
    }
}
