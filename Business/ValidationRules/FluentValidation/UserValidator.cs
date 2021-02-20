using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.UserFirstName).NotEmpty();
            RuleFor(u => u.UserLastName).NotEmpty();
            RuleFor(u => u.Password).NotEmpty();
            RuleFor(u => u.Password).MinimumLength(6).WithMessage("Şifre en az 6 karakterli olmalıdır");
            RuleFor(u => u.Email).EmailAddress().WithMessage("Geçersiz e-mail adresi");
        }
       
    }
}
