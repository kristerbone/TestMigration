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

namespace SFA.Apprenticeships.Web.Candidate.Views.TraineeshipSearch
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/TraineeshipSearch/Details.cshtml")]
    public partial class Details : System.Web.Mvc.WebViewPage<VacancyDetailViewModel>
    {
        public Details()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\TraineeshipSearch\Details.cshtml"
  
    ViewBag.Title = "Find a traineeship - " + Model.Title;
    Layout = "~/Views/Shared/_Layout.cshtml";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

DefineSection("metatags", () => {

WriteLiteral("\r\n    <meta");

WriteLiteral(" name=\"DCSext.Days2Close\"");

WriteAttribute("content", Tuple.Create(" content=\"", 203), Tuple.Create("\"", 255)
            
            #line 9 "..\..\Views\TraineeshipSearch\Details.cshtml"
, Tuple.Create(Tuple.Create("", 213), Tuple.Create<System.Object, System.Int32>((Model.ClosingDate - DateTime.Now).Days
            
            #line default
            #line hidden
, 213), false)
);

WriteLiteral("/>\r\n");

});

WriteLiteral("\r\n<div itemscope");

WriteLiteral(" itemtype=\"http://schema.org/JobPosting\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"grid-wrapper\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"grid grid-2-3\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"hgroup text\"");

WriteLiteral(">\r\n                <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(" id=\"vacancy-title\"");

WriteLiteral(" itemprop=\"title\"");

WriteLiteral(">");

            
            #line 16 "..\..\Views\TraineeshipSearch\Details.cshtml"
                                                                          Write(Model.Title);

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n                <p");

WriteLiteral(" class=\"subtitle\"");

WriteLiteral(" id=\"vacancy-subtitle-employer-name\"");

WriteLiteral(" itemprop=\"hiringOrganization\"");

WriteLiteral(">");

            
            #line 17 "..\..\Views\TraineeshipSearch\Details.cshtml"
                                                                                                 Write(Model.EmployerName);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"grid grid-1-3\"");

WriteLiteral(">\r\n");

            
            #line 21 "..\..\Views\TraineeshipSearch\Details.cshtml"
            
            
            #line default
            #line hidden
            
            #line 21 "..\..\Views\TraineeshipSearch\Details.cshtml"
             if (ViewBag.SearchReturnUrl != null)
            {

            
            #line default
            #line hidden
WriteLiteral("                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 812), Tuple.Create("\"", 843)
            
            #line 23 "..\..\Views\TraineeshipSearch\Details.cshtml"
, Tuple.Create(Tuple.Create("", 819), Tuple.Create<System.Object, System.Int32>(ViewBag.SearchReturnUrl
            
            #line default
            #line hidden
, 819), false)
);

WriteLiteral(" title=\"Return to search results\"");

WriteLiteral(" class=\"page-link\"");

WriteLiteral(" id=\"lnk-return-search-results\"");

