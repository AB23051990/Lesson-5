using FluentValidation;
using HW3.Requests;

namespace HW3.Validation.Requests
{
    public interface ICreatePersonsValidator : IValidationService<CreatePersonsRequest>
    {

    }

    internal sealed class CreatePersonsValidator : FluentValidationService<CreatePersonsRequest>, ICreatePersonsValidator
    {
        public CreatePersonsValidator()
        {
            RuleFor(x => x.Name)
                .Length(3, 20)
                .WithErrorCode("BRL-110.1");
        }
    }
}
