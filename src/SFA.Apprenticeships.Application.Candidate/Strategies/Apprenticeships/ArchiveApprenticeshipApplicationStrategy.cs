namespace SFA.Apprenticeships.Application.Candidate.Strategies.Apprenticeships
{
    using System;
    using Domain.Interfaces.Repositories;

    public class ArchiveApprenticeshipApplicationStrategy : IArchiveApplicationStrategy
    {
        private readonly IApprenticeshipApplicationReadRepository _apprenticeshipApplicationReadRepository;
        private readonly IApprenticeshipApplicationWriteRepository _apprenticeshipApplicationWriteRepository;

        public ArchiveApprenticeshipApplicationStrategy(IApprenticeshipApplicationReadRepository apprenticeshipApplicationReadRepository,
            IApprenticeshipApplicationWriteRepository apprenticeshipApplicationWriteRepository)
        {
            _apprenticeshipApplicationReadRepository = apprenticeshipApplicationReadRepository;
            _apprenticeshipApplicationWriteRepository = apprenticeshipApplicationWriteRepository;
        }

        public void ArchiveApplication(Guid applicationId)
        {
            var applicationDetail = _apprenticeshipApplicationReadRepository.Get(applicationId, true);

            if (applicationDetail.IsArchived) return;

            applicationDetail.IsArchived = true;
            _apprenticeshipApplicationWriteRepository.Save(applicationDetail);
        }
    }
}