﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
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
    using SFA.Apprenticeships.Web.Candidate;
    using SFA.Apprenticeships.Web.Candidate.Constants;
    using SFA.Apprenticeships.Web.Candidate.Constants.ViewModels;
    
    #line 1 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
    using SFA.Apprenticeships.Web.Candidate.Extensions;
    
    #line default
    #line hidden
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ApprenticeshipSearch/_searchUpdate.cshtml")]
    public partial class searchUpdate : System.Web.Mvc.WebViewPage<ApprenticeshipSearchViewModel>
    {
        public searchUpdate()
        {
        }
        public override void Execute()
        {
WriteLiteral("<section");

WriteLiteral(" class=\"grid grid-1-3\"");

WriteLiteral(">\r\n    <div>\r\n        <fieldset");

WriteLiteral(" class=\"search-filter\"");

WriteLiteral(">\r\n\r\n            <legend");

WriteLiteral(" class=\"heading-medium mob-collpanel-trigger\"");

WriteLiteral(" id=\"editSearchToggle\"");

WriteLiteral(">Edit search</legend>\r\n            <div");

WriteLiteral(" class=\"mob-collpanel toggle-content--mob\"");

WriteLiteral(" id=\"editSearchPanel\"");

WriteLiteral(">\r\n                <nav");

WriteLiteral(" class=\"tabbed-nav\"");

WriteLiteral(">\r\n");

            
            #line 11 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 11 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
                      
                        var searchTabControlUrl = Url.ApprenticeshipSearchViewModelAction("results", new ApprenticeshipSearchViewModel(Model) {SearchMode = ApprenticeshipSearchMode.Keyword});
                        var browseTabControlUrl = Url.ApprenticeshipSearchViewModelAction("results", new ApprenticeshipSearchViewModel(Model) {SearchMode = ApprenticeshipSearchMode.Category});
                        var searchTabControlClass = Model.SearchMode == ApprenticeshipSearchMode.Keyword ? "active" : "";
                        var browseTabControlClass = Model.SearchMode == ApprenticeshipSearchMode.Category ? "active" : "";
                    
            
            #line default
            #line hidden
WriteLiteral("\r\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1117), Tuple.Create("\"", 1144)
            
            #line 17 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
, Tuple.Create(Tuple.Create("", 1124), Tuple.Create<System.Object, System.Int32>(searchTabControlUrl
            
            #line default
            #line hidden
, 1124), false)
);

WriteLiteral(" id=\"search-tab-control\"");

WriteAttribute("class", Tuple.Create(" class=\"", 1169), Tuple.Create("\"", 1210)
, Tuple.Create(Tuple.Create("", 1177), Tuple.Create("tabbed-tab", 1177), true)
            
            #line 17 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
            , Tuple.Create(Tuple.Create(" ", 1187), Tuple.Create<System.Object, System.Int32>(searchTabControlClass
            
            #line default
            #line hidden
, 1188), false)
);

WriteLiteral(" tab=\"#tab1\"");

WriteLiteral(">Search</a>\r\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1258), Tuple.Create("\"", 1285)
            
            #line 18 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
, Tuple.Create(Tuple.Create("", 1265), Tuple.Create<System.Object, System.Int32>(browseTabControlUrl
            
            #line default
            #line hidden
, 1265), false)
);

WriteLiteral(" id=\"browse-tab-control\"");

WriteAttribute("class", Tuple.Create(" class=\"", 1310), Tuple.Create("\"", 1351)
, Tuple.Create(Tuple.Create("", 1318), Tuple.Create("tabbed-tab", 1318), true)
            
            #line 18 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
            , Tuple.Create(Tuple.Create(" ", 1328), Tuple.Create<System.Object, System.Int32>(browseTabControlClass
            
            #line default
            #line hidden
, 1329), false)
);

WriteLiteral(" tab=\"#tab2\"");

WriteLiteral(">Browse</a>\r\n                </nav>\r\n                <div");

WriteLiteral(" class=\"tabbed-content active\"");

WriteLiteral(">\r\n\r\n");

