﻿namespace SFA.Apprenticeships.Web.Candidate.Mappers.Resolvers
{
    using AutoMapper;
    using Domain.Entities.Applications;
    using Domain.Entities.Candidates;
    using Domain.Entities.Locations;
    using Domain.Entities.Vacancies;
    using Helpers;
    using ViewModels.Applications;
    using ViewModels.Candidate;
    using ViewModels.VacancySearch;

    public class ApplicationViewModelToApplicationDetailResolver :
        ITypeConverter<ApplicationViewModel, ApplicationDetail>
    {
        public ApplicationDetail Convert(ResolutionContext context)
        {
            var model = (ApplicationViewModel) context.SourceValue;

            var application = new ApplicationDetail
            {
                CandidateId = model.Candidate.Id,
                Vacancy = GetVacancy(model.VacancyDetail),
                CandidateDetails = GetCandidateDetails(model.Candidate),
                CandidateInformation = GetCandidateInformation(model.Candidate),
                AdditionalQuestion1Answer = model.Candidate.EmployerQuestionAnswers.CandidateAnswer1,
                AdditionalQuestion2Answer = model.Candidate.EmployerQuestionAnswers.CandidateAnswer2
            };

            return application;
        }

        private static ApplicationTemplate GetCandidateInformation(CandidateViewModel model)
        {
            return new ApplicationTemplate
            {
                AboutYou = ApplicationConverter.GetAboutYou(model.AboutYou),
                EducationHistory = ApplicationConverter.GetEducation(model.Education),
                Qualifications = ApplicationConverter.GetQualifications(model.Qualifications),
                WorkExperience = ApplicationConverter.GetWorkExperiences(model.WorkExperience),
            };
        }

        private static RegistrationDetails GetCandidateDetails(CandidateViewModel model)
        {
            return new RegistrationDetails
            {
                EmailAddress = model.EmailAddress,
                Address = ApplicationConverter.GetAddress(model.Address),
                DateOfBirth = model.DateOfBirth,
                PhoneNumber = model.PhoneNumber,
                FirstName = model.FirstName,
                LastName = model.LastName,
            };
        }

        private static VacancySummary GetVacancy(VacancyDetailViewModel model)
        {
            return new VacancySummary
            {
                Id = model.Id,
                ClosingDate = model.ClosingDate,
                Description = model.Description,
                EmployerName = model.EmployerName,
                Location = new GeoPoint
                {
                    Longitude = model.VacancyAddress.GeoPoint.Longitude,
                    Latitude = model.VacancyAddress.GeoPoint.Latitude
                },
                Title = model.Title,
            };
        }
    }
}