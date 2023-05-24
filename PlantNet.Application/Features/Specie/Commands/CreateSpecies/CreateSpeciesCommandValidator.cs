using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantNet.Application.Features.Specie.Commands.CreateSpecies
{
    public class CreateSpeciesCommandValidator: AbstractValidator<CreateSpeciesCommand>
    {

        public CreateSpeciesCommandValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

            RuleFor(p => p.MinTemp)
                .NotEmpty().WithMessage("{PropertyName} is required.");

            RuleFor(p => p.MaxTemp)
                .GreaterThan(p => p.MinTemp).WithMessage("{PropertyName} must be greater than {ComparisonProperty}");

            RuleFor(p => p.PlantType)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();
        }
    }
}
