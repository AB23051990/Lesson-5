using FluentValidation;
using HW3.Requests;

namespace HW3.Validation.Requests
{
    public interface IDeletePersonsValidator : IValidationService<DeletePersonsRequest>
    {

    }

    internal sealed class DeletePersonsValidator : FluentValidationService<DeletePersonsRequest>, IDeletePersonsValidator
    {
        public DeletePersonsValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0)
                .WithErrorCode("BRL-111.1");
        }
    }
}
