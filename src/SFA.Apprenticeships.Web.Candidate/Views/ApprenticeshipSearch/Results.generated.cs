﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SFA.Apprenticeships.Web.Candidate.Views.ApprenticeshipSearch
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 1 "..\..\Views\ApprenticeshipSearch\Results.cshtml"
    using SFA.Apprenticeships.Application.Interfaces.Vacancies;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\ApprenticeshipSearch\Results.cshtml"
    using SFA.Apprenticeships.Domain.Entities.Vacancies;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\ApprenticeshipSearch\Results.cshtml"
    using SFA.Apprenticeships.Domain.Entities.Vacancies.Apprenticeships;
    
    #line default
    #line hidden
    using SFA.Apprenticeships.Web.Candidate;
    using SFA.Apprenticeships.Web.Candidate.Constants;
    using SFA.Apprenticeships.Web.Candidate.Constants.ViewModels;
    using SFA.Apprenticeships.Web.Candidate.Helpers;
    using SFA.Apprenticeships.Web.Candidate.ViewModels;
    using SFA.Apprenticeships.Web.Candidate.ViewModels.Candidate;
    using SFA.Apprenticeships.Web.Candidate.ViewModels.Locations;
    using SFA.Apprenticeships.Web.Candidate.ViewModels.Login;
    using SFA.Apprenticeships.Web.Candidate.ViewModels.Register;
    using SFA.Apprenticeships.Web.Candidate.ViewModels.VacancySearch;
    using SFA.Apprenticeships.Web.Common.Constants;
    using SFA.Apprenticeships.Web.Common.Framework;
    using SFA.Apprenticeships.Web.Common.Models.Common;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ApprenticeshipSearch/Results.cshtml")]
    public partial class Results : System.Web.Mvc.WebViewPage<ApprenticeshipSearchResponseViewModel>
    {
        public Results()
        {
        }
        public override void Execute()
        {
            
            #line 6 "..\..\Views\ApprenticeshipSearch\Results.cshtml"
  
    ViewBag.Title = "Apprenticeships - Results";
    Layout = "~/Views/Shared/_Layout.cshtml";

    var locationTypeLink = Model.VacancySearch.LocationType == ApprenticeshipLocationType.National ? Url.Action("results", new ApprenticeshipSearchViewModel(Model.VacancySearch) { LocationType = ApprenticeshipLocationType.NonNational, SearchAction = SearchAction.LocationTypeChanged, PageNumber = 1 }) : Url.Action("results", new ApprenticeshipSearchViewModel(Model.VacancySearch) { LocationType = ApprenticeshipLocationType.National, SearchAction = SearchAction.LocationTypeChanged, SortType = VacancySearchSortType.Distance, PageNumber = 1 });

    string resultMessage;
    string nationalResultsMessage;

    if (Model.TotalLocalHits == 0)
    {
        resultMessage = "";
    }
    else if (Model.TotalLocalHits == 1)
    {

        if (Model.VacancySearch.LocationType == ApprenticeshipLocationType.National)
        {
            resultMessage = "We've found <b class=\"bold-medium\">1</b> <a id='localLocationTypeLink' href=" + locationTypeLink + ">apprenticeship in your selected area</a>.";
        }
        else
        {
            resultMessage = "We've found <b class=\"bold-medium\">1</b> apprenticeship in your selected area.";
        }
    }
    else
    {
        if (Model.VacancySearch.LocationType == ApprenticeshipLocationType.National)
        {
            var message = "We've found <b class=\"bold-medium\">{0}</b> <a id='localLocationTypeLink' href=" + locationTypeLink + ">apprenticeships in your selected area</a>.";
            resultMessage = string.Format(message, Model.TotalLocalHits);
        }
        else
        {
            resultMessage = string.Format("We've found <b class=\"bold-medium\">{0}</b> apprenticeships in your selected area.", Model.TotalLocalHits);
        }
    }

    if (Model.TotalNationalHits == 0)
    {
        nationalResultsMessage = "";
    }
    else
    {
        var nationalResultsMessagePrefix = Model.TotalLocalHits == 0 ? "We've found" : "We've also found";

        if (Model.TotalNationalHits == 1)
        {

            if (Model.VacancySearch.LocationType == ApprenticeshipLocationType.NonNational)
            {
                nationalResultsMessage = string.Format("{1} <a id='nationwideLocationTypeLink' href={0}>1 apprenticeship nationwide</a>.", locationTypeLink, nationalResultsMessagePrefix);
            }
            else
            {
                nationalResultsMessage = nationalResultsMessagePrefix + " 1 apprenticeship nationwide.";
            }
        }
        else
        {
            if (Model.VacancySearch.LocationType == ApprenticeshipLocationType.NonNational)
            {
                nationalResultsMessage = string.Format("{2} <a id='nationwideLocationTypeLink' href={1}>{0} apprenticeships nationwide</a>.", Model.TotalNationalHits, locationTypeLink, nationalResultsMessagePrefix);
            }
            else
            {
                nationalResultsMessage = string.Format("{1} {0} apprenticeships nationwide.", Model.TotalNationalHits, nationalResultsMessagePrefix);
            }
        }
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

DefineSection("metatags", () => {

WriteLiteral("\r\n    ");

WriteLiteral("\r\n    <meta");

WriteLiteral(" name=\"WT.oss_r\"");

WriteAttribute("content", Tuple.Create(" content=\"", 3549), Tuple.Create("\"", 3580)
            
            #line 81 "..\..\Views\ApprenticeshipSearch\Results.cshtml"
, Tuple.Create(Tuple.Create("", 3559), Tuple.Create<System.Object, System.Int32>(Model.TotalLocalHits
            
            #line default
            #line hidden
, 3559), false)
);

WriteLiteral(" />\r\n");

});

WriteLiteral("\r\n<div");

WriteLiteral(" class=\"search-results-wrapper grid-wrapper\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"hgroup\"");

WriteLiteral(">\r\n        <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">Search results</h1>\r\n        <div");

WriteLiteral(" id=\"vacancy-result-summary\"");

WriteLiteral(">\r\n            <p");

WriteLiteral(" id=\"result-message\"");

WriteLiteral(" class=\"small-btm-margin\"");

WriteLiteral(">");

            
            #line 88 "..\..\Views\ApprenticeshipSearch\Results.cshtml"
                                                       Write(Html.Raw(resultMessage));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n            <p");

WriteLiteral(" id=\"national-results-message\"");

WriteLiteral(">");

            
            #line 89 "..\..\Views\ApprenticeshipSearch\Results.cshtml"
                                        Write(Html.Raw(nationalResultsMessage));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n\r\n");

            
            #line 93 "..\..\Views\ApprenticeshipSearch\Results.cshtml"
    
            
            #line default
            #line hidden
            
            #line 93 "..\..\Views\ApprenticeshipSearch\Results.cshtml"
     using (Html.BeginRouteForm(CandidateRouteNames.ApprenticeshipResults, FormMethod.Get))
    {
        Html.Partial("ValidationSummary", ViewData.ModelState);
        Html.RenderPartial("_searchUpdate", Model.VacancySearch);

            
            #line default
            #line hidden
WriteLiteral("        <section");

WriteLiteral(" class=\"grid grid-2-3\"");

WriteLiteral(">\r\n");

            
            #line 98 "..\..\Views\ApprenticeshipSearch\Results.cshtml"
            
            
            #line default
            #line hidden
            
            #line 98 "..\..\Views\ApprenticeshipSearch\Results.cshtml"
              
                if (Model.TotalLocalHits == 0 && Model.TotalNationalHits == 0)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <p");

WriteLiteral(" id=\"search-no-results-title\"");

WriteLiteral(">There are currently no apprenticeships that match your search.</p>\r\n");

WriteLiteral("                    <p>Try editing your search:</p>\r\n");

WriteLiteral("                    <ul");

WriteLiteral(" id=\"search-no-results\"");

WriteLiteral(">\r\n");

            
            #line 104 "..\..\Views\ApprenticeshipSearch\Results.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 104 "..\..\Views\ApprenticeshipSearch\Results.cshtml"
                         if (Model.VacancySearch.SearchMode == ApprenticeshipSearchMode.Keyword)
                        {
                            if (VacancyHelper.IsVacancyReference(Model.VacancySearch.Keywords))
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <li");

WriteLiteral(" id=\"search-no-results-reference-number\"");

WriteLiteral(">try a different reference number</li>\r\n");

            
            #line 109 "..\..\Views\ApprenticeshipSearch\Results.cshtml"
                            }
                            else
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <li");

WriteLiteral(" id=\"search-no-results-keywords\"");

WriteLiteral(">using different keywords</li>\r\n");

            
            #line 113 "..\..\Views\ApprenticeshipSearch\Results.cshtml"
                            }
                        }

            
            #line default
            #line hidden
WriteLiteral("                        ");

            
            #line 115 "..\..\Views\ApprenticeshipSearch\Results.cshtml"
                         if (Model.VacancySearch.SearchMode == ApprenticeshipSearchMode.Category)
                        {
                            if (Model.VacancySearch.SubCategories == null || Model.VacancySearch.SubCategories.Length == 0)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <li");

WriteLiteral(" id=\"search-no-results-category\"");

WriteLiteral(">try a different category</li>\r\n");

            
            #line 120 "..\..\Views\ApprenticeshipSearch\Results.cshtml"
                            }
                            else
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <li");

WriteLiteral(" id=\"search-no-results-sub-category\"");

WriteLiteral(">select a different sub-category or sub-categories</li>\r\n");

            
            #line 124 "..\..\Views\ApprenticeshipSearch\Results.cshtml"
                            }
                        }

            
            #line default
            #line hidden
WriteLiteral("                        <li>expanding your search location</li>\r\n");

            
            #line 127 "..\..\Views\ApprenticeshipSearch\Results.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 127 "..\..\Views\ApprenticeshipSearch\Results.cshtml"
                         if (Model.VacancySearch.ApprenticeshipLevel != "All")
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <li");

WriteLiteral(" id=\"search-no-results-apprenticeship-levels\"");

WriteLiteral(">using a different level, or change to all levels</li>\r\n");

            
            #line 130 "..\..\Views\ApprenticeshipSearch\Results.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </ul>\r\n");

            
            #line 132 "..\..\Views\ApprenticeshipSearch\Results.cshtml"
                }
                else
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" id=\"pagedList\"");

