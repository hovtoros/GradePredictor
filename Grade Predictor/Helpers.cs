using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grade_Predictor.Models
{
    public class Helpers
    {
        public static void HideControl(List<Control> c) // function to hide a container
        {
            foreach (var control in c)
            {
                control.Visible = false;
            }
        }

        public static void ShowControl(List<Control> c) // function to show a container
        {
            foreach (var control in c)
            {
                control.Visible = true;
            }
        }

        public static bool IsValidGrade(int value)
        {
            if (value < 0 || value > 100)
            {
                return false;
            }
            return true;
        }

        public static bool IsValidSbNum(int value, int number)
        {
            if (value < 0 || value > number)
            {
                return false;
            }
            return true;
        }

        //public static bool IsClicked(Button btn)
        //{
        //    return false;
        //}
    }
}