WriteLiteral("                    ");

            
            #line 22 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
               Write(Html.Partial("_categoriesAndSubCategories", Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 24 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 24 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
                      
                        var keywordsClass = Model.SearchMode == ApprenticeshipSearchMode.Keyword ? " active" : "";
                        
            
            #line default
            #line hidden
            
            #line 26 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
                   Write(Html.FormTextFor(m => m.Keywords, hintText: "", containerHtmlAttributes: new {@class = "tabbed-element tab1" + keywordsClass }));

            
            #line default
            #line hidden
            
            #line 26 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
                                                                                                                                                        
                    
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

WriteLiteral("                    ");

            
            #line 29 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
               Write(Html.FormTextFor(m => m.Location, hintText: ""));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 31 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 31 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
                     if (Model.LocationSearches != null && Model.LocationSearches.Length > 0)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <details open");

WriteLiteral(" class=\"open form-group form-group-compound\"");

WriteLiteral(" id=\"locationSuggestions\"");

WriteLiteral(">\r\n                            <summary");

WriteLiteral(" tabindex=\"0\"");

WriteLiteral(" aria-describedby=\"locSuggestionsAria\"");

WriteLiteral(">Did you mean:</summary>\r\n                            <p");

WriteLiteral(" class=\"visuallyhidden\"");

WriteLiteral(" aria-live=\"polite\"");

WriteLiteral(" id=\"locSuggestionsAria\"");

WriteLiteral("></p>\r\n                            <div");

WriteLiteral(" class=\"detail-content panel-indent\"");

WriteLiteral(">\r\n                                <ul");

WriteLiteral(" id=\"location-suggestions\"");

WriteLiteral(" class=\"list-text list-max-11\"");

WriteLiteral(">\r\n");

            
            #line 38 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
                                    
            
            #line default
            #line hidden
            
            #line 38 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
                                     foreach (var locationSearch in Model.LocationSearches)
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 2708), Tuple.Create("\"", 2753)
            
            #line 40 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
, Tuple.Create(Tuple.Create("", 2715), Tuple.Create<System.Object, System.Int32>(Url.Action("results", locationSearch)
            
            #line default
            #line hidden
, 2715), false)
);

WriteLiteral(">");

            
            #line 40 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
                                                                                        Write(locationSearch.Location);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 41 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                </ul>\r\n                            </div>\r\n      " +
"                  </details>\r\n");

            
            #line 45 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" for=\"loc-within\"");

WriteLiteral(" class=\"form-label\"");

WriteLiteral(">Within</label>\r\n");

WriteLiteral("                        ");

            
            #line 48 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
                   Write(Html.DropDownListFor(m => m.WithinDistance, Model.Distances, new {@id = "loc-within", @name = "WithinDistance"}));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" for=\"apprenticeship-level\"");

WriteLiteral(" class=\"form-label\"");

WriteLiteral(">Apprenticeship level</label>\r\n");

WriteLiteral("                        ");

            
            #line 52 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
                   Write(Html.DropDownListFor(m => m.ApprenticeshipLevel, Model.ApprenticeshipLevels, new {@id = "apprenticeship-level", @name = "ApprenticeshipLevel"}));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                        <button");

WriteLiteral(" class=\"button no-btm-margin\"");

WriteLiteral(" id=\"search-button\"");

WriteLiteral(" name=\"SearchAction\"");

WriteLiteral(" value=\"Search\"");

WriteLiteral(">Update results</button>\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"form-group map-container hide-nojs\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" id=\"map-canvas\"");

WriteLiteral(" style=\"width: 100%; height: 250px\"");

WriteLiteral("></div>\r\n                    </div>\r\n\r\n");

WriteLiteral("                    ");

            
            #line 61 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
               Write(Html.HiddenFor(m => m.Latitude));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 62 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
               Write(Html.HiddenFor(m => m.Longitude));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 63 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
               Write(Html.Hidden("Hash", Model.LatLonLocHash()));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 64 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
               Write(Html.HiddenFor(m => m.SearchMode));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    ");

WriteLiteral("\r\n                    <input");

WriteLiteral(" id=\"LocationType\"");

WriteLiteral(" name=\"LocationType\"");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("value", Tuple.Create(" value=\"", 4510), Tuple.Create("\"", 4537)
            
            #line 66 "..\..\Views\ApprenticeshipSearch\_searchUpdate.cshtml"
      , Tuple.Create(Tuple.Create("", 4518), Tuple.Create<System.Object, System.Int32>(Model.LocationType
            
            #line default
            #line hidden
, 4518), false)
);

WriteLiteral(" />\r\n\r\n                </div>\r\n            </div>\r\n        </fieldset>\r\n    </div" +
">\r\n</section>");

        }
    }
}
#pragma warning restore 1591
