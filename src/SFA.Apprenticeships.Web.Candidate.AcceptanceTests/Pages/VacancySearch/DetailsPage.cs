﻿namespace SFA.Apprenticeships.Web.Candidate.AcceptanceTests.Pages.VacancySearch
{
    using global::SpecBind.Pages;
    using OpenQA.Selenium;

    [PageNavigation("/vacancysearch/details")]
    [PageAlias("VacancyDetailsPage")]
    public class DetailsPage
    {
        [ElementLocator(Id = "apply-button")]
        public IWebElement Apply { get; set; }
    }
}