WriteLiteral(">Return to search results</a>\r\n");

            
            #line 24 "..\..\Views\TraineeshipSearch\Details.cshtml"
            }
            else
            {
                
            
            #line default
            #line hidden
            
            #line 27 "..\..\Views\TraineeshipSearch\Details.cshtml"
           Write(Html.RouteLink("Find a traineeship", CandidateRouteNames.TraineeshipSearch, null, new { @id="lnk-find-traineeship", @class = "page-link" }));

            
            #line default
            #line hidden
            
            #line 27 "..\..\Views\TraineeshipSearch\Details.cshtml"
                                                                                                                                                            
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n    </div>\r\n\r\n");

            
            #line 32 "..\..\Views\TraineeshipSearch\Details.cshtml"
    
            
            #line default
            #line hidden
            
            #line 32 "..\..\Views\TraineeshipSearch\Details.cshtml"
     if (!Model.HasError())
    {

            
            #line default
            #line hidden
WriteLiteral("        <section");

WriteLiteral(" class=\"section-border grid-wrapper\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"grid grid-2-3\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"inner-block-padr\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"text\"");

WriteLiteral(">\r\n                        <p>");

            
            #line 38 "..\..\Views\TraineeshipSearch\Details.cshtml"
                      Write(Html.Raw(Model.TrainingToBeProvided));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                        <p>");

            
            #line 39 "..\..\Views\TraineeshipSearch\Details.cshtml"
                      Write(Html.Raw(Model.ProviderDescription));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n   " +
"         <div");

WriteLiteral(" class=\"grid grid-1-3\"");

WriteLiteral(">\r\n                <h3");

WriteLiteral(" class=\"bold-small\"");

WriteLiteral(">Training provider</h3>\r\n                <p>");

            
            #line 45 "..\..\Views\TraineeshipSearch\Details.cshtml"
              Write(Model.ProviderName);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                <h3");

WriteLiteral(" class=\"bold-small\"");

WriteLiteral(">Contact</h3>\r\n                <p>");

            
            #line 47 "..\..\Views\TraineeshipSearch\Details.cshtml"
              Write(Model.Contact);

            
            #line default
            #line hidden
WriteLiteral("</p>                \r\n                <h3");

WriteLiteral(" class=\"bold-small\"");

WriteLiteral(">Traineeship duration</h3>\r\n                <p");

WriteLiteral(" id=\"vacancy-expected-duration\"");

WriteLiteral(">");

            
            #line 49 "..\..\Views\TraineeshipSearch\Details.cshtml"
                                              Write(string.IsNullOrWhiteSpace(@Model.ExpectedDuration) ? "Not specified" : @Model.ExpectedDuration);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                <h3");

WriteLiteral(" class=\"bold-small\"");

WriteLiteral(">Possible start date</h3>\r\n                <p");

WriteLiteral(" id=\"vacancy-start-date\"");

WriteLiteral(">");

            
            #line 51 "..\..\Views\TraineeshipSearch\Details.cshtml"
                                      Write(Html.DisplayFor(m => Model.StartDate));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 52 "..\..\Views\TraineeshipSearch\Details.cshtml"
                
            
            #line default
            #line hidden
            
            #line 52 "..\..\Views\TraineeshipSearch\Details.cshtml"
                 if (Model.Distance != null)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <h3");

WriteLiteral(" class=\"bold-small\"");

WriteLiteral(">Distance</h3>\r\n");

WriteLiteral("                    <p");

WriteLiteral(" id=\"vacancy-distance\"");

WriteLiteral(">");

            
            #line 55 "..\..\Views\TraineeshipSearch\Details.cshtml"
                                        Write(Model.Distance);

            
            #line default
            #line hidden
WriteLiteral(" miles</p>\r\n");

            
            #line 56 "..\..\Views\TraineeshipSearch\Details.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                <h3");

WriteLiteral(" class=\"bold-small\"");

WriteLiteral(">Reference number</h3>\r\n                <p");

WriteLiteral(" id=\"vacancy-reference-id\"");

WriteLiteral(">");

            
            #line 58 "..\..\Views\TraineeshipSearch\Details.cshtml"
                                        Write(Model.VacancyReference);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

WriteLiteral("                ");

            
            #line 59 "..\..\Views\TraineeshipSearch\Details.cshtml"
           Write(Html.Partial("_Apply", Model, new ViewDataDictionary() { new KeyValuePair<string, object>("AnalyticsButtonPosition", "Top")}));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </section>\r\n");

WriteLiteral("        <section");

WriteLiteral(" class=\"section-border grid-wrapper\"");

WriteLiteral(" id=\"vacancy-info\"");

WriteLiteral(">\r\n            <h2");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">Work experience</h2>\r\n            <div");

WriteLiteral(" class=\"text\"");

WriteLiteral(">\r\n                <p>");

            
            #line 65 "..\..\Views\TraineeshipSearch\Details.cshtml"
              Write(Html.Raw(Model.Description));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"grid-wrapper\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"grid grid-1-2\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"inner-block-padr\"");

WriteLiteral(">\r\n                        <h3");

WriteLiteral(" class=\"bold-small\"");

WriteLiteral(">Employer</h3>\r\n                        <p");

WriteLiteral(" id=\"vacancy-employer-name\"");

WriteAttribute("class", Tuple.Create(" class=\"", 3290), Tuple.Create("\"", 3360)
            
            #line 71 "..\..\Views\TraineeshipSearch\Details.cshtml"
, Tuple.Create(Tuple.Create("", 3298), Tuple.Create<System.Object, System.Int32>(Model.IsWellFormedEmployerWebsiteUrl ? "no-btm-margin" : ""
            
            #line default
            #line hidden
, 3298), false)
);

