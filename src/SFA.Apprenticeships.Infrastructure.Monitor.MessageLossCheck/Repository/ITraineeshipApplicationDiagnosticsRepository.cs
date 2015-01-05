﻿namespace SFA.Apprenticeships.Infrastructure.Monitor.MessageLossCheck.Repository
{
    using System.Collections.Generic;
    using Domain.Entities.Applications;

    public interface ITraineeshipApplicationDiagnosticsRepository
    {
        IEnumerable<TraineeshipApplicationDetail> GetApplicationsForValidCandidatesWithUnsetLegacyId();
    }
}