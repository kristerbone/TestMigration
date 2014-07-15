﻿namespace SFA.Apprenticeships.Web.Candidate.SpecBind.IntegrationTests.Templates.EditorFor
{
    using global::SpecBind.Pages;
    using global::SpecBind.Selenium;
    using OpenQA.Selenium;

    [ElementLocator(Id = "address-details")]
    public class AddressTemplate : WebElement
    {
        public AddressTemplate(ISearchContext searchContext) : base(searchContext)
        {
        }

        [ElementLocator(Id = "find-addresses")]
        public IWebElement FindAddresses { get; set; }

        [ElementLocator(Class = "address-select")]
        public IElementList<IWebElement, AddressDropdownItem> AddressDropdown { get; set; }

        [ElementLocator(Id = "address-select")]
        public IWebElement Addresses { get; set; }

        [ElementLocator(Id = "Address_AddressLine1")]
        public IWebElement AddressLine1 { get; set; }

        [ElementLocator(Id = "Address_AddressLine2")]
        public IWebElement AddressLine2 { get; set; }

        [ElementLocator(Id = "Address_AddressLine3")]
        public IWebElement AddressLine3 { get; set; }

        [ElementLocator(Id = "Address_AddressLine4")]
        public IWebElement AddressLine4 { get; set; }

        [ElementLocator(Id = "Address_Postcode")]
        public IWebElement Postcode { get; set; }

        [ElementLocator(Id = "Address_Uprn")]
        public IWebElement Uprn { get; set; }

        [ElementLocator(Id = "Address_Latitude")]
        public IWebElement Latitude { get; set; }

        [ElementLocator(Id = "Address_Longitude")]
        public IWebElement Longitude { get; set; }

    }

    [ElementLocator(TagName = "option")]
    public class AddressDropdownItem : WebElement
    {
        public AddressDropdownItem(ISearchContext parent) : base(parent)
        {
        }

        public string AddressLine1 { get { return this.Text ; } }
        public string AddressLine2 { get { return this.GetAttribute("data-address-line2"); } }
        public string Postcode { get { return this.GetAttribute("data-post0code") ; } }
    }
}