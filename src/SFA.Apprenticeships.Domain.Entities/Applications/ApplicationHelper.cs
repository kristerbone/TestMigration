﻿namespace SFA.Apprenticeships.Domain.Entities.Applications
{
    using System;
    using Exceptions;
    using System.Linq;

    public static class ApplicationHelper
    {
        public static void AssertState(this ApplicationDetail applicationDetail, string errorMessage, params ApplicationStatuses[] allowedUserStatuses)
        {
            if (!allowedUserStatuses.Contains(applicationDetail.Status))
            {
                throw new CustomException(errorMessage, ErrorCodes.ApplicationInIncorrectStateError);
            }
        }

        public static void SetStateSubmitting(this ApplicationDetail applicationDetail)
        {
            applicationDetail.Status = ApplicationStatuses.Submitting;
            applicationDetail.DateApplied = DateTime.UtcNow;
        }

        public static void SetStateSubmitted(this ApplicationDetail applicationDetail)
        {
            applicationDetail.Status = ApplicationStatuses.Submitted;
        }
    }
}