WriteLiteral(">");

            
            #line 71 "..\..\Views\TraineeshipSearch\Details.cshtml"
                                                                                                                        Write(Model.EmployerName);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 72 "..\..\Views\TraineeshipSearch\Details.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 72 "..\..\Views\TraineeshipSearch\Details.cshtml"
                         if (Model.IsWellFormedEmployerWebsiteUrl)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <p><a");

WriteLiteral(" itemprop=\"url\"");

WriteAttribute("href", Tuple.Create(" href=\"", 3530), Tuple.Create("\"", 3559)
            
            #line 74 "..\..\Views\TraineeshipSearch\Details.cshtml"
, Tuple.Create(Tuple.Create("", 3537), Tuple.Create<System.Object, System.Int32>(Model.EmployerWebsite
            
            #line default
            #line hidden
, 3537), false)
);

WriteLiteral(" id=\"vacancy-employer-website\"");

WriteLiteral(" target=\"_blank\"");

WriteAttribute("title", Tuple.Create(" title=\"", 3606), Tuple.Create("\"", 3641)
            
            #line 74 "..\..\Views\TraineeshipSearch\Details.cshtml"
                                                    , Tuple.Create(Tuple.Create("", 3614), Tuple.Create<System.Object, System.Int32>(Model.EmployerName
            
            #line default
            #line hidden
, 3614), false)
, Tuple.Create(Tuple.Create(" ", 3633), Tuple.Create("Website", 3634), true)
);

WriteLiteral(" rel=\"external\"");

WriteLiteral(">");

            
            #line 74 "..\..\Views\TraineeshipSearch\Details.cshtml"
                                                                                                                                                                           Write(Model.EmployerWebsite);

            
            #line default
            #line hidden
WriteLiteral("</a></p>\r\n");

            
            #line 75 "..\..\Views\TraineeshipSearch\Details.cshtml"
                        }
                        else
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <p>");

            
            #line 78 "..\..\Views\TraineeshipSearch\Details.cshtml"
                          Write(Model.EmployerWebsite);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 79 "..\..\Views\TraineeshipSearch\Details.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                        <div itemscope");

WriteLiteral(" itemtype=\"http://schema.org/PostalAddress\"");

WriteLiteral(">\r\n                            <h3");

WriteLiteral(" class=\"bold-small\"");

WriteLiteral(">Address</h3>\r\n                            <div");

WriteLiteral(" itemprop=\"address\"");

WriteLiteral(">\r\n                                <p");

WriteLiteral(" class=\"small-btm-margin\"");

WriteLiteral(" itemprop=\"streetAddress\"");

WriteLiteral(">");

            
            #line 83 "..\..\Views\TraineeshipSearch\Details.cshtml"
                                                                                Write(Model.VacancyAddress.AddressLine1);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                                <p");

WriteLiteral(" class=\"small-btm-margin\"");

WriteLiteral(" itemprop=\"streetAddress\"");

WriteLiteral(">");

            
            #line 84 "..\..\Views\TraineeshipSearch\Details.cshtml"
                                                                                Write(Model.VacancyAddress.AddressLine2);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                                <p");

WriteLiteral(" class=\"small-btm-margin\"");

WriteLiteral(" itemprop=\"addressLocality\"");

WriteLiteral(">");

            
            #line 85 "..\..\Views\TraineeshipSearch\Details.cshtml"
                                                                                  Write(Model.VacancyAddress.AddressLine3);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                                <p");

WriteLiteral(" class=\"small-btm-margin\"");

WriteLiteral(" itemprop=\"addressRegion\"");

WriteLiteral(">");

            
            #line 86 "..\..\Views\TraineeshipSearch\Details.cshtml"
                                                                                Write(Model.VacancyAddress.AddressLine4);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                                <p");

WriteLiteral(" class=\"\"");

WriteLiteral(" itemprop=\"postalCode\"");

WriteLiteral(">");

            
            #line 87 "..\..\Views\TraineeshipSearch\Details.cshtml"
                                                             Write(Model.VacancyAddress.Postcode);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n       " +
