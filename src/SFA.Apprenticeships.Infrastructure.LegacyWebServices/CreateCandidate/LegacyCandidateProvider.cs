﻿namespace SFA.Apprenticeships.Infrastructure.LegacyWebServices.CreateCandidate
{
    using System;
    using System.Linq;
    using Application.Candidate.Strategies;
    using GatewayServiceProxy;
    using NLog;
    using Wcf;
    using Candidate = Domain.Entities.Candidates.Candidate;

    public class LegacyCandidateProvider : ILegacyCandidateProvider
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        private readonly IWcfService<GatewayServiceContract> _service;

        public LegacyCandidateProvider(IWcfService<GatewayServiceContract> service)
        {
            _service = service;
        }

        public int CreateCandidate(Candidate candidate)
        {
            Logger.Info("CreateCandidate handled for EntityId={0}, EmailAddress={1}", candidate.EntityId, candidate.RegistrationDetails.EmailAddress);
            var request = new CreateCandidateRequest
            {
                Candidate = new GatewayServiceProxy.Candidate
                {
                    EmailAddress = candidate.RegistrationDetails.EmailAddress,
                    FirstName = candidate.RegistrationDetails.FirstName,
                    MiddleName = candidate.RegistrationDetails.MiddleNames,
                    Surname = candidate.RegistrationDetails.LastName,
                    DateOfBirth = candidate.RegistrationDetails.DateOfBirth.Date,
                    AddressLine1 = candidate.RegistrationDetails.Address.AddressLine1,
                    AddressLine2 = candidate.RegistrationDetails.Address.AddressLine2,
                    AddressLine3 = candidate.RegistrationDetails.Address.AddressLine3,
                    AddressLine4 = candidate.RegistrationDetails.Address.AddressLine4,
                    TownCity = "N/A",
                    Postcode = candidate.RegistrationDetails.Address.Postcode,
                    LandlineTelephone = candidate.RegistrationDetails.PhoneNumber,
                    MobileTelephone = string.Empty
                }
            };

            var response = default(CreateCandidateResponse);
            _service.Use(client => response = client.CreateCandidate(request));

            if (response == null || (response.ValidationErrors != null && response.ValidationErrors.Any()))
            {
                if (response != null)
                {
                    Logger.Error("Legacy CreateCandidate reported {0} validation errors", response.ValidationErrors.Count());
                }
                else
                {
                    Logger.Error("Legacy CreateCandidate did not respond");
                }
                // TODO: EXCEPTION: should use an application exception type
                throw new Exception("Failed to create candidate in legacy system");
            }

            var legacyCandidateId = response.CandidateId;

            Logger.Info("Candidate was successfully created on Legacy web service. LegacyCandidateId={0} ", legacyCandidateId);

            return legacyCandidateId;
        }
    }
}
