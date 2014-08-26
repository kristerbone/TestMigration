﻿namespace SFA.Apprenticeships.Web.Candidate.AcceptanceTests.Pages.Account
{
    using OpenQA.Selenium;
    using Registration;
    using SpecBind.Pages;
    using Templates.EditorFor;

    [PageNavigation("/settings")]
    [PageAlias("SettingsPage")]
    public class SettingsPage : BaseValidationPage
    {
        public SettingsPage(ISearchContext context)
            : base(context)
        {
        }

        [ElementLocator(Id = "Firstname")]
        public IWebElement Firstname { get; set; }

        [ElementLocator(Id = "Lastname")]
        public IWebElement Lastname { get; set; }

        [ElementLocator(Id = "PhoneNumber")]
        public IWebElement Phonenumber { get; set; }

        [ElementLocator(Id = "update-details-button")]
        public IWebElement UpdateDetailsButton { get; set; }

        #region Date of birth

        [ElementLocator(Class = "date-input")]
        public DateOfBirthTemplate DateOfBirth { get; set; }

        public IWebElement Day { get { return DateOfBirth.Day; } }

        public IWebElement Month { get { return DateOfBirth.Month; } }

        public IWebElement Year { get { return DateOfBirth.Year; } }

        #endregion

        #region Address Template

        [ElementLocator(Id = "address-details")]
        public AddressTemplate Address { get; set; }

        public IWebElement AddressLine1 { get { return Address.AddressLine1; } }

        public IWebElement AddressLine2 { get { return Address.AddressLine2; } }

        public IWebElement AddressLine3 { get { return Address.AddressLine3; } }

        public IWebElement AddressLine4 { get { return Address.AddressLine4; } }

        public IWebElement Postcode { get { return Address.Postcode; } }

        public string Uprn { get { return Address.Uprn.GetAttribute("value"); } }

        public string Latitude { get { return Address.Latitude.GetAttribute("value"); } }

        public string Longitude { get { return Address.Longitude.GetAttribute("value"); } }

        #region Search Inputs

        [ElementLocator(Id = "postcode-search")]
        public IWebElement PostcodeSearch { get; set; }

        [ElementLocator(Id = "find-addresses")]
        public IWebElement FindAddresses { get; set; }

        [ElementLocator(Id = "address-select")]
        public IElementList<IWebElement, AddressDropdownItem> AddressDropdown { get; set; }

        [ElementLocator(Id = "address-select")]
        public IWebElement Addresses { get; set; }

        #endregion

        #endregion
    }
}
