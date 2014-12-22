﻿namespace SFA.Apprenticeships.Application.Candidate.Strategies.Traineeships
{
    using System;
    using System.Collections.Generic;
    using Domain.Entities.Applications;
    using Domain.Interfaces.Repositories;
    using NLog;

    public class LegacyGetCandidateTraineeshipApplicationsStrategy : IGetCandidateTraineeshipApplicationsStrategy
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        private readonly ITraineeshipApplicationReadRepository _traineeshipApplicationReadRepository;

        public LegacyGetCandidateTraineeshipApplicationsStrategy(
            ITraineeshipApplicationReadRepository traineeshipApplicationReadRepository)
        {
            _traineeshipApplicationReadRepository = traineeshipApplicationReadRepository;
        }

        public IList<TraineeshipApplicationSummary> GetApplications(Guid candidateId)
        {
            return _traineeshipApplicationReadRepository.GetForCandidate(candidateId);
        }
    }
}