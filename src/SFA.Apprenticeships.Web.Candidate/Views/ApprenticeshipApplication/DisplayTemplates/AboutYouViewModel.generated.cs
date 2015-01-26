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

namespace SFA.Apprenticeships.Web.Candidate.Views.ApprenticeshipApplication.DisplayTemplates
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ApprenticeshipApplication/DisplayTemplates/AboutYouViewModel.cshtml")]
    public partial class AboutYouViewModel_ : System.Web.Mvc.WebViewPage<AboutYouViewModel>
    {
        public AboutYouViewModel_()
        {
        }
        public override void Execute()
        {
WriteLiteral("<section");

WriteLiteral(" class=\"section-border\"");

WriteLiteral(">\r\n    <h2");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">\r\n        About you\r\n");

            
            #line 6 "..\..\Views\ApprenticeshipApplication\DisplayTemplates\AboutYouViewModel.cshtml"
        
            
            #line default
            #line hidden
            
            #line 6 "..\..\Views\ApprenticeshipApplication\DisplayTemplates\AboutYouViewModel.cshtml"
         if (ViewBag.VacancyId != null)
        {

            
            #line default
            #line hidden
WriteLiteral("            <a");

WriteLiteral(" class=\"icon-with-text\"");

WriteAttribute("href", Tuple.Create(" href=\'", 202), Tuple.Create("\'", 307)
            
            #line 8 "..\..\Views\ApprenticeshipApplication\DisplayTemplates\AboutYouViewModel.cshtml"
, Tuple.Create(Tuple.Create("", 209), Tuple.Create<System.Object, System.Int32>(Url.RouteUrl(CandidateRouteNames.ApprenticeshipApply, new {id = ViewBag.VacancyId})
            
            #line default
            #line hidden
, 209), false)
, Tuple.Create(Tuple.Create("", 293), Tuple.Create("#applyAboutYou", 293), true)
);

WriteLiteral(">\r\n                <i");

WriteLiteral(" class=\"the-icon fa fa-pencil\"");

WriteLiteral("></i><span");

WriteLiteral(" class=\"the-text\"");

WriteLiteral(">Change details</span>\r\n            </a>\r\n");

            
            #line 11 "..\..\Views\ApprenticeshipApplication\DisplayTemplates\AboutYouViewModel.cshtml"

        }

            
            #line default
            #line hidden
WriteLiteral("    </h2>\r\n\r\n    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 16 "..\..\Views\ApprenticeshipApplication\DisplayTemplates\AboutYouViewModel.cshtml"
   Write(Html.SpanFor(m => m.WhatAreYourStrengths, new { @class = "form-label text" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <span");

WriteAttribute("id", Tuple.Create(" id=\"", 585), Tuple.Create("\"", 630)
            
            #line 17 "..\..\Views\ApprenticeshipApplication\DisplayTemplates\AboutYouViewModel.cshtml"
, Tuple.Create(Tuple.Create("", 590), Tuple.Create<System.Object, System.Int32>(Html.IdFor(m => m.WhatAreYourStrengths)
            
            #line default
            #line hidden
, 590), false)
);

WriteLiteral(" class=\"form-prepopped prewrap\"");

WriteLiteral(">");

            
            #line 17 "..\..\Views\ApprenticeshipApplication\DisplayTemplates\AboutYouViewModel.cshtml"
                                                                                      Write(Html.DisplayFor(m => m.WhatAreYourStrengths));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 20 "..\..\Views\ApprenticeshipApplication\DisplayTemplates\AboutYouViewModel.cshtml"
   Write(Html.SpanFor(m => m.WhatDoYouFeelYouCouldImprove, new { @class = "form-label text" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <span");

WriteAttribute("id", Tuple.Create(" id=\"", 868), Tuple.Create("\"", 921)
            
            #line 21 "..\..\Views\ApprenticeshipApplication\DisplayTemplates\AboutYouViewModel.cshtml"
, Tuple.Create(Tuple.Create("", 873), Tuple.Create<System.Object, System.Int32>(Html.IdFor(m => m.WhatDoYouFeelYouCouldImprove)
            
            #line default
            #line hidden
, 873), false)
);

WriteLiteral(" class=\"form-prepopped prewrap\"");

WriteLiteral(">");

            
            #line 21 "..\..\Views\ApprenticeshipApplication\DisplayTemplates\AboutYouViewModel.cshtml"
                                                                                              Write(Html.DisplayFor(m => m.WhatDoYouFeelYouCouldImprove));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 24 "..\..\Views\ApprenticeshipApplication\DisplayTemplates\AboutYouViewModel.cshtml"
   Write(Html.SpanFor(m => m.WhatAreYourHobbiesInterests, new { @class = "form-label text" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <span");

WriteAttribute("id", Tuple.Create(" id=\"", 1166), Tuple.Create("\"", 1218)
            
            #line 25 "..\..\Views\ApprenticeshipApplication\DisplayTemplates\AboutYouViewModel.cshtml"
, Tuple.Create(Tuple.Create("", 1171), Tuple.Create<System.Object, System.Int32>(Html.IdFor(m => m.WhatAreYourHobbiesInterests)
            
            #line default
            #line hidden
, 1171), false)
);

WriteLiteral(" class=\"form-prepopped prewrap\"");

WriteLiteral(">");

            
            #line 25 "..\..\Views\ApprenticeshipApplication\DisplayTemplates\AboutYouViewModel.cshtml"
                                                                                             Write(Html.DisplayFor(m => m.WhatAreYourHobbiesInterests));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n        <p");

WriteLiteral(" class=\"form-label\"");

WriteLiteral(">Is there anything we can do to support your interview?</p>\r\n");

            
            #line 30 "..\..\Views\ApprenticeshipApplication\DisplayTemplates\AboutYouViewModel.cshtml"
        
            
            #line default
            #line hidden
            
            #line 30 "..\..\Views\ApprenticeshipApplication\DisplayTemplates\AboutYouViewModel.cshtml"
         if (Model.RequiresSupportForInterview)
        {

            
            #line default
            #line hidden
WriteLiteral("            <span");

WriteAttribute("id", Tuple.Create(" id=\"", 1523), Tuple.Create("\"", 1585)
            
            #line 32 "..\..\Views\ApprenticeshipApplication\DisplayTemplates\AboutYouViewModel.cshtml"
, Tuple.Create(Tuple.Create("", 1528), Tuple.Create<System.Object, System.Int32>(Html.IdFor(m => m.AnythingWeCanDoToSupportYourInterview)
            
            #line default
            #line hidden
, 1528), false)
);

WriteLiteral(" class=\"form-prepopped prewrap\"");

WriteLiteral(">");

            
            #line 32 "..\..\Views\ApprenticeshipApplication\DisplayTemplates\AboutYouViewModel.cshtml"
                                                                                                           Write(Html.DisplayFor(m => m.AnythingWeCanDoToSupportYourInterview));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 33 "..\..\Views\ApprenticeshipApplication\DisplayTemplates\AboutYouViewModel.cshtml"
        }
        else
        {

            
            #line default
            #line hidden
WriteLiteral("            <span");

WriteAttribute("id", Tuple.Create(" id=\"", 1742), Tuple.Create("\"", 1804)
            
            #line 36 "..\..\Views\ApprenticeshipApplication\DisplayTemplates\AboutYouViewModel.cshtml"
, Tuple.Create(Tuple.Create("", 1747), Tuple.Create<System.Object, System.Int32>(Html.IdFor(m => m.AnythingWeCanDoToSupportYourInterview)
            
            #line default
            #line hidden
, 1747), false)
);

WriteLiteral(" class=\"form-prepopped prewrap\"");

WriteLiteral(">I don\'t have any interview support requirements</span>\r\n");

            
            #line 37 "..\..\Views\ApprenticeshipApplication\DisplayTemplates\AboutYouViewModel.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</section>\r\n");

        }
    }
}
#pragma warning restore 1591