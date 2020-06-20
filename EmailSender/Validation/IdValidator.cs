using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace EmailSender.Validation
{
    class IdValidator : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            int intValue = 0;
            try
            {
                intValue = Convert.ToInt16(value);
            }
            catch (Exception)
            {
                return new ValidationResult(false, "Enter a value");
            }
            if (intValue < 0) return new ValidationResult(false, "Enter a value grater than 0");
            return ValidationResult.ValidResult;
        }
    }
}
