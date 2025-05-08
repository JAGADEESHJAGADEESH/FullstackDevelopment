using DotNetCoreWebAPI.Models;
using FluentValidation;
using System.Text.RegularExpressions;

namespace DotNetCoreWebAPI.Services
{
    public class LoginModelValidator : AbstractValidator<LoginModel>
    {
        public LoginModelValidator()
        {
            RuleFor(x => x.Username).NotEmpty().Length(3, 100);
            RuleFor(x => x.Password).Must(BeAStrongPassword);
        }

        private bool BeAStrongPassword(string password)
        {
            return Regex.IsMatch(password, @"^(?=.*[A-Z])(?=.*\d).{8,}$");
        }
    
    }
}