WriteLiteral(">\r\n");

            
            #line 136 "..\..\Views\ApprenticeshipSearch\Results.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 136 "..\..\Views\ApprenticeshipSearch\Results.cshtml"
                           Html.RenderPartial("_searchResults", Model); 
            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n");

            
            #line 138 "..\..\Views\ApprenticeshipSearch\Results.cshtml"
                }
            
            
            #line default
            #line hidden
WriteLiteral("\r\n        </section>\r\n");

            
            #line 141 "..\..\Views\ApprenticeshipSearch\Results.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n");

DefineSection("scripts", () => {

WriteLiteral("\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(" src=\"https://maps.googleapis.com/maps/api/js?v=3&client=gme-skillsfundingagency\"" +
"");

WriteLiteral("></script>\r\n\r\n");

WriteLiteral("    ");

            
            #line 148 "..\..\Views\ApprenticeshipSearch\Results.cshtml"
Write(Scripts.Render("~/bundles/nas/locationsearch"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        $(function () {\r\n            $(\"#Location\").locationMatch({\r\n         " +
"       url: \'");

            
            #line 152 "..\..\Views\ApprenticeshipSearch\Results.cshtml"
                 Write(Url.Action("location", "Location"));

            
            #line default
            #line hidden
WriteLiteral(@"',
                longitude: '#Longitude',
                latitude: '#Latitude',
                latlonhash: '#Hash'
            });

            $('#sort-results').change(function () {

                $('#SearchAction').val(""Sort"");
                $(""form"").submit();
            });

            $('#results-per-page').change(function () {
                $('#SearchAction').val(""Sort"");
                $(""form"").submit();
            });

            $('#search-button').click(function () {
                $('#LocationType').val(""NonNational"");
            });
            $(""#search-tab-control"").click(function () {
                $(""#SearchMode"").val(""Keyword"");
            });

            $(""#browse-tab-control"").click(function () {
                $(""#SearchMode"").val(""Category"");
            });
        });
    </script>


");

WriteLiteral("    ");

            
            #line 183 "..\..\Views\ApprenticeshipSearch\Results.cshtml"
Write(Scripts.Render("~/bundles/nas/resultsMap"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

});

        }
    }
}
#pragma warning restore 1591
