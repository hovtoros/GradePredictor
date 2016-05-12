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
        Student _student;

        public CS_Form()
        {
            InitializeComponent();
        }

        public CS_Form(Student _student)
        {
            this._student = _student;
        }

        private void CS_core_Form_Load(object sender, EventArgs e)
        {
            Helpers.HideControl(new List<Control> { grade_label, grade_text, grade_quest, next2, back1, back2, close });
        }

        #region Navigation buttons

        private void next1_Click(object sender, EventArgs e)
        {
            Helpers.HideControl(new List<Control> { hw_label, hw_descript1, hw_descript2, hw_text, sb_hw_text,qz_label,qz_descript1, qz_descript2, qz_text, sb_qz_text, mdt_label, mdt_descript1, mdt_descript2, md_text, sb_md_text, fnl_label, fnl_text, next1 });
            Helpers.ShowControl(new List<Control> { grade_label, grade_text, grade_quest, next2, back1 });
        }
        private void next2_Click(object sender, EventArgs e)
        {
            Helpers.HideControl(new List<Control> { grade_label, grade_text, grade_quest, next2, back1 });
            Helpers.ShowControl(new List<Control> { back2, close });
            label2.Text = "olaaaa";
        }

        private void back1_Click(object sender, EventArgs e)
        {
            Helpers.ShowControl(new List<Control> { hw_label, hw_descript1, hw_descript2, hw_text, sb_hw_text, qz_label, qz_descript1, qz_descript2, qz_text, sb_qz_text, mdt_label, mdt_descript1, mdt_descript2, md_text, sb_md_text, fnl_label, fnl_text, next1 });
            Helpers.HideControl(new List<Control> { grade_label, grade_text, grade_quest, next2, back1 });
        }
        private void back2_Click(object sender, EventArgs e)
        {
            Helpers.ShowControl(new List<Control> { grade_label, grade_text, grade_quest, next2, back1 });
            Helpers.HideControl(new List<Control> { back2, close });
        }
        private void finish_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Textboxes

        private void hw_text_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _student._Course._Grade.In_Grade.Homework = int.Parse(hw_text.Text);
                hw_label.ForeColor = Color.Black;

            }
            catch
            {
                if(_student._Course._Grade.In_Grade.Sb_Hw == 0)
                {
                    _student._Course._Grade.In_Grade.Homework.Equals(0);
                    hw_label.ForeColor = Color.Gray;
                }
                else
                {
                    hw_label.ForeColor = Color.Red;
                }
            }
        }

        private void hw_text_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (!Helpers.IsValidGrade(_student._Course._Grade.In_Grade.Homework))
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

        private void sb_hw_text_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _student._Course._Grade.In_Grade.Sb_Hw = int.Parse(sb_hw_text.Text);
                hw_descript1.ForeColor = Color.Black;

            }
            catch
            {
                hw_descript1.ForeColor = Color.Red;
            }
            //if(_inputGrade.Sb_Hw == 0)
            //{
            //    hw_label.ForeColor = Color.Gray;
            //}
            //else
            //{
            //    hw_label.ForeColor = Color.Black;
            //}
        }

        private void sb_hw_text_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (!Helpers.IsValidSbNum(_student._Course._Grade.In_Grade.Sb_Hw, 10))
                {
                    e.Cancel = true;
                    hw_descript1.ForeColor = Color.Red;
                }
            }
            catch
            {
                hw_descript1.ForeColor = Color.Red;
            }
        }

        private void qz_text_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _student._Course._Grade.In_Grade.Quiz = int.Parse(qz_text.Text);
                qz_label.ForeColor = Color.Black;

            }
            catch
            {
                qz_label.ForeColor = Color.Red;
            }
        }
        private void qz_text_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (!Helpers.IsValidGrade(_student._Course._Grade.In_Grade.Quiz))
                {
                    e.Cancel = true;
                    qz_label.ForeColor = Color.Red;
                }
            }
            catch
            {
                qz_label.ForeColor = Color.Red;
            }
        }

        private void sb_qz_text_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _student._Course._Grade.In_Grade.Sb_Qz = int.Parse(sb_qz_text.Text);
                qz_descript1.ForeColor = Color.Black;

            }
            catch
            {
                qz_descript1.ForeColor = Color.Red;
            }
        }
        private void sb_qz_text_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (!Helpers.IsValidSbNum(_student._Course._Grade.In_Grade.Sb_Qz, 5))
                {
                    e.Cancel = true;
                    qz_descript1.ForeColor = Color.Red;
                }
            }
            catch
            {
                qz_descript1.ForeColor = Color.Red;
            }
        }

        private void md_text_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _student._Course._Grade.In_Grade.Midterm = int.Parse(md_text.Text);
                mdt_label.ForeColor = Color.Black;

            }
            catch
            {
                mdt_label.ForeColor = Color.Red;
            }
        }
        
        private void md_text_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (!Helpers.IsValidGrade(_student._Course._Grade.In_Grade.Midterm))
                {
                    e.Cancel = true;
                    mdt_label.ForeColor = Color.Red;
                }
            }
            catch
            {
                mdt_label.ForeColor = Color.Red;
            }
        }

        private void sb_md_text_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _student._Course._Grade.In_Grade.Sb_Mdt = int.Parse(sb_md_text.Text);
                mdt_descript1.ForeColor = Color.Black;

            }
            catch
            {
                mdt_descript1.ForeColor = Color.Red;
            }
        }
        private void sb_md_text_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (!Helpers.IsValidSbNum(_student._Course._Grade.In_Grade.Sb_Mdt, 2))
                {
                    e.Cancel = true;
                    mdt_descript1.ForeColor = Color.Red;
                }
            }
            catch
            {
                mdt_descript1.ForeColor = Color.Red;
            }
        }

        private void fnl_text_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _student._Course._Grade.In_Grade.Final = int.Parse(fnl_text.Text);
                fnl_label.ForeColor = Color.Black;

            }
            catch
            {
                fnl_label.ForeColor = Color.Red;
            }
        }

        private void fnl_text_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (!Helpers.IsValidGrade(_student._Course._Grade.In_Grade.Final))
                {
                    e.Cancel = true;
                    fnl_label.ForeColor = Color.Red;
                }
            }
            catch
            {
                fnl_label.ForeColor = Color.Red;
            }
        }

        private void grade_text_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _student._Course._Grade.In_Grade.Grade = int.Parse(grade_text.Text);
                grade_label.ForeColor = Color.Black;

            }
            catch
            {
                grade_label.ForeColor = Color.Red;
            }
        }

        private void grade_text_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (!Helpers.IsValidGrade(_student._Course._Grade.In_Grade.Grade))
                {
                    e.Cancel = true;
                    grade_label.ForeColor = Color.Red;
                }
            }
            catch
            {
                grade_label.ForeColor = Color.Red;
            }
        }
        #endregion

        private void CS_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Environment.Exit(0);
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate () { this.Close(); });
        }
    }
}
