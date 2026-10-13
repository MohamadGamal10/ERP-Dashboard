using FluentValidation;

namespace ERP_Dashboard.Core.Features.Suppliers.Commands
{
    public class CreateSupplierCommandValidator : AbstractValidator<CreateSupplierCommand>
    {
        public CreateSupplierCommandValidator()
        {
            RuleFor(x => x.CompanyName).NotEmpty().WithMessage("CompanyName is required");
            RuleFor(x => x.ContactName).NotEmpty().WithMessage("ContactName is required");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email is required").EmailAddress().WithMessage("Invalid email format");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Phone is required");
            RuleFor(x => x.PaymentTerms).NotEmpty().WithMessage("PaymentTerms is required");
        }
    }
}
