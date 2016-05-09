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
    public partial class CS_Form : Form
    {
        InputGrade _inputGrade = new InputGrade();

        public CS_Form()
        {
            InitializeComponent();
        }


        private void CS_core_Form_Load(object sender, EventArgs e)
        {
            Helpers.HideControl(new List<Control> { grade_label, grade_text, grade_quest, next2 });
        }

        private void next1_Click(object sender, EventArgs e)
        {
            Helpers.HideControl(new List<Control> { hw_label, hw_descript1, hw_descript2, hw_text, sb_hw_text,qz_label,qz_descript1, qz_descript2, qz_text, sb_qz_text, mdt_label, mdt_descript1, mdt_descript2, md_text, sb_md_text, fnl_label, fnl_text });
            Helpers.ShowControl(new List<Control> { grade_label, grade_text, grade_quest, next2 });
        }

        private void hw_text_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _inputGrade.Homework = int.Parse(hw_text.Text);
                hw_label.ForeColor = Color.Black;

            }
            catch
            {
                hw_label.ForeColor = Color.Red;
            }
        }

        private void hw_text_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (!Helpers.IsValidGrade(int.Parse(hw_text.Text)))
                {
                    e.Cancel = true;
                    hw_label.ForeColor = Color.Red;
                }
            }
            catch
            {
                hw_label.ForeColor = Color.Red;
            }

        }
        #region Text...
        private void sb_hw_text_TextChanged(object sender, EventArgs e)
        {
            _inputGrade.Sb_Hw = int.Parse(sb_hw_text.Text);
        }

        private void qz_text_TextChanged(object sender, EventArgs e)
        {
            _inputGrade.Quiz = int.Parse(qz_text.Text);
        }

        private void sb_qz_text_TextChanged(object sender, EventArgs e)
        {
            _inputGrade.Sb_Qz = int.Parse(sb_qz_text.Text);
        }

        private void md_text_TextChanged(object sender, EventArgs e)
        {
            _inputGrade.Midterm = int.Parse(md_text.Text);
        }

        private void sb_md_text_TextChanged(object sender, EventArgs e)
        {
            _inputGrade.Sb_Mdt = int.Parse(sb_md_text.Text);
        }

        private void fnl_text_TextChanged(object sender, EventArgs e)
        {
            _inputGrade.Final = int.Parse(fnl_text.Text);
        }

        private void grade_text_TextChanged(object sender, EventArgs e)
        {
            _inputGrade.Grade = int.Parse(grade_text.Text);
        }
        #endregion


        private void next2_Click(object sender, EventArgs e)
        {
            Helpers.HideControl(new List<Control> { grade_label, grade_text, grade_quest, next2 });
            label2.Text = "olaaaa";
        }

        private void back1_Click(object sender, EventArgs e)
        {
            Helpers.ShowControl(new List<Control> { hw_label, hw_descript1, hw_descript2, hw_text, sb_hw_text, qz_label, qz_descript1, qz_descript2, qz_text, sb_qz_text, mdt_label, mdt_descript1, mdt_descript2, md_text, sb_md_text, fnl_label, fnl_text });
            Helpers.HideControl(new List<Control> { grade_label, grade_text, grade_quest, next2 });
        }

        private void CS_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
