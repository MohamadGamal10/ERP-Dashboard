using FluentValidation;

namespace ERP_Dashboard.Core.Features.Categories.Commands
{
    public class EditCategoryCommandValidator : AbstractValidator<EditCategoryCommand>
    {
        public EditCategoryCommandValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("Id must be greater than zero");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required");
        }
    }
}
