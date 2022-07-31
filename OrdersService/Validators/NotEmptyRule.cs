using System.Globalization;
using System.Windows.Controls;

namespace OrdersService.Validators
{
    public class NotEmptyRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
                if (string.IsNullOrEmpty((string)value))
                    return new ValidationResult(false, "Value cannot be null");
                else return ValidationResult.ValidResult;
        }
    }
}
