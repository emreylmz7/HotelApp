using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using HotelProject.WebUI.Dtos.GuestDto;

namespace HotelProject.WebUI.ValidationRules.GuestValidationRules
{
    public class UpdateGuestValidator:AbstractValidator<UpdateGuestDto>
    {
        public UpdateGuestValidator()
        {
            RuleFor(x=>x.Name).NotEmpty().WithMessage("Name field cannot be empty");
            RuleFor(x=>x.Name).MinimumLength(3).WithMessage("Please enter at least 3 characters of data");
            RuleFor(x=>x.Name).MaximumLength(20).WithMessage("Please enter max. 20 characters of data");

            RuleFor(x=>x.Surname).NotEmpty().WithMessage("Surname field cannot be empty");
            RuleFor(x=>x.Surname).MinimumLength(3).WithMessage("Please enter at least 3 characters of data");
            RuleFor(x=>x.Surname).MaximumLength(20).WithMessage("Please enter max. 20 characters of data");

            RuleFor(x=>x.City).NotEmpty().WithMessage("City field cannot be empty");
            RuleFor(x=>x.City).MinimumLength(3).WithMessage("Please enter at least 3 characters of data");
            RuleFor(x=>x.City).MaximumLength(20).WithMessage("Please enter max. 20 characters of data");
        }
    }
}