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

namespace SFA.Apprenticeships.Web.Candidate.Views.Shared.EditorTemplates
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/EditorTemplates/DateViewModel.cshtml")]
    public partial class DateViewModel_ : System.Web.Mvc.WebViewPage<DateViewModel>
    {
        public DateViewModel_()
        {
        }
        public override void Execute()
        {
WriteLiteral("<fieldset");

WriteLiteral(" class=\"form-group inline-fixed date-input\"");

WriteLiteral(">\r\n    <legend");

WriteLiteral(" class=\"form-label\"");

WriteLiteral(">Date of birth</legend>\r\n");

WriteLiteral("    ");

            
            #line 4 "..\..\Views\Shared\EditorTemplates\DateViewModel.cshtml"
Write(Html.FormTextFor(m => m.Day, containerHtmlAttributes: new { @class = "form-group-compound" }, labelHtmlAttributes: new { @class = "form-hint" }, controlHtmlAttributes: new { @class = "form-control-xsmall", type = "tel", maxlength = "2", pattern = "[0-9]*" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 5 "..\..\Views\Shared\EditorTemplates\DateViewModel.cshtml"
Write(Html.FormTextFor(m => m.Month, containerHtmlAttributes: new { @class = "form-group-compound" }, labelHtmlAttributes: new { @class = "form-hint" }, controlHtmlAttributes: new { @class = "form-control-xsmall", type = "tel", maxlength = "2", pattern = "[0-9]*" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 6 "..\..\Views\Shared\EditorTemplates\DateViewModel.cshtml"
Write(Html.FormTextFor(m => m.Year, containerHtmlAttributes: new { @class = "form-group-compound" }, labelHtmlAttributes: new { @class = "form-hint" }, controlHtmlAttributes: new { @class = "form-control-small", type = "tel", maxlength = "4", pattern = "[0-9]*" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n</fieldset>");

        }
    }
}
#pragma warning restore 1591