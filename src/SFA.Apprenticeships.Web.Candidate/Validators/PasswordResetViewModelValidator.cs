﻿namespace SFA.Apprenticeships.Web.Candidate.Validators
{
    using Constants.Pages;
    using Constants.ViewModels;
    using FluentValidation;
    using ViewModels.Register;

    public class PasswordResetViewModelClientValidator : AbstractValidator<PasswordResetViewModel>
    {
        public PasswordResetViewModelClientValidator()
        {
            this.AddCommonRules();
        }
    }

    public class PasswordResetViewModelServerValidator : AbstractValidator<PasswordResetViewModel>
    {
        public PasswordResetViewModelServerValidator()
        {
            this.AddCommonRules();
            this.AddServerRules();
        }
    }

    public static class PasswordResetViewModelValidatorRules
    {
        public static void AddCommonRules(this AbstractValidator<PasswordResetViewModel> validator)
        {
            validator.RuleFor(x => x.PasswordResetCode)
              .NotEmpty()
              .WithMessage(PasswordResetViewModelMessages.PasswordResetCodeMessages.RequiredErrorText)
              .Length(6, 6)
              .WithMessage(PasswordResetViewModelMessages.PasswordResetCodeMessages.LengthErrorText);

            validator.RuleFor(x => x.Password)
                .Length(8, 127)
                .WithMessage(PasswordResetViewModelMessages.PasswordMessages.LengthErrorText)
                .NotEmpty()
                .WithMessage(PasswordResetViewModelMessages.PasswordMessages.RequiredErrorText)
                .Matches(PasswordResetViewModelMessages.PasswordMessages.WhiteListRegularExpression)
                .WithMessage(PasswordResetViewModelMessages.PasswordMessages.WhiteListErrorText);
        }

        public static void AddServerRules(this AbstractValidator<PasswordResetViewModel> validator)
        {
            validator.RuleFor(x => x.Password)
                .Must(IsPasswordResetSuccessful)
                .WithMessage(PasswordResetPageMessages.FailedPasswordReset);

            validator.RuleFor(x => x.PasswordResetCode)
                .Must(IsPasswordResetCodeInvalid)
                .WithName(PasswordResetPageMessages.InvalidCode);
        }

        private static bool IsPasswordResetCodeInvalid(PasswordResetViewModel model, string passwordResetCode)
        {
            return passwordResetCode != null &&
                   (!string.IsNullOrEmpty(passwordResetCode) && model.IsPasswordResetCodeInvalid);
        }

        private static bool IsPasswordResetSuccessful(PasswordResetViewModel model, string password)
        {
            return password != null && (!string.IsNullOrEmpty(password) && model.IsPasswordResetSuccessful);
        }
    }
}