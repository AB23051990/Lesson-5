using FluentValidation;
using HW3.Requests;

namespace HW3.Validation.Requests
{
    public interface IGetPersonsByIdValidator : IValidationService<GetPersonsByIdRequest>
    {

    }

    internal sealed class GetPersonsByIdValidator : FluentValidationService<GetPersonsByIdRequest>, IGetPersonsByIdValidator
    {
        public GetPersonsByIdValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0)
                .WithErrorCode("BRL-112.1");
        }
    }
}
