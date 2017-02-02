using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engine.Engine
{
    static class ValidationUtil
    {
        public static bool cmb_Validator(object sender, ErrorProvider errorProvider)
        {
            bool isValid = false;
            ComboBox subject = (ComboBox)sender;

            if (subject.SelectedItem == null)
            {
                errorProvider.SetError(subject, "Please select from the drop down list!");
            }
            else
            {
                errorProvider.SetError(subject, "");
                isValid = true;
            }
            return isValid;
        }

        public static bool txt_Validator(object sender, ErrorProvider errorProvider)
        {
            bool isValid = false;
            TextBox subject = (TextBox)sender;

            if (String.IsNullOrEmpty(subject.Text))
            {
                errorProvider.SetError(subject, "Feild is required!");
            }
            else
            {
                errorProvider.SetError(subject, "");
                isValid = true;
            }
            return isValid;
        }

        public static bool real_Validator(object sender, ErrorProvider errorProvider)
        {
            bool isValid = false;
            TextBox subject = (TextBox)sender;

            if (String.IsNullOrEmpty(subject.Text))
            {
                errorProvider.SetError(subject, "Feild is required!");
            }
            else if (!Regex.IsMatch(subject.Text, @"[0-9]"))
            {
                errorProvider.SetError(subject, "Invalid value! Please enter a numeric value.");
            }
            else
            {
                errorProvider.SetError(subject, "");
                isValid = true;
            }
            return isValid;
        }

        public static bool double_Validator(object sender, ErrorProvider errorProvider)
        {
            bool isValid = false;
            TextBox subject = (TextBox)sender;

            if (String.IsNullOrEmpty(subject.Text))
            {
                errorProvider.SetError(subject, "Feild is required!");
            }
            else
            {
                double result;
                if (!double.TryParse(subject.Text, out result))
                {
                    errorProvider.SetError(subject, "Invalid value!");
                }
                else
                {
                    errorProvider.SetError(subject, "");
                    isValid = true;
                }
            }
            return isValid;
        }

        public static bool period_Validator(DateTimePicker start, DateTimePicker end, ErrorProvider errorProvider)
        {
            bool isValid = false;
            if (end.Value < start.Value)
            {
                errorProvider.SetError(end, "Invalid value! End date occur before start date");
            }
            else
            {
                errorProvider.SetError(end, "");
                isValid = true;
            }
            return isValid;
        }
    }
}
