using FluentValidation;
using ZestMonitor.Api.Data.Entities;
using ZestMonitor.Api.Data.Models;

namespace ZestMonitor.Api.Validation {
    public class ProposalPaymentsValidator : AbstractValidator<ProposalPaymentsModel> {
        public ProposalPaymentsValidator () {

            RuleFor (x => x.Amount).NotNull ().NotEmpty ();
            RuleFor (x => x.ExpectedPayment).NotNull ().NotEmpty ();
            RuleFor (x => x.Hash).NotNull ().NotEmpty ();
            RuleFor (x => x.ShortDescription).NotNull ().NotEmpty ();

        }
    }
}