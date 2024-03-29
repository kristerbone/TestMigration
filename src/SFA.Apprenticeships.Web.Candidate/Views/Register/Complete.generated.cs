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

namespace SFA.Apprenticeships.Web.Candidate.Views.Register
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Register/Complete.cshtml")]
    public partial class Complete : System.Web.Mvc.WebViewPage<string>
    {
        public Complete()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Register\Complete.cshtml"
  
    ViewBag.Title = "Apprenticeships - Account created";
    Layout = "~/Views/Shared/_Layout.cshtml";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">Account created</h1>\r\n<fieldset>\r\n    <legend");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">Confirmation email sent</legend>\r\n    <div");

WriteLiteral(" class=\"form-group text\"");

WriteLiteral(">\r\n        <p>\r\n            Your confirmation email has been sent to <strong>");

            
            #line 12 "..\..\Views\Register\Complete.cshtml"
                                                        Write(Model);

            
            #line default
            #line hidden
WriteLiteral("</strong>\r\n        </p>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n        <button");

WriteLiteral(" class=\"button\"");

WriteLiteral(">Go to dashboard</button>\r\n    </div>\r\n</fieldset>");

        }
    }
}
#pragma warning restore 1591
