using System.Text.RegularExpressions;

namespace LAB07
{
    public class ValidationHelper
    {
        public static bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^\s@]+@[^\s@]+\.[^\s@]+$");
        }
        public static bool IsValidPhone(string phone)
        {
            return Regex.IsMatch(phone, "^\\d{9,15}$");
        }
    }
}