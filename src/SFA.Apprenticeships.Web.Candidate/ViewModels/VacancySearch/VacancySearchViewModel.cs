﻿namespace SFA.Apprenticeships.Web.Candidate.ViewModels.VacancySearch
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using Application.Interfaces.Search;
    using FluentValidation.Attributes;
    using SFA.Apprenticeships.Web.Candidate.Validators;

    //[Validator(typeof(VacancySearchValidator))]
    public class VacancySearchViewModel
    {
        public VacancySearchViewModel() { }

        public VacancySearchViewModel(VacancySearchViewModel viewModel)
        {
            Keywords = viewModel.Keywords;
            Location = viewModel.Location;
            Longitude = viewModel.Longitude;
            Latitude = viewModel.Latitude;
            WithinDistance = viewModel.WithinDistance;
            PageNumber = viewModel.PageNumber;
            SortType = viewModel.SortType;
        }

        private int _pageNumber = 1;

        [Display(Name = "Keywords (optional)", Description = "For example, mechanical engineer, retail, customer service")]
        public string Keywords { get; set; }
        [Display(Name = "Apprenticeship location", Description = "Enter postcode, town or city")]
        public string Location { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }

        public int WithinDistance { get; set; }

        public VacancySortType SortType { get; set; }

        public int PageNumber
        {
            get { return _pageNumber; }
            set { _pageNumber = value; }
        }
    }
}