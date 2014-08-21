﻿namespace SFA.Apprenticeships.Web.Candidate.ViewModels.VacancySearch
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Domain.Entities.Applications;
    using Locations;

    [Serializable]
    public class VacancyDetailViewModel
    {
        #region Vacancy

        public int Id { get; set; }

        public string FullVacancyReferenceId
        {
            get { return "VAC" + Id.ToString("D9"); }
        }

        public string Title { get; set; }
        
        public string Description { get; set; }

        public string FullDescription { get; set; }

        public string Framework { get; set; }
        
        public string VacancyType { get; set; }

        [UIHint("Date")]
        [DataType(DataType.DateTime)]
        public DateTime ClosingDate { get; set; }

        public string Wage { get; set; }

        public string WorkingWeek { get; set; }

        #endregion

        #region Employer

        public string EmployerName { get; set; }

        public string EmployerDescription { get; set; }

        public string EmployerWebsite { get; set; }

        public string ExpectedDuration { get; set; }

        public AddressViewModel VacancyAddress { get; set; }

        public string SupplementaryQuestion1 { get; set; }

        public string SupplementaryQuestion2 { get; set; }

        #endregion

        #region Provider

        public string ProviderName { get; set; }

        public string Contact { get; set; }

        public int? ProviderSectorPassRate { get; set; }

        public string TrainingToBeProvided { get; set; }

        #endregion

        #region Candidate

        public string QualificationRequired { get; set; }

        public string SkillsRequired { get; set; }
        
        public string FutureProspects { get; set; }

        public ApplicationStatuses? CandidateApplicationStatus { get; set; }

        [UIHint("Date")]
        [DataType(DataType.DateTime)]
        public DateTime? DateApplied { get; set; }

        #endregion        
    }
}
