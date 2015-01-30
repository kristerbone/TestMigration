﻿namespace SFA.Apprenticeships.Application.ApplicationUpdate
{
    using System;
    using Domain.Entities.Applications;
    using Domain.Entities.Vacancies;
    using Domain.Interfaces.Repositories;
    using NLog;

    public class ApplicationVacancyStatusUpdater : IApplicationVacancyStatusUpdater
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        private readonly IApprenticeshipApplicationReadRepository _apprenticeshipApplicationReadRepository;
        private readonly IApprenticeshipApplicationWriteRepository _apprenticeshipApplicationWriteRepository;
        private readonly ITraineeshipApplicationReadRepository _traineeshipApplicationReadRepository;
        private readonly ITraineeshipApplicationWriteRepository _traineeshipApplicationWriteRepository;

        public ApplicationVacancyStatusUpdater(
            IApprenticeshipApplicationWriteRepository apprenticeshipApplicationWriteRepository,
            IApprenticeshipApplicationReadRepository apprenticeshipApplicationReadRepository,
            ITraineeshipApplicationWriteRepository traineeshipApplicationWriteRepository,
            ITraineeshipApplicationReadRepository traineeshipApplicationReadRepository)
        {
            _apprenticeshipApplicationWriteRepository = apprenticeshipApplicationWriteRepository;
            _apprenticeshipApplicationReadRepository = apprenticeshipApplicationReadRepository;
            _traineeshipApplicationWriteRepository = traineeshipApplicationWriteRepository;
            _traineeshipApplicationReadRepository = traineeshipApplicationReadRepository;
        }

        public void Update(Guid candidateId, int vacancyId, VacancyStatuses currentVacancyStatus)
        {
            // Try apprenticeships first, the majority should be apprenticeships.
            var apprenticeshipApplication = _apprenticeshipApplicationReadRepository.GetForCandidate(candidateId, vacancyId);

            if (apprenticeshipApplication != null)
            {
                if (apprenticeshipApplication.VacancyStatus != currentVacancyStatus)
                {
                    apprenticeshipApplication.VacancyStatus = currentVacancyStatus;
                    _apprenticeshipApplicationWriteRepository.Save(apprenticeshipApplication);
                }
            }
            else
            {
                var traineeshipApplication = _traineeshipApplicationReadRepository.GetForCandidate(candidateId, vacancyId);

                if (traineeshipApplication != null)
                {
                    if (traineeshipApplication.VacancyStatus != currentVacancyStatus)
                    {
                        traineeshipApplication.VacancyStatus = currentVacancyStatus;
                        _traineeshipApplicationWriteRepository.Save(traineeshipApplication);
                    }
                }
                else
                {
                    Logger.Warn(
                        "Unable to find apprenticeship or traineeship application for candiate ID {0} with legacy vacancy ID \"{1}\".",
                        candidateId, vacancyId);
                }
            }
        }
    }
}