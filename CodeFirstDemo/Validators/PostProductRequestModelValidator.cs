using CodeFirstDemo.RequestModels;
using FluentValidation;

namespace CodeFirstDemo.Validators;

public class PostProductRequestModelValidator : AbstractValidator<PostProductRequestModel>
{
    public PostProductRequestModelValidator()
    {
        RuleFor(x => x.Name)
            .NotNull().NotEmpty().WithMessage("Nazwa jest wymagana.")
            .MaximumLength(100).WithMessage("Nazwa może mieć maksymalnie 50 znaków.");

        RuleFor(x => x.Weight)
            .GreaterThan(0).WithMessage("Waga musi być większa od zera.")
            .PrecisionScale(5, 2, true).WithMessage("Waga musi zawierać maksymalnie 5 cyfr przed przecinkiem i 2 po przecinku.");

        RuleFor(x => x.Width)
            .GreaterThan(0).WithMessage("Szerokość musi być większa od zera.")
            .PrecisionScale(5, 2, true).WithMessage("Szerokość musi zawierać maksymalnie 5 cyfr przed przecinkiem i 2 po przecinku.");


        RuleFor(x => x.Height)
            .GreaterThan(0).WithMessage("Wysokość musi być większa od zera.")
            .PrecisionScale(5, 2, true).WithMessage("Wysokość musi zawierać maksymalnie 5 cyfr przed przecinkiem i 2 po przecinku.");


        RuleFor(x => x.Depth)
            .GreaterThan(0).WithMessage("Głębokość musi być większa od zera.")
            .PrecisionScale(5, 2, true).WithMessage("Głębokość musi zawierać maksymalnie 5 cyfr przed przecinkiem i 2 po przecinku.");

    }
}