"             </div>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"grid grid-1-2\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"ad-details__map\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"map-overlay\"");

WriteLiteral(" onclick=\"style.pointerEvents=\'none\'\"");

WriteLiteral("></div>\r\n                        <iframe");

WriteLiteral(" width=\"700\"");

WriteLiteral(" height=\"250\"");

WriteLiteral(" frameborder=\"0\"");

WriteLiteral(" style=\"border:0\"");

WriteAttribute("src", Tuple.Create(" src=\"", 5066), Tuple.Create("\"", 5221)
, Tuple.Create(Tuple.Create("", 5072), Tuple.Create("https://www.google.com/maps/embed/v1/place?q=", 5072), true)
            
            #line 95 "..\..\Views\TraineeshipSearch\Details.cshtml"
                                                            , Tuple.Create(Tuple.Create("", 5117), Tuple.Create<System.Object, System.Int32>(Html.Raw(Model.VacancyAddress.Postcode)
            
            #line default
            #line hidden
, 5117), false)
, Tuple.Create(Tuple.Create("", 5157), Tuple.Create(",+United+Kingdom&amp;key=AIzaSyCusA_0x4bJEjU-_gLOFiXMSBXKZYtvHz8", 5157), true)
);

WriteLiteral("></iframe>\r\n                        <p");

WriteLiteral(" class=\"nojs-notice\"");

WriteLiteral(">You must have JavaScript enabled to view a map of the location</p>\r\n            " +
"        </div>\r\n                </div>\r\n            </div>\r\n        </section>\r\n" +
"");

WriteLiteral("        <section");

WriteLiteral(" class=\"section-border grid-wrapper\"");

WriteLiteral(" id=\"course-info\"");

WriteLiteral(">\r\n            <h2");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">Desired skills and what this will lead to</h2>\r\n            <div");

WriteLiteral(" class=\"text\"");

WriteLiteral(">\r\n                <h3");

WriteLiteral(" class=\"heading-small\"");

WriteLiteral(">Desired skills</h3>\r\n                <p>");

            
            #line 105 "..\..\Views\TraineeshipSearch\Details.cshtml"
              Write(Html.Raw(Model.SkillsRequired));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                <p>");

            
            #line 106 "..\..\Views\TraineeshipSearch\Details.cshtml"
              Write(Html.Raw(Model.PersonalQualities));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                \r\n");

            
            #line 108 "..\..\Views\TraineeshipSearch\Details.cshtml"
                
            
            #line default
            #line hidden
            
            #line 108 "..\..\Views\TraineeshipSearch\Details.cshtml"
                 if (!string.IsNullOrWhiteSpace(Model.FutureProspects))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <h3");

WriteLiteral(" class=\"heading-small\"");

WriteLiteral(">What this will lead to</h3>\r\n");

WriteLiteral("                    <p");

WriteLiteral(" id=\"vacancy-future-prospects\"");

WriteLiteral(">");

            
            #line 111 "..\..\Views\TraineeshipSearch\Details.cshtml"
                                                Write(Html.Raw(Model.FutureProspects));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 112 "..\..\Views\TraineeshipSearch\Details.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n        </section>\r\n");

            
            #line 115 "..\..\Views\TraineeshipSearch\Details.cshtml"
        
        if (!string.IsNullOrWhiteSpace(Model.OtherInformation))
        {

            
            #line default
            #line hidden
WriteLiteral("             <section");

WriteLiteral(" class=\"grid-wrapper\"");

WriteLiteral(">\r\n                 <h2");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">Other information</h2>\r\n                 <div");

WriteLiteral(" class=\"text\"");

WriteLiteral(">\r\n                     <p");

WriteLiteral(" id=\"vacany-other-information\"");

WriteLiteral(">");

            
            #line 121 "..\..\Views\TraineeshipSearch\Details.cshtml"
                                                 Write(Html.Raw(Model.OtherInformation));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                 </div>\r\n             </section>\r\n");

            
            #line 124 "..\..\Views\TraineeshipSearch\Details.cshtml"
         }
    }

            
            #line default
            #line hidden
WriteLiteral("</div>");

        }
    }
}
#pragma warning restore 1591
