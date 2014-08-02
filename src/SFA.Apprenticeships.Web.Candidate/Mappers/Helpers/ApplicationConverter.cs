﻿namespace SFA.Apprenticeships.Web.Candidate.Mappers.Helpers
{
    using System.Collections.Generic;
    using System.Data;
    using System.Globalization;
    using System.Linq;
    using Domain.Entities.Candidates;
    using Domain.Entities.Locations;
    using ViewModels.Candidate;
    using ViewModels.Locations;

    public static class ApplicationConverter
    {
        #region Entity To Model Converters

        public static AddressViewModel GetAddressViewModel(Address address)
        {
            return new AddressViewModel
            {
                AddressLine1 = address.AddressLine1,
                AddressLine2 = address.AddressLine2,
                AddressLine3 = address.AddressLine3,
                AddressLine4 = address.AddressLine4,
                Postcode = address.Postcode,
                GeoPoint = new GeoPointViewModel
                {
                    Longitude = address.GeoPoint.Longitude,
                    Latitude = address.GeoPoint.Latitude
                },
                Uprn = address.Uprn
            };
        }

        public static IEnumerable<QualificationsViewModel> GetQualificationsViewModels(IEnumerable<Qualification> qualifications)
        {
            return qualifications.Select(q => new QualificationsViewModel
            {
                Grade = q.Grade,
                IsPredicted = q.IsPredicted,
                QualificationType = q.QualificationType,
                Subject = q.Subject,
                Year = q.Year
            }).AsEnumerable();
        }

        public static IEnumerable<WorkExperienceViewModel> GetWorkExperiencesViewModels(
            IEnumerable<WorkExperience> workExperiences)
        {
            return workExperiences.Select(m => new WorkExperienceViewModel
            {
                Description = m.Description,
                Employer = m.Employer,
                JobTitle = m.JobTitle,
                FromYear = m.FromYear,
                ToYear = m.ToYear
            }).AsEnumerable();
        }

        public static EducationViewModel GetEducationViewModel(Education educationHistory)
        {
            if (educationHistory == null)
            {
                return null;
            }

            return new EducationViewModel
            {
                FromYear = educationHistory.FromYear.ToString(CultureInfo.InvariantCulture),
                NameOfMostRecentSchoolCollege = educationHistory.Institution,
                ToYear = educationHistory.ToYear.ToString(CultureInfo.InvariantCulture)
            };
        }

        public static AboutYouViewModel GetAboutYouViewModel(AboutYou aboutYou)
        {
            return new AboutYouViewModel
            {
                AnythingWeCanDoToSupportYourInterview = aboutYou.Support,
                WhatAreYourHobbiesInterests = aboutYou.HobbiesAndInterests,
                WhatAreYourStrengths = aboutYou.Strengths,
                WhatDoYouFeelYouCouldImprove = aboutYou.Improvements
            };
        }

        #endregion

        #region ViewModel To Entity Converters

        public static Address GetAddress(AddressViewModel model)
        {
            return new Address
            {
                AddressLine1 = model.AddressLine1,
                AddressLine2 = model.AddressLine2,
                AddressLine3 = model.AddressLine3,
                AddressLine4 = model.AddressLine4,
                GeoPoint = new GeoPoint
                {
                    Longitude = model.GeoPoint.Longitude,
                    Latitude = model.GeoPoint.Latitude
                },
                Postcode = model.Postcode,
                Uprn = model.Uprn
            };
        }

        public static AboutYou GetAboutYou(AboutYouViewModel model)
        {
            return new AboutYou
            {
                HobbiesAndInterests = model.WhatAreYourHobbiesInterests,
                Improvements = model.WhatDoYouFeelYouCouldImprove,
                Strengths = model.WhatAreYourStrengths,
                Support = model.AnythingWeCanDoToSupportYourInterview
            };
        }

        public static Education GetEducation(EducationViewModel model)
        {
            if (model == null)
            {
                return null;
            }

            return new Education
            {
                FromYear = ConvertYearStringToInt(model.FromYear),
                Institution = model.NameOfMostRecentSchoolCollege,
                ToYear = ConvertYearStringToInt(model.ToYear)
            };
        }

        public static IList<WorkExperience> GetWorkExperiences(
            IEnumerable<WorkExperienceViewModel> workExperienceViewModels)
        {
            return workExperienceViewModels.Select(model => new WorkExperience
            {
                Description = model.Description,
                Employer = model.Employer,
                JobTitle = model.JobTitle,
                FromYear = model.FromYear,
                ToYear = model.ToYear
            }).ToList();
        }

        public static IList<Qualification> GetQualifications(
            IEnumerable<QualificationsViewModel> qualifications)
        {
            return qualifications.Select(model => new Qualification
            {
                Grade = model.Grade,
                IsPredicted = model.IsPredicted,
                QualificationType = model.QualificationType,
                Subject = model.Subject,
                Year = model.Year
            }).ToList();
        }

        private static int ConvertYearStringToInt(string stringYear)
        {
            int year;
            int.TryParse(stringYear, out year);
            return year;
        }

        #endregion
    